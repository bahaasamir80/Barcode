namespace Barcode
{
    partial class frmPrintPreview2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPreview));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pgDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewControl1 = new CustomPrintPreviewControl();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pDFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnPageSetup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tcboZoom = new System.Windows.Forms.ToolStripComboBox();
            this.tbtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSinglePage = new System.Windows.Forms.ToolStripButton();
            this.tbtnTowPages = new System.Windows.Forms.ToolStripButton();
            this.tbtnMultiPage = new System.Windows.Forms.ToolStripButton();
            this.tbtnFitWidth = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.tbtnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.ttextPageCounter = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnNextPage = new System.Windows.Forms.ToolStripButton();
            this.tbtnLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pgDialog
            // 
            this.pgDialog.EnableMetric = true;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 25);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(872, 423);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.StartPageChanged += new System.EventHandler(this.printPreviewControl1_StartPageChanged);
            this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 22);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.tbtnPrint_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFFileToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripDropDownButton1.Text = "Save As";
            // 
            // pDFFileToolStripMenuItem
            // 
            this.pDFFileToolStripMenuItem.Name = "pDFFileToolStripMenuItem";
            this.pDFFileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pDFFileToolStripMenuItem.Text = "PDF File";
            this.pDFFileToolStripMenuItem.Click += new System.EventHandler(this.pDFFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnPageSetup
            // 
            this.tbtnPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("tbtnPageSetup.Image")));
            this.tbtnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPageSetup.Name = "tbtnPageSetup";
            this.tbtnPageSetup.Size = new System.Drawing.Size(82, 22);
            this.tbtnPageSetup.Text = "Page Setup";
            this.tbtnPageSetup.Click += new System.EventHandler(this.tbtnPageSetup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Zoom";
            // 
            // tcboZoom
            // 
            this.tcboZoom.DropDownWidth = 25;
            this.tcboZoom.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100",
            "125",
            "150",
            "200",
            "250"});
            this.tcboZoom.Name = "tcboZoom";
            this.tcboZoom.Size = new System.Drawing.Size(75, 25);
            this.tcboZoom.Text = "75";
            this.tcboZoom.SelectedIndexChanged += new System.EventHandler(this.tcboZoom_SelectedIndexChanged);
            this.tcboZoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcboZoom_KeyDown);
            // 
            // tbtnZoomIn
            // 
            this.tbtnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tbtnZoomIn.Image")));
            this.tbtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomIn.Name = "tbtnZoomIn";
            this.tbtnZoomIn.Size = new System.Drawing.Size(35, 22);
            this.tbtnZoomIn.Text = "+";
            this.tbtnZoomIn.Click += new System.EventHandler(this.tbtnZoomIn_Click);
            // 
            // tbtnZoomOut
            // 
            this.tbtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tbtnZoomOut.Image")));
            this.tbtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomOut.Name = "tbtnZoomOut";
            this.tbtnZoomOut.Size = new System.Drawing.Size(31, 22);
            this.tbtnZoomOut.Text = "-";
            this.tbtnZoomOut.Click += new System.EventHandler(this.tbtnZoomOut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSinglePage
            // 
            this.tbtnSinglePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSinglePage.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSinglePage.Image")));
            this.tbtnSinglePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSinglePage.Name = "tbtnSinglePage";
            this.tbtnSinglePage.Size = new System.Drawing.Size(23, 22);
            this.tbtnSinglePage.Text = "toolStripButton1";
            this.tbtnSinglePage.Click += new System.EventHandler(this.tbtnSinglePage_Click);
            // 
            // tbtnTowPages
            // 
            this.tbtnTowPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnTowPages.Enabled = false;
            this.tbtnTowPages.Image = ((System.Drawing.Image)(resources.GetObject("tbtnTowPages.Image")));
            this.tbtnTowPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnTowPages.Name = "tbtnTowPages";
            this.tbtnTowPages.Size = new System.Drawing.Size(23, 22);
            this.tbtnTowPages.Text = "toolStripButton2";
            this.tbtnTowPages.Click += new System.EventHandler(this.tbtnTowPages_Click);
            // 
            // tbtnMultiPage
            // 
            this.tbtnMultiPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMultiPage.Enabled = false;
            this.tbtnMultiPage.Image = ((System.Drawing.Image)(resources.GetObject("tbtnMultiPage.Image")));
            this.tbtnMultiPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMultiPage.Name = "tbtnMultiPage";
            this.tbtnMultiPage.Size = new System.Drawing.Size(23, 22);
            this.tbtnMultiPage.Text = "toolStripButton3";
            this.tbtnMultiPage.Click += new System.EventHandler(this.tbtnMultiPage_Click);
            // 
            // tbtnFitWidth
            // 
            this.tbtnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnFitWidth.Image = ((System.Drawing.Image)(resources.GetObject("tbtnFitWidth.Image")));
            this.tbtnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnFitWidth.Name = "tbtnFitWidth";
            this.tbtnFitWidth.Size = new System.Drawing.Size(23, 22);
            this.tbtnFitWidth.Text = "Fit Width";
            this.tbtnFitWidth.Click += new System.EventHandler(this.tbtnFitWidth_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnFirstPage
            // 
            this.tbtnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnFirstPage.Enabled = false;
            this.tbtnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("tbtnFirstPage.Image")));
            this.tbtnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnFirstPage.Name = "tbtnFirstPage";
            this.tbtnFirstPage.Size = new System.Drawing.Size(23, 22);
            this.tbtnFirstPage.Text = "First Page";
            this.tbtnFirstPage.Click += new System.EventHandler(this.NavigationButtons_Click);
            // 
            // tbtnPreviousPage
            // 
            this.tbtnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPreviousPage.Enabled = false;
            this.tbtnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("tbtnPreviousPage.Image")));
            this.tbtnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPreviousPage.Name = "tbtnPreviousPage";
            this.tbtnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbtnPreviousPage.Size = new System.Drawing.Size(23, 22);
            this.tbtnPreviousPage.Text = "Previous Page";
            this.tbtnPreviousPage.Click += new System.EventHandler(this.NavigationButtons_Click);
            // 
            // ttextPageCounter
            // 
            this.ttextPageCounter.Name = "ttextPageCounter";
            this.ttextPageCounter.Size = new System.Drawing.Size(50, 25);
            this.ttextPageCounter.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttextPageCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttextPageCounter_KeyDown);
            this.ttextPageCounter.Validating += new System.ComponentModel.CancelEventHandler(this.ttextPageCounter_Validating);
            this.ttextPageCounter.Click += new System.EventHandler(this.ttextPageCounter_Click);
            // 
            // tbtnNextPage
            // 
            this.tbtnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnNextPage.Enabled = false;
            this.tbtnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("tbtnNextPage.Image")));
            this.tbtnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNextPage.Name = "tbtnNextPage";
            this.tbtnNextPage.Size = new System.Drawing.Size(23, 22);
            this.tbtnNextPage.Text = "Next Page";
            this.tbtnNextPage.Click += new System.EventHandler(this.NavigationButtons_Click);
            // 
            // tbtnLastPage
            // 
            this.tbtnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnLastPage.Enabled = false;
            this.tbtnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("tbtnLastPage.Image")));
            this.tbtnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLastPage.Name = "tbtnLastPage";
            this.tbtnLastPage.Size = new System.Drawing.Size(23, 22);
            this.tbtnLastPage.Text = "Last Page";
            this.tbtnLastPage.Click += new System.EventHandler(this.NavigationButtons_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.tbtnPageSetup,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tcboZoom,
            this.tbtnZoomIn,
            this.tbtnZoomOut,
            this.toolStripSeparator3,
            this.tbtnSinglePage,
            this.tbtnTowPages,
            this.tbtnMultiPage,
            this.tbtnFitWidth,
            this.toolStripSeparator4,
            this.tbtnFirstPage,
            this.tbtnPreviousPage,
            this.ttextPageCounter,
            this.tbtnNextPage,
            this.tbtnLastPage,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 448);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmPrintPreview";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmPrintPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrintPreview_Load);
            
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrintPreview_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPrintPreview_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pgDialog;
        private CustomPrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pDFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnPageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tcboZoom;
        private System.Windows.Forms.ToolStripButton tbtnZoomIn;
        private System.Windows.Forms.ToolStripButton tbtnZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnSinglePage;
        private System.Windows.Forms.ToolStripButton tbtnTowPages;
        private System.Windows.Forms.ToolStripButton tbtnMultiPage;
        private System.Windows.Forms.ToolStripButton tbtnFitWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtnFirstPage;
        private System.Windows.Forms.ToolStripButton tbtnPreviousPage;
        private System.Windows.Forms.ToolStripTextBox ttextPageCounter;
        private System.Windows.Forms.ToolStripButton tbtnNextPage;
        private System.Windows.Forms.ToolStripButton tbtnLastPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}