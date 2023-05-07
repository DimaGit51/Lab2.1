namespace LaboratoryNumber_2_1_
{
    partial class Form2
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
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.textBoxElement = new System.Windows.Forms.TextBox();
            this.listBoxCalculate = new System.Windows.Forms.ListBox();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.labelInfo4 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo2.Location = new System.Drawing.Point(12, 25);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(0, 26);
            this.labelInfo2.TabIndex = 5;
            // 
            // textBoxElement
            // 
            this.textBoxElement.Location = new System.Drawing.Point(12, 92);
            this.textBoxElement.Name = "textBoxElement";
            this.textBoxElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxElement.TabIndex = 6;
            // 
            // listBoxCalculate
            // 
            this.listBoxCalculate.FormattingEnabled = true;
            this.listBoxCalculate.ItemHeight = 16;
            this.listBoxCalculate.Location = new System.Drawing.Point(304, 120);
            this.listBoxCalculate.Name = "listBoxCalculate";
            this.listBoxCalculate.Size = new System.Drawing.Size(187, 308);
            this.listBoxCalculate.TabIndex = 7;
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo3.Location = new System.Drawing.Point(12, 54);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(0, 26);
            this.labelInfo3.TabIndex = 8;
            // 
            // labelInfo4
            // 
            this.labelInfo4.AutoSize = true;
            this.labelInfo4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo4.Location = new System.Drawing.Point(299, 88);
            this.labelInfo4.Name = "labelInfo4";
            this.labelInfo4.Size = new System.Drawing.Size(81, 26);
            this.labelInfo4.TabIndex = 9;
            this.labelInfo4.Text = "Вывод:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(118, 92);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 27);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 445);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelInfo4);
            this.Controls.Add(this.labelInfo3);
            this.Controls.Add(this.listBoxCalculate);
            this.Controls.Add(this.textBoxElement);
            this.Controls.Add(this.labelInfo2);
            this.Name = "Form2";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.TextBox textBoxElement;
        public System.Windows.Forms.ListBox listBoxCalculate;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label labelInfo4;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

