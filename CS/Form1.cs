using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace RichEditFieldsToValues {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();

            richEditControl1.LoadDocument("Template.rtf");

            richEditControl1.Options.Fields.HighlightMode = FieldsHighlightMode.Always;
            richEditControl1.Options.Fields.HighlightColor = Color.Yellow;

            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Peter Parker", "Spiderman road 123"));
            
            richEditControl1.Options.MailMerge.DataSource = list;
            richEditControl1.Options.MailMerge.ViewMergedData = true;
        }

        private void richEditControl1_CalculateDocumentVariable(object sender, DevExpress.XtraRichEdit.CalculateDocumentVariableEventArgs e) {
            if (e.VariableName == "dvField") {
                e.Value = "Test";
                e.Handled = true;
            }
        }
        private void FieldsToValues(RichEditControl control) {
            control.Document.UnlinkAllFields();
        }

        private void btnReplaceFields_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FieldsToValues(richEditControl1);
        }
    }   
}
