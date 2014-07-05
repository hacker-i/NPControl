using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace NPForm.Utils
{
    /// <summary>
    /// Describe: Form Utils
    /// Author  : Ziegler Penn
    /// Date    : 2014-6-27
    /// E-mail  : hacker_i@foxmail.com
    /// </summary>
    public class FormUtils
    {
        /// <summary>
        /// 获取窗体在屏幕中间的Location坐标
        /// </summary>
        /// <param name="form">窗体引用</param>
        /// <returns>坐标点</returns>
        public static Point getFormPosToScreen(int height, int width)
        {
            return new Point((getScreenWidth() / 2) - (width / 2), (getScreenHeight() / 2) - (height / 2));
        }

        /// <summary>
        /// 获取屏幕高度
        /// </summary>
        /// <returns>高度</returns>
        public static int getScreenHeight()
        {
            return Screen.PrimaryScreen.WorkingArea.Height;
        }

        /// <summary>
        /// 获取屏幕宽度
        /// </summary>
        /// <returns>宽度</returns>
        public static int getScreenWidth()
        {
            return Screen.PrimaryScreen.WorkingArea.Width;
        }


        //窗体阴影示例
        //SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果

        //public static readonly Int32
        //CS_BYTEALIGNCLIENT = 0x1000,
        //CS_BYTEALIGNWINDOW = 0x2000,
        //CS_CLASSDC = 0x0040,
        //CS_DBLCLKS = 0x0008,
        //CS_DROPSHADOW = 0x00020000,
        //CS_GLOBALCLASS = 0x4000,
        //CS_HREDRAW = 0x0002,
        //CS_NOCLOSE = 0x0200,
        //CS_OWNDC = 0x0020,
        //CS_PARENTDC = 0x0080,
        //CS_SAVEBITS = 0x0800,
        //CS_VREDRAW = 0x0001;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= ClassStyles.CS_DROPSHADOW;
        //        return cp;
        //    }
        //} 
    }
}
