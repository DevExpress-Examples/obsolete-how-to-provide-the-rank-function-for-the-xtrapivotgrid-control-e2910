# OBSOLETE - How to provide the Rank function for the XtraPivotGrid control


<p>Update: Starting from version 11.2 it is possible to accomplish this task by setting the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_SummaryDisplayTypetopic"><u>PivotGridFieldBase.SummaryDisplayType</u></a> property: <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataPivotGridPivotSummaryDisplayTypeEnumtopic"><u>PivotSummaryDisplayType Members</u></a></p><p>In this example, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetCellValuetopic1107"><u>PivotCellBaseEventArgs.GetCellValue</u></a> method is used to get the value of a processed cell and all comparable cells. To address a specific cell, a set of the Column and Row Field values is used.</p>

<br/>

