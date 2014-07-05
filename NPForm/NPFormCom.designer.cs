namespace NPForm
{
    partial class NPFormCom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPFormCom));
            this.pfCtrlMenu = new System.Windows.Forms.Panel();
            this.flowSysCtrl = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.Label();
            this.pbMax = new System.Windows.Forms.Label();
            this.pbMin = new System.Windows.Forms.Label();
            this.pbTop = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.Label();
            this.flowTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pbIcon = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.pfContent = new System.Windows.Forms.Panel();
            this.pfCtrlMenu.SuspendLayout();
            this.flowSysCtrl.SuspendLayout();
            this.flowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pfCtrlMenu
            // 
            this.pfCtrlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(213)))));
            this.pfCtrlMenu.Controls.Add(this.flowSysCtrl);
            this.pfCtrlMenu.Controls.Add(this.flowTitle);
            this.pfCtrlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pfCtrlMenu.Location = new System.Drawing.Point(5, 5);
            this.pfCtrlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pfCtrlMenu.Name = "pfCtrlMenu";
            this.pfCtrlMenu.Size = new System.Drawing.Size(990, 27);
            this.pfCtrlMenu.TabIndex = 0;
            this.pfCtrlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // flowSysCtrl
            // 
            this.flowSysCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowSysCtrl.AutoSize = true;
            this.flowSysCtrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowSysCtrl.Controls.Add(this.pbClose);
            this.flowSysCtrl.Controls.Add(this.pbMax);
            this.flowSysCtrl.Controls.Add(this.pbMin);
            this.flowSysCtrl.Controls.Add(this.pbTop);
            this.flowSysCtrl.Controls.Add(this.pbMenu);
            this.flowSysCtrl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowSysCtrl.Location = new System.Drawing.Point(812, 0);
            this.flowSysCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.flowSysCtrl.Name = "flowSysCtrl";
            this.flowSysCtrl.Size = new System.Drawing.Size(178, 27);
            this.flowSysCtrl.TabIndex = 0;
            this.flowSysCtrl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::NPForm.Properties.RControlBar.close_1;
            this.pbClose.Location = new System.Drawing.Point(144, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.MaximumSize = new System.Drawing.Size(34, 27);
            this.pbClose.MinimumSize = new System.Drawing.Size(34, 27);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(34, 27);
            this.pbClose.TabIndex = 0;
            this.pbClose.Tag = "0X0001";
            this.pbClose.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.pbClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.pbClose.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // pbMax
            // 
            this.pbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMax.Image = global::NPForm.Properties.RControlBar.max_1;
            this.pbMax.Location = new System.Drawing.Point(108, 0);
            this.pbMax.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pbMax.MaximumSize = new System.Drawing.Size(34, 27);
            this.pbMax.MinimumSize = new System.Drawing.Size(34, 27);
            this.pbMax.Name = "pbMax";
            this.pbMax.Size = new System.Drawing.Size(34, 27);
            this.pbMax.TabIndex = 1;
            this.pbMax.Tag = "0X0002";
            this.pbMax.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.pbMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.pbMax.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.pbMax.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // pbMin
            // 
            this.pbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMin.Image = global::NPForm.Properties.RControlBar.min_1;
            this.pbMin.Location = new System.Drawing.Point(72, 0);
            this.pbMin.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pbMin.MaximumSize = new System.Drawing.Size(34, 27);
            this.pbMin.MinimumSize = new System.Drawing.Size(34, 27);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(34, 27);
            this.pbMin.TabIndex = 2;
            this.pbMin.Tag = "0X0003";
            this.pbMin.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.pbMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.pbMin.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.pbMin.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // pbTop
            // 
            this.pbTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTop.Image = global::NPForm.Properties.RControlBar.top_1;
            this.pbTop.Location = new System.Drawing.Point(36, 0);
            this.pbTop.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pbTop.MaximumSize = new System.Drawing.Size(34, 27);
            this.pbTop.MinimumSize = new System.Drawing.Size(34, 27);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(34, 27);
            this.pbTop.TabIndex = 3;
            this.pbTop.Tag = "0X0004";
            this.pbTop.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.pbTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.pbTop.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.pbTop.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMenu.Image = global::NPForm.Properties.RControlBar.menu_1;
            this.pbMenu.Location = new System.Drawing.Point(0, 0);
            this.pbMenu.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pbMenu.MaximumSize = new System.Drawing.Size(34, 27);
            this.pbMenu.MinimumSize = new System.Drawing.Size(34, 27);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(34, 27);
            this.pbMenu.TabIndex = 5;
            this.pbMenu.Tag = "0X0005";
            this.pbMenu.Click += new System.EventHandler(this.ctrlMenu_Click);
            this.pbMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlMenu_MouseDown);
            this.pbMenu.MouseEnter += new System.EventHandler(this.ctrlMenu_MouseEnter);
            this.pbMenu.MouseLeave += new System.EventHandler(this.ctrlMenu_MouseLeave);
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
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
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
            this.labTitle.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(25, 8);
            this.labTitle.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(43, 13);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "P窗体";
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSysMenu_MouseDown);
            // 
            // pfContent
            // 
            this.pfContent.BackColor = System.Drawing.Color.White;
            this.pfContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfContent.Location = new System.Drawing.Point(5, 32);
            this.pfContent.Name = "pfContent";
            this.pfContent.Size = new System.Drawing.Size(990, 563);
            this.pfContent.TabIndex = 1;
            // 
            // PForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pfContent);
            this.Controls.Add(this.pfCtrlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::NPForm.Properties.RControlBar.icon_def;
            this.Location = new System.Drawing.Point(570, 280);
            this.MinimumSize = new System.Drawing.Size(300, 70);
            this.Name = "PForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P窗体";
            this.pfCtrlMenu.ResumeLayout(false);
            this.pfCtrlMenu.PerformLayout();
            this.flowSysCtrl.ResumeLayout(false);
            this.flowTitle.ResumeLayout(false);
            this.flowTitle.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label pbClose;
        private System.Windows.Forms.Label pbMax;
        private System.Windows.Forms.Label pbMin;
        private System.Windows.Forms.Label pbIcon;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label pbTop;
        protected System.Windows.Forms.Label pbMenu;
        private System.Windows.Forms.FlowLayoutPanel flowTitle;        
        public System.Windows.Forms.Panel pfContent;
        private System.Windows.Forms.Panel pfCtrlMenu;
        private System.Windows.Forms.FlowLayoutPanel flowSysCtrl;        
    }
}