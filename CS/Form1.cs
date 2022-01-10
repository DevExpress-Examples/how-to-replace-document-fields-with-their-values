using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditFieldsToValues {
    public partial class Form1 : Form {
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

        private void button1_Click(object sender, EventArgs e) {
            FieldsToValues(richEditControl1);
        }

        private void FieldsToValues(RichEditControl control) {
            control.Document.UnlinkAllFields();
        }
    }

    public class Employee {
        string name;
        
        public string Name {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address {
            get {return address;}
            set { address = value;}
        }

        public Employee(string name, string address) {
            this.name = name;
            this.address = address;
        }
    }
}
