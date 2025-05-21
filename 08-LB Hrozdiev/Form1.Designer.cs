namespace _08_LB_Hrozdiev
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
            this.SuspendLayout();
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSerializeBinary.Location = new System.Drawing.Point(534, 88);
            this.btnSerializeBinary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(217, 39);
            this.btnSerializeBinary.TabIndex = 83;
            this.btnSerializeBinary.Text = "Зробити бінарну серіалізацію";
            this.btnSerializeBinary.UseVisualStyleBackColor = false;
            // 
            // btnSaveToTextFile
            // 
            this.btnSaveToTextFile.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSaveToTextFile.Location = new System.Drawing.Point(534, 32);
            this.btnSaveToTextFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveToTextFile.Name = "btnSaveToTextFile";
            this.btnSaveToTextFile.Size = new System.Drawing.Size(217, 39);
            this.btnSaveToTextFile.TabIndex = 82;
            this.btnSaveToTextFile.Text = "Зберегти у текстовий файл";
            this.btnSaveToTextFile.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSort.Location = new System.Drawing.Point(568, 380);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(183, 39);
            this.btnSort.TabIndex = 81;
            this.btnSort.Text = "Сортувати список";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // btnAddSample
            // 
            this.btnAddSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSample.Location = new System.Drawing.Point(356, 380);
            this.btnAddSample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(183, 39);
            this.btnAddSample.TabIndex = 80;
            this.btnAddSample.Text = "Додати готові області";
            this.btnAddSample.UseVisualStyleBackColor = false;
            // 
            // tbAdminPop
            // 
            this.tbAdminPop.BackColor = System.Drawing.Color.OldLace;
            this.tbAdminPop.Location = new System.Drawing.Point(54, 321);
            this.tbAdminPop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminPop.Name = "tbAdminPop";
            this.tbAdminPop.Size = new System.Drawing.Size(283, 22);
            this.tbAdminPop.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Введіть населення адміністративного центру:";
            // 
            // tbAdminName
            // 
            this.tbAdminName.BackColor = System.Drawing.Color.OldLace;
            this.tbAdminName.Location = new System.Drawing.Point(54, 255);
            this.tbAdminName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(283, 22);
            this.tbAdminName.TabIndex = 77;
            // 
            // tbPopulation
            // 
            this.tbPopulation.BackColor = System.Drawing.Color.OldLace;
            this.tbPopulation.Location = new System.Drawing.Point(57, 186);
            this.tbPopulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(280, 22);
            this.tbPopulation.TabIndex = 76;
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.Color.OldLace;
            this.tbArea.Location = new System.Drawing.Point(54, 119);
            this.tbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(283, 22);
            this.tbArea.TabIndex = 75;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.OldLace;
            this.tbName.Location = new System.Drawing.Point(54, 51);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(283, 22);
            this.tbName.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Введіть назву адміністративного центру області України:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Введіть населення області України:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Введіть площу області України: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Введіть назву області України:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Aqua;
            this.btnShow.Location = new System.Drawing.Point(206, 380);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 39);
            this.btnShow.TabIndex = 69;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(53, 380);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

