using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NPForm.CoreLib;

namespace NPForm
{
    /// <summary>
    /// Describe: Common Form
    /// Author  : Ziegler Penn
    /// Date    : 2014-6-27
    /// E-mail  : hacker_i@foxmail.com
    /// </summary>
    [ToolboxBitmap(typeof(NPFormCom), "Resources.forms.NPFormCom.bmp")]
    public partial class NPFormCom : Form
    {  
        private int borderSize = 7;             // 处理缩放触发边框像素大小
        private int roundCornerSize = 0;        // 窗体圆角大小
        private bool isShowMaxBox = true;       // 指示是否显示最大化按钮
        private bool isShowMinBox = true;       // 指示是否显示最小化按钮
        private bool isMaxState = false;        // 窗体是否是最大化状态
        private Size normalSize;                // 窗体常态大小
        private Point normalLocation;           // 窗体常态坐标
        private bool isSizable = true;          // 窗体是否允许调整大小

        [CategoryAttribute("系统控制条按钮事件"), Description("设置右上角倒三角控制条按钮的点击事件[AUTHOR:Ziegler Penn]")]
        public event EventHandler SysMenuClick;

        /// <summary>
        /// 默认构造
        /// </summary>
        public NPFormCom()
        {
            InitializeComponent();
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.isMaxState = this.WindowState == FormWindowState.Maximized ? true : false;
            WIN32API.SetClassLong(this.Handle, WIN32API.GCL_STYLE, WIN32API.GetClassLong(this.Handle, WIN32API.GCL_STYLE) | WIN32API.CS_DropSHADOW);
        }        

        /// <summary>
        /// 窗体最大化处理
        /// </summary>
        private void MaxWindow()
        {
            if (isMaxState)
            {
                /* 最小化处理 */
                this.isMaxState = !isMaxState;
                this.Padding = new Padding(this.BorderThickness);
                this.Size = this.normalSize;
                this.Location = this.normalLocation;
            }
            else
            {
                /* 最大化处理 */
                this.isMaxState = !isMaxState;
                this.normalSize = new Size(this.Width, this.Height);
                this.normalLocation = this.Location;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);               
            }
        }

