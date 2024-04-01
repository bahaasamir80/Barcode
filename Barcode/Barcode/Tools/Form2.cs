using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Barcode
{
    public partial class Form2 : Form
    {
        private Barcode m_Barcode = new Barcode();

        DataTable dtMain = new DataTable();
        DataTable dtBarCode = new DataTable();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 825, 1130);

            FillGrid();

            iPrintColCount = dtBarCode.Columns.Count - 1;
            iPrintRowCount = dtBarCode.Rows.Count;
        }

        private void FillGrid()
        {
            dtMain.Columns.Add("ID", typeof(int));

            dtBarCode.Columns.Add("Col1", typeof(Image));
            dtBarCode.Columns.Add("Col2", typeof(Image));
            dtBarCode.Columns.Add("Col3", typeof(Image));
            dtBarCode.Columns.Add("Col4", typeof(Image));
            dtBarCode.Columns.Add("Col5", typeof(Image));

            for (int iLoop = 0; iLoop < 300; iLoop++)
            {
                dtMain.Rows.Add((iLoop + 1));
            }


            int iRowCount = dtMain.Rows.Count;
            int iColCount = dtBarCode.Columns.Count;

            ShowData();

            DataRow drw = null;

            for (int iRow = 0; iRow < iRowCount; )
            {
                drw = dtBarCode.NewRow();
                for (int iColLoop = 0; iColLoop < iColCount; iColLoop++)
                {
                    m_Barcode.BarcodeText = dtMain.Rows[iRow][0].ToString();
                    drw[iColLoop] = m_Barcode.DrawTest();

                    iRow++;
                    if (iRow > iRowCount)
                    {
                        break;
                    }
                }
                dtBarCode.Rows.Add(drw);
            }


            //dataGridView1.DataSource = dtBarCode;

            //dataGridView1.Columns[0].Width = 151;
            //dataGridView1.Columns[1].Width = 151;
            //dataGridView1.Columns[2].Width = 151;
            //dataGridView1.Columns[3].Width = 151;
            //dataGridView1.Columns[4].Width = 151;
        }

        private void ShowData()
        {
            m_Barcode.Width = 151;
            m_Barcode.Height = 113;

            m_Barcode.HorizontalMargin = 0;
            m_Barcode.TopMargin = 0;
            //Caption
            m_Barcode.CaptionText = "Ã„⁄Ì… «·›—œÊ”";
            m_Barcode.ShowCaption = true;
            m_Barcode.CaptionLineColor.Color = Color.Black;
            m_Barcode.ShowCaptionLine = true;
            m_Barcode.CaptionAlign = StringAlignment.Center;
            m_Barcode.CaptionForeColor = Color.Black;

            //Header
            m_Barcode.HeaderText = "Test Header";
            m_Barcode.HeaderFont = new Font("Tahma", 8, FontStyle.Regular);
            m_Barcode.HeaderForeColor = Color.Black;
            m_Barcode.HeaderAlign = StringAlignment.Center;
            m_Barcode.ShowHeader = true;

            //Barcode
            m_Barcode.BarcodeHeight = 30;
            m_Barcode.BarcodeAlignment = HorizontalAlignment.Center;
            m_Barcode.BarcodeNarrow = 1;
            m_Barcode.BarcodeColor = Color.Black;
            m_Barcode.BarcodeStyle = BarcodeStyle.Small;
            m_Barcode.BarCodeType = BarcodeType.Code39;
            //Barcode Text
            m_Barcode.BarcodeTextFont = new Font("Tahoma", 8, FontStyle.Regular);
            m_Barcode.BarcodeTextForeColor = Color.Black;
            m_Barcode.ShowBarcodeText = true;

            //Footer
            m_Barcode.FooterText = "Test Footer";
            m_Barcode.FooterFont = new Font("Tahma", 8, FontStyle.Regular);
            m_Barcode.FooterForeColor = Color.Black;
            m_Barcode.FooterAlign = StringAlignment.Center;
            m_Barcode.ShowFooterLine = true;
            m_Barcode.ShowFooter = true;


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pv = new PrintPreviewDialog();

            pv.Document = pd;
            pv.ShowDialog();
        }

        int X = 0;
        int Y = 0;
        int iPrintColCount = 0;
        int iPrintRowCount = 0;
        int iWidth = 151;
        int iHeight = 113;
        int iPageCount = 1;
        int i = 0;

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle rec = new Rectangle();

            for (int iRowLoop = 0; iRowLoop < 9; iRowLoop++)
            {

                for (int iColLoop = 0; iColLoop <= iPrintColCount; iColLoop++)
                {
                    rec = new Rectangle(X, Y, iWidth, iHeight);
                    e.Graphics.DrawImage((Image)dtBarCode.Rows[i][iColLoop], rec);

                    X += iWidth;
                }
                i++;
                if (i == dtBarCode.Rows.Count)
                {
                    Y = 0;
                    X = 0;
                    iPageCount = 1;
                    iPrintRowCount = dtBarCode.Rows.Count - 1;
                    i = 0;
                    return;
                }
                X = 0;
                Y += iHeight;
                iPrintRowCount--;
            }
            if (iPrintRowCount > 0)
            {
                e.HasMorePages = true;
                Y = 0;
                iPageCount++;
            }
            else
            {
                e.HasMorePages = false;

            }
        }
    }
}