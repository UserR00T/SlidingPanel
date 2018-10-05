using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SlidingPanelNS
{
    public class SlidingPanel
    {
        public enum ToSide
        {
          //  Left,
            Right,
        //    Top,
            Bottom
        }
        private enum States
        {
            Open,
            Closed,
            Opening,
            Closing
        }
        private readonly Panel MainPanel;
        public ToSide Side;
        private readonly int MaxSize;
        private readonly int MinSize;
        private readonly int IncreaseAmount;
        private readonly int ThreadDelay;


        private bool isInitialized;
        private bool isEnabled;
        private bool isDone;
        private States state = States.Closed;
        private Thread loopThread;

        public SlidingPanel(Panel mainPanel, ToSide side, int maxWidth, int minWidth, int increaseBy = 1, int threadDelay = 10, bool start = true)
        {
            MainPanel = mainPanel;
            Side = side;
            MaxSize = maxWidth;
            MinSize = minWidth;
            IncreaseAmount = increaseBy;
            ThreadDelay = threadDelay;
            Initialize();
            if (start)
                StartLoop();
        }
        private void Initialize()
        {
            if (isInitialized)
                throw new InvalidOperationException("Cannot initialize slidingPanel because it has already been initialized.");
            isInitialized = true;
            loopThread = new Thread(MainLoop)
            {
                IsBackground = true
            };
            loopThread.Start();
        }
        private void MainLoop()
        {
            while (isInitialized)
            {
                if (isEnabled && !isDone)
                    CheckStates();
                Thread.Sleep(1);
            }
        }
        private void CheckStates()
        {
            if (state == States.Opening)
            {
                if (IsOverAllowedSize(false))
                {
                    state = States.Open;
                    return;
                }
                SetPositionBySide(false);
            }
            else if (state == States.Closing)
            {
                if (IsOverAllowedSize(true))
                {
                    state = States.Closed;
                    return;
                }
                SetPositionBySide(true);
            }
            Thread.Sleep(ThreadDelay);
        }
        private bool IsOverAllowedSize(bool minSize)
        {
            if (minSize)
                return (Side == ToSide.Right && MainPanel.Width <= MinSize || Side == ToSide.Bottom && MainPanel.Height <= MinSize);
            return (Side == ToSide.Right && MainPanel.Width >= MaxSize || Side == ToSide.Bottom && MainPanel.Height >= MaxSize);
        }
        private void SetPositionBySide(bool closing)
        {
            if (Side == ToSide.Right)
            {
                if (!closing)
                    SetWidth(MainPanel.Width + IncreaseAmount);
                else
                    SetWidth(MainPanel.Width - IncreaseAmount);
            }
            else
                if (!closing)
                SetHeight(MainPanel.Height + IncreaseAmount);
            else
                SetHeight(MainPanel.Height - IncreaseAmount);
        }
        private void SetWidth(int width)
        {
            if (MainPanel.InvokeRequired)
                MainPanel.BeginInvoke((MethodInvoker)delegate () { MainPanel.Width = width; });
            else
                MainPanel.Width = width;
        }
        private void SetHeight(int height)
        {
            if (MainPanel.InvokeRequired)
                MainPanel.BeginInvoke((MethodInvoker)delegate () { MainPanel.Height = height; });
            else
                MainPanel.Height = height;
        }
        private void ResetDoneStatus()
        {
            isDone = false;
        }
        public void Hide()
        {
            ResetDoneStatus();
            state = States.Closing;
        }
        public void Show()
        {
            ResetDoneStatus();
            state = States.Opening;
        }
        public void Toggle()
        {
            ResetDoneStatus();
            if (state == States.Open || state == States.Opening)
            {
                Hide();
                return;
            }
            Show();
        }
        public void StartLoop()
        {
            ResetDoneStatus();
            isEnabled = true;
        }
        public void StopLoop()
        {
            ResetDoneStatus();
            isEnabled = false;
        }
        public void ToggleLoop()
        {
            if (isEnabled)
            {
                StopLoop();
                return;
            }
            StartLoop();
        }
    }
}
