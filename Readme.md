<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611006/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3482)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to replace document fields with their values


When the RichEditControl document is merged with data via the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9330"><u>Mail Merge</u></a> mechanism, the resulting (merged) document does not contain any fields. This is very convenient because this document is self-contained and it can be sent to the client without any additional processing. 


> **Starting from v21.2**, you can use the [Field.Unlink](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Field.Unlink), [FieldCollection.Unlink](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.FieldCollection.Unlink) or [Document.UnlinkAllFields](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.UnlinkAllFields) method to replace fields with their values instead of the mail merge operation.


<!-- default file list -->
## Files to look at:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->

## Documentation
<a href="https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.FieldCollection#replace-fields-with-field-values"><u>Replace Fields with Field Values</u></a>
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-replace-document-fields-with-their-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-replace-document-fields-with-their-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
