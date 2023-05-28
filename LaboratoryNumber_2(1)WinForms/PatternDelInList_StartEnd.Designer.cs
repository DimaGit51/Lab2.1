namespace LaboratoryNumber_2_1_WinForms
{
    partial class PatternDelInList_StartEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternDelInList_StartEnd));
            this.listBoxPatternDelInList = new System.Windows.Forms.ListBox();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPatternDelInList
            // 
            this.listBoxPatternDelInList.FormattingEnabled = true;
            this.listBoxPatternDelInList.ItemHeight = 16;
            this.listBoxPatternDelInList.Location = new System.Drawing.Point(12, 45);
            this.listBoxPatternDelInList.Name = "listBoxPatternDelInList";
            this.listBoxPatternDelInList.Size = new System.Drawing.Size(188, 324);
            this.listBoxPatternDelInList.TabIndex = 25;
            // 
            // ButtonDel
            // 
            this.ButtonDel.Location = new System.Drawing.Point(12, 12);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(188, 27);
            this.ButtonDel.TabIndex = 24;
            this.ButtonDel.Text = "Delete->";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // PatternDelInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 383);
            this.Controls.Add(this.listBoxPatternDelInList);
            this.Controls.Add(this.ButtonDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatternDelInList";
            this.Text = "PatternDelInList";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPatternDelInList;
        private System.Windows.Forms.Button ButtonDel;
    }
}