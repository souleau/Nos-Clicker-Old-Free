using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krokmou_Clicker_V3.UI.Controls
{
    public class KrokmouTrackBar : UserControl
    {
        private int _minimumValue = 0;
        private int _maximumValue = 100;
        private int _value = 0;

        private Rectangle _trackRectangle;
        private Rectangle _thumbRectangle;

        public KrokmouTrackBar()
        {
            this.DoubleBuffered = true;
        }

        private void DrawRoundRectangle(Graphics graphics, Pen pen, RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - (radius * 2), rect.Y);
            path.AddArc(rect.X + rect.Width - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - (radius * 2));
            path.AddArc(rect.X + rect.Width - (radius * 2), rect.Y + rect.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.X + rect.Width - (radius * 2), rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - (radius * 2), rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.CloseFigure();

            graphics.DrawPath(pen, path);
        }

        private void FillRoundRectangle(Graphics graphics, Brush brush, RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - (radius * 2), rect.Y);
            path.AddArc(rect.X + rect.Width - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - (radius * 2));
            path.AddArc(rect.X + rect.Width - (radius * 2), rect.Y + rect.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.X + rect.Width - (radius * 2), rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - (radius * 2), rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.CloseFigure();

            graphics.FillPath(brush, path);
        }

        private GraphicsPath GetRoundRectangle(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            float diameter = 2 * radius;
            RectangleF arc = new RectangleF(rect.X, rect.Y, diameter, diameter);

            // Top left arc  
            path.AddArc(arc, 180, 90);

            // Top right arc  
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc  
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc 
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private Color _thumbColor = Color.FromArgb(0, 192, 0);
        public Color ThumbColor
        {
            get { return _thumbColor; }
            set { _thumbColor = value; Invalidate(); }
        }

        private Color _trackColor = Color.DimGray;
        public Color TrackColor
        {
            get { return _trackColor; }
            set { _trackColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Calcul des dimensions
            int padding = 2;
            int thumbSize = 17;
            int trackHeight = 3;

            // Calcul de la position du curseur
            float thumbPosition = (float)(_value - _minimumValue) / (_maximumValue - _minimumValue) * (Width - thumbSize - 2 * padding) + padding;

            // Dessin du track
            RectangleF trackRect = new RectangleF(padding, Height / 2 - trackHeight / 2, Width - 2 * padding, trackHeight);
            FillRoundRectangle(e.Graphics, new SolidBrush(TrackColor), trackRect, trackHeight / 2);

            // Dessin de la partie sélectionnée
            float thumbCenter = thumbPosition + thumbSize / 2;
            RectangleF selectionRect = new RectangleF(trackRect.X, trackRect.Y, thumbCenter - trackRect.X, trackRect.Height);
            FillRoundRectangle(e.Graphics, new SolidBrush(ThumbColor), selectionRect, trackHeight / 2);

            // Dessin du curseur
            RectangleF thumbRect = new RectangleF(thumbPosition, Height / 2 - thumbSize / 2, thumbSize, thumbSize);
            GraphicsPath thumbPath = GetRoundRectangle(thumbRect, thumbSize / 2);
            e.Graphics.FillPath(new SolidBrush(ThumbColor), thumbPath);
            e.Graphics.DrawPath(new Pen(Color.FromArgb(35, 35, 35), 1), thumbPath);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            UpdateValue(e.Location.X);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                UpdateValue(e.Location.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            UpdateValue(e.Location.X);
        }

        private int GetThumbPosition()
        {
            return (int)((double)(_value - _minimumValue) / (_maximumValue - _minimumValue) * (double)(this.Width - 16));
        }

        private void UpdateValue(int x)
        {
            int newValue = (int)((double)x / (double)(this.Width - 16) * (_maximumValue - _minimumValue) + _minimumValue);
            newValue = Math.Min(newValue, _maximumValue);
            newValue = Math.Max(newValue, _minimumValue);

            if (_value != newValue)
            {
                _value = newValue;
                this.Invalidate();
                OnValueChanged(EventArgs.Empty);
            }
        }

        public event EventHandler ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ValueChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public int MinimumValue
        {
            get { return _minimumValue; }
            set
            {
                _minimumValue = value;
                _value = Math.Max(_minimumValue, _value);
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public int MaximumValue
        {
            get { return _maximumValue; }
            set
            {
                _maximumValue = value;
                _value = Math.Min(_maximumValue, _value);
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public int Value
        {
            get { return _value; }
            set
            {
                value = Math.Min(_maximumValue, value);
                value = Math.Max(_minimumValue, value);

                if (_value != value)
                {
                    _value = value;
                    this.Invalidate();
                    OnValueChanged(EventArgs.Empty);
                }
            }
        }
    }
}
