namespace NPForm
{
    partial class NPFormCom
    {
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
            this.npCtrlMenu = new System.Windows.Forms.Panel();
            this.flowSysCtrl = new System.Windows.Forms.FlowLayoutPanel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.maxBtn = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Label();
            this.topBtn = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Label();
            this.flowTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pbIcon = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.npContent = new System.Windows.Forms.Panel();
            this.npCtrlMenu.SuspendLayout();
            this.flowSysCtrl.SuspendLayout();
            this.flowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // npCtrlMenu
            // 
            this.npCtrlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(213)))));
            this.npCtrlMenu.Controls.Add(this.flowSysCtrl);
            this.npCtrlMenu.Controls.Add(this.flowTitle);
            this.npCtrlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.npCtrlMenu.Location = new System.Drawing.Point(5, 5);
            this.npCtrlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.npCtrlMenu.Name = "npCtrlMenu";
            this.npCtrlMenu.Size = new System.Drawing.Size(990, 27);
            this.npCtrlMenu.TabIndex = 0;
            this.npCtrlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // flowSysCtrl
            // 
            this.flowSysCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowSysCtrl.AutoSize = true;
            this.flowSysCtrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowSysCtrl.Controls.Add(this.closeBtn);
            this.flowSysCtrl.Controls.Add(this.maxBtn);
            this.flowSysCtrl.Controls.Add(this.minBtn);
            this.flowSysCtrl.Controls.Add(this.topBtn);
            this.flowSysCtrl.Controls.Add(this.menuBtn);
            this.flowSysCtrl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowSysCtrl.Location = new System.Drawing.Point(812, 0);
            this.flowSysCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.flowSysCtrl.Name = "flowSysCtrl";
            this.flowSysCtrl.Size = new System.Drawing.Size(178, 27);
            this.flowSysCtrl.TabIndex = 0;
            this.flowSysCtrl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::NPForm.Properties.Resources.close_1;
            this.closeBtn.Location = new System.Drawing.Point(144, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.MaximumSize = new System.Drawing.Size(34, 27);
            this.closeBtn.MinimumSize = new System.Drawing.Size(34, 27);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(34, 27);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Tag = "0X0001";
            this.closeBtn.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.closeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.closeBtn.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.Image = global::NPForm.Properties.Resources.max_1;
            this.maxBtn.Location = new System.Drawing.Point(108, 0);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.maxBtn.MaximumSize = new System.Drawing.Size(34, 27);
            this.maxBtn.MinimumSize = new System.Drawing.Size(34, 27);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(34, 27);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.Tag = "0X0002";
            this.maxBtn.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.maxBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.maxBtn.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.maxBtn.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.Image = global::NPForm.Properties.Resources.min_1;
            this.minBtn.Location = new System.Drawing.Point(72, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.minBtn.MaximumSize = new System.Drawing.Size(34, 27);
            this.minBtn.MinimumSize = new System.Drawing.Size(34, 27);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(34, 27);
            this.minBtn.TabIndex = 2;
            this.minBtn.Tag = "0X0003";
            this.minBtn.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.minBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.minBtn.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // topBtn
            // 
            this.topBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topBtn.Image = global::NPForm.Properties.Resources.top_1;
            this.topBtn.Location = new System.Drawing.Point(36, 0);
            this.topBtn.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.topBtn.MaximumSize = new System.Drawing.Size(34, 27);
            this.topBtn.MinimumSize = new System.Drawing.Size(34, 27);
            this.topBtn.Name = "topBtn";
            this.topBtn.Size = new System.Drawing.Size(34, 27);
            this.topBtn.TabIndex = 3;
            this.topBtn.Tag = "0X0004";
            this.topBtn.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.topBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.topBtn.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.topBtn.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.Image = global::NPForm.Properties.Resources.menu_1;
            this.menuBtn.Location = new System.Drawing.Point(0, 0);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.menuBtn.MaximumSize = new System.Drawing.Size(34, 27);
            this.menuBtn.MinimumSize = new System.Drawing.Size(34, 27);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(34, 27);
            this.menuBtn.TabIndex = 5;
            this.menuBtn.Tag = "0X0005";
            this.menuBtn.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.menuBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.menuBtn.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.menuBtn.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // flowTitle
            // 
            this.flowTitle.AutoSize = true;
            this.flowTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowTitle.Controls.Add(this.pbIcon);
            this.flowTitle.Controls.Add(this.labTitle);
            this.flowTitle.Location = new System.Drawing.Point(0, 0);
            this.flowTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flowTitle.Name = "flowTitle";
            this.flowTitle.Size = new System.Drawing.Size(68, 25);
            this.flowTitle.TabIndex = 0;
            this.flowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbIcon.Image = global::NPForm.Properties.Resources.window_def;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcon.MaximumSize = new System.Drawing.Size(25, 25);
            this.pbIcon.MinimumSize = new System.Drawing.Size(25, 25);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(25, 25);
            this.pbIcon.TabIndex = 3;
            this.pbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("ËÎÌå", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(25, 8);
            this.labTitle.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(43, 13);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "P´°Ìå";
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // npContent
            // 
            this.npContent.BackColor = System.Drawing.Color.White;
            this.npContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npContent.Location = new System.Drawing.Point(5, 32);
            this.npContent.Name = "npContent";
            this.npContent.Size = new System.Drawing.Size(990, 563);
            this.npContent.TabIndex = 1;
            // 
            // NPFormCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.npContent);
            this.Controls.Add(this.npCtrlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::NPForm.Properties.Resources.icon_def;
            this.Location = new System.Drawing.Point(570, 280);
            this.MinimumSize = new System.Drawing.Size(300, 70);
            this.Name = "NPFormCom";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P´°Ìå";
            this.npCtrlMenu.ResumeLayout(false);
            this.npCtrlMenu.PerformLayout();
            this.flowSysCtrl.ResumeLayout(false);
            this.flowTitle.ResumeLayout(false);
            this.flowTitle.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label maxBtn;
        private System.Windows.Forms.Label minBtn;
        private System.Windows.Forms.Label pbIcon;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label topBtn;
        private System.Windows.Forms.Label menuBtn;
        private System.Windows.Forms.FlowLayoutPanel flowTitle;        
        private System.Windows.Forms.Panel npCtrlMenu;
        private System.Windows.Forms.FlowLayoutPanel flowSysCtrl;
        public System.Windows.Forms.Panel npContent;
    }
}
