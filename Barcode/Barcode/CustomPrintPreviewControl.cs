using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace Barcode
{
    public partial class CustomPrintPreviewControl : System.Windows.Forms.PrintPreviewControl
    {
        private Type _T;
        private FieldInfo _Position;
        private FieldInfo _PageInfo;
        private MethodInfo _SetPositionMethod;
        private MethodInfo _InvalidateLayout;
        private PrintController _OriginalControllar;
        private PreviewPrintController prevCont;
        private float _LineHeight = 0f;
        private int _Pages;
        private bool _layoutOk;

        #region Constructor
        public CustomPrintPreviewControl()
            : base()
        {
            _T = typeof(System.Windows.Forms.PrintPreviewControl);
            _Position = _T.GetField("position", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
            _PageInfo = _T.GetField("pageInfo", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);

            _SetPositionMethod = _T.GetMethod("SetPositionNoInvalidate",
                                BindingFlags.Instance |
                                BindingFlags.NonPublic |
                                BindingFlags.ExactBinding);
            _InvalidateLayout = _T.GetMethod("InvalidateLayout",
                                BindingFlags.Instance |
                                BindingFlags.NonPublic |
                                BindingFlags.ExactBinding);
            this.MouseWheel += new MouseEventHandler(PrintPreviewControl_MouseWheel);
            this.KeyUp += new KeyEventHandler(CustomPrintPreviewControl_KeyUp);

            // Get the lineheight
            using (Graphics g = this.CreateGraphics())
            {
                using (Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point))
                {
                    SizeF size = g.MeasureString("A", font);

                    _LineHeight = size.Height;
                }
            }
        }
        #endregion

        void CustomPrintPreviewControl_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // check if the Document exists; no sense in doing anything otherwise
                if (Document != null)
                {
                    float amount = SystemInformation.MouseWheelScrollLines;

                    // We need to know the line height to know how many lines to scroll
                    amount *= _LineHeight;

                    // And take the zoom into consideration
                    amount *= (float)Zoom;
                    if (e.KeyCode == Keys.Down)
                    {
                        performScrollVertical((int)amount);
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        performScrollVertical((int)-amount);
                    }

                }
            }
            catch (Exception) { }
        }


        void PrintPreviewControl_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                // check if the Document exists; no sense in doing anything otherwise
                if (Document != null && Control.ModifierKeys != Keys.Control)
                {
                    int amount = getScrollAmount(e.Delta);

                    performScrollVertical(amount);
                }
            }
            catch (Exception) { }
        }

        public int PageCount
        {
            get { return _Pages; }
        }

        public void resetCount()
        {
            _Pages = 0;
        }

        // Doing this so that we can get the page count when the document prints.
        public new PrintDocument Document
        {
            get { return base.Document; }
            set
            {
                base.Document = value;
                resetCount();
                base.Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
                base.Document.BeginPrint += new PrintEventHandler(Document_BeginPrint);
                _OriginalControllar = value.PrintController;
            }
        }

        public new void InvalidatePreview()
        {
            _layoutOk = false;
            this.Invalidate();
        }

        void Document_BeginPrint(object sender, PrintEventArgs e)
        {
            _Pages = 0;
        }

        // To get the amount of pages
        void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            _PageInfo.SetValue(this, prevCont.GetPreviewPageInfo());
            _InvalidateLayout.Invoke(this, new object[] { });
            _layoutOk = true;
            _Pages++;
        }


        // get the scroll amount
        private int getScrollAmount(int delta)
        {
            // We want to scroll amount to be porportionate to the delta
            float amount = Math.Abs(delta) / SystemInformation.MouseWheelScrollDelta;

            // Use the system default to how many lines we scroll per tick
            amount *= SystemInformation.MouseWheelScrollLines;

            // We need to know the line height to know how many lines to scroll
            amount *= _LineHeight;

            // And take the zoom into consideration
            amount *= (float)Zoom;

            // return as an int
            return (delta < 0) ? (int)amount : -(int)amount;
        }

        // Use reflection to call the SetPositionNoInvalidate method.
        public void performScrollVertical(int amount)
        {
            // get the current position
            Point currentPos = (Point)(_Position.GetValue(this));

            // add the scroll amount to the current position
            _SetPositionMethod.Invoke(this, new object[] { new Point(currentPos.X + 0, currentPos.Y + amount) });

            // get the new position
            Point newPos = (Point)(_Position.GetValue(this));

            // if the old and new positions are the same, we need to go to the next page
            if (newPos.Y == currentPos.Y)
            {
                // if scrolling down
                if (amount > 0)
                {
                    // If the startpage is less than the amount of pages
                    if (this.StartPage + 1 < _Pages && !(Rows > 1))
                    {
                        // go the next page
                        this.StartPage++;
                        _SetPositionMethod.Invoke(this, new object[] { new Point(currentPos.X + 0, 0) });
                    }
                }
                else // otherwise go to the preview page
                {

                    this.StartPage--;
                    _SetPositionMethod.Invoke(this, new object[] { new Point(currentPos.X + 0, ClientSize.Height) });
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            try
            {
                if (!_layoutOk && !this.DesignMode)
                {
                    prevCont = new PreviewPrintController();
                    base.Document.PrintController = prevCont;
                    prevCont.UseAntiAlias = base.UseAntiAlias;
                    base.Document.Print();
                    base.Document.PrintController = _OriginalControllar;
                }
                base.OnPaint(pevent);
            }
            catch (Exception ex)
            {
                TMain.ErrorMessage(ex);
            }
        }


    }
}
