namespace LaboratoryNumber_2_1_
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.произвольноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонецToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроизвольнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрушениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заданиеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСпискаToolStripMenuItem,
            this.редактированиеСпискаToolStripMenuItem,
            this.обработкаToolStripMenuItem,
            this.разрушениеToolStripMenuItem});
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.заданиеToolStripMenuItem.Text = "Задание";
            // 
            // созданиеСпискаToolStripMenuItem
            // 
            this.созданиеСпискаToolStripMenuItem.Name = "созданиеСпискаToolStripMenuItem";
            this.созданиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.созданиеСпискаToolStripMenuItem.Text = "Создание списка";
            this.созданиеСпискаToolStripMenuItem.Click += new System.EventHandler(this.созданиеСпискаToolStripMenuItem_Click);
            // 
            // редактированиеСпискаToolStripMenuItem
            // 
            this.редактированиеСпискаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеЭлементаToolStripMenuItem,
            this.удалениеЭлементаToolStripMenuItem});
            this.редактированиеСпискаToolStripMenuItem.Name = "редактированиеСпискаToolStripMenuItem";
            this.редактированиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.редактированиеСпискаToolStripMenuItem.Text = "Редактирование списка";
            // 
            // добавлениеЭлементаToolStripMenuItem
            // 
            this.добавлениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалоToolStripMenuItem,
            this.вКонецToolStripMenuItem,
            this.произвольноToolStripMenuItem});
            this.добавлениеЭлементаToolStripMenuItem.Name = "добавлениеЭлементаToolStripMenuItem";
            this.добавлениеЭлементаToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.добавлениеЭлементаToolStripMenuItem.Text = "Добавление элемента";
            // 
            // вНачалоToolStripMenuItem
            // 
            this.вНачалоToolStripMenuItem.Name = "вНачалоToolStripMenuItem";
            this.вНачалоToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.вНачалоToolStripMenuItem.Text = "В начало";
            this.вНачалоToolStripMenuItem.Click += new System.EventHandler(this.вНачалоToolStripMenuItem_Click);
            // 
            // вКонецToolStripMenuItem
            // 
            this.вКонецToolStripMenuItem.Name = "вКонецToolStripMenuItem";
            this.вКонецToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.вКонецToolStripMenuItem.Text = "В конец";
            this.вКонецToolStripMenuItem.Click += new System.EventHandler(this.вКонецToolStripMenuItem_Click);
            // 
            // произвольноToolStripMenuItem
            // 
            this.произвольноToolStripMenuItem.Name = "произвольноToolStripMenuItem";
            this.произвольноToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.произвольноToolStripMenuItem.Text = "В произвольную";
            this.произвольноToolStripMenuItem.Click += new System.EventHandler(this.произвольноToolStripMenuItem_Click);
            // 
            // удалениеЭлементаToolStripMenuItem
            // 
            this.удалениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалоToolStripMenuItem1,
            this.вКонецToolStripMenuItem1,
            this.вПроизвольнуюToolStripMenuItem});
            this.удалениеЭлементаToolStripMenuItem.Name = "удалениеЭлементаToolStripMenuItem";
            this.удалениеЭлементаToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.удалениеЭлементаToolStripMenuItem.Text = "Удаление элемента";
            // 
            // вНачалоToolStripMenuItem1
            // 
            this.вНачалоToolStripMenuItem1.Name = "вНачалоToolStripMenuItem1";
            this.вНачалоToolStripMenuItem1.Size = new System.Drawing.Size(209, 26);
            this.вНачалоToolStripMenuItem1.Text = "В начало";
            this.вНачалоToolStripMenuItem1.Click += new System.EventHandler(this.вНачалоToolStripMenuItem1_Click);
            // 
            // вКонецToolStripMenuItem1
            // 
            this.вКонецToolStripMenuItem1.Name = "вКонецToolStripMenuItem1";
            this.вКонецToolStripMenuItem1.Size = new System.Drawing.Size(209, 26);
            this.вКонецToolStripMenuItem1.Text = "В конец";
            this.вКонецToolStripMenuItem1.Click += new System.EventHandler(this.вКонецToolStripMenuItem1_Click);
            // 
            // вПроизвольнуюToolStripMenuItem
            // 
            this.вПроизвольнуюToolStripMenuItem.Name = "вПроизвольнуюToolStripMenuItem";
            this.вПроизвольнуюToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.вПроизвольнуюToolStripMenuItem.Text = "В произвольную";
            this.вПроизвольнуюToolStripMenuItem.Click += new System.EventHandler(this.вПроизвольнуюToolStripMenuItem_Click);
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            this.обработкаToolStripMenuItem.Click += new System.EventHandler(this.обработкаToolStripMenuItem_Click);
            // 
            // разрушениеToolStripMenuItem
            // 
            this.разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            this.разрушениеToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.разрушениеToolStripMenuItem.Text = "Разрушение";
            this.разрушениеToolStripMenuItem.Click += new System.EventHandler(this.разрушениеToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(407, 80);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(173, 308);
            this.listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(389, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создание списка:";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(208, 144);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(90, 22);
            this.textBoxAdd.TabIndex = 3;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo1.Location = new System.Drawing.Point(12, 140);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(181, 26);
            this.labelInfo1.TabIndex = 4;
            this.labelInfo1.Text = "Введите элемент:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(304, 144);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(97, 27);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add->";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(304, 177);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(97, 27);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "<-Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MenuList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеЭлементаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вНачалоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКонецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem произвольноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеЭлементаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вНачалоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вКонецToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вПроизвольнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрушениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button buttonRemove;
    }
}

