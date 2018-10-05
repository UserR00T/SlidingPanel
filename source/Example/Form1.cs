using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlidingPanelNS;

namespace Example
{
    public partial class Form1 : Form
    {
        private readonly List<SlidingPanel> slidingPanels = new List<SlidingPanel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            slidingPanels.Add(new SlidingPanel(SidePanel, SlidingPanel.ToSide.Right, 200, SidePanel.Width, 3));
            slidingPanels.Add(new SlidingPanel(SidePanel2, SlidingPanel.ToSide.Right, 2, SidePanel2.Width, 1, 400));
            slidingPanels.Add(new SlidingPanel(MainPanel, SlidingPanel.ToSide.Bottom, 230, MainPanel.Height, 3));
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            slidingPanels.ForEach(x=>x.Hide());
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            slidingPanels.ForEach(x => x.Show());
        }

        private void ToggleBtn_Click(object sender, EventArgs e)
        {
            slidingPanels.ForEach(x => x.Toggle());
        }
    }
}
