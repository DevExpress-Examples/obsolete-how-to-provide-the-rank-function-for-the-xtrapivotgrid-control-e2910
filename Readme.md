<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061702/10.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2910)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication21/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication21/Form1.vb))
* [Program.cs](./CS/WindowsApplication21/Program.cs) (VB: [Program.vb](./VB/WindowsApplication21/Program.vb))
<!-- default file list end -->
# OBSOLETE - How to provide the Rank function for the XtraPivotGrid control
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2910)**
<!-- run online end -->


<p>Update: Starting from version 11.2 it is possible to accomplish this task by setting the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_SummaryDisplayTypetopic"><u>PivotGridFieldBase.SummaryDisplayType</u></a> property: <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataPivotGridPivotSummaryDisplayTypeEnumtopic"><u>PivotSummaryDisplayType Members</u></a></p><p>In this example, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetCellValuetopic1107"><u>PivotCellBaseEventArgs.GetCellValue</u></a> method is used to get the value of a processed cell and all comparable cells. To address a specific cell, a set of the Column and Row Field values is used.</p>

<br/>


