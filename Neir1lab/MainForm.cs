using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Neir1lab
{
    public partial class MainForm : Form
    {
        private double[][] valuesA; 
        private double[][] valuesB; 

        public MainForm()
        {
            InitializeComponent();
            SetDefaultValue();
        }

        private void btnDrawA_Click(object sender, EventArgs e)
        {
            ClearChart();

            if (IsPreparedTableValue(dataA))
            {
                DrawGraph(dataA, 0);
            }
        }

        private void btnDrawB_Click(object sender, EventArgs e)
        {
            ClearChart();

            if (IsPreparedTableValue(dataB))
            {
                DrawGraph(dataB, 1);
            }
        }

        private bool IsPreparedTableValue(DataGridView data)
        {
            var validator = ValidateTable(data);

            if (validator.isValid)
            {
                ConvertCellsToDouble(data);
                data.Sort(data.Columns[0], ListSortDirection.Ascending);
                return true; 
            }
            else
            {
                MessageBox.Show(validator.message);
                return false;
            }
        }

        private void DrawGraph(DataGridView data, int chartSeries)  //нарисовать график
        {
            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.IsNewRow || row.Cells[0].Value == null)
                {
                    continue;
                }

                double y = (double)row.Cells[0].Value;
                double x = (double)row.Cells[1].Value;
                graphics.Series[chartSeries].Points.AddXY(x, y);
            }

            for(int i = data.RowCount-1; i > -1; i--)
            {
                if(data.Rows[i].IsNewRow || data.Rows[i].Cells[0].Value == null)
                {
                    continue; 
                }

                DataGridViewRow row = data.Rows[i];
                double y = (double)row.Cells[0].Value;
                double x = (double)row.Cells[2].Value;
                graphics.Series[chartSeries].Points.AddXY(x, y);
            }
        }        

        private void SetDefaultValue()
        {
            dataA.Rows.Add();
            dataA.Rows.Add();
            dataA.Rows.Add();
            //dataA.Rows.Add();
            dataA.Rows[0].Cells[0].Value = 0;
            dataA.Rows[0].Cells[1].Value = 1;
            dataA.Rows[0].Cells[2].Value = 9;
            dataA.Rows[1].Cells[0].Value = 0.5;
            dataA.Rows[1].Cells[1].Value = 2;
            dataA.Rows[1].Cells[2].Value = 8;
            dataA.Rows[2].Cells[0].Value = 1;
            dataA.Rows[2].Cells[1].Value = 3;
            dataA.Rows[2].Cells[2].Value = 4;
            /*dataA.Rows[3].Cells[0].Value = 0.8;
            dataA.Rows[3].Cells[1].Value = 2.5;
            dataA.Rows[3].Cells[2].Value = 6;*/

            dataB.Rows.Add();
            dataB.Rows.Add();
            dataB.Rows.Add();
            dataB.Rows.Add();
            dataB.Rows[0].Cells[0].Value = 0;
            dataB.Rows[0].Cells[1].Value = 1;
            dataB.Rows[0].Cells[2].Value = 9;
            dataB.Rows[1].Cells[0].Value = 0.5;
            dataB.Rows[1].Cells[1].Value = 3;
            dataB.Rows[1].Cells[2].Value = 6;
            dataB.Rows[2].Cells[0].Value = 1;
            dataB.Rows[2].Cells[1].Value = 4;
            dataB.Rows[2].Cells[2].Value = 5;
            dataB.Rows[3].Cells[0].Value = 0.2;
            dataB.Rows[3].Cells[1].Value = 2;
            dataB.Rows[3].Cells[2].Value = 7;
        }

        private void ConvertCellsToDouble(DataGridView data)
        {
            for (var i = 0; i < data.Rows.Count - 1; i++)
            {
                foreach (DataGridViewCell cell in data.Rows[i].Cells)
                {
                    cell.Value = double.Parse(cell.Value.ToString());
                }
            }
        }

        private (bool isValid,string message) ValidateTable(DataGridView data)
        {
            if(data.Rows.Count < 2)
            {
                return (false, "Минимальное количество срезов 2!"); 
            }

            foreach (DataGridViewRow row in data.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || !double.TryParse(cell.Value.ToString(), out _))
                        {
                            return (false, "Таблица с значениями множества содержит некорректные значения или пустые ячейки");
                        }
                    }
                }
            }

            var columnTable = data.Rows.Cast<DataGridViewRow>()
                .Take(data.Rows.Count - 1)
                .Select(row => row.Cells
                    .Cast<DataGridViewCell>()
                    .Select(x => double.Parse(x.Value.ToString()))
                    .Take(1)
                    .ToArray())
                .ToArray();

            if (columnTable.SingleOrDefault(x => x[0] == 0) == null || columnTable.SingleOrDefault(x => x[0] == 1) == null)
            {
                return (false, "Срезы с значениями 0 и 1 обязательны!");
            }

            if (columnTable.SingleOrDefault(x => x[0] < 0) != null || columnTable.SingleOrDefault(x => x[0] > 1) != null)
            {
                return (false, "Значения среза не могут принимать значения больше 1 или меньше 0");
            }

            return (true, "Проблем не обнаруженно"); 
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (IsPreparedTableValue(dataA) && IsPreparedTableValue(dataB))
            {
                InitMatrix(); //инициал
                SumSets(); 
                ClearChart();
                DrawGraph(dataA, 0);
                DrawGraph(dataB, 1);
                DrawGraph(dataC, 2);
            }
        }

        private void InitMatrix()
        {
            valuesA = GetMatrix(dataA);
            valuesB = GetMatrix(dataB);
        }

        private void SumSets()
        {
            MergeMatrix(valuesA, ref valuesB);
            MergeMatrix(valuesB, ref valuesA);

            for (int i = 0; i < valuesA.GetLength(0); i++)
            {
                dataC.Rows.Add();
                dataC.Rows[i].Cells[0].Value = valuesA[i][0];
                dataC.Rows[i].Cells[1].Value = valuesA[i][1] + valuesB[i][1];
                dataC.Rows[i].Cells[2].Value = valuesA[i][2] + valuesB[i][2];
            }
        }

        private double[][] GetMatrix(DataGridView data)
        {
            return data.Rows
                .Cast<DataGridViewRow>()
                .Take(data.Rows.Count - 1)
                .Select(row => row.Cells
                    .Cast<DataGridViewCell>()
                    .Select(x => double.Parse(x.Value.ToString()))
                    .ToArray())
                .ToArray(); 
        }

        private double SearchXFromTwoPointAndY(double y, double x1, double y1, double x2, double y2)
        {
            return (x2-x1)*(y-y1)/(y2-y1) + x1; 
        }

        // Ищет все несовпадающие срезы в матрицах и добавляет их друг в друга
        private void MergeMatrix(double[][] matrixSource, ref double[][] matrixDestination)
        {
            for (int i = 0; i < matrixSource.GetLength(0); i++)
            {
                if (!IsHasElement(matrixDestination, matrixSource[i][0]))
                {
                    int index = SearchIndexByValue(matrixDestination, matrixSource[i][0]);

                    matrixDestination = AddStringInMatrix( // передавать найденные координаты
                        matrixSource[i][0], // значение среза
                        SearchXFromTwoPointAndY(matrixSource[i][0], matrixDestination[index - 1][1], matrixDestination[index - 1][0], matrixDestination[index][1], matrixDestination[index][0]), // найденная первая точка
                        SearchXFromTwoPointAndY(matrixSource[i][0], matrixDestination[index - 1][2], matrixDestination[index - 1][0], matrixDestination[index][2], matrixDestination[index][0]), // найденная вторая точка
                        matrixDestination) ;
                }
            }
        }

        private bool IsHasElement(double[][] matrix, double value)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i][0] == value)
                {
                    return true; 
                }
            }

            return false; 
        }

        private int SearchIndexByValue(double[][] matrix, double value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (value < matrix[i][0])
                {
                    return i;
                }
            }

            return -1;
        }

        private double[][] AddStringInMatrix(double val1, double val2, double val3, double[][] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if(val1 < matrix[i][0])
                {
                    double[] newString = new double[] { val1, val2, val3 };
                    double[][] newMatrix = new double[matrix.GetLength(0) + 1][]; 
                    
                    matrix.CopyTo(newMatrix, 0); 

                    for(int j = newMatrix.GetLength(0) -1; j > i; j--)
                    {
                        newMatrix[j] = newMatrix[j - 1]; 
                    }

                    newMatrix[i] = newString;
                    return newMatrix;
                }
            }
 
            return matrix; 
        }

        private void dataA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dgv = (DataGridView)sender;
            int delIndex = dgv.CurrentRow.Index;
            dgv.Rows.RemoveAt(delIndex);
        }

        private void dataB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dgv = (DataGridView)sender;
            int delIndex = dgv.CurrentRow.Index;
            dgv.Rows.RemoveAt(delIndex);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (IsPreparedTableValue(dataA) && IsPreparedTableValue(dataB))
            {
                InitMatrix();
                SubstractSets();
                ClearChart();
                DrawGraph(dataA, 0);
                DrawGraph(dataB, 1);
                DrawGraph(dataC, 2);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (IsPreparedTableValue(dataA) && IsPreparedTableValue(dataB))
            {
                InitMatrix();
                MultiplySets();
                ClearChart();
                DrawGraph(dataA, 0);
                DrawGraph(dataB, 1);
                DrawGraph(dataC, 2);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (IsPreparedTableValue(dataA) && IsPreparedTableValue(dataB))
            {
                InitMatrix();
                DivisionSets();
                ClearChart();
                DrawGraph(dataA, 0);
                DrawGraph(dataB, 1);
                DrawGraph(dataC, 2);
            }
        }

        private void ClearChart()
        {
            graphics.Series[0].Points.Clear();
            graphics.Series[1].Points.Clear();
            graphics.Series[2].Points.Clear();
        }

        private void DivisionSets()
        {
            MergeMatrix(valuesA, ref valuesB);
            MergeMatrix(valuesB, ref valuesA);

            for (int i = 0; i < valuesA.GetLength(0); i++)
            {
                dataC.Rows.Add();
                dataC.Rows[i].Cells[0].Value = valuesA[i][0];
                dataC.Rows[i].Cells[1].Value = valuesB[i][2] == 0 ? 0 : valuesA[i][1] / valuesB[i][2];
                dataC.Rows[i].Cells[2].Value = valuesB[i][1] == 0 ? 0 : valuesA[i][2] / valuesB[i][1];
            }
        }

        private void SubstractSets()
        {
            MergeMatrix(valuesA, ref valuesB);
            MergeMatrix(valuesB, ref valuesA);

            for (int i = 0; i < valuesA.GetLength(0); i++)
            {
                dataC.Rows.Add();
                dataC.Rows[i].Cells[0].Value = valuesA[i][0];
                dataC.Rows[i].Cells[1].Value = valuesA[i][1] - valuesB[i][2];
                dataC.Rows[i].Cells[2].Value = valuesA[i][2] - valuesB[i][1];
            }
        }

        private void MultiplySets()
        {
            MergeMatrix(valuesA, ref valuesB);
            MergeMatrix(valuesB, ref valuesA);

            for (int i = 0; i < valuesA.GetLength(0); i++)
            {
                dataC.Rows.Add();
                dataC.Rows[i].Cells[0].Value = valuesA[i][0];
                dataC.Rows[i].Cells[1].Value = valuesA[i][1] * valuesB[i][1];
                dataC.Rows[i].Cells[2].Value = valuesA[i][2] * valuesB[i][2];
            }
        }

        private void comparison_Click(object sender, EventArgs e)  //0 колво строк, 1 колво столб
        {
            InitMatrix();
            double SummA = 0, SummB = 0, numberA, numberB;
            for(int i=0; i< valuesA.GetLength(0); i++)
                SummA += valuesA[i][1] + valuesA[i][2];
            numberA = SummA / valuesA.GetLength(0);

            for (int i = 0; i < valuesB.GetLength(0); i++)
                SummB += valuesB[i][1] + valuesB[i][2];
            numberB = SummB / valuesB.GetLength(0);

            more.BackColor = numberA > numberB ? Color.Green : Color.Red;
            less.BackColor = numberA < numberB ? Color.Green : Color.Red;
            lessORequal.BackColor = numberA <= numberB ? Color.Green : Color.Red;
            moreORequal.BackColor = numberA >= numberB ? Color.Green : Color.Red;
            equal.BackColor = numberA == numberB ? Color.Green : Color.Red;
            notEqual.BackColor = numberA != numberB ? Color.Green : Color.Red;

        }
    }
}
