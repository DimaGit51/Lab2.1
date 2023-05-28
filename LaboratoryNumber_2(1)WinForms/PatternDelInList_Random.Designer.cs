namespace LaboratoryNumber_2_1_WinForms
{
    partial class PatternDelInList_Random
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelElement_list = new System.Windows.Forms.Label();
            this.listBox_PrintListDelRandom = new System.Windows.Forms.ListBox();
            this.textBoxFindElementDR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 27);
            this.button1.TabIndex = 36;
            this.button1.Text = "Del->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(227, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 50);
            this.label1.TabIndex = 34;
            this.label1.Text = "Введите элемент\r\nПосле которого вы хотите удалить элемент:\r\n";
            // 
            // labelElement_list
            // 
            this.labelElement_list.AutoSize = true;
            this.labelElement_list.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelElement_list.Location = new System.Drawing.Point(12, 12);
            this.labelElement_list.Name = "labelElement_list";
            this.labelElement_list.Size = new System.Drawing.Size(123, 25);
            this.labelElement_list.TabIndex = 33;
            this.labelElement_list.Text = "Список_1:";
            // 
            // listBox_PrintListDelRandom
            // 
            this.listBox_PrintListDelRandom.FormattingEnabled = true;
            this.listBox_PrintListDelRandom.ItemHeight = 16;
            this.listBox_PrintListDelRandom.Location = new System.Drawing.Point(12, 40);
            this.listBox_PrintListDelRandom.Name = "listBox_PrintListDelRandom";
            this.listBox_PrintListDelRandom.Size = new System.Drawing.Size(184, 356);
            this.listBox_PrintListDelRandom.TabIndex = 32;
            // 
            // textBoxFindElementDR
            // 
            this.textBoxFindElementDR.Location = new System.Drawing.Point(232, 103);
            this.textBoxFindElementDR.Name = "textBoxFindElementDR";
            this.textBoxFindElementDR.Size = new System.Drawing.Size(116, 22);
            this.textBoxFindElementDR.TabIndex = 31;
            // 
            // PatternDelInList_Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelElement_list);
            this.Controls.Add(this.listBox_PrintListDelRandom);
            this.Controls.Add(this.textBoxFindElementDR);
            this.Name = "PatternDelInList_Random";
            this.Text = "PatternDelInList_Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelElement_list;
        private System.Windows.Forms.ListBox listBox_PrintListDelRandom;
        private System.Windows.Forms.TextBox textBoxFindElementDR;
    }
}