namespace AddCalibrateOrGainApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInitialData = new System.Windows.Forms.GroupBox();
            this.dgvInitialData = new System.Windows.Forms.DataGridView();
            this.columnFrequencyInitData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmplitudeInitData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddInitialData = new System.Windows.Forms.Button();
            this.gbCalibrateData = new System.Windows.Forms.GroupBox();
            this.dgvCalibrateData = new System.Windows.Forms.DataGridView();
            this.columnFrequencyCalData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmplitudeCalData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCalibrateData = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.columnFrequencyResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmplitudeResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.gbInitialData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialData)).BeginInit();
            this.gbCalibrateData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibrateData)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInitialData
            // 
            this.gbInitialData.Controls.Add(this.dgvInitialData);
            this.gbInitialData.Controls.Add(this.btnAddInitialData);
            this.gbInitialData.Location = new System.Drawing.Point(12, 12);
            this.gbInitialData.Name = "gbInitialData";
            this.gbInitialData.Size = new System.Drawing.Size(360, 426);
            this.gbInitialData.TabIndex = 0;
            this.gbInitialData.TabStop = false;
            this.gbInitialData.Text = "Исходные данные";
            // 
            // dgvInitialData
            // 
            this.dgvInitialData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInitialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFrequencyInitData,
            this.columnAmplitudeInitData});
            this.dgvInitialData.Location = new System.Drawing.Point(6, 51);
            this.dgvInitialData.Name = "dgvInitialData";
            this.dgvInitialData.RowTemplate.Height = 25;
            this.dgvInitialData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInitialData.Size = new System.Drawing.Size(351, 369);
            this.dgvInitialData.TabIndex = 1;
            // 
            // columnFrequencyInitData
            // 
            this.columnFrequencyInitData.HeaderText = "Частота";
            this.columnFrequencyInitData.Name = "columnFrequencyInitData";
            // 
            // columnAmplitudeInitData
            // 
            this.columnAmplitudeInitData.HeaderText = "Амплитуда";
            this.columnAmplitudeInitData.Name = "columnAmplitudeInitData";
            // 
            // btnAddInitialData
            // 
            this.btnAddInitialData.Location = new System.Drawing.Point(6, 22);
            this.btnAddInitialData.Name = "btnAddInitialData";
            this.btnAddInitialData.Size = new System.Drawing.Size(115, 23);
            this.btnAddInitialData.TabIndex = 0;
            this.btnAddInitialData.Text = "Выбрать данные";
            this.btnAddInitialData.UseVisualStyleBackColor = true;
            this.btnAddInitialData.Click += new System.EventHandler(this.btnAddInitialData_Click);
            // 
            // gbCalibrateData
            // 
            this.gbCalibrateData.Controls.Add(this.dgvCalibrateData);
            this.gbCalibrateData.Controls.Add(this.btnAddCalibrateData);
            this.gbCalibrateData.Location = new System.Drawing.Point(378, 12);
            this.gbCalibrateData.Name = "gbCalibrateData";
            this.gbCalibrateData.Size = new System.Drawing.Size(360, 426);
            this.gbCalibrateData.TabIndex = 1;
            this.gbCalibrateData.TabStop = false;
            this.gbCalibrateData.Text = "Данные калибровки или усиления";
            // 
            // dgvCalibrateData
            // 
            this.dgvCalibrateData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalibrateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalibrateData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFrequencyCalData,
            this.columnAmplitudeCalData});
            this.dgvCalibrateData.Location = new System.Drawing.Point(6, 51);
            this.dgvCalibrateData.Name = "dgvCalibrateData";
            this.dgvCalibrateData.RowTemplate.Height = 25;
            this.dgvCalibrateData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCalibrateData.Size = new System.Drawing.Size(348, 369);
            this.dgvCalibrateData.TabIndex = 1;
            // 
            // columnFrequencyCalData
            // 
            this.columnFrequencyCalData.HeaderText = "Частота";
            this.columnFrequencyCalData.Name = "columnFrequencyCalData";
            // 
            // columnAmplitudeCalData
            // 
            this.columnAmplitudeCalData.HeaderText = "Амплитуда";
            this.columnAmplitudeCalData.Name = "columnAmplitudeCalData";
            // 
            // btnAddCalibrateData
            // 
            this.btnAddCalibrateData.Location = new System.Drawing.Point(6, 22);
            this.btnAddCalibrateData.Name = "btnAddCalibrateData";
            this.btnAddCalibrateData.Size = new System.Drawing.Size(115, 23);
            this.btnAddCalibrateData.TabIndex = 0;
            this.btnAddCalibrateData.Text = "Выбрать данные";
            this.btnAddCalibrateData.UseVisualStyleBackColor = true;
            this.btnAddCalibrateData.Click += new System.EventHandler(this.btnAddCalibrateData_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.dgvResult);
            this.gbResult.Controls.Add(this.btnResult);
            this.gbResult.Location = new System.Drawing.Point(744, 12);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(360, 426);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFrequencyResult,
            this.columnAmplitudeResult});
            this.dgvResult.Location = new System.Drawing.Point(6, 51);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.Size = new System.Drawing.Size(348, 369);
            this.dgvResult.TabIndex = 1;
            // 
            // columnFrequencyResult
            // 
            this.columnFrequencyResult.HeaderText = "Частота";
            this.columnFrequencyResult.Name = "columnFrequencyResult";
            // 
            // columnAmplitudeResult
            // 
            this.columnAmplitudeResult.HeaderText = "Амплитуда";
            this.columnAmplitudeResult.Name = "columnAmplitudeResult";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(6, 22);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(115, 23);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Рассчитать";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(964, 444);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(140, 23);
            this.btnSaveResult.TabIndex = 3;
            this.btnSaveResult.Text = "Сохранить результат";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 473);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbCalibrateData);
            this.Controls.Add(this.gbInitialData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbInitialData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialData)).EndInit();
            this.gbCalibrateData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibrateData)).EndInit();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInitialData;
        private System.Windows.Forms.DataGridView dgvInitialData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFrequencyInitData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmplitudeInitData;
        private System.Windows.Forms.Button btnAddInitialData;
        private System.Windows.Forms.GroupBox gbCalibrateData;
        private System.Windows.Forms.DataGridView dgvCalibrateData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFrequencyCalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmplitudeCalData;
        private System.Windows.Forms.Button btnAddCalibrateData;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFrequencyResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmplitudeResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnSaveResult;
    }
}
