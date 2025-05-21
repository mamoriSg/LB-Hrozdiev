namespace _10_LB_Hrozdiev
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSerializeBinary = new System.Windows.Forms.Button();
            this.btnSaveToTextFile = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAddSample = new System.Windows.Forms.Button();
            this.tbAdminPop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdminName = new System.Windows.Forms.TextBox();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCalculateDensity = new System.Windows.Forms.Button();
            this.tbDensityResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(529, 306);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(177, 22);
            this.textBoxResult.TabIndex = 125;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(529, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 124;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(948, 240);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(186, 76);
            this.btnCount.TabIndex = 123;
            this.btnCount.Text = "Підрахунок кількості елементів у списку";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click_1);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Location = new System.Drawing.Point(948, 129);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(186, 76);
            this.btnDeleteLast.TabIndex = 122;
            this.btnDeleteLast.Text = "Видалення останнього елементу зі списку";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(948, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 76);
            this.btnClear.TabIndex = 121;
            this.btnClear.Text = "Очищення форми";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSerializeBinary.Location = new System.Drawing.Point(496, 73);
            this.btnSerializeBinary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(250, 39);
            this.btnSerializeBinary.TabIndex = 120;
            this.btnSerializeBinary.Text = "Зробити бінарну серіалізацію";
            this.btnSerializeBinary.UseVisualStyleBackColor = false;
            this.btnSerializeBinary.Click += new System.EventHandler(this.btnSerializeBinary_Click_1);
            // 
            // btnSaveToTextFile
            // 
            this.btnSaveToTextFile.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSaveToTextFile.Location = new System.Drawing.Point(496, 17);
            this.btnSaveToTextFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveToTextFile.Name = "btnSaveToTextFile";
            this.btnSaveToTextFile.Size = new System.Drawing.Size(250, 39);
            this.btnSaveToTextFile.TabIndex = 119;
            this.btnSaveToTextFile.Text = "Зберегти у текстовий файл";
            this.btnSaveToTextFile.UseVisualStyleBackColor = false;
            this.btnSaveToTextFile.Click += new System.EventHandler(this.btnSaveToTextFile_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSort.Location = new System.Drawing.Point(234, 429);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(183, 39);
            this.btnSort.TabIndex = 118;
            this.btnSort.Text = "Сортувати список";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // btnAddSample
            // 
            this.btnAddSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSample.Location = new System.Drawing.Point(22, 429);
            this.btnAddSample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(183, 39);
            this.btnAddSample.TabIndex = 117;
            this.btnAddSample.Text = "Додати готові області";
            this.btnAddSample.UseVisualStyleBackColor = false;
            this.btnAddSample.Click += new System.EventHandler(this.btnAddSample_Click);
            // 
            // tbAdminPop
            // 
            this.tbAdminPop.BackColor = System.Drawing.Color.OldLace;
            this.tbAdminPop.Location = new System.Drawing.Point(19, 306);
            this.tbAdminPop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminPop.Name = "tbAdminPop";
            this.tbAdminPop.Size = new System.Drawing.Size(283, 22);
            this.tbAdminPop.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 16);
            this.label5.TabIndex = 115;
            this.label5.Text = "Введіть населення адміністративного центру:";
            // 
            // tbAdminName
            // 
            this.tbAdminName.BackColor = System.Drawing.Color.OldLace;
            this.tbAdminName.Location = new System.Drawing.Point(19, 240);
            this.tbAdminName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(283, 22);
            this.tbAdminName.TabIndex = 114;
            // 
            // tbPopulation
            // 
            this.tbPopulation.BackColor = System.Drawing.Color.OldLace;
            this.tbPopulation.Location = new System.Drawing.Point(22, 171);
            this.tbPopulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(280, 22);
            this.tbPopulation.TabIndex = 113;
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.Color.OldLace;
            this.tbArea.Location = new System.Drawing.Point(19, 104);
            this.tbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(283, 22);
            this.tbArea.TabIndex = 112;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.OldLace;
            this.tbName.Location = new System.Drawing.Point(19, 36);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(283, 22);
            this.tbName.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "Введіть назву адміністративного центру області України:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Введіть населення області України:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Введіть площу області України: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Введіть назву області України:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Aqua;
            this.btnShow.Location = new System.Drawing.Point(234, 386);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(183, 39);
            this.btnShow.TabIndex = 106;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(22, 386);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 39);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAbout.Location = new System.Drawing.Point(872, 392);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(262, 76);
            this.btnAbout.TabIndex = 126;
            this.btnAbout.Text = "Інформація про виконуючого лабораторної";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCalculateDensity
            // 
            this.btnCalculateDensity.BackColor = System.Drawing.Color.Violet;
            this.btnCalculateDensity.Location = new System.Drawing.Point(496, 127);
            this.btnCalculateDensity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateDensity.Name = "btnCalculateDensity";
            this.btnCalculateDensity.Size = new System.Drawing.Size(250, 39);
            this.btnCalculateDensity.TabIndex = 127;
            this.btnCalculateDensity.Text = "Обчислити щільність населення\r\n";
            this.btnCalculateDensity.UseVisualStyleBackColor = false;
            this.btnCalculateDensity.Click += new System.EventHandler(this.btnCalculateDensity_Click);
            // 
            // tbDensityResult
            // 
            this.tbDensityResult.Location = new System.Drawing.Point(496, 171);
            this.tbDensityResult.Name = "tbDensityResult";
            this.tbDensityResult.Size = new System.Drawing.Size(250, 22);
            this.tbDensityResult.TabIndex = 128;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 484);
            this.Controls.Add(this.tbDensityResult);
            this.Controls.Add(this.btnCalculateDensity);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSerializeBinary);
            this.Controls.Add(this.btnSaveToTextFile);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAddSample);
            this.Controls.Add(this.tbAdminPop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAdminName);
            this.Controls.Add(this.tbPopulation);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSerializeBinary;
        private System.Windows.Forms.Button btnSaveToTextFile;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnAddSample;
        private System.Windows.Forms.TextBox tbAdminPop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAdminName;
        private System.Windows.Forms.TextBox tbPopulation;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCalculateDensity;
        private System.Windows.Forms.TextBox tbDensityResult;
    }
}

