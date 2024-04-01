using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Barcode
{
    class Barcode : IDisposable
    {
        #region Declares

        //General
        private float m_HorizontalMargin = 0;
        private float m_TopMargin = 0;
        private float m_LabelWidth = 0;
        private float m_LabelHeight = 0;
        private BarcodeType m_BarCodeType = BarcodeType.Code128;
        private Graphics m_Graphics = null;

        //Caption
        private bool m_ShowCaption = true;
        private bool m_ShowCaptionLine = true;
        private string m_CaptionText = string.Empty;
        private StringAlignment m_CaptionAlignment = StringAlignment.Center;
        private Font m_CaptionFont = new Font("Tahoma", 8, FontStyle.Regular);
        private Color m_CaptionForeColor = Color.Black;
        private Pen m_CaptionLineColor = new Pen(Color.Black);

        //Header 
        private bool m_ShowHeader = true;
        private string m_HeaderText = string.Empty;
        private StringAlignment m_HeaderAlignment = StringAlignment.Center;
        private Font m_HeaderFont = new Font("Tahoma", 8, FontStyle.Regular);
        private Color m_HeaderForeColor = Color.Black;

        //Barcode39
        private string m_BarcodeText = string.Empty;
        private float m_Narrow = 0;
        private float m_BarHeight = 0;
        private HorizontalAlignment m_BarAlign = HorizontalAlignment.Center;
        private Color m_BarColor = Color.Black;
        private BarcodeStyle m_BarStyle = BarcodeStyle.Small;

        //Barcode Text
        private bool m_ShowBarcodeText = true;
        private Font m_BarcodeTextFont = new Font("Tahoma", 8, FontStyle.Regular);
        private Color m_BarcodeTextForeColor = Color.Black;

        //Footer 
        private bool m_ShowFooter = true;
        private bool m_ShowFooterLine = true;
        private string m_FooterText = string.Empty;
        private StringAlignment m_FooterAlignment = StringAlignment.Center;
        private Font m_FooterFont = new Font("Tahoma", 8, FontStyle.Regular);
        private Color m_FooterForeColor = Color.Black;
        private Pen m_FooterLineColor = new Pen(Color.Black);



        //General
        private SolidBrush _Brush = new SolidBrush(Color.Black);
        private StringFormat _stFormat = new StringFormat();
        private RectangleF _LabelRec = new RectangleF();

        //Caption
        private RectangleF _CaptionRec = new RectangleF();

        //BarCode Text 
        private RectangleF _HeaderRec = new RectangleF();

        //BarCode Text
        private RectangleF _BarCodeTextRec = new RectangleF();

        //Footer
        private RectangleF _FooterRec = new RectangleF();

        //Barcode39
        private string _stintercharacterGap = string.Empty;
        private string _str = string.Empty;
        private StringBuilder _stencodedString = new StringBuilder();
        private int _strLength = 0;
        private int _CodeLength = 0;
        private float _Bar39X = 0;
        private float _LineWid = 0;
        private float _fwidthOfBarCodeString = 0;
        private float _fwideToNarrowRatio = 0;
        private int _iEncodedStringLength = 0;

        //Barcode128
        private Code128 _Barcode128 = new Code128();
        private PointF _p1 = new PointF();
        private PointF _p2 = new PointF();
        private string _EncodedValue = string.Empty;
        private int _pos = 0;
        private float _Bar128X = 0;
        private float _Bar128Width = 0;
        private float _Bar128WidthModifier = 1;
        private float _Code128Width = 0;

        //Drawing Control
        private Control m_DrawingBoard;

        #endregion

        #region Properties

        //General
        public float HorizontalMargin
        {
            get { return m_HorizontalMargin; }
            set { m_HorizontalMargin = value; }
        }
        public float TopMargin
        {
            get { return m_TopMargin; }
            set { m_TopMargin = value; }
        }
        public float Width
        {
            get { return m_LabelWidth; }
            set { m_LabelWidth = value; }
        }
        public float Height
        {
            get { return m_LabelHeight; }
            set { m_LabelHeight = value; }
        }
        public BarcodeType BarCodeType
        {
            get { return m_BarCodeType; }
            set { m_BarCodeType = value; }
        }
        public Graphics ImageGraphics
        {
            get { return m_Graphics; }
            set { m_Graphics = value; }
        }

        //Caption
        public bool ShowCaption
        {
            get { return m_ShowCaption; }
            set { m_ShowCaption = value; }
        }
        public bool ShowCaptionLine
        {
            get { return m_ShowCaptionLine; }
            set { m_ShowCaptionLine = value; }
        }
        public string CaptionText
        {
            get { return m_CaptionText; }
            set { m_CaptionText = value; }
        }
        public StringAlignment CaptionAlign
        {
            get { return m_CaptionAlignment; }
            set
            {
                m_CaptionAlignment = value;
            }
        }
        public Font CaptionFont
        {
            get { return m_CaptionFont; }
            set { m_CaptionFont = value; }
        }
        public Color CaptionForeColor
        {
            get { return m_CaptionForeColor; }
            set { m_CaptionForeColor = value; }
        }
        public Pen CaptionLineColor
        {
            get { return m_CaptionLineColor; }
            set { m_CaptionLineColor = value; }
        }

        //Header
        public bool ShowHeader
        {
            get { return m_ShowHeader; }
            set { m_ShowHeader = value; }
        }
        public string HeaderText
        {
            get { return m_HeaderText; }
            set { m_HeaderText = value; }
        }
        public StringAlignment HeaderAlign
        {
            get { return m_HeaderAlignment; }
            set
            {
                m_HeaderAlignment = value;
            }
        }
        public Font HeaderFont
        {
            get { return m_HeaderFont; }
            set { m_HeaderFont = value; }
        }
        public Color HeaderForeColor
        {
            get { return m_HeaderForeColor; }
            set { m_HeaderForeColor = value; }
        }

       
        //Footer
        public bool ShowFooter
        {
            get { return m_ShowFooter; }
            set { m_ShowFooter = value; }
        }
        public bool ShowFooterLine
        {
            get { return m_ShowFooterLine; }
            set { m_ShowFooterLine = value; }
        }
        public string FooterText
        {
            get { return m_FooterText; }
            set { m_FooterText = value; }
        }
        public StringAlignment FooterAlign
        {
            get { return m_FooterAlignment; }
            set
            {
                m_FooterAlignment = value;
            }
        }
        public Font FooterFont
        {
            get { return m_FooterFont; }
            set { m_FooterFont = value; }
        }
        public Color FooterForeColor
        {
            get { return m_FooterForeColor; }
            set { m_FooterForeColor = value; }
        }
        public Pen FooterLineColor
        {
            get {return  m_FooterLineColor; }
            set { m_FooterLineColor = value; }
        }

        //Barcode
        public string BarcodeText
        {
            get { return m_BarcodeText; }
            set { m_BarcodeText = value.Trim().ToUpper(); }
        }
        // From 0 To 1
        /// <summary>
        /// From 0 To 1
        /// </summary>
        public float BarcodeNarrow
        {
            get { return m_Narrow; }
            set
            {
                m_Narrow = value;
                if (m_Narrow > 1)
                {
                    MessageBox.Show("Narrow Must Be Between 0 To 1");
                    m_Narrow = 1;
                }
            }
        }
        public float BarcodeHeight
        {
            get { return m_BarHeight; }
            set { m_BarHeight = value; }
        }
        public HorizontalAlignment BarcodeAlignment
        {
            get { return m_BarAlign; }
            set { m_BarAlign = value; }

        }
        public Color BarcodeColor
        {
            get { return m_BarColor; }
            set { m_BarColor = value; }
        }
        public BarcodeStyle BarcodeStyle
        {
            get { return m_BarStyle; }
            set { m_BarStyle = value; }
        }
      
        //Bracode Text
        public bool ShowBarcodeText
        {
            get { return m_ShowBarcodeText; }
            set { m_ShowBarcodeText = value; }
        }
        public Font BarcodeTextFont
        {
            get { return m_BarcodeTextFont; }
            set { m_BarcodeTextFont = value; }
        }
        public Color BarcodeTextForeColor
        {
            get { return m_BarcodeTextForeColor; }
            set { m_BarcodeTextForeColor = value; }
        }

        //Drawing Control
        public Control DrawingBoard
        {
            get { return m_DrawingBoard; }
            set
            {
                m_DrawingBoard = value;
                m_DrawingBoard.Paint += new PaintEventHandler(m_DrawingBoard_Paint);
                //m_DrawingBoard.Resize += new EventHandler(DrawingBoard_Resize);
            }
        }

        #endregion

        #region Methods

        private void DrawLabelRectangle(Graphics g)
        {
            _LabelRec.X = 0;
            _LabelRec.Y = 0;
            _LabelRec.Width = m_LabelWidth;
            _LabelRec.Height = m_LabelHeight;
            g.FillRectangle(Brushes.White, _LabelRec);

        }

        private void DrawCaption(Graphics g)
        {
            if (m_ShowCaption == true)
            {
                _CaptionRec.X = m_HorizontalMargin + _LabelRec.X;
                _CaptionRec.Y = TopMargin + _LabelRec.Y;
                _CaptionRec.Width = (_LabelRec.Width - m_HorizontalMargin) - 1;
                _CaptionRec.Height = g.MeasureString(m_CaptionText, m_CaptionFont).Height;


                //Set Header ForeColor
                _Brush.Color = m_CaptionForeColor;

                //Set Header StringFormat(Aligment)
                _stFormat.Alignment = m_CaptionAlignment;

                //g.DrawRectangle(Pens.Black, _CaptionRec.X, _CaptionRec.Y, _CaptionRec.Width, _CaptionRec.Height);
                g.DrawString(m_CaptionText, m_CaptionFont, _Brush, _CaptionRec, _stFormat);

                if (m_ShowCaptionLine == true)
                {
                    g.DrawLine(m_CaptionLineColor, _CaptionRec.X, _CaptionRec.Bottom, _CaptionRec.Right, _CaptionRec.Bottom);
                }
            }
            else
            {
                _CaptionRec.X = 0;
                _CaptionRec.Y = 5;
                _CaptionRec.Width = 0;
                _CaptionRec.Height = 0;
            }
        }

        private void DrawHeader(Graphics g)
        {
            if (m_ShowHeader == true)
            {
                _HeaderRec.X = m_HorizontalMargin + _LabelRec.X;
                _HeaderRec.Y = _CaptionRec.Bottom;
                _HeaderRec.Width = (_LabelRec.Width - m_HorizontalMargin) - 1;
                _HeaderRec.Height = g.MeasureString(m_HeaderText, m_HeaderFont).Height;


                //Set Header ForeColor
                _Brush.Color = m_HeaderForeColor;

                //Set Header StringFormat(Aligment)
                _stFormat.Alignment = m_HeaderAlignment;

                //g.DrawRectangle(Pens.Black, _HeaderRec.X, _HeaderRec.Y, _HeaderRec.Width, _HeaderRec.Height);
                g.DrawString(m_HeaderText, m_HeaderFont, _Brush, _HeaderRec, _stFormat);
            }
            else
            {
                _HeaderRec.X = 0;
                if (m_ShowCaptionLine == true)
                {
                    _HeaderRec.Y = _CaptionRec.Bottom + 1;
                }
                else
                {
                    _HeaderRec.Y = 0;
                }
                _HeaderRec.Width = 0;
                _HeaderRec.Height = 0;
            }
        }

        private void DrawBarCode39(Graphics g)
        {
            _stintercharacterGap = "0";
            _str = '*' + m_BarcodeText.ToUpper() + '*';
            _stencodedString.Remove(0, _stencodedString.Length);
            _strLength = _str.Length;
            _CodeLength = m_BarcodeText.Length;
            _Bar39X = 0;
            _LineWid = 0;
            _fwidthOfBarCodeString = 0;
            //Set BarCode Narrow
            _fwideToNarrowRatio = 3 - m_Narrow;


            //Check For Code Characters
            for (int i = 0; i < _CodeLength; i++)
            {
                if (alphabet39.IndexOf(m_BarcodeText[i]) == -1 || m_BarcodeText[i] == '*')
                {
                    g.DrawString("Invalid Bar Code Text", m_DrawingBoard.Font, Brushes.Red, 10, 10);
                    return;
                }
            }

            //Binary
            for (int i = 0; i < _strLength; i++)
            {
                if (i > 0)
                {
                    _stencodedString.Append(_stintercharacterGap);
                }
                _stencodedString.Append(coded39Char[alphabet39.IndexOf(_str[i])]);
            }
            _iEncodedStringLength = _stencodedString.Length;


            //Set Barcode 
            if (m_BarAlign == HorizontalAlignment.Left)
            {
                _Bar39X = m_HorizontalMargin + _LabelRec.X;
            }
            else
            {
                for (int i = 0; i < _iEncodedStringLength; i++)
                {
                    if (_stencodedString[i] == '1')
                    {
                        _fwidthOfBarCodeString += ((_fwideToNarrowRatio * (int)m_BarStyle));
                    }
                    else
                    {
                        _fwidthOfBarCodeString += (int)m_BarStyle;
                    }
                }

                if (m_BarAlign == HorizontalAlignment.Center)
                {
                    _Bar39X = ((_LabelRec.X + _LabelRec.Right) - _fwidthOfBarCodeString) / 2;
                }
                else
                {
                    _Bar39X = (_LabelRec.Right - m_HorizontalMargin) - _fwidthOfBarCodeString;
                }
            }

            //Draw BarCode
            for (int i = 0; i < _iEncodedStringLength; i++)
            {
                if (_stencodedString[i] == '1')
                {
                    _LineWid = (_fwideToNarrowRatio * (int)m_BarStyle);
                }
                else
                {
                    _LineWid = (int)m_BarStyle;
                }

                _Brush.Color = m_BarColor; //Set Bar Color

                g.FillRectangle(i % 2 == 0 ? _Brush : Brushes.White, _Bar39X, _HeaderRec.Bottom, _LineWid, m_BarHeight);

                _Bar39X += _LineWid;
            }
        }

        private void DrawBarCode128(Graphics g)
        {
            _Barcode128.RawData = m_BarcodeText.Trim().ToUpper();

            _EncodedValue = string.Empty;

            _EncodedValue = _Barcode128.Encode_Code128();

            if (string.IsNullOrEmpty(_EncodedValue) == true)
            {
                MessageBox.Show("EGENERATE_IMAGE-1: Must be encoded first.");
                return;
            }
            _Bar128Width = _EncodedValue.Length;

            _Code128Width = _Bar128Width / _EncodedValue.Length;

            switch (m_BarAlign)
            {
                case HorizontalAlignment.Center:
                    {
                        // _Bar128X = (_LabelRec.Width % _EncodedValue.Length) / 2;
                        _Bar128X = ((_LabelRec.X + _LabelRec.Right) - _EncodedValue.Length) / 2;
                        break;
                    }
                case HorizontalAlignment.Left:
                    {
                        _Bar128X = _LabelRec.X + m_HorizontalMargin;
                        break;
                    }
                case HorizontalAlignment.Right:
                    {
                        _Bar128X = ((_LabelRec.X + _LabelRec.Right) - _EncodedValue.Length) + 1;
                        break;
                    }
                default:
                    {
                        _Bar128X = ((_LabelRec.X + _LabelRec.Right) - _EncodedValue.Length) / 2;
                        break;
                    }
            }
            
            _pos = 0;
            //Lines Are FBarWidth Wide So Draw The Appropriate Color Line Vertically
            using (Pen pen = new Pen(m_BarcodeTextForeColor, _Code128Width / _Bar128WidthModifier))
            {
                while (_pos < _EncodedValue.Length)
                {
                    if (_EncodedValue[_pos] == '1')
                    {
                        _p1.X = _pos * _Code128Width + _Bar128X + (_Code128Width * 0.5f);
                        _p1.Y = _HeaderRec.Bottom;

                        _p2.X = _pos * _Code128Width + _Bar128X + (_Code128Width * 0.5f);
                        _p2.Y = _HeaderRec.Bottom + m_BarHeight;
                        g.DrawLine(pen, _p1, _p2);
                    }
                    _pos++;
                }
            }
        }

        private void DrawBarCode(Graphics g)
        {
            switch (m_BarCodeType)
            {
                case BarcodeType.Code39:
                    {
                        DrawBarCode39(g);
                        break;
                    }
                case BarcodeType.Code128:
                    {
                        DrawBarCode128(g);
                        break;
                    }
            }
        }

        private void DrawBarCodeText(Graphics g)
        {
            if (m_ShowBarcodeText == true)
            {
                _BarCodeTextRec.X = m_HorizontalMargin + _LabelRec.X;
                _BarCodeTextRec.Width = (_LabelRec.Width - m_HorizontalMargin) - 1;
                _BarCodeTextRec.Height = g.MeasureString(m_BarcodeText, m_BarcodeTextFont).Height;
                _BarCodeTextRec.Y = _HeaderRec.Bottom + m_BarHeight;

                //Set Header ForeColor
                _Brush.Color = m_BarcodeTextForeColor;

                //Set Header StringFormat(Aligment)
                switch (m_BarAlign)
                {
                    case HorizontalAlignment.Center:
                        {
                            _stFormat.Alignment = StringAlignment.Center;

                            break;
                        }
                    case HorizontalAlignment.Left:
                        {
                            _stFormat.Alignment = StringAlignment.Near;

                            break;
                        }
                    case HorizontalAlignment.Right:
                        {
                            _stFormat.Alignment = StringAlignment.Far;

                            break;
                        }
                }
                //g.DrawRectangle(Pens.Black, _BarCodeTextRec.X, _BarCodeTextRec.Y, _BarCodeTextRec.Width, _BarCodeTextRec.Height);
                g.DrawString(m_BarcodeText.Replace("$", ""), m_BarcodeTextFont, _Brush, _BarCodeTextRec, _stFormat);
            }
            else
            {
                _BarCodeTextRec.X = 0;
                _BarCodeTextRec.Y = 0;
                _BarCodeTextRec.Width = 0;
                _BarCodeTextRec.Height = 0;
            }
        }

        private void DrawFooter(Graphics g)
        {
            if (m_ShowFooter == true)
            {
                _FooterRec.X = m_HorizontalMargin + _LabelRec.X;
                _FooterRec.Width = (_LabelRec.Width - m_HorizontalMargin) - 1;
                _FooterRec.Height = g.MeasureString(m_FooterText, m_FooterFont).Height;
                _FooterRec.Y = _BarCodeTextRec.Bottom;

                //Set Header ForeColor
                _Brush.Color = m_FooterForeColor;

                _stFormat.Alignment = m_FooterAlignment;

                if (m_ShowFooterLine == true)
                {
                    g.DrawLine(m_FooterLineColor, _FooterRec.X, _FooterRec.Top, _FooterRec.Right, _FooterRec.Top);
                }
                g.DrawString(m_FooterText, m_FooterFont, _Brush, _FooterRec, _stFormat);
            }
            else
            {
                _FooterRec.X = 0;
                _FooterRec.Y = 0;
                _FooterRec.Width = 0;
                _FooterRec.Height = 0;
            }
        }

        public Bitmap DrawTest()
        {
            Bitmap img = new Bitmap((int)m_LabelWidth, (int)m_LabelHeight);
            

            Graphics g = Graphics.FromImage(img);

            img.SetResolution(151, 113);

            DrawLabelRectangle(g);

            DrawCaption(g);
            DrawHeader(g);
            DrawBarCode(g);
            DrawBarCodeText(g);
            DrawFooter(g);

            return img;
            
        }

        #endregion

        private void m_DrawingBoard_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                DrawLabelRectangle(e.Graphics);


                DrawCaption(e.Graphics);
                DrawHeader(e.Graphics);
                DrawBarCode(e.Graphics);
                DrawBarCodeText(e.Graphics);
                DrawFooter(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveImage(string FilePath, System.Drawing.Imaging.ImageFormat ImgFormat)
        {
            using (Bitmap bmp = new Bitmap(m_DrawingBoard.Width, m_DrawingBoard.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    //g.FillRectangle(Brushes.White, 0, 0, Width, Height);

                    DrawHeader(g);
                    DrawBarCode39(g);
                    DrawBarCodeText(g);

                    bmp.Save(FilePath, ImgFormat);
                }
            }
        }

        public void Print()
        {
            using (PrintDocument pd = new PrintDocument())
            {
                pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                pd.OriginAtMargins = true;
                pd.DefaultPageSettings.Landscape = false;
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                pd.Print();
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            DrawHeader(e.Graphics);
            DrawBarCode39(e.Graphics);
            DrawBarCodeText(e.Graphics);
        }

        #region coded39Char

        string alphabet39 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*";

        string[] coded39Char = 
		{
			/* 0 */ "000110100", 
			/* 1 */ "100100001", 
			/* 2 */ "001100001", 
			/* 3 */ "101100000",
			/* 4 */ "000110001", 
			/* 5 */ "100110000", 
			/* 6 */ "001110000", 
			/* 7 */ "000100101",
			/* 8 */ "100100100", 
			/* 9 */ "001100100", 
			/* A */ "100001001", 
			/* B */ "001001001",
			/* C */ "101001000", 
			/* D */ "000011001", 
			/* E */ "100011000", 
			/* F */ "001011000",
			/* G */ "000001101", 
			/* H */ "100001100", 
			/* I */ "001001100", 
			/* J */ "000011100",
			/* K */ "100000011", 
			/* L */ "001000011", 
			/* M */ "101000010", 
			/* N */ "000010011",
			/* O */ "100010010", 
			/* P */ "001010010", 
			/* Q */ "000000111", 
			/* R */ "100000110",
			/* S */ "001000110", 
			/* T */ "000010110", 
			/* U */ "110000001", 
			/* V */ "011000001",
			/* W */ "111000000", 
			/* X */ "010010001", 
			/* Y */ "110010000", 
			/* Z */ "011010000",
			/* - */ "010000101", 
			/* . */ "110000100", 
			/*' '*/ "011000100",
			/* $ */ "010101000",
			/* / */ "010100010", 
			/* + */ "010001010", 
			/* % */ "000101010", 
			/* * */ "010010100" 
		};
        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            _Barcode128.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}