namespace LaboratoryNumber_2_1_WinForms
{
    partial class MyTask14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTask14));
            this.buttonRemove2 = new System.Windows.Forms.Button();
            this.buttonList2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonMyTask = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ButtonAdd2 = new System.Windows.Forms.Button();
            this.textBoxAdd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRemove2
            // 
            this.buttonRemove2.Location = new System.Drawing.Point(104, 78);
            this.buttonRemove2.Name = "buttonRemove2";
            this.buttonRemove2.Size = new System.Drawing.Size(94, 27);
            this.buttonRemove2.TabIndex = 30;
            this.buttonRemove2.Text = "Remove2->";
            this.buttonRemove2.UseVisualStyleBackColor = true;
            this.buttonRemove2.Click += new System.EventHandler(this.buttonRemove2_Click);
            // 
            // buttonList2
            // 
            this.buttonList2.Location = new System.Drawing.Point(10, 408);
            this.buttonList2.Name = "buttonList2";
            this.buttonList2.Size = new System.Drawing.Size(191, 27);
            this.buttonList2.TabIndex = 28;
            this.buttonList2.Text = "Создать список 2->";
            this.buttonList2.UseVisualStyleBackColor = true;
            this.buttonList2.Click += new System.EventHandler(this.buttonList2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(232, 46);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(188, 356);
            this.listBox3.TabIndex = 26;
            // 
            // buttonMyTask
            // 
            this.buttonMyTask.Location = new System.Drawing.Point(232, 408);
            this.buttonMyTask.Name = "buttonMyTask";
            this.buttonMyTask.Size = new System.Drawing.Size(188, 27);
            this.buttonMyTask.TabIndex = 25;
            this.buttonMyTask.Text = "Выполнить задание";
            this.buttonMyTask.UseVisualStyleBackColor = true;
            this.buttonMyTask.Click += new System.EventHandler(this.buttonMyTask_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(10, 110);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 292);
            this.listBox2.TabIndex = 24;
            // 
            // ButtonAdd2
            // 
            this.ButtonAdd2.Location = new System.Drawing.Point(10, 78);
            this.ButtonAdd2.Name = "ButtonAdd2";
            this.ButtonAdd2.Size = new System.Drawing.Size(94, 27);
            this.ButtonAdd2.TabIndex = 23;
            this.ButtonAdd2.Text = "Add2->";
            this.ButtonAdd2.UseVisualStyleBackColor = true;
            this.ButtonAdd2.Click += new System.EventHandler(this.ButtonAdd2_Click);
            // 
            // textBoxAdd2
            // 
            this.textBoxAdd2.Location = new System.Drawing.Point(10, 50);
            this.textBoxAdd2.Name = "textBoxAdd2";
            this.textBoxAdd2.Size = new System.Drawing.Size(188, 22);
            this.textBoxAdd2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "*Вариант 14*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Создание списка_2:";
            // 
            // MyTask14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemove2);
            this.Controls.Add(this.buttonList2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.buttonMyTask);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ButtonAdd2);
            this.Controls.Add(this.textBoxAdd2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyTask14";
            this.Text = "MyTask14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove2;
        private System.Windows.Forms.Button buttonList2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonMyTask;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ButtonAdd2;
        private System.Windows.Forms.TextBox textBoxAdd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}