        /// <summary>
        /// 通过鼠标按下事件控制窗体的移动
        /// </summary>
        /// <param name="sender">发送者</param>
        /// <param name="e">事件源</param>
        private void panelSysMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 2 && this.MaximizeBox)
            {
                MaxWindow();
            }
            else
            {
                if (isMaxState) { return; }
                WIN32API.ReleaseCapture();
                WIN32API.SendMessage(Handle, WIN32API.WM_SYSCOMMAND, WIN32API.SC_MOVE | WIN32API.HTCAPTION, 0);
            }
        }

        #region 窗体大小调整WND消息处理        
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (isMaxState)
            {
                this.Padding = new Padding(0);
                return;
            }
            if (!isSizable) { return; }

            switch (m.Msg)
            {
                case WIN32API.WM_NCHITTEST:
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        if (vPoint.X <= borderSize)
                        {
                            if (vPoint.Y <= borderSize)
                            {
                                m.Result = (IntPtr)WIN32API.HTTOPLEFT;
                            }
                            else if (vPoint.Y >= ClientSize.Height - borderSize)
                            {
                                m.Result = (IntPtr)WIN32API.HTBOTTOMLEFT;
                            }
                            else
                            {
                                m.Result = (IntPtr)WIN32API.HTLEFT;
                            }
                        }
                        else if (vPoint.X >= ClientSize.Width - borderSize)
                        {
                            if (vPoint.Y <= borderSize)
                            {
                                m.Result = (IntPtr)WIN32API.HTTOPRIGHT;
                            }
                            else if (vPoint.Y >= ClientSize.Height - borderSize)
                            {
                                m.Result = (IntPtr)WIN32API.HTBOTTOMRIGHT;
                            }
                            else
                            {
                                m.Result = (IntPtr)WIN32API.HTRIGHT;
                            }
                        }
                        else if (vPoint.Y <= borderSize)
                        {
                            m.Result = (IntPtr)WIN32API.HTTOP;
                        }
                        else if (vPoint.Y >= ClientSize.Height - borderSize)
                        {
                            m.Result = (IntPtr)WIN32API.HTBOTTOM;
                        }
                    }
                    break;
            }
        }
        #endregion

        #region 圆角处理

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int Rgn;
            if (isMaxState)
            {
                Rgn = 0;
            }
            else
            {
                Rgn = WIN32API.CreateRoundRectRgn(1, 1, this.Width, this.Height, this.roundCornerSize, this.roundCornerSize);
            }
            WIN32API.SetWindowRgn(this.Handle, Rgn, true);
        }
        #endregion

        /// <summary>
        /// 控制最大化按钮是否显示
        /// </summary>
        public new bool MaximizeBox
        {
            get { return this.isShowMaxBox; }
            set
            {
                this.isShowMaxBox = value;
                if (value)
                {
                    this.maxBtn.Visible = true;
                }
                else
                {
                    this.maxBtn.Visible = false;
                }
            }
        }

        /// <summary>
        /// 对设计器隐藏BackColor属性设置
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        /// <summary>
        /// 对设计器隐藏FormBorderStyle属性
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new FormBorderStyle FormBorderStyle 
        {
            get
            {
                return System.Windows.Forms.FormBorderStyle.None;
            }
            set 
            {
                base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        /// <summary>
        /// 对设计器隐藏BackgroundImage属性设置
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        /// <summary>
        /// /最小化按钮是否显示
        /// </summary>
        public new bool MinimizeBox
        {
            get { return this.isShowMinBox; }
            set
            {
                this.isShowMinBox = value;
                if (value)
                {
                    this.minBtn.Visible = true;
                }
                else
                {
                    this.minBtn.Visible = false;
                }
            }
        }

        /// <summary>
        /// 覆盖窗体标题属性
        /// </summary>
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                if (this.labTitle != null)
                {
                    this.labTitle.Text = value;
                }
            }
        }

        /// <summary>
        /// 窗体左上角图标资源
        /// </summary>
        public new Icon Icon
        {
            get
            {
                return base.Icon;
            }
            set
            {
                base.Icon = value;
                if (this.pbIcon != null)
                {
                    this.pbIcon.Image = value.ToBitmap();
                }               
            }
        }

        /// <summary>
        /// 是否显示左上角图标
        /// </summary>
        public new bool ShowIcon
        {
            get
            {
                if (this.pbIcon != null)
                {
                    return this.pbIcon.Visible;
                }
                return false;
            }
            set
            {
                if (this.pbIcon != null)
                {
                    this.pbIcon.Visible = value;
                }
            }
        }

        /// <summary>
        /// 是否显示窗口置顶按钮
        /// </summary>
        [CategoryAttribute("是否显示置顶按钮"), Description("设置窗体置顶")]
        public bool IsShowTopButton 
        {
            set 
            {
                if (this.topBtn != null)
                {
                    this.topBtn.Visible = value;
                }
            }
            get
            {
                if (this.topBtn != null)
                {
                    return this.topBtn.Visible;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 是否显示窗体菜单按钮
        /// </summary>
        [CategoryAttribute("是否显示窗体菜单按钮"), Description("窗体菜单按钮")]
        [EditorAttribute(typeof(bool), typeof(bool))] 
        public bool IsShowMenuButton
        {
            set
            {
                if (this.menuBtn != null)
                {
                    this.menuBtn.Visible = value;
                }
            }
            get
            {
                if (this.menuBtn != null)
                {
                    return this.menuBtn.Visible;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 设定窗体调整边框的粗细(像素单位)
        /// </summary>
        [CategoryAttribute("边框线条粗细度"), Description("设置窗体调整大小的边框粗细度")]
        public int BorderThickness
        {
            get
            {
                return this.borderSize;
            }
            set
            {
                this.borderSize = value;
                this.Padding = new Padding(value);
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Padding Padding 
        {
            get
            {
                return base.Padding;
            }
            set 
            {
                base.Padding = value;
            }
        }
        

        [CategoryAttribute("圆角直径大小"), Description("设置窗体圆角直径大小")]
        public int RoundCornerSize
        {
            get
            {
                return this.roundCornerSize;
            }
            set
            {
                this.roundCornerSize = value;
            }
        }

        /// <summary>
        /// 窗体边框的颜色设置
        /// </summary>
        [CategoryAttribute("边框的颜色"), Description("设置窗体调整大小的边框的颜色")]
        public Color BorderColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        [CategoryAttribute("标题栏颜色"), Description("设置窗体顶部标题栏底色")]
        public Color TitleColor
        {
            get
            {
                if (this.npCtrlMenu != null)
                {
                    return this.npCtrlMenu.BackColor;
                }
                return Color.Blue;
            }
            set
            {
                if (this.npCtrlMenu != null)
                {
                    this.npCtrlMenu.BackColor = value;
                }
            }
        }

        [CategoryAttribute("窗体是否可调整大小"), Description("设置窗体是否可以调整大小")]
        public bool IsSizable
        {
            get { return isSizable; }
            set { isSizable = value; }
        }

        #region 窗体系统控制栏事件处理
        /// <summary>
        /// 描述: 控制栏鼠标进入事件统一处理函数
        /// 作者: Ziegler Penn
        /// 日期: 2014-6-30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrlMenu_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Int16 tagFlag = Convert.ToInt16(((Label)sender).Tag.ToString(), 16);
                /*
                 * 说明: 使用控件的Tag属性标记其实质含义(采用16进制数字表示)
                 * 参数: 
                 *      0X0001: 关闭
                 *      0X0002: 最大化
                 *      0X0003: 最小化
                 *      0X0004: 置顶
                 *      0X0005: 系统菜单
                 */
                switch (tagFlag)
                {
                    case 0X0001:
                        this.closeBtn.Image = Properties.Resources.close_2;   
                        break;
                    case 0X0002:
                        this.maxBtn.Image = Properties.Resources.max_2;
                        break;
                    case 0X0003:
                        this.minBtn.Image = Properties.Resources.min_2;
                        break;
                    case 0X0004:
                        this.topBtn.Image = this.TopMost ? Properties.Resources.top_2_1 : Properties.Resources.top_2;
                        break;
                    case 0X0005:
                        this.menuBtn.Image = Properties.Resources.menu_2;
                        break;
                }
            }                     
        }

        /// <summary>
        /// 描述: 控制栏鼠标离开事件统一处理函数
        /// 作者: Ziegler Penn
        /// 日期: 2014-6-30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrlMenu_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Int16 tagFlag = Convert.ToInt16(((Label)sender).Tag.ToString(), 16);
                /*
                 * 说明: 使用控件的Tag属性标记其实质含义(采用16进制数字表示)
                 * 参数: 
                 *      0X0001: 关闭
                 *      0X0002: 最大化
                 *      0X0003: 最小化
                 *      0X0004: 置顶
                 *      0X0005: 系统菜单
                 */
                switch (tagFlag)
                {
                    case 0X0001:
                        this.closeBtn.Image = Properties.Resources.close_1;
                        break;
                    case 0X0002:
                        this.maxBtn.Image = Properties.Resources.max_1;
                        break;
                    case 0X0003:
                        this.minBtn.Image = Properties.Resources.min_1;
                        break;
                    case 0X0004:
                        this.topBtn.Image = this.TopMost ? Properties.Resources.top_1_1 : Properties.Resources.top_1;
                        break;
                    case 0X0005:
                        this.menuBtn.Image = Properties.Resources.menu_1;
                        break;
                }
            }             
        }

        /// <summary>
        /// 描述: 控制栏鼠标按下事件统一处理函数
        /// 作者: Ziegler Penn
        /// 日期: 2014-6-30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Label)
            {
                Int16 tagFlag = Convert.ToInt16(((Label)sender).Tag.ToString(), 16);
                /*
                 * 说明: 使用控件的Tag属性标记其实质含义(采用16进制数字表示)
                 * 参数: 
                 *      0X0001: 关闭
                 *      0X0002: 最大化
                 *      0X0003: 最小化
                 *      0X0004: 置顶
                 *      0X0005: 系统菜单
                 */
                switch (tagFlag)
                {
                    case 0X0001:
                        this.closeBtn.Image = Properties.Resources.close_3;
                        break;
                    case 0X0002:
                        this.maxBtn.Image = Properties.Resources.max_3;  
                        break;
                    case 0X0003:
                        this.minBtn.Image = Properties.Resources.min_3;
                        break;
                    case 0X0004:
                        this.topBtn.Image = this.TopMost ? Properties.Resources.top_3_1 : Properties.Resources.top_3;
                        break;
                    case 0X0005:
                        this.menuBtn.Image = Properties.Resources.menu_3;
                        break;
                }
            }            
        }

        /// <summary>
        /// 描述: 控制栏点击事件统一处理函数
        /// 作者: Ziegler Penn
        /// 日期: 2014-6-30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrlMenu_Click(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Int16 tagFlag = Convert.ToInt16(((Label)sender).Tag.ToString(), 16);
                /*
                 * 说明: 使用控件的Tag属性标记其实质含义(采用16进制数字表示)
                 * 参数: 
                 *      0X0001: 关闭
                 *      0X0002: 最大化
                 *      0X0003: 最小化
                 *      0X0004: 置顶
                 *      0X0005: 系统菜单
                 */
                switch (tagFlag)
                { 
                    case 0X0001:
                        this.Close();
                        break;
                    case 0X0002:
                        this.MaxWindow();
                        this.maxBtn.Image = Properties.Resources.max_1;
                        break;
                    case 0X0003:
                        this.WindowState = FormWindowState.Minimized;
                        break;
                    case 0X0004:
                        this.TopMost = !this.TopMost;
                        this.topBtn.Image = this.TopMost ? Properties.Resources.top_1_1 : Properties.Resources.top_1;
                        break;
                    case 0X0005:
                        if (this.SysMenuClick != null)
                        {
                            this.SysMenuClick(sender, e);
                        }
                        break;
                }
            }            
        }
        #endregion
    }
}
