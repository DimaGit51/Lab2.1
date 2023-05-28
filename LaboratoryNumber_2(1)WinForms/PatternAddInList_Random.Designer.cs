namespace LaboratoryNumber_2_1_WinForms
{
    partial class PatternAddInList_Random
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
            this.labelElement_list = new System.Windows.Forms.Label();
            this.listBox_PrintList = new System.Windows.Forms.ListBox();
            this.textBoxFindElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAddElementRandom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelElement_list
            // 
            this.labelElement_list.AutoSize = true;
            this.labelElement_list.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelElement_list.Location = new System.Drawing.Point(12, 18);
            this.labelElement_list.Name = "labelElement_list";
            this.labelElement_list.Size = new System.Drawing.Size(123, 25);
            this.labelElement_list.TabIndex = 26;
            this.labelElement_list.Text = "Список_1:";
            // 
            // listBox_PrintList
            // 
            this.listBox_PrintList.FormattingEnabled = true;
            this.listBox_PrintList.ItemHeight = 16;
            this.listBox_PrintList.Location = new System.Drawing.Point(12, 46);
            this.listBox_PrintList.Name = "listBox_PrintList";
            this.listBox_PrintList.Size = new System.Drawing.Size(184, 356);
            this.listBox_PrintList.TabIndex = 25;
            // 
            // textBoxFindElement
            // 
            this.textBoxFindElement.Location = new System.Drawing.Point(232, 109);
            this.textBoxFindElement.Name = "textBoxFindElement";
            this.textBoxFindElement.Size = new System.Drawing.Size(116, 22);
            this.textBoxFindElement.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(227, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "Введите элемент\r\nПосле которого вы хотите добавить новый:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(227, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 50);
            this.label2.TabIndex = 30;
            this.label2.Text = "Введите элемент\r\nКоторый вы хотите добавить:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 27);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAddElementRandom
            // 
            this.textBoxAddElementRandom.Location = new System.Drawing.Point(232, 230);
            this.textBoxAddElementRandom.Name = "textBoxAddElementRandom";
            this.textBoxAddElementRandom.Size = new System.Drawing.Size(116, 22);
            this.textBoxAddElementRandom.TabIndex = 28;
            // 
            // PatternAddInList_Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAddElementRandom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelElement_list);
            this.Controls.Add(this.listBox_PrintList);
            this.Controls.Add(this.textBoxFindElement);
            this.Name = "PatternAddInList_Random";
            this.Text = "PatternAddInList_Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelElement_list;
        private System.Windows.Forms.ListBox listBox_PrintList;
        private System.Windows.Forms.TextBox textBoxFindElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAddElementRandom;
    }
}