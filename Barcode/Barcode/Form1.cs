using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Barcode
{
    public partial class Form1 : Form
    {
        private Barcode m_Barcode = new Barcode();



        public Form1()
        {
            InitializeComponent();
        }

        #region Caption

        private void btnCaptionFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.AllowSimulations = true;
                fd.AllowVectorFonts = false;
                fd.AllowVerticalFonts = false;
                fd.ShowColor = false;
                //fd.Font = txtCaptionText.Font;
                fd.ShowEffects = false;
                fd.ShowDialog();
                m_Barcode.CaptionFont = fd.Font;
            }

            lblBarcode.Refresh();
        }

        private void btnCaptionForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.AnyColor = true;
                cd.Color = txtCaptionText.ForeColor;
                cd.FullOpen = true;
                cd.ShowDialog();
                m_Barcode.CaptionForeColor = cd.Color;
            }
            lblBarcode.Refresh();
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.AnyColor = true;
                cd.Color = m_Barcode.CaptionLineColor.Color;
                cd.FullOpen = true;
                cd.ShowDialog();
                m_Barcode.CaptionLineColor.Color = cd.Color;
            }
            lblBarcode.Refresh();
        }

        private void btnCaptionAlignRight_Click(object sender, EventArgs e)
        {
            m_Barcode.CaptionAlign = StringAlignment.Far;
            lblBarcode.Refresh();
        }

        private void btnCaptionAlignCenter_Click(object sender, EventArgs e)
        {
            m_Barcode.CaptionAlign = StringAlignment.Center;
            lblBarcode.Refresh();
        }

        private void btnCaptionAlignLeft_Click(object sender, EventArgs e)
        {
            m_Barcode.CaptionAlign = StringAlignment.Near;
            lblBarcode.Refresh();
        }

        private void chkShowCaption_CheckedChanged(object sender, EventArgs e)
        {
            m_Barcode.ShowCaption = chkShowCaption.Checked;
            lblBarcode.Refresh();
        }

        private void chkShowCaptionLine_CheckedChanged(object sender, EventArgs e)
        {
            m_Barcode.ShowCaptionLine = chkShowCaptionLine.Checked;
            lblBarcode.Refresh();
        }

        private void txtCaptionText_TextChanged(object sender, EventArgs e)
        {
            m_Barcode.CaptionText = txtCaptionText.Text;
            lblBarcode.Refresh();
        }

        #endregion

        #region Header

        private void btnHeaderFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.AllowSimulations = true;
                fd.AllowVectorFonts = false;
                fd.AllowVerticalFonts = false;
                fd.ShowColor = false;
                fd.Font = m_Barcode.HeaderFont;
                fd.ShowEffects = false;
                fd.ShowDialog();
                m_Barcode.HeaderFont = fd.Font;
            }

            lblBarcode.Refresh();
        }

        private void btnHeaderForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.AnyColor = true;
                //cd.Color = textBox1.ForeColor;
                cd.FullOpen = true;
                cd.ShowDialog();
                m_Barcode.HeaderForeColor = cd.Color;
            }
            lblBarcode.Refresh();

        }

        private void btnHeaderAlignRight_Click(object sender, EventArgs e)
        {
            m_Barcode.HeaderAlign = StringAlignment.Far;
            lblBarcode.Refresh();
        }

        private void btnHeaderAlignCenter_Click(object sender, EventArgs e)
        {
            m_Barcode.HeaderAlign = StringAlignment.Center;
            lblBarcode.Refresh();
        }

        private void btnHeaderAlignLeft_Click(object sender, EventArgs e)
        {
            m_Barcode.HeaderAlign = StringAlignment.Near;
            lblBarcode.Refresh();
        }

        private void chkShowHeader_CheckedChanged(object sender, EventArgs e)
        {
            m_Barcode.ShowHeader = chkShowHeader.Checked;
            lblBarcode.Refresh();
        }

        private void chkShowClintType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowClintType.Checked == true)
            {
                m_Barcode.HeaderText = txtHeaderText.Text + Environment.NewLine + "‘Â—Ì";
            }
            else
            {
                m_Barcode.HeaderText = txtHeaderText.Text;
            }
            lblBarcode.Refresh();
        }

        private void txtHeaderText_TextChanged(object sender, EventArgs e)
        {
            if (chkShowClintType.Checked == true)
            {
                m_Barcode.HeaderText = txtHeaderText.Text + Environment.NewLine + "‘Â—Ì";
            }
            else
            {
                m_Barcode.HeaderText = txtHeaderText.Text;
            }
            lblBarcode.Refresh();
        }

        #endregion

        #region Barcode

        private void btnBarTextFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.AllowSimulations = true;
                fd.AllowVectorFonts = false;
                fd.AllowVerticalFonts = false;
                fd.ShowColor = false;
                //fd.Font = txtCaptionText.Font;
                fd.ShowEffects = false;
                fd.ShowDialog();
                m_Barcode.BarcodeTextFont = fd.Font;
            }

            lblBarcode.Refresh();
        }

        private void btnBarcodeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.AnyColor = true;
                //cd.Color = textBox1.ForeColor;
                cd.FullOpen = true;
                cd.ShowDialog();
                m_Barcode.BarcodeTextForeColor = cd.Color;
                m_Barcode.BarcodeColor = cd.Color;
            }
            lblBarcode.Refresh();
        }

        private void btnBarcodeAlignRight_Click(object sender, EventArgs e)
        {
            m_Barcode.BarcodeAlignment = HorizontalAlignment.Right;
            lblBarcode.Refresh();
        }

        private void btnBarCodeAlignCenter_Click(object sender, EventArgs e)
        {
            m_Barcode.BarcodeAlignment = HorizontalAlignment.Center;
            lblBarcode.Refresh();
        }

        private void btnBarcodeAlignLeft_Click(object sender, EventArgs e)
        {
            m_Barcode.BarcodeAlignment = HorizontalAlignment.Left;
            lblBarcode.Refresh();
        }

        private void cboEncodeType_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboEncodeType.SelectedIndex)
            {
                case 0:
                    {
                        m_Barcode.BarCodeType = BarcodeType.Code39;
                        numNarrow.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        m_Barcode.BarCodeType = BarcodeType.Code128;
                        numNarrow.Enabled = false;
                        break;
                    }
            }
            lblBarcode.Refresh();
        }

        private void txtBarcodeText_TextChanged(object sender, EventArgs e)
        {
            m_Barcode.BarcodeText = txtBarcodeText.Text;

            lblBarcode.Refresh();
        }

        private void chkShowBarcodeText_CheckedChanged(object sender, EventArgs e)
        {
            m_Barcode.ShowBarcodeText = chkShowBarcodeText.Checked;
            lblBarcode.Refresh();
        }

        private void numBarcodeHeight_ValueChanged(object sender, EventArgs e)
        {
            m_Barcode.BarcodeHeight = (float)numBarcodeHeight.Value;
            lblBarcode.Refresh();
        }

        private void numNarrow_ValueChanged(object sender, EventArgs e)
        {
            m_Barcode.BarcodeNarrow = (float)numNarrow.Value;
            lblBarcode.Refresh();
        }

        #endregion

        #region Footer

        private void chkShowFooter_CheckedChanged(object sender, EventArgs e)
        {
            m_Barcode.ShowFooter = chkShowFooter.Checked;
            lblBarcode.Refresh();
        }

        private void btnFooterFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.AllowSimulations = true;
                fd.AllowVectorFonts = false;
                fd.AllowVerticalFonts = false;
                fd.ShowColor = false;
                //fd.Font = txtCaptionText.Font;
                fd.ShowEffects = false;
                fd.ShowDialog();
                m_Barcode.FooterFont = fd.Font;
            }

            lblBarcode.Refresh();

        }

        private void btnFooterForeColor_Click(object sender, EventArgs e)
        {

            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.AnyColor = true;
                //cd.Color = textBox1.ForeColor;
                cd.FullOpen = true;
                cd.ShowDialog();
                m_Barcode.FooterForeColor = cd.Color;
            }
            lblBarcode.Refresh();
        }

        private void btnFooterAlignRight_Click(object sender, EventArgs e)
        {
            m_Barcode.FooterAlign = StringAlignment.Far;
            lblBarcode.Refresh();

        }

        private void btnFooterAlignCenter_Click(object sender, EventArgs e)
        {
            m_Barcode.FooterAlign = StringAlignment.Center;
            lblBarcode.Refresh();
        }

        private void btnFooterAlignLeft_Click(object sender, EventArgs e)
        {
            m_Barcode.FooterAlign = StringAlignment.Near;
            lblBarcode.Refresh();
        }

        private void txtFooterText_TextChanged(object sender, EventArgs e)
        {
            m_Barcode.FooterText = txtFooterText.Text;
            lblBarcode.Refresh();
        }

        private void btnFooterLineColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.AnyColor = true;
                cd.Color = m_Barcode.FooterLineColor.Color;
                cd.FullOpen = true;
                cd.ShowDialog();
                m_Barcode.FooterLineColor.Color = cd.Color;
            }
            lblBarcode.Refresh();
        }

        private void chkFooterLine_CheckedChanged(object sender, EventArgs e)
        {
            m_Barcode.ShowFooterLine = chkFooterLine.Checked;

            lblBarcode.Refresh();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
            SetData();



            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 825, 1130);

            //Barcode Will Draw In Control
            m_Barcode.DrawingBoard = lblBarcode;
            cboEncodeType.SelectedIndex = 1;
            //  

        }

        private void ShowData()
        {
            //Printing Label
            numLabelWidth.Value = (decimal)151.181102362;
            numLabelHeight.Value = (decimal)113.385826772f;

            //Caption
            txtCaptionText.Text = "Ã„⁄Ì… «·›—œÊ”";
            chkShowCaption.Checked = true;
            m_Barcode.CaptionLineColor.Color = Color.Black;
            chkShowCaptionLine.Checked = true;
            m_Barcode.CaptionAlign = StringAlignment.Center;
            m_Barcode.CaptionForeColor = Color.Black;

            //Header
            txtHeaderText.Text = "Test Header";
            m_Barcode.HeaderFont = new Font("Tahma", 8, FontStyle.Regular);
            m_Barcode.HeaderForeColor = Color.Black;
            m_Barcode.HeaderAlign = StringAlignment.Center;
            chkShowHeader.Checked = true;
            chkShowClintType.Checked = true;

            //Barcode
            txtBarcodeText.Text = "1";
            m_Barcode.BarcodeHeight = 30;
            m_Barcode.BarcodeAlignment = HorizontalAlignment.Center;
            numNarrow.Value = (decimal)1;
            m_Barcode.BarcodeColor = Color.Black;
            m_Barcode.BarcodeStyle = BarcodeStyle.Small;

            //Barcode Text
            m_Barcode.BarcodeTextFont = new Font("Tahoma", 8, FontStyle.Regular);
            m_Barcode.BarcodeTextForeColor = Color.Black;
            chkShowBarcodeText.Checked = true;

            //Footer
            txtFooterText.Text = "Test Footer";
            m_Barcode.FooterFont = new Font("Tahma", 8, FontStyle.Regular);
            m_Barcode.FooterForeColor = Color.Black;
            m_Barcode.FooterAlign = StringAlignment.Center;
            chkFooterLine.Checked = true;

            chkShowFooter.Checked = true;

            lblBarcode.Refresh();
        }

        private void SetData()
        {
            m_Barcode.Width = 151;
            m_Barcode.Height = 113;

            switch (cboEncodeType.SelectedIndex)
            {
                case 0:
                    {
                        m_Barcode.BarCodeType = BarcodeType.Code39;
                        break;
                    }
                case 1:
                    {
                        m_Barcode.BarCodeType = BarcodeType.Code128;
                        break;
                    }
            }

            //Caption
            m_Barcode.CaptionText = txtCaptionText.Text.Trim();
            m_Barcode.CaptionLineColor.Color = Color.Black;
            m_Barcode.CaptionAlign = StringAlignment.Center;
            m_Barcode.CaptionForeColor = Color.Black;
            m_Barcode.ShowCaptionLine = chkShowCaptionLine.Checked;
            m_Barcode.ShowCaption = chkShowCaption.Checked;
            m_Barcode.CaptionFont = new Font("Arial", 11, FontStyle.Bold);

            //Header
            m_Barcode.HeaderText = txtHeaderText.Text.Trim();
            m_Barcode.HeaderFont = new Font("Arial", 11, FontStyle.Bold);
            m_Barcode.HeaderForeColor = Color.Black;
            m_Barcode.HeaderAlign = StringAlignment.Center;
            m_Barcode.ShowHeader = chkShowHeader.Checked;

            //Barcode
            m_Barcode.BarcodeHeight = (float)numBarcodeHeight.Value;
            m_Barcode.BarcodeAlignment = HorizontalAlignment.Center;
            numNarrow.Value = (decimal)1;
            m_Barcode.BarcodeColor = Color.Black;
            m_Barcode.BarcodeStyle = BarcodeStyle.Small;

            //Barcode Text
            m_Barcode.BarcodeTextFont = new Font("Arial", 11, FontStyle.Bold);
            m_Barcode.BarcodeTextForeColor = Color.Black;
            m_Barcode.ShowBarcodeText = chkShowBarcodeText.Checked;


            //Footer
            m_Barcode.FooterText = txtFooterText.Text.Trim();
            m_Barcode.FooterFont = new Font("Arial", 11, FontStyle.Bold);
            m_Barcode.FooterForeColor = Color.Black;
            m_Barcode.FooterAlign = StringAlignment.Center;

            m_Barcode.ShowFooterLine = chkFooterLine.Checked;
            m_Barcode.ShowFooter = chkShowFooter.Checked;
            lblBarcode.Refresh();
        }

        private void numHMargin_ValueChanged(object sender, EventArgs e)
        {
            m_Barcode.HorizontalMargin = (float)numHMargin.Value;
            lblBarcode.Refresh();
        }

        private void numTMargin_ValueChanged(object sender, EventArgs e)
        {
            m_Barcode.TopMargin = (float)numTMargin.Value;
            lblBarcode.Refresh();
        }

        private void numLabelWidth_ValueChanged(object sender, EventArgs e)
        {
            m_Barcode.Width = (float)numLabelWidth.Value;
            lblBarcode.Refresh();
        }

        private void numLabelHeight_ValueChanged(object sender, EventArgs e)
        {
            m_Barcode.Height = (float)numLabelHeight.Value;
            lblBarcode.Refresh();
        }

        #region Print


        DataTable dtMain = new DataTable();
        DataTable dtBarCode = new DataTable();

        int iX = 0;
        int iY = 0;

        int iPrintColCount = 0;
        int iPrintRowCount = 0;
        float iWidth = 151;
        float iHeight = 113;
        int iPageCount = 1;
        int i = 0;

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            iX = int.Parse(txtLeftMargin.Text); ;
            iY = int.Parse(txtTopMargin.Text);
            int X = iX;
            int Y = iY;

            RectangleF rec = new RectangleF();

            for (int iRowLoop = 0; iRowLoop < 9; iRowLoop++)
            {
                for (int iColLoop = 0; iColLoop <= iPrintColCount; iColLoop++)
                {
                    rec = new RectangleF((float)X, (float)Y, iWidth, iHeight);
                    e.Graphics.DrawImage((Image)dtBarCode.Rows[i][iColLoop], rec);

                    X += (int)iWidth;
                }
                i++;
                if (i == dtBarCode.Rows.Count)
                {
                    Y = iY;
                    X = iX;
                    iPageCount = 1;
                    iPrintRowCount = dtBarCode.Rows.Count - 1;
                    i = 0;
                    return;
                }
                X = iX;
                Y += (int)iHeight;
                iPrintRowCount--;
            }
            if (iPrintRowCount > 0)
            {
                e.HasMorePages = true;
                Y = iY;
                iPageCount++;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void FillTables()
        {
            dtMain.Columns.Clear();
            dtMain.Rows.Clear();
            dtBarCode.Columns.Clear();
            dtBarCode.Rows.Clear();


            dtMain.Columns.Add("ID", typeof(int));

            dtBarCode.Columns.Add("Col1", typeof(Image));
            dtBarCode.Columns.Add("Col2", typeof(Image));
            dtBarCode.Columns.Add("Col3", typeof(Image));
            dtBarCode.Columns.Add("Col4", typeof(Image));
            dtBarCode.Columns.Add("Col5", typeof(Image));

            for (int iLoop = 0; iLoop < 400; iLoop++)
            {
                dtMain.Rows.Add((iLoop + 1));
            }


            dtMain.Columns.Add("IDSwap", typeof(string));

            dtMain.Columns["IDSwap"].Expression = "IIF(ID < 10 ,'$' + ID , ID)";

            int iRowCount = dtMain.Rows.Count;
            int iColCount = dtBarCode.Columns.Count;

            DataRow drw = null;

            for (int iRow = 0; iRow < iRowCount; )
            {
                drw = dtBarCode.NewRow();
                for (int iColLoop = 0; iColLoop < iColCount; iColLoop++)
                {
                    m_Barcode.BarcodeText = dtMain.Rows[iRow]["IDSwap"].ToString();
                    drw[iColLoop] = m_Barcode.DrawTest();

                    iRow++;
                    if (iRow > iRowCount)
                    {
                        break;
                    }
                }
                dtBarCode.Rows.Add(drw);
            }
            iPrintColCount = dtBarCode.Columns.Count - 1;
            iPrintRowCount = dtBarCode.Rows.Count;
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            SetData();
            FillTables();

            frmPrintPreview frm = new frmPrintPreview();
            frm.DataSource = dtBarCode;
            frm.LeftMargin = int.Parse(txtLeftMargin.Text);
            frm.TopMargin = int.Parse(txtTopMargin.Text);
            frm.ShowDialog();

            //SetData();
            //FillTables();

            //PrintPreviewDialog pv = new PrintPreviewDialog();
            //pv.Document = pd;


            //pv.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetData();
            FillTables();
            PrintPreviewDialog pvd = new PrintPreviewDialog();
            pvd.Document = pd;
            pvd.ShowDialog();

            //pd.Print();
        }

    }
}