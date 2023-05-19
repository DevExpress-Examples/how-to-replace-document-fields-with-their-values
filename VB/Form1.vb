Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars.Ribbon

Namespace RichEditFieldsToValues

    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("Template.rtf")
            richEditControl1.Options.Fields.HighlightMode = FieldsHighlightMode.Always
            richEditControl1.Options.Fields.HighlightColor = Color.Yellow
            Dim list As List(Of Employee) = New List(Of Employee)()
            list.Add(New Employee("Peter Parker", "Spiderman road 123"))
            richEditControl1.Options.MailMerge.DataSource = list
            richEditControl1.Options.MailMerge.ViewMergedData = True
        End Sub

        Private Sub richEditControl1_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            If Equals(e.VariableName, "dvField") Then
                e.Value = "Test"
                e.Handled = True
            End If
        End Sub

        Private Sub FieldsToValues(ByVal control As RichEditControl)
            control.Document.UnlinkAllFields()
        End Sub

        Private Sub btnReplaceFields_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReplaceFields.ItemClick
            FieldsToValues(richEditControl1)
        End Sub
    End Class
End Namespace
