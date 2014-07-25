using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace NPForm.Controls
{
    /// <summary>
    /// 功能:自定义按钮类
    /// 作者:彭紫梁
    /// 时间:2014-4-14
    /// </summary>  
    [ToolboxBitmap("NPButton.bmp")]
    public class NPButton:System.Windows.Forms.Button
    {
        public NPButton() { 
            //禁用聚焦虚线
            this.SetStyle(System.Windows.Forms.ControlStyles.Selectable, false); 
        }
    }
}
