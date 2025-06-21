using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int MAX_MATRIX_SIZE = 20;

        public Form1()
        {
            InitializeComponent();
            numericUpDownCols1.Maximum = MAX_MATRIX_SIZE;
            numericUpDownRows1.Maximum = MAX_MATRIX_SIZE;
            numericUpDown21.Maximum = MAX_MATRIX_SIZE;
            numericUpDown22.Maximum = MAX_MATRIX_SIZE;
            numericUpDownCols1.Minimum = 1;
            numericUpDownRows1.Minimum = 1;
            numericUpDown21.Minimum = 1;
            numericUpDown22.Minimum = 1;

            numericUpDownCols1.Value = 1;
            numericUpDownRows1.Value = 1;
            numericUpDown21.Value = 1;
            numericUpDown22.Value = 1;
            InitializeDataGridView(dataGridView1, 1, 1);
            InitializeDataGridView(dataGridView2, 1, 1);

            dataGridView3.ReadOnly = true;
        }



        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void format_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Normal)
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }
        //}

        private void turn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void UpdateMatrixSize(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            if (numericUpDown.TabIndex == 21 || numericUpDown.TabIndex == 23) 
            {
                UpdateDataGridViewSize(dataGridView1,
                                    (int)numericUpDownRows1.Value,
                                    (int)numericUpDownCols1.Value);
            }
            else 
            {
                UpdateDataGridViewSize(dataGridView2,
                                    (int)numericUpDown21.Value,
                                    (int)numericUpDown22.Value);
            }

        }

        private void UpdateDataGridViewSize(DataGridView grid, int newRows, int newCols)
        {
            newRows = Math.Min(newRows, MAX_MATRIX_SIZE);
            newCols = Math.Min(newCols, MAX_MATRIX_SIZE);

            List<List<object>> oldValues = new List<List<object>>();
            for (int i = 0; i < grid.RowCount && i < newRows; i++)
            {
                var row = new List<object>();
                for (int j = 0; j < grid.ColumnCount && j < newCols; j++)
                {
                    row.Add(grid[j, i].Value);
                }
                oldValues.Add(row);
            }

            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.AllowUserToAddRows = false;

            for (int j = 0; j < newCols; j++)
            {
                grid.Columns.Add($"Column{j}", "");
            }

            for (int i = 0; i < newRows; i++)
            {
                grid.Rows.Add();
                for (int j = 0; j < newCols; j++)
                {
                    grid[j, i].Value = (i < oldValues.Count && j < oldValues[i].Count)
                                     ? oldValues[i][j] ?? 0
                                     : 0;
                }
            }
        }

        private void InitializeDataGridView(DataGridView grid, int rows, int cols)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.AllowUserToAddRows = false;

            for (int j = 0; j < cols; j++)
                grid.Columns.Add("", "");

            for (int i = 0; i < rows; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(grid);
                for (int j = 0; j < cols; j++)
                {
                    row.Cells[j].Value = 0;
                }
                grid.Rows.Add(row);
            }
        }


        private void CellValidatingNumericOnly(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                string input = e.FormattedValue?.ToString() ?? "";
                if (!double.TryParse(input, out _))
                {
                    MessageBox.Show("Пожалуйста, введите корректное число (целое или с запятой).");
                    e.Cancel = true;
                }
            }
        }


        private double[,] ReadMatrix(DataGridView grid)
        {
            int rows = grid.RowCount;
            int cols = grid.ColumnCount;
            var result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    var cellValue = grid[j, i].Value?.ToString();
                    if (double.TryParse(cellValue, out double val))
                        result[i, j] = val;
                    else
                        result[i, j] = 0;
                }

            return result;
        }

        private void DisplayMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            dataGridView3.AllowUserToAddRows = false;

            for (int j = 0; j < cols; j++)
                dataGridView3.Columns.Add("", "");

            for (int i = 0; i < rows; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView3);
                for (int j = 0; j < cols; j++)
                {
                    double value = matrix[i, j];
                    if (Math.Abs(value) < 1e-10)
                        value = 0;
                    else if (Math.Abs(value - 1) < 1e-10)
                        value = 1;
                    else if (Math.Abs(value + 1) < 1e-10) 
                        value = -1;
                    //double value = Math.Abs(matrix[i, j]) < 1e-10 ? 0 : matrix[i, j];
                    row.Cells[j].Value = value;
                }
                dataGridView3.Rows.Add(row);
            }
        }

        private void MatrixOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double[,] a = ReadMatrix(dataGridView1);
            double[,] b = ReadMatrix(dataGridView2);
            double[,] result = null;
            if (button.TabIndex == 9) //Сложение матриц
            {
                int rows = a.GetLength(0), cols = a.GetLength(1);
                if (b.GetLength(0) != rows || b.GetLength(1) != cols)
                {
                    MessageBox.Show("Размеры матриц не совпадают");
                    return;
                }

                result = new double[rows, cols];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        result[i, j] = a[i, j] + b[i, j];
            }
            else if(button.TabIndex == 10) //Вычитание
            {
                int rows = a.GetLength(0), cols = a.GetLength(1);
                if (b.GetLength(0) != rows || b.GetLength(1) != cols)
                {
                    MessageBox.Show("Размеры матриц не совпадают");
                }

                result = new double[rows, cols];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        result[i, j] = a[i, j] - b[i, j];
            }
            else if( button.TabIndex == 11) //Умножение
            {
                int aRows = a.GetLength(0), aCols = a.GetLength(1), bCols = b.GetLength(1), bRows = b.GetLength(0);
                if (aCols != bRows)
                {
                    MessageBox.Show("Число столбцов A должно совпадать с числом строк B");
                    return;
                }

                result = new double[aRows, bCols];
                for (int i = 0; i < aRows; i++)
                    for (int j = 0; j < bCols; j++)
                        for (int k = 0; k < aCols; k++)
                            result[i, j] += a[i, k] * b[k, j];
            }
            else if (button.TabIndex == 13) //Транспонирование
            {
                int rows = a.GetLength(0), cols = a.GetLength(1);
                result = new double[cols, rows];

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        result[j, i] = a[i, j];
            }
            else if (button.TabIndex == 14) //Определитель
            {

                if (a.GetLength(0) != a.GetLength(1))
                {
                    MessageBox.Show("Матрица должна быть квадратной.");
                    return;
                }

                double det = Determinant(a);
                MessageBox.Show("Определитель: " + det.ToString("F4"));
                return;
            }
            else if (button.TabIndex == 15) //Обратная матрица
            {
                int n = a.GetLength(0);
                if (n != a.GetLength(1))
                {
                    MessageBox.Show("Матрица должна быть квадратной.");
                    return;
                }

                result = Inverse(a);
                if (result == null)
                {
                    MessageBox.Show("Обратная матрица не существует.");
                    return;
                }
            }
            else if (button.TabIndex == 16) //Ранг
            {
                int rank = CalculateRank(a);
                MessageBox.Show("Ранг матрицы: " + rank);
                return;
            }
            else //Умножение на скаляр
            {
                try
                {
                    double scalar = double.Parse(txtScalar.Text);
                    int rows = a.GetLength(0), cols = a.GetLength(1);
                    result = new double[rows, cols];

                    for (int i = 0; i < rows; i++)
                        for (int j = 0; j < cols; j++)
                            result[i, j] = a[i, j] * scalar;
                }
                catch
                {
                    MessageBox.Show("Введите корректное число в поле скаляра.");
                    return;
                }
            }
            DisplayMatrix(result);
        }

        private double Determinant(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double det = 1;
            double[,] tempMatrix = (double[,])matrix.Clone();

            for (int i = 0; i < n; i++)
            {
                int pivot = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(tempMatrix[j, i]) > Math.Abs(tempMatrix[pivot, i]))
                    {
                        pivot = j;
                    }
                }
                if (tempMatrix[pivot, i] == 0)
                    return 0;

                if (pivot != i)
                {
                    for (int j = 0; j < n; j++)
                    {
                        (tempMatrix[i, j], tempMatrix[pivot, j]) = (tempMatrix[pivot, j], tempMatrix[i, j]);
                    }
                    det *= -1; 
                }

                det *= tempMatrix[i, i];

                for (int j = i + 1; j < n; j++)
                {
                    double factor = tempMatrix[j, i] / tempMatrix[i, i];
                    for (int k = i; k < n; k++)
                    {
                        tempMatrix[j, k] -= factor * tempMatrix[i, k];
                    }
                }
            }

            return det;
        }

        private double[,] Inverse(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            var result = new double[n, n];
            var augmented = new double[n, 2 * n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    augmented[i, j] = matrix[i, j];
                    augmented[i, j + n] = (i == j) ? 1 : 0;
                }

            for (int i = 0; i < n; i++)
            {
                if (augmented[i, i] == 0)
                {
                    bool swapped = false;
                    for (int k = i + 1; k < n; k++)
                    {
                        if (augmented[k, i] != 0)
                        {
                            for (int j = 0; j < 2 * n; j++)
                            {
                                double temp = augmented[i, j];
                                augmented[i, j] = augmented[k, j];
                                augmented[k, j] = temp;
                            }
                            swapped = true;
                            break;
                        }
                    }
                    if (!swapped) return null;
                }

                double diag = augmented[i, i];
                for (int j = 0; j < 2 * n; j++)
                    augmented[i, j] /= diag;

                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = augmented[k, i];
                    for (int j = 0; j < 2 * n; j++)
                        augmented[k, j] -= factor * augmented[i, j];
                }
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = augmented[i, j + n];

            return result;
        }

        private int CalculateRank(double[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            var mat = (double[,])matrix.Clone();
            int rank = 0;

            for (int row = 0; row < m; row++)
            {
                if (row >= n) break;

                if (mat[row, row] != 0)
                {
                    for (int col = 0; col < m; col++)
                        if (col != row)
                        {
                            double mult = mat[col, row] / mat[row, row];
                            for (int i = 0; i < n; i++)
                                mat[col, i] -= mult * mat[row, i];
                        }
                }
                else
                {
                    bool reduced = false;
                    for (int i = row + 1; i < m; i++)
                    {
                        if (mat[i, row] != 0)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                double temp = mat[row, j];
                                mat[row, j] = mat[i, j];
                                mat[i, j] = temp;
                            }
                            reduced = true;
                            break;
                        }
                    }
                    if (!reduced) continue;
                }
                rank++;
            }

            return rank;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            InitializeDataGridView(dataGridView1, 1, 1);
            InitializeDataGridView(dataGridView2, 1, 1);
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            numericUpDownRows1.Value = 1;
            numericUpDownCols1.Value = 1;
            numericUpDown21.Value = 1;
            numericUpDown22.Value = 1;

            txtScalar.Text = "";
        }

        private void MatrixReplaced(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.TabIndex == 29)//AB
            {
                int rows = dataGridView1.RowCount;
                int cols = dataGridView1.ColumnCount;


                numericUpDown21.Value = rows;
                numericUpDown22.Value = cols;


                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        dataGridView2[j, i].Value = dataGridView1[j, i].Value;

            }
            else if( button.TabIndex == 31)//BA
            {
                int rows = dataGridView2.RowCount;
                int cols = dataGridView2.ColumnCount;

                numericUpDownRows1.Value = rows;
                numericUpDownCols1.Value = cols;

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        dataGridView1[j, i].Value = dataGridView2[j, i].Value;
            }
            else if(button.TabIndex == 32)//CA
            {
                int rows = dataGridView3.RowCount;
                int cols = dataGridView3.ColumnCount;
                if (cols == 0 || rows == 0) return;
                numericUpDownRows1.Value = rows;
                numericUpDownCols1.Value = cols;

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        dataGridView1[j, i].Value = dataGridView3[j, i].Value;
            }
            else//CB
            {
                int rows = dataGridView3.RowCount;
                int cols = dataGridView3.ColumnCount;
                if (cols == 0 || rows == 0) return;
                numericUpDown21.Value = rows;
                numericUpDown22.Value = cols;
                

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        dataGridView2[j, i].Value = dataGridView3[j, i].Value;
            }
        }

        private void FillRandomValues(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DataGridView targetGrid = button.TabIndex == 34 ? dataGridView1 : dataGridView2;
            Random rand = new Random();

            foreach (DataGridViewRow row in targetGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = Math.Round(rand.NextDouble() * 20 - 10, 2);
                }
            }
        }
    }
}
