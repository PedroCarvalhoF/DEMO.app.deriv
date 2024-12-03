using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DEMO.app.deriv.Controles.Helpers
{
    public class EasyPanel : Panel
    {
        public int CornerRadius { get; set; } = 30;
        public int? CornerRadiusTopLeft { get; set; }
        public int? CornerRadiusTopRight { get; set; }
        public int? CornerRadiusBottomRight { get; set; }
        public int? CornerRadiusBottomLeft { get; set; }
        public Color BorderColor { get; set; } = Color.White;
        public float BorderThickness { get; set; } = 1.5f;
        public Color ShadowColor { get; set; } = Color.Gray;
        public int ShadowSize { get; set; } = 5;

        public EasyPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-(int)(BorderThickness / 2), -(int)(BorderThickness / 2));

            using (GraphicsPath path = GetRoundedRectPath(rect))
            {
                DrawShadow(e.Graphics, path);

                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                if (BorderThickness > 0)
                {
                    using (Pen pen = new Pen(BorderColor, BorderThickness))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                this.Region = new Region(path);
            }
        }

        private void DrawShadow(Graphics g, GraphicsPath path)
        {
            using (PathGradientBrush brush = new PathGradientBrush(path))
            {
                brush.CenterColor = Color.FromArgb(50, ShadowColor);
                brush.SurroundColors = new Color[] { Color.Transparent };
                g.TranslateTransform(ShadowSize, ShadowSize);
                g.FillPath(brush, path);
                g.TranslateTransform(-ShadowSize, -ShadowSize);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();

            // Utiliza os valores individuais de cada canto, ou o valor padrão de CornerRadius
            float curveSizeTL = (CornerRadiusTopLeft ?? CornerRadius) * 2F;
            float curveSizeTR = (CornerRadiusTopRight ?? CornerRadius) * 2F;
            float curveSizeBR = (CornerRadiusBottomRight ?? CornerRadius) * 2F;
            float curveSizeBL = (CornerRadiusBottomLeft ?? CornerRadius) * 2F;

            // Top-Left Corner
            if (CornerRadiusTopLeft > 0 || CornerRadius > 0)
                path.AddArc(rect.X, rect.Y, curveSizeTL, curveSizeTL, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            // Top-Right Corner
            if (CornerRadiusTopRight > 0 || CornerRadius > 0)
                path.AddArc(rect.Right - curveSizeTR, rect.Y, curveSizeTR, curveSizeTR, 270, 90);
            else
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);

            // Bottom-Right Corner
            if (CornerRadiusBottomRight > 0 || CornerRadius > 0)
                path.AddArc(rect.Right - curveSizeBR, rect.Bottom - curveSizeBR, curveSizeBR, curveSizeBR, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

            // Bottom-Left Corner
            if (CornerRadiusBottomLeft > 0 || CornerRadius > 0)
                path.AddArc(rect.X, rect.Bottom - curveSizeBL, curveSizeBL, curveSizeBL, 90, 90);
            else
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

            path.CloseFigure();
            return path;
        }
    }
}
