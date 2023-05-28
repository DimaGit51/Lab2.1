namespace LaboratoryNumber_2_1_WinForms
{
    partial class PatternAddInList_StartEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternAddInList_StartEnd));
            this.listBoxPatternAddInList = new System.Windows.Forms.ListBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.textBoxAddPatternAdd = new System.Windows.Forms.TextBox();
            this.labelElement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPatternAddInList
            // 
            this.listBoxPatternAddInList.FormattingEnabled = true;
            this.listBoxPatternAddInList.ItemHeight = 16;
            this.listBoxPatternAddInList.Location = new System.Drawing.Point(12, 80);
            this.listBoxPatternAddInList.Name = "listBoxPatternAddInList";
            this.listBoxPatternAddInList.Size = new System.Drawing.Size(188, 292);
            this.listBoxPatternAddInList.TabIndex = 19;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 47);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(188, 27);
            this.ButtonAdd.TabIndex = 18;
            this.ButtonAdd.Text = "Add->";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxAddPatternAdd
            // 
            this.textBoxAddPatternAdd.Location = new System.Drawing.Point(127, 20);
            this.textBoxAddPatternAdd.Name = "textBoxAddPatternAdd";
            this.textBoxAddPatternAdd.Size = new System.Drawing.Size(73, 22);
            this.textBoxAddPatternAdd.TabIndex = 17;
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelElement.Location = new System.Drawing.Point(8, 17);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(102, 25);
            this.labelElement.TabIndex = 22;
            this.labelElement.Text = "Element:";
            // 
            // PatternAddInList_StartEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 399);
            this.Controls.Add(this.labelElement);
            this.Controls.Add(this.listBoxPatternAddInList);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBoxAddPatternAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatternAddInList_StartEnd";
            this.Text = "PatternAddInList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPatternAddInList;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox textBoxAddPatternAdd;
        private System.Windows.Forms.Label labelElement;
    }
}