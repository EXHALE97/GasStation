using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Queries.Support.MessageBox;

namespace Queries.Support.Export
{
    public static class DataExport
    {
        public static void PrintTable(DataGridView dataGridView, PrintPageEventArgs eventArgs)
        {
            var graphics = eventArgs.Graphics;
            var x = 0;
            var y = 20;
            var cellHeight = 0;

            var columnCount = dataGridView.ColumnCount;
            var rowCount = dataGridView.RowCount - 1;
            var currentColumn = 0;
            var currentRow = 0;
            string value;

            var width = dataGridView[currentColumn, currentRow].Size.Width;
            var height = dataGridView[currentColumn, currentRow].Size.Height;

            Rectangle cellBorder;
            var brush = new SolidBrush(Color.Black);


            while (currentColumn < columnCount)
            {
                x += dataGridView[currentColumn, currentRow].Size.Width;
                cellHeight = dataGridView[currentColumn, currentRow].Size.Height;
                cellBorder = new Rectangle(x, y, width, height);
                value = dataGridView.Columns[currentColumn].HeaderText.ToString();
                graphics.DrawRectangle(new Pen(Color.Black), cellBorder);
                graphics.DrawString(value, new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point), brush, x, y);
                currentColumn++;
            }
            while (currentRow < rowCount)
            {
                while (currentColumn < columnCount)
                {
                    x += dataGridView[currentColumn, currentRow].Size.Width;
                    cellHeight = dataGridView[currentColumn, currentRow].Size.Height;
                    cellBorder = new Rectangle(x, y, width, height);
                    value = dataGridView[currentColumn, currentRow].Value.ToString();
                    graphics.DrawRectangle(new Pen(Color.Black), cellBorder);
                    graphics.DrawString(value, new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point), brush, x, y);
                    currentColumn++;
                }
                currentColumn = 0;
                currentRow++;
                x = 0;
                y += cellHeight;
            }
        }

        public static void ExportInCsv(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                var saveFileDialog = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", DefaultExt = "csv", FileName = "Output.csv" };
                var fileError = false;
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                if (File.Exists(saveFileDialog.FileName))
                {
                    try
                    {
                        File.Delete(saveFileDialog.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;

                        ErrorMessageBox.ShowCustomErrorMessage("Невозможно экспортировать данные! " + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        var columnCount = dataGridView.Columns.Count;
                        var columnNames = "";
                        var outputCsv = new string[dataGridView.Rows.Count + 1];

                        for (var i = 0; i < columnCount; i++)
                        {
                            if (columnCount - i == 1)
                            {
                                columnNames += dataGridView.Columns[i].HeaderText;
                            }
                            else
                            {
                                columnNames += dataGridView.Columns[i].HeaderText + ",";
                            }
                            
                        }
                        outputCsv[0] += columnNames;

                        for (var i = 1; (i - 1) < dataGridView.Rows.Count; i++)
                        {
                            for (var j = 0; j < columnCount; j++)
                            {
                                if (columnCount - j == 1)
                                {
                                    outputCsv[i] += dataGridView.Rows[i - 1].Cells[j].Value;
                                }
                                else
                                {
                                    outputCsv[i] += dataGridView.Rows[i - 1].Cells[j].Value + ",";
                                }
                                
                            }
                        }

                        File.WriteAllLines(saveFileDialog.FileName, outputCsv, Encoding.UTF8);
                        SuccessMessageBox.ShowSuccessBox();
                    }
                    catch (Exception ex)
                    {
                        ErrorMessageBox.ShowCustomErrorMessage("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                ErrorMessageBox.ShowCustomErrorMessage("Нет записей для экспорта!");
            }
        }
    }
}