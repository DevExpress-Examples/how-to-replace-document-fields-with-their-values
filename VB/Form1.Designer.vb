Namespace RichEditFieldsToValues

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.InsertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.ShowAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.ShowAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.ToggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.btnReplaceFields = New DevExpress.XtraBars.BarButtonItem()
            Me.MailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.MailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.RichEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richEditControl1
            '
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 193)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.richEditControl1.MenuManager = Me.RibbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(795, 467)
            Me.richEditControl1.TabIndex = 0
            '
            'RibbonControl1
            '
            Me.RibbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(26, 30, 26, 30)
            Me.RibbonControl1.ExpandCollapseItem.Id = 0
            Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.InsertMergeFieldItem1, Me.ShowAllFieldCodesItem1, Me.ShowAllFieldResultsItem1, Me.ToggleViewMergedDataItem1, Me.btnReplaceFields})
            Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl1.MaxItemId = 6
            Me.RibbonControl1.Name = "RibbonControl1"
            Me.RibbonControl1.OptionsMenuMinWidth = 289
            Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.MailingsRibbonPage1})
            Me.RibbonControl1.Size = New System.Drawing.Size(795, 193)
            '
            'InsertMergeFieldItem1
            '
            Me.InsertMergeFieldItem1.Id = 1
            Me.InsertMergeFieldItem1.Name = "InsertMergeFieldItem1"
            '
            'ShowAllFieldCodesItem1
            '
            Me.ShowAllFieldCodesItem1.Id = 2
            Me.ShowAllFieldCodesItem1.Name = "ShowAllFieldCodesItem1"
            '
            'ShowAllFieldResultsItem1
            '
            Me.ShowAllFieldResultsItem1.Id = 3
            Me.ShowAllFieldResultsItem1.Name = "ShowAllFieldResultsItem1"
            '
            'ToggleViewMergedDataItem1
            '
            Me.ToggleViewMergedDataItem1.Id = 4
            Me.ToggleViewMergedDataItem1.Name = "ToggleViewMergedDataItem1"
            '
            'btnReplaceFields
            '
            Me.btnReplaceFields.Caption = "Replace Fields with Values"
            Me.btnReplaceFields.Id = 5
            Me.btnReplaceFields.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.btnReplaceFields.Name = "btnReplaceFields"
            '
            'MailingsRibbonPage1
            '
            Me.MailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.MailMergeRibbonPageGroup1, Me.RibbonPageGroup1})
            Me.MailingsRibbonPage1.Name = "MailingsRibbonPage1"
            '
            'MailMergeRibbonPageGroup1
            '
            Me.MailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.InsertMergeFieldItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldCodesItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldResultsItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ToggleViewMergedDataItem1, "P")
            Me.MailMergeRibbonPageGroup1.Name = "MailMergeRibbonPageGroup1"
            '
            'RibbonPageGroup1
            '
            Me.RibbonPageGroup1.ItemLinks.Add(Me.btnReplaceFields)
            Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
            Me.RibbonPageGroup1.Text = "Replace"
            '
            'RichEditBarController1
            '
            Me.RichEditBarController1.BarItems.Add(Me.InsertMergeFieldItem1)
            Me.RichEditBarController1.BarItems.Add(Me.ShowAllFieldCodesItem1)
            Me.RichEditBarController1.BarItems.Add(Me.ShowAllFieldResultsItem1)
            Me.RichEditBarController1.BarItems.Add(Me.ToggleViewMergedDataItem1)
            Me.RichEditBarController1.Control = Me.richEditControl1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(795, 660)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.RibbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Form1"
            Me.Ribbon = Me.RibbonControl1
            Me.Text = "Form1"
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RichEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Friend WithEvents InsertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Friend WithEvents ShowAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Friend WithEvents ShowAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Friend WithEvents ToggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Friend WithEvents btnReplaceFields As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents MailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Friend WithEvents MailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
        Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents RichEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    End Class
End Namespace
