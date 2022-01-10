<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611006/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3482)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to replace document fields with their values


<p>When the RichEditControl document is merged with data via the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9330"><u>Mail Merge</u></a> mechanism, the resulting (merged) document does not contain any fields. This is very convenient because this document is self-contained and it can be sent to the client without any additional processing. But what will you do if you do not want to perform Mail Merge and your task is only to transform a Mail Merge template to a self-contained document in the same RichEditControl instance by using current data? Take a look at the <strong>FieldsToValues</strong> method for this example. It illustrates how to accomplish your task.</p>

<br/>


