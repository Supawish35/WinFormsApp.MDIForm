namespace WinFormsApp.MDIForm;

partial class Main {
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mnuForm = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormMaximize = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormMinimize = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormNormal = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            mnuCloseActiveForm = new System.Windows.Forms.ToolStripMenuItem();
            mnuCloseAllChild = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormA = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormB = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormC = new System.Windows.Forms.ToolStripMenuItem();
            mnuFormArrange = new System.Windows.Forms.ToolStripMenuItem();
            mnuArrangeCascade = new System.Windows.Forms.ToolStripMenuItem();
            mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuForm, mnuFormA, mnuFormB, mnuFormC, mnuFormArrange });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuForm
            // 
            mnuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFormMaximize, mnuFormMinimize, mnuFormNormal, toolStripMenuItem1, mnuCloseActiveForm, mnuCloseAllChild, toolStripMenuItem2, mnuExit });
            mnuForm.Name = "mnuForm";
            mnuForm.Size = new System.Drawing.Size(55, 24);
            mnuForm.Text = "ฟอร์ม";
            // 
            // mnuFormMaximize
            // 
            mnuFormMaximize.Name = "mnuFormMaximize";
            mnuFormMaximize.Size = new System.Drawing.Size(255, 26);
            mnuFormMaximize.Text = "ขยาย (Maximize)";
            mnuFormMaximize.Click += mnuFormMaximize_Click;
            // 
            // mnuFormMinimize
            // 
            mnuFormMinimize.Name = "mnuFormMinimize";
            mnuFormMinimize.Size = new System.Drawing.Size(255, 26);
            mnuFormMinimize.Text = "ย่อ (Minimize)";
            mnuFormMinimize.Click += mnuFormMinimize_Click;
            // 
            // mnuFormNormal
            // 
            mnuFormNormal.Name = "mnuFormNormal";
            mnuFormNormal.Size = new System.Drawing.Size(255, 26);
            mnuFormNormal.Text = "ปรับเป็นปกติ (Normal)";
            mnuFormNormal.Click += mnuFormNormal_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(252, 6);
            // 
            // mnuCloseActiveForm
            // 
            mnuCloseActiveForm.Name = "mnuCloseActiveForm";
            mnuCloseActiveForm.Size = new System.Drawing.Size(255, 26);
            mnuCloseActiveForm.Text = "ปิดฟอร์ม (Close)";
            mnuCloseActiveForm.Click += mnuCloseActiveForm_Click;
            // 
            // mnuCloseAllChild
            // 
            mnuCloseAllChild.Name = "mnuCloseAllChild";
            mnuCloseAllChild.Size = new System.Drawing.Size(255, 26);
            mnuCloseAllChild.Text = "ปิดฟอร์มทั้งหมด (Close All)";
            mnuCloseAllChild.Click += mnuCloseAllChild_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(252, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new System.Drawing.Size(255, 26);
            mnuExit.Text = "ปิดโปรแกรม (Exit)";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuFormA
            // 
            mnuFormA.Name = "mnuFormA";
            mnuFormA.Size = new System.Drawing.Size(91, 24);
            mnuFormA.Text = "เปิดฟอร์ม A";
            mnuFormA.Click += mnuFormA_Click;
            // 
            // mnuFormB
            // 
            mnuFormB.Name = "mnuFormB";
            mnuFormB.Size = new System.Drawing.Size(90, 24);
            mnuFormB.Text = "เปิดฟอร์ม B";
            mnuFormB.Click += mnuFormB_Click;
            // 
            // mnuFormC
            // 
            mnuFormC.Name = "mnuFormC";
            mnuFormC.Size = new System.Drawing.Size(90, 24);
            mnuFormC.Text = "เปิดฟอร์ม C";
            mnuFormC.Click += mnuFormC_Click;
            // 
            // mnuFormArrange
            // 
            mnuFormArrange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuArrangeCascade, mnuTileHorizontal, mnuTileVertical });
            mnuFormArrange.Name = "mnuFormArrange";
            mnuFormArrange.Size = new System.Drawing.Size(96, 24);
            mnuFormArrange.Text = "จัดเรียงฟอร์ม";
            // 
            // mnuArrangeCascade
            // 
            mnuArrangeCascade.Name = "mnuArrangeCascade";
            mnuArrangeCascade.Size = new System.Drawing.Size(284, 26);
            mnuArrangeCascade.Text = "เรียงซ้อนกัน (Cascade)";
            mnuArrangeCascade.Click += mnuArrangeCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new System.Drawing.Size(284, 26);
            mnuTileHorizontal.Text = "ต่อกันแนวนอน (TileHorizontal)";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new System.Drawing.Size(284, 26);
            mnuTileVertical.Text = "ต่อกันแนวตั้ง (TileVertical)";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Text = "ทดสอบฟอร์มแบบ MDI Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuForm;
        private System.Windows.Forms.ToolStripMenuItem mnuFormMaximize;
        private System.Windows.Forms.ToolStripMenuItem mnuFormMinimize;
        private ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormA;
        private System.Windows.Forms.ToolStripMenuItem mnuFormB;
        private System.Windows.Forms.ToolStripMenuItem mnuFormC;
        private System.Windows.Forms.ToolStripMenuItem mnuFormNormal;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseActiveForm;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAllChild;
        private ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFormArrange;
        private System.Windows.Forms.ToolStripMenuItem mnuArrangeCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
}