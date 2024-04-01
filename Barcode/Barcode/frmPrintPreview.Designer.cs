namespace Barcode
{
    partial class frmPrintPreview
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
            this.tsPV = new System.Windows.Forms.ToolStrip();
            this.btnSaveAS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.PrintToPrinter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.txtPageCount = new System.Windows.Forms.ToolStripTextBox();
            this.btnPrevPage = new System.Windows.Forms.ToolStripButton();
            this.btnFistPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.pv = new System.Windows.Forms.PrintPreviewControl();
            this.PDoc = new System.Drawing.Printing.PrintDocument();
            this.printSet = new System.Windows.Forms.PrintDialog();
            this.tsPV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPV
            // 
            this.tsPV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveAS,
            this.toolStripSeparator1,
            this.btnPrint,
            this.PrintToPrinter,
            this.toolStripSeparator2,
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnLastPage,
            this.btnNextPage,
            this.txtPageCount,
            this.btnPrevPage,
            this.btnFistPage,
            this.toolStripSeparator4,
            this.toolStripButton6,
            this.toolStripButton7});
            this.tsPV.Location = new System.Drawing.Point(0, 0);
            this.tsPV.Name = "tsPV";
            this.tsPV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsPV.Size = new System.Drawing.Size(883, 25);
            this.tsPV.TabIndex = 0;
            this.tsPV.Text = "toolStrip1";
            // 
            // btnSaveAS
            // 
            this.btnSaveAS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAS.Image = global::Barcode.Properties.Resources.Export;
            this.btnSaveAS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAS.Name = "btnSaveAS";
            this.btnSaveAS.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAS.ToolTipText = " ’œÌ— ·„·› PDF";
            this.btnSaveAS.Click += new System.EventHandler(this.btnPageSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::Barcode.Properties.Resources.Print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.ToolTipText = "≈⁄œ«œ«  «·ÿ«»⁄…";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PrintToPrinter
            // 
            this.PrintToPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToPrinter.Image = global::Barcode.Properties.Resources.PrintToPrinter;
            this.PrintToPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToPrinter.Name = "PrintToPrinter";
            this.PrintToPrinter.Size = new System.Drawing.Size(23, 22);
            this.PrintToPrinter.ToolTipText = "ÿ»«⁄… ";
            this.PrintToPrinter.Click += new System.EventHandler(this.PrintToPrinter_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::Barcode.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.ToolTipText = " ÕœÌÀ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLastPage
            // 
            this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastPage.Image = global::Barcode.Properties.Resources.LastPage;
            this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(23, 22);
            this.btnLastPage.ToolTipText = "«·’›Õ… «·√ŒÌ—…";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = global::Barcode.Properties.Resources.NextPage;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(23, 22);
            this.btnNextPage.ToolTipText = "«·’›Õ… «· «·Ì…";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // txtPageCount
            // 
            this.txtPageCount.BackColor = System.Drawing.Color.White;
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.ReadOnly = true;
            this.txtPageCount.Size = new System.Drawing.Size(100, 25);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevPage.Image = global::Barcode.Properties.Resources.Previous;
            this.btnPrevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(23, 22);
            this.btnPrevPage.ToolTipText = "«·’›Õ… «·”«»ﬁ…";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnFistPage
            // 
            this.btnFistPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFistPage.Image = global::Barcode.Properties.Resources.FirstPage;
            this.btnFistPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFistPage.Name = "btnFistPage";
            this.btnFistPage.Size = new System.Drawing.Size(23, 22);
            this.btnFistPage.ToolTipText = "«·’›Õ… «·√Ê·Ï";
            this.btnFistPage.Click += new System.EventHandler(this.btnFistPage_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Barcode.Properties.Resources.Zoom;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Barcode.Properties.Resources.ZoomOut;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // pv
            // 
            this.pv.AutoZoom = false;
            this.pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv.Document = this.PDoc;
            this.pv.Location = new System.Drawing.Point(0, 25);
            this.pv.Name = "pv";
            this.pv.Size = new System.Drawing.Size(883, 426);
            this.pv.TabIndex = 1;
            this.pv.Zoom = 1;
            // 
            // PDoc
            // 
            this.PDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PDoc_PrintPage);
            this.PDoc.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PDoc_EndPrint);
            this.PDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PDoc_BeginPrint);
            // 
            // printSet
            // 
            this.printSet.AllowCurrentPage = true;
            this.printSet.AllowSelection = true;
            this.printSet.AllowSomePages = true;
            this.printSet.PrintToFile = true;
            this.printSet.UseEXDialog = true;
            // 
            // frmPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 451);
            this.Controls.Add(this.pv);
            this.Controls.Add(this.tsPV);
            this.Name = "frmPrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrintPreview_Load);
            this.tsPV.ResumeLayout(false);
            this.tsPV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPV;
        private System.Windows.Forms.PrintPreviewControl pv;
        private System.Windows.Forms.PrintDialog printSet;
        private System.Windows.Forms.ToolStripButton btnSaveAS;
        private System.Windows.Forms.ToolStripButton PrintToPrinter;
       
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnLastPage;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton btnPrevPage;
        private System.Windows.Forms.ToolStripButton btnFistPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox txtPageCount;
        private System.Drawing.Printing.PrintDocument PDoc;

    }
}