namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lastname = new System.Windows.Forms.CheckBox();
            this.fathername = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bukvaBox = new System.Windows.Forms.CheckBox();
            this.versionBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.text_out = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочаяПапкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ссылкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.началоРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотобанкPxhereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотобанкPxbayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаТекстовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Генератор ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(10, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Для генерации кликните по полю";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Мужские имена";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Checked = true;
            this.lastname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lastname.Location = new System.Drawing.Point(10, 119);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(75, 17);
            this.lastname.TabIndex = 6;
            this.lastname.Text = "Фамилия";
            this.lastname.UseVisualStyleBackColor = true;
            // 
            // fathername
            // 
            this.fathername.AutoSize = true;
            this.fathername.Location = new System.Drawing.Point(91, 119);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(73, 17);
            this.fathername.TabIndex = 7;
            this.fathername.Text = "Отчество";
            this.fathername.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(255, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Генератор названий товаров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(255, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Для генерации кликните по полю";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // bukvaBox
            // 
            this.bukvaBox.AutoSize = true;
            this.bukvaBox.Checked = true;
            this.bukvaBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bukvaBox.Location = new System.Drawing.Point(258, 96);
            this.bukvaBox.Name = "bukvaBox";
            this.bukvaBox.Size = new System.Drawing.Size(150, 17);
            this.bukvaBox.TabIndex = 11;
            this.bukvaBox.Text = "Добавить букву и цифру";
            this.bukvaBox.UseVisualStyleBackColor = true;
            // 
            // versionBox
            // 
            this.versionBox.AutoSize = true;
            this.versionBox.Location = new System.Drawing.Point(258, 119);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(117, 17);
            this.versionBox.TabIndex = 12;
            this.versionBox.Text = "Добавить версию";
            this.versionBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тексты для вставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кликните для копирования в буфер обмена";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Консультация специалиста",
            "Оставьте заявку на сайте",
            "Текст для акции (скидка)",
            "Текст для акции (промокод)",
            "Способы доставки",
            "Способы оплаты",
            "Контакты"});
            this.comboBox1.Location = new System.Drawing.Point(10, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // text_out
            // 
            this.text_out.Location = new System.Drawing.Point(10, 225);
            this.text_out.Name = "text_out";
            this.text_out.Size = new System.Drawing.Size(447, 146);
            this.text_out.TabIndex = 16;
            this.text_out.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Нижний регистр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Верхний регистр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ссылкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рабочаяПапкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // рабочаяПапкаToolStripMenuItem
            // 
            this.рабочаяПапкаToolStripMenuItem.Name = "рабочаяПапкаToolStripMenuItem";
            this.рабочаяПапкаToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.рабочаяПапкаToolStripMenuItem.Text = "Рабочая папка";
            this.рабочаяПапкаToolStripMenuItem.Click += new System.EventHandler(this.рабочаяПапкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ссылкиToolStripMenuItem
            // 
            this.ссылкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоРаботыToolStripMenuItem,
            this.фотобанкPxhereToolStripMenuItem,
            this.фотобанкPxbayToolStripMenuItem,
            this.проверкаТекстовToolStripMenuItem});
            this.ссылкиToolStripMenuItem.Name = "ссылкиToolStripMenuItem";
            this.ссылкиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ссылкиToolStripMenuItem.Text = "Ссылки";
            // 
            // началоРаботыToolStripMenuItem
            // 
            this.началоРаботыToolStripMenuItem.Name = "началоРаботыToolStripMenuItem";
            this.началоРаботыToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.началоРаботыToolStripMenuItem.Text = "Начало работы";
            this.началоРаботыToolStripMenuItem.Click += new System.EventHandler(this.началоРаботыToolStripMenuItem_Click);
            // 
            // фотобанкPxhereToolStripMenuItem
            // 
            this.фотобанкPxhereToolStripMenuItem.Name = "фотобанкPxhereToolStripMenuItem";
            this.фотобанкPxhereToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.фотобанкPxhereToolStripMenuItem.Text = "Фотобанк Pxhere";
            this.фотобанкPxhereToolStripMenuItem.Click += new System.EventHandler(this.фотобанкPxhereToolStripMenuItem_Click);
            // 
            // фотобанкPxbayToolStripMenuItem
            // 
            this.фотобанкPxbayToolStripMenuItem.Name = "фотобанкPxbayToolStripMenuItem";
            this.фотобанкPxbayToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.фотобанкPxbayToolStripMenuItem.Text = "Фотобанк Pixabay";
            this.фотобанкPxbayToolStripMenuItem.Click += new System.EventHandler(this.фотобанкPxbayToolStripMenuItem_Click);
            // 
            // проверкаТекстовToolStripMenuItem
            // 
            this.проверкаТекстовToolStripMenuItem.Name = "проверкаТекстовToolStripMenuItem";
            this.проверкаТекстовToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.проверкаТекстовToolStripMenuItem.Text = "Проверка текстов";
            this.проверкаТекстовToolStripMenuItem.Click += new System.EventHandler(this.проверкаТекстовToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.контактыToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.контактыToolStripMenuItem.Text = "Контакты";
            this.контактыToolStripMenuItem.Click += new System.EventHandler(this.контактыToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_out);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.bukvaBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fathername);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Набор инструментов веб-мастера";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox lastname;
        private System.Windows.Forms.CheckBox fathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox bukvaBox;
        private System.Windows.Forms.CheckBox versionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox text_out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ссылкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem началоРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотобанкPxhereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотобанкPxbayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаТекстовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рабочаяПапкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
    }
}

