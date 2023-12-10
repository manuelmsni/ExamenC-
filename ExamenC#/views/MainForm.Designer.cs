namespace ExamenC_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _statusStrip = new StatusStrip();
            menuStrip1 = new MenuStrip();
            customObjectsToolStripMenuItem = new ToolStripMenuItem();
            MainContainer = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // _statusStrip
            // 
            _statusStrip.Location = new Point(0, 428);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Size = new Size(800, 22);
            _statusStrip.TabIndex = 0;
            _statusStrip.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { customObjectsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "MenuStrip";
            // 
            // customObjectsToolStripMenuItem
            // 
            customObjectsToolStripMenuItem.Name = "customObjectsToolStripMenuItem";
            customObjectsToolStripMenuItem.Size = new Size(101, 20);
            customObjectsToolStripMenuItem.Text = "CustomObjects";
            customObjectsToolStripMenuItem.Click += MenuCustomObjects_Click;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 24);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(800, 404);
            MainContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainContainer);
            Controls.Add(_statusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip _statusStrip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem customObjectsToolStripMenuItem;
        private FlowLayoutPanel MainContainer;
    }
}