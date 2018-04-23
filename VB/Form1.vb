Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditFieldsToValues
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditControl1.LoadDocument("Template.rtf")

			richEditControl1.Options.Fields.HighlightMode = FieldsHighlightMode.Always
			richEditControl1.Options.Fields.HighlightColor = Color.Yellow

			Dim list As New List(Of Employee)()
			list.Add(New Employee("Peter Parker", "Spiderman road 123"))

			richEditControl1.Options.MailMerge.DataSource = list
			richEditControl1.Options.MailMerge.ViewMergedData = True
		End Sub

		Private Sub richEditControl1_CalculateDocumentVariable(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.CalculateDocumentVariableEventArgs) Handles richEditControl1.CalculateDocumentVariable
			If e.VariableName = "dvField" Then
				e.Value = "Test"
				e.Handled = True
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			FieldsToValues(richEditControl1)
		End Sub

		Private Sub FieldsToValues(ByVal control As RichEditControl)
			control.BeginUpdate()
			Try
				Dim document As Document = control.Document
				document.BeginUpdate()
				Try
					Dim fields As FieldCollection = document.Fields
					Dim count As Integer = fields.Count
					For i As Integer = count - 1 To 0 Step -1
						Dim field As Field = fields(i)
						field.ShowCodes = True
						Dim fieldCode As String = document.GetText(field.CodeRange)
						Dim fieldResult As String = document.GetRtfText(field.ResultRange)
						Dim fieldPosition As DocumentPosition = field.Range.Start
						document.Delete(field.Range)
						document.InsertRtfText(fieldPosition, fieldResult)
					Next i
				Finally
					document.EndUpdate()
				End Try
			Finally
				control.EndUpdate()
			End Try
		End Sub
	End Class

	Public Class Employee
		Private name_Renamed As String

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Private address_Renamed As String

		Public Property Address() As String
			Get
				Return address_Renamed
			End Get
			Set(ByVal value As String)
				address_Renamed = value
			End Set
		End Property

		Public Sub New(ByVal name As String, ByVal address As String)
			Me.name_Renamed = name
			Me.address_Renamed = address
		End Sub
	End Class
End Namespace