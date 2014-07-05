using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace NPForm.Controls
{
    [ToolboxBitmap(typeof(NPFormCom), "Resources/Forms/NPFormCom.bmp")]
    public class NPDataGridView : System.Windows.Forms.DataGridView
    {
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            //如果是Column
            if (e.RowIndex == -1)
            {
                drawColumnAndRow(e);
                e.Handled = true;
                //如果是Rowheader
            }
            else if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                drawColumnAndRow(e);
                e.Handled = true;
            }
        }

        void drawColumnAndRow(DataGridViewCellPaintingEventArgs e)
        {
            // 绘制背景色
            using (LinearGradientBrush backbrush = new LinearGradientBrush(e.CellBounds, Color.Orange, Color.Orange, LinearGradientMode.Vertical))
            {           
                Rectangle border = e.CellBounds;
                border.Width -= 1;
                //填充绘制效果
                e.Graphics.FillRectangle(backbrush, border);
                //绘制Column、Row的Text信息
                e.PaintContent(e.CellBounds);
                //绘制边框
                //ControlPaint.DrawBorder3D(e.Graphics, e.CellBounds, Border3DStyle.Flat);
                ControlPaint.DrawBorder(e.Graphics, e.CellBounds, Color.White, ButtonBorderStyle.Solid);
            }
        }


    }
}
