namespace LaboratoryNumber_2_1_WinForms
{
    partial class PrintCreateList
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
            this.labelListPrint = new System.Windows.Forms.Label();
            this.listBoxPrintList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelListPrint
            // 
            this.labelListPrint.AutoSize = true;
            this.labelListPrint.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListPrint.Location = new System.Drawing.Point(51, 9);
            this.labelListPrint.Name = "labelListPrint";
            this.labelListPrint.Size = new System.Drawing.Size(215, 32);
            this.labelListPrint.TabIndex = 0;
            this.labelListPrint.Text = "Список ListNow:";
            // 
            // listBoxPrintList
            // 
            this.listBoxPrintList.FormattingEnabled = true;
            this.listBoxPrintList.ItemHeight = 16;
            this.listBoxPrintList.Location = new System.Drawing.Point(18, 60);
            this.listBoxPrintList.Name = "listBoxPrintList";
            this.listBoxPrintList.Size = new System.Drawing.Size(290, 340);
            this.listBoxPrintList.TabIndex = 1;
            // 
            // PrintCreateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 430);
            this.Controls.Add(this.listBoxPrintList);
            this.Controls.Add(this.labelListPrint);
            this.Name = "PrintCreateList";
            this.Text = "PrintList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListPrint;
        private System.Windows.Forms.ListBox listBoxPrintList;
    }
}