Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication21
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			FillDataSource(New DateTime(2010, 1, 1), New DateTime(2012, 12, 31))

		End Sub

		Private Sub FillDataSource(ByVal beginDate As DateTime, ByVal endDate As DateTime)
			Dim dt As DataTable = dataSet1.Tables("Data")
			Dim r As New Random()
			Dim i As Integer = 0
			Dim d As DateTime = beginDate
			Do While d <= endDate
				dt.Rows.Add(New Object() { "Name " & i Mod 5, "Type " & i Mod 3, d, r.Next(10) })
				i += 1
				d = d.AddDays(5)
			Loop
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pivotGridControl1.BestFit()
		End Sub

		Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs) Handles pivotGridControl1.CustomCellValue
			Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)
			If ReferenceEquals(e.DataField, fieldRank) Then
				If e.RowField IsNot Nothing Then

					Dim rowValues() As Object = GetRowFieldValues(e)
					Dim columnValues() As Object = GetColumnFieldValues(e)
					Dim currentValue As Decimal = Convert.ToDecimal(e.GetCellValue(columnValues, rowValues, e.DataField))
					Dim visibleValues As List(Of Object) = e.RowField.GetVisibleValues()
					Dim rank As Integer = 1
					For Each val As Object In visibleValues
						rowValues(rowValues.Length - 1) = val
						Dim comparableValue As Object = e.GetCellValue(columnValues, rowValues, e.DataField)
						If comparableValue IsNot Nothing AndAlso Convert.ToDecimal(comparableValue) > currentValue Then
							rank += 1
						End If
					Next val
					e.Value = rank
				Else
					e.Value = Nothing
				End If
			End If

		End Sub

		Private Function GetColumnFieldValues(ByVal e As PivotCellValueEventArgs) As Object()
			Dim columnValues As New List(Of Object)()
			For Each field As PivotGridField In e.GetColumnFields()
				columnValues.Add(e.GetFieldValue(field))
			Next field
			Return columnValues.ToArray()
		End Function

		Private Function GetRowFieldValues(ByVal e As PivotCellValueEventArgs) As Object()
			Dim rowValues As New List(Of Object)()
			For Each field As PivotGridField In e.GetRowFields()
				rowValues.Add(e.GetFieldValue(field))
			Next field
			Return rowValues.ToArray()
		End Function


	End Class
End Namespace