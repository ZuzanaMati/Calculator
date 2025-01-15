using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Kalkulacka
{
    public class RoundedButton : Button
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 20; // Default corner radius

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Enable anti-aliasing
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Top-left
            path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Top-right
            path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Bottom-right
            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Bottom-left
            path.CloseFigure();

            // Apply clipping region
            this.Region = new Region(path);

            // Draw the border
            using (Pen borderPen = new Pen(Color.Black, 1)) // Border color and thickness
            {
                pevent.Graphics.DrawPath(borderPen, path);
            }
        }
    }
}