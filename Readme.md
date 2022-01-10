<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611006/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3482)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to replace document fields with their values


When the RichEditControl document is merged with data via the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9330"><u>Mail Merge</u></a> mechanism, the resulting (merged) document does not contain any fields. This is very convenient because this document is self-contained and it can be sent to the client without any additional processing. 
Instead of the mail merge operation, you can replace fields with their values using the [Field.Unlink](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Field.Unlink), [FieldCollection.Unlink](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.FieldCollection.Unlink) or [Document.UnlinkAllFields](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.UnlinkAllFields) method. 


<!-- default file list -->
## Files to look at:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->

## Documentation
<a href="https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.FieldCollection#replace-fields-with-field-values"><u>Replace Fields with Field Values</u></a>
