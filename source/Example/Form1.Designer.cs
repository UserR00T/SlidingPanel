namespace Example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ToggleBtn = new System.Windows.Forms.Button();
            this.SidePanel2 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.mLabel3 = new System.Windows.Forms.Label();
            this.mLabel2 = new System.Windows.Forms.Label();
            this.mLabel1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SidePanel.Controls.Add(this.Label1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(0, 450);
            this.SidePanel.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 29);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Great stuff";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(360, 367);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(451, 367);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ToggleBtn
            // 
            this.ToggleBtn.Location = new System.Drawing.Point(532, 367);
            this.ToggleBtn.Name = "ToggleBtn";
            this.ToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.ToggleBtn.TabIndex = 3;
            this.ToggleBtn.Text = "Toggle";
            this.ToggleBtn.UseVisualStyleBackColor = true;
            this.ToggleBtn.Click += new System.EventHandler(this.ToggleBtn_Click);
            // 
            // SidePanel2
            // 
            this.SidePanel2.BackColor = System.Drawing.Color.Aqua;
            this.SidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel2.Location = new System.Drawing.Point(0, 0);
            this.SidePanel2.Name = "SidePanel2";
            this.SidePanel2.Size = new System.Drawing.Size(0, 450);
            this.SidePanel2.TabIndex = 5;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Coral;
            this.MainPanel.Controls.Add(this.mLabel3);
            this.MainPanel.Controls.Add(this.mLabel2);
            this.MainPanel.Controls.Add(this.mLabel1);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainPanel.Location = new System.Drawing.Point(290, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(498, 10);
            this.MainPanel.TabIndex = 6;
            // 
            // mLabel3
            // 
            this.mLabel3.AutoSize = true;
            this.mLabel3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel3.Location = new System.Drawing.Point(129, 96);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(249, 19);
            this.mLabel3.TabIndex = 2;
            this.mLabel3.Text = "Animate your panel\'s width and height.";
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel2.Location = new System.Drawing.Point(81, 141);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(337, 19);
            this.mLabel2.TabIndex = 1;
            this.mLabel2.Text = "For Windows Forms Application, created by UserR00T";
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel1.Location = new System.Drawing.Point(162, 66);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(135, 30);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Sliding Panel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanel2);
            this.Controls.Add(this.ToggleBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.SidePanel);
            this.Name = "Form1";
            this.Text = "Sliding Panel Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ToggleBtn;
        private System.Windows.Forms.Panel SidePanel2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label mLabel3;
        private System.Windows.Forms.Label mLabel2;
        private System.Windows.Forms.Label mLabel1;
    }
}

