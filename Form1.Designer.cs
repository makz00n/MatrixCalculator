namespace WindowsFormsApp10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.turn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.btnDeterminant = new System.Windows.Forms.Button();
            this.btnInvers = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnScalarMultiply = new System.Windows.Forms.Button();
            this.txtScalar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRows1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCols1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown22 = new System.Windows.Forms.NumericUpDown();
            this.btnAB = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.btnCB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.turn);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // turn
            // 
            this.turn.Dock = System.Windows.Forms.DockStyle.Right;
            this.turn.FlatAppearance.BorderSize = 0;
            this.turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turn.Image = ((System.Drawing.Image)(resources.GetObject("turn.Image")));
            this.turn.Location = new System.Drawing.Point(1142, 0);
            this.turn.Margin = new System.Windows.Forms.Padding(0);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(50, 49);
            this.turn.TabIndex = 4;
            this.turn.UseVisualStyleBackColor = true;
            this.turn.Click += new System.EventHandler(this.turn_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1192, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 49);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Матрица А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1032, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Матрица B";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 333);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CellValidatingNumericOnly);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(820, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(410, 333);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CellValidatingNumericOnly);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(420, 477);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(410, 333);
            this.dataGridView3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(520, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Матрица C";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(635, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Сложение";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(435, 156);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(179, 34);
            this.btnSubstract.TabIndex = 10;
            this.btnSubstract.Text = "Вычитание";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(635, 156);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(179, 34);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "Умножение матриц";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnTranspose
            // 
            this.btnTranspose.Location = new System.Drawing.Point(435, 196);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(179, 34);
            this.btnTranspose.TabIndex = 13;
            this.btnTranspose.Text = "Транспонирование";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.Location = new System.Drawing.Point(635, 196);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(179, 34);
            this.btnDeterminant.TabIndex = 14;
            this.btnDeterminant.Text = "Определитель";
            this.btnDeterminant.UseVisualStyleBackColor = true;
            this.btnDeterminant.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnInvers
            // 
            this.btnInvers.Location = new System.Drawing.Point(435, 236);
            this.btnInvers.Name = "btnInvers";
            this.btnInvers.Size = new System.Drawing.Size(179, 34);
            this.btnInvers.TabIndex = 15;
            this.btnInvers.Text = "Обратная матрица";
            this.btnInvers.UseVisualStyleBackColor = true;
            this.btnInvers.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(635, 236);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(179, 34);
            this.btnRank.TabIndex = 16;
            this.btnRank.Text = "Ранг";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // btnScalarMultiply
            // 
            this.btnScalarMultiply.Location = new System.Drawing.Point(435, 276);
            this.btnScalarMultiply.Name = "btnScalarMultiply";
            this.btnScalarMultiply.Size = new System.Drawing.Size(179, 34);
            this.btnScalarMultiply.TabIndex = 17;
            this.btnScalarMultiply.Text = "Умножение на число";
            this.btnScalarMultiply.UseVisualStyleBackColor = true;
            this.btnScalarMultiply.Click += new System.EventHandler(this.MatrixOperation);
            // 
            // txtScalar
            // 
            this.txtScalar.Location = new System.Drawing.Point(635, 276);
            this.txtScalar.Multiline = true;
            this.txtScalar.Name = "txtScalar";
            this.txtScalar.Size = new System.Drawing.Size(87, 34);
            this.txtScalar.TabIndex = 18;
            this.txtScalar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Кол-во строк";
            // 
            // numericUpDownRows1
            // 
            this.numericUpDownRows1.Location = new System.Drawing.Point(150, 479);
            this.numericUpDownRows1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRows1.Name = "numericUpDownRows1";
            this.numericUpDownRows1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRows1.TabIndex = 21;
            this.numericUpDownRows1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows1.ValueChanged += new System.EventHandler(this.UpdateMatrixSize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Кол-во столбцов";
            // 
            // numericUpDownCols1
            // 
            this.numericUpDownCols1.Location = new System.Drawing.Point(150, 511);
            this.numericUpDownCols1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCols1.Name = "numericUpDownCols1";
            this.numericUpDownCols1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCols1.TabIndex = 23;
            this.numericUpDownCols1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCols1.ValueChanged += new System.EventHandler(this.UpdateMatrixSize);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(865, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Кол-во строк";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Кол-во столбцов";
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(998, 475);
            this.numericUpDown21.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown21.TabIndex = 26;
            this.numericUpDown21.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown21.ValueChanged += new System.EventHandler(this.UpdateMatrixSize);
            // 
            // numericUpDown22
            // 
            this.numericUpDown22.Location = new System.Drawing.Point(998, 517);
            this.numericUpDown22.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown22.Name = "numericUpDown22";
            this.numericUpDown22.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown22.TabIndex = 27;
            this.numericUpDown22.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown22.ValueChanged += new System.EventHandler(this.UpdateMatrixSize);
            // 
            // btnAB
            // 
            this.btnAB.Location = new System.Drawing.Point(435, 360);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(92, 47);
            this.btnAB.TabIndex = 29;
            this.btnAB.Text = "A->B";
            this.btnAB.UseVisualStyleBackColor = true;
            this.btnAB.Click += new System.EventHandler(this.MatrixReplaced);
            // 
            // btnBA
            // 
            this.btnBA.Location = new System.Drawing.Point(533, 360);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(81, 47);
            this.btnBA.TabIndex = 31;
            this.btnBA.Text = "B->A";
            this.btnBA.UseVisualStyleBackColor = true;
            this.btnBA.Click += new System.EventHandler(this.MatrixReplaced);
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(711, 360);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(85, 47);
            this.btnCA.TabIndex = 32;
            this.btnCA.Text = "C->A";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.MatrixReplaced);
            // 
            // btnCB
            // 
            this.btnCB.Location = new System.Drawing.Point(620, 360);
            this.btnCB.Name = "btnCB";
            this.btnCB.Size = new System.Drawing.Size(85, 47);
            this.btnCB.TabIndex = 33;
            this.btnCB.Text = "C->B";
            this.btnCB.UseVisualStyleBackColor = true;
            this.btnCB.Click += new System.EventHandler(this.MatrixReplaced);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FillRandomValues);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(917, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 34);
            this.button2.TabIndex = 35;
            this.button2.Text = "Заполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FillRandomValues);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 822);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCB);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btnAB);
            this.Controls.Add(this.numericUpDown22);
            this.Controls.Add(this.numericUpDown21);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCols1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownRows1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScalar);
            this.Controls.Add(this.btnScalarMultiply);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnInvers);
            this.Controls.Add(this.btnDeterminant);
            this.Controls.Add(this.btnTranspose);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button turn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.Button btnDeterminant;
        private System.Windows.Forms.Button btnInvers;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnScalarMultiply;
        private System.Windows.Forms.TextBox txtScalar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRows1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCols1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown21;
        private System.Windows.Forms.NumericUpDown numericUpDown22;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.Button btnCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

