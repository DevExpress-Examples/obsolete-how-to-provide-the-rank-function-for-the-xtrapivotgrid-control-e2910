using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillDataSource(new DateTime(2010, 1, 1), new DateTime(2012, 12, 31));

        }

        private void FillDataSource(DateTime beginDate, DateTime endDate)
        {
            DataTable dt = dataSet1.Tables["Data"];
            Random r = new Random();
            int i = 0;
            for (DateTime d = beginDate; d <= endDate; d = d.AddDays(5))
            {
                dt.Rows.Add(new object[] { "Name " + i % 5, "Type " + i % 3, d, r.Next(10) });
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivotGridControl1.BestFit();
        }

        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
            PivotGridControl pivot = sender as PivotGridControl;
            if (ReferenceEquals(e.DataField, fieldRank))
                if (e.RowField != null)
                {

                    object[] rowValues = GetRowFieldValues(e);
                    object[] columnValues = GetColumnFieldValues(e);
                    decimal currentValue = Convert.ToDecimal(e.GetCellValue(columnValues, rowValues, e.DataField));
                    List<object> visibleValues = e.RowField.GetVisibleValues();
                    int rank = 1;
                    foreach (object val in visibleValues)
                    {
                        rowValues[rowValues.Length - 1] = val;
                        object comparableValue = e.GetCellValue(columnValues, rowValues, e.DataField);
                        if (comparableValue != null && Convert.ToDecimal(comparableValue) > currentValue)
                            rank++;
                    }
                    e.Value = rank;
                }
                else
                    e.Value = null;

        }

        private object[] GetColumnFieldValues(PivotCellValueEventArgs e)
        {
            List<object> columnValues = new List<object>();
            foreach (PivotGridField field in e.GetColumnFields())
                columnValues.Add(e.GetFieldValue(field));
            return columnValues.ToArray();
        }

        private object[] GetRowFieldValues(PivotCellValueEventArgs e)
        {
            List<object> rowValues = new List<object>();
            foreach (PivotGridField field in e.GetRowFields())
                rowValues.Add(e.GetFieldValue(field));
            return rowValues.ToArray();
        }


    }
}