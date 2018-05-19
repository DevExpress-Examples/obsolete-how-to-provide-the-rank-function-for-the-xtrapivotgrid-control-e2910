Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication21
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
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
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.fieldName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldType1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldRank = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable1.TableName = "Data"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Type"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Date"
			Me.dataColumn3.DataType = GetType(System.DateTime)
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "Value"
			Me.dataColumn4.DataType = GetType(Decimal)
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.dataBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldName1, Me.fieldType1, Me.fieldYear, Me.fieldValue, Me.fieldQuarter, Me.fieldRank})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(577, 299)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomCellValue += New System.EventHandler(Of DevExpress.XtraPivotGrid.PivotCellValueEventArgs)(Me.pivotGridControl1_CustomCellValue);
			' 
			' dataBindingSource
			' 
			Me.dataBindingSource.DataMember = "Data"
			Me.dataBindingSource.DataSource = Me.dataSet1
			' 
			' fieldName1
			' 
			Me.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldName1.AreaIndex = 1
			Me.fieldName1.Caption = "Name"
			Me.fieldName1.FieldName = "Name"
			Me.fieldName1.Name = "fieldName1"
			' 
			' fieldType1
			' 
			Me.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldType1.AreaIndex = 0
			Me.fieldType1.Caption = "Type"
			Me.fieldType1.FieldName = "Type"
			Me.fieldType1.Name = "fieldType1"
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "Date"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldDate1"
			' 
			' fieldValue
			' 
			Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldValue.AreaIndex = 0
			Me.fieldValue.Caption = "Value"
			Me.fieldValue.CellFormat.FormatString = "N0"
			Me.fieldValue.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldValue.FieldName = "Value"
			Me.fieldValue.Name = "fieldValue"
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			Me.fieldQuarter.FieldName = "Date"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			' 
			' fieldRank
			' 
			Me.fieldRank.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldRank.AreaIndex = 1
			Me.fieldRank.Caption = "Rank"
			Me.fieldRank.CellFormat.FormatString = "N0"
			Me.fieldRank.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldRank.FieldName = "Value"
			Me.fieldRank.Name = "fieldRank"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(577, 299)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataBindingSource As System.Windows.Forms.BindingSource
		Private fieldName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldType1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldRank As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

