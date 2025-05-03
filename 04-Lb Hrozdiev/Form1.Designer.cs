namespace _04_Lb_Hrozdiev
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
            this.tbRegionType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYearFounded = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAdminPop
            // 
            this.tbAdminPop.Location = new System.Drawing.Point(39, 244);
            this.tbAdminPop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminPop.Name = "tbAdminPop";
            this.tbAdminPop.Size = new System.Drawing.Size(283, 22);
            this.tbAdminPop.TabIndex = 35;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Введіть населення адміністративного центру:";

            // 
            // tbAdminName
            // 
            this.tbAdminName.Location = new System.Drawing.Point(39, 190);
            this.tbAdminName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(283, 22);
            this.tbAdminName.TabIndex = 33;

            // 
            // tbPopulation
            // 
            this.tbPopulation.Location = new System.Drawing.Point(42, 133);
            this.tbPopulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(280, 22);
            this.tbPopulation.TabIndex = 32;
   
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(36, 82);
            this.tbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(283, 22);
            this.tbArea.TabIndex = 31;

            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(39, 38);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(283, 22);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Введіть назву адміністративного центру області України:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Введіть населення області України:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введіть площу області України: ";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Введіть назву області України:";

            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(572, 185);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 39);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(575, 89);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbRegionType
            // 
            this.tbRegionType.Location = new System.Drawing.Point(39, 300);
            this.tbRegionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegionType.Name = "tbRegionType";
            this.tbRegionType.Size = new System.Drawing.Size(283, 22);
            this.tbRegionType.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Введіть тип регіону :";
            // 
            // tbYearFounded
            // 
            this.tbYearFounded.Location = new System.Drawing.Point(36, 357);
            this.tbYearFounded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbYearFounded.Name = "tbYearFounded";
            this.tbYearFounded.Size = new System.Drawing.Size(283, 22);
            this.tbYearFounded.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Введіть рік утворення області :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbYearFounded);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRegionType);
            this.Controls.Add(this.label6);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tbRegionType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYearFounded;
        private System.Windows.Forms.Label label7;
    }
}

