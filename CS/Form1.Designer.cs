namespace RichEditFieldsToValues {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.insertMergeFieldItem1 = new DevExpress.XtraRichEdit.UI.InsertMergeFieldItem();
            this.showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleViewMergedDataItem1 = new DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem();
            this.mailingsRibbonPage1 = new DevExpress.XtraRichEdit.UI.MailingsRibbonPage();
            this.mailMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnReplaceFields = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 193);
            this.richEditControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richEditControl1.MenuManager = this.ribbonControl1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(795, 467);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.CalculateDocumentVariable += new DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(this.richEditControl1_CalculateDocumentVariable);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.insertMergeFieldItem1,
            this.showAllFieldCodesItem1,
            this.showAllFieldResultsItem1,
            this.toggleViewMergedDataItem1,
            this.btnReplaceFields});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mailingsRibbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(795, 193);
            // 
            // insertMergeFieldItem1
            // 
            this.insertMergeFieldItem1.Id = 1;
            this.insertMergeFieldItem1.Name = "insertMergeFieldItem1";
            // 
            // showAllFieldCodesItem1
            // 
            this.showAllFieldCodesItem1.Id = 2;
            this.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            this.showAllFieldResultsItem1.Id = 3;
            this.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleViewMergedDataItem1
            // 
            this.toggleViewMergedDataItem1.Id = 4;
            this.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1";
            // 
            // mailingsRibbonPage1
            // 
            this.mailingsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeRibbonPageGroup1,
            this.ribbonPageGroup1});
            this.mailingsRibbonPage1.Name = "mailingsRibbonPage1";
            // 
            // mailMergeRibbonPageGroup1
            // 
            this.mailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.insertMergeFieldItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldCodesItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldResultsItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.toggleViewMergedDataItem1, "P");
            this.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.insertMergeFieldItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldCodesItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldResultsItem1);
            this.richEditBarController1.BarItems.Add(this.toggleViewMergedDataItem1);
            this.richEditBarController1.Control = this.richEditControl1;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReplaceFields);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Replace";
            // 
            // btnReplaceFields
            // 
            this.btnReplaceFields.Caption = "Replace Fields with Values";
            this.btnReplaceFields.Id = 5;
            this.btnReplaceFields.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnReplaceFields.Name = "btnReplaceFields";
            this.btnReplaceFields.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReplaceFields_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 660);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraRichEdit.UI.InsertMergeFieldItem insertMergeFieldItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem toggleViewMergedDataItem1;
        private DevExpress.XtraRichEdit.UI.MailingsRibbonPage mailingsRibbonPage1;
        private DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup mailMergeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.BarButtonItem btnReplaceFields;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

