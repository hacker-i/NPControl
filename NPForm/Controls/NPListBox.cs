using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;

namespace NPForm.Controls
{
    public class NPListBox : System.Windows.Forms.ListBox
    {
        //private System.Drawing.Color normal, over, selected;
        private ArrayList bgColors = new ArrayList();
        private Brush bgBrush = new SolidBrush(Color.Orange);

        public NPListBox() : base()
        {
            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
        {
            int index = e.Index;            //获取当前要进行绘制的行的序号，从0开始。
            Graphics g = e.Graphics;        //获取Graphics对象。
            Rectangle bound = e.Bounds;     //获取当前要绘制的行的一个矩形范围。
            string text = this.Items[index].ToString();//获取当前要绘制的行的显示文本。

            //如果当前行为选中行
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //绘制选中时要显示的蓝色边框。
                g.DrawRectangle(Pens.Blue, bound.Left, bound.Top, bound.Width - 1, bound.Height - 1);
                Rectangle rect = new Rectangle(bound.Left + 2, bound.Top +2, bound.Width - 4, bound.Height - 4);
                //绘制选中时要显示的蓝色背景。
                g.FillRectangle(Brushes.Blue, rect);
                //绘制显示文本。
                TextRenderer.DrawText(g, text, this.Font, rect, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else
            {   
                //GetBrush为自定义方法，根据当前的行号来选择Brush进行绘制。
                //using (Brush brush = GetBrush(e.Index))
                //{
                //    g.FillRectangle(brush, bound);//绘制背景色。
                //}

                g.FillRectangle(bgBrush, bound);
                TextRenderer.DrawText(g, text, this.Font, bound, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }


        }

        private Brush GetBrush(int index)
        {
            Brush brush;
            if (index < bgColors.Count)
            {
                brush = new SolidBrush((Color)bgColors[index]);
            }
            brush = new SolidBrush(Color.Orange);
            return brush;
        }

    }
}
