﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fastfood
{
    public partial class Transactions : UserControl
    {
        Information info = new Information();
        DataGridViewCell? pCell = null;
        public Transactions()
        {
            InitializeComponent();
            dtStart.Value = DateTime.Now.AddMonths(-1);
            dtEnd.Value = DateTime.Now;
            info.TransactionTable(this);
        }

        private void controlRecords_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                info.ViewReceipt(this, e);
                return;
            }
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Are you sure you want to delete this transaction?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    info.DeleteTransaction(this, e);
                    info.TransactionTable(this);
                }
                return;
            }
        }

        private void dataGridView1_RowHeightInfoNeeded(object sender, DataGridViewRowHeightInfoNeededEventArgs e)
        {

        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            FilterByDate();
            dtEnd.MinDate = dtStart.Value;
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            FilterByDate();
        }

        private void FilterByDate()
        {
            DateTime startDate = dtStart.Value.Date;
            DateTime endDate = dtEnd.Value.Date.AddDays(1).AddSeconds(-1);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime DDay = Convert.ToDateTime(row.Cells["Date"].Value);
                if (DDay >= startDate && DDay <= endDate)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void pbHeader_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells["Products"];

                if (cell.Value != null && cell.Value.ToString()!.ToLower().Contains(textBox1.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["Products"];
                if (cell.Tag != null && (bool)cell.Tag)
                {
                    cell.Tag = false;
                    cell.Style.WrapMode = DataGridViewTriState.False;
                    dataGridView1.Rows[e.RowIndex].Height = cell.Size.Height;
                    pCell = null;
                }
                else
                {
                    if (pCell != null)
                    {
                        pCell.Tag = false;
                        pCell.Style.WrapMode = DataGridViewTriState.False;
                        dataGridView1.Rows[pCell.RowIndex].Height = pCell.Size.Height;
                    }
                    cell.Tag = true;
                    cell.Style.WrapMode = DataGridViewTriState.True;
                    dataGridView1.AutoResizeRow(e.RowIndex, DataGridViewAutoSizeRowMode.AllCells);
                    pCell = cell;
                }
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value.ToString()!.Length > 25)
                {
                    dataGridView1.ShowCellToolTips = true;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Click to show all products.";
                }
                else
                {
                    dataGridView1.ShowCellToolTips = false;
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                dataGridView1.ShowCellToolTips = false;
            }
        }
    }
}
