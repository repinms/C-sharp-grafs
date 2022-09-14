
namespace Graf_Duku
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete2 = new System.Windows.Forms.Button();
            this.combo_delete = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete1 = new System.Windows.Forms.Button();
            this.combo_search = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pointName_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(500, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(601, 36);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(126, 40);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Начать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить точки";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 557);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Редактировать путь";
            // 
            // combo1
            // 
            this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(43, 164);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(77, 21);
            this.combo1.TabIndex = 5;
            // 
            // combo2
            // 
            this.combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(142, 165);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(75, 21);
            this.combo2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Точка 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Точка 2";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(8, 191);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(114, 40);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete2
            // 
            this.button_delete2.Location = new System.Drawing.Point(140, 192);
            this.button_delete2.Name = "button_delete2";
            this.button_delete2.Size = new System.Drawing.Size(113, 40);
            this.button_delete2.TabIndex = 12;
            this.button_delete2.Text = "Удалить";
            this.button_delete2.UseVisualStyleBackColor = true;
            this.button_delete2.Click += new System.EventHandler(this.button_delete2_Click);
            // 
            // combo_delete
            // 
            this.combo_delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_delete.FormattingEnabled = true;
            this.combo_delete.Location = new System.Drawing.Point(91, 37);
            this.combo_delete.Name = "combo_delete";
            this.combo_delete.Size = new System.Drawing.Size(77, 21);
            this.combo_delete.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Удалить точку";
            // 
            // button_delete1
            // 
            this.button_delete1.Location = new System.Drawing.Point(83, 64);
            this.button_delete1.Name = "button_delete1";
            this.button_delete1.Size = new System.Drawing.Size(100, 25);
            this.button_delete1.TabIndex = 15;
            this.button_delete1.Text = "Удалить";
            this.button_delete1.UseVisualStyleBackColor = true;
            this.button_delete1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_delete1_MouseDown);
            // 
            // combo_search
            // 
            this.combo_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_search.FormattingEnabled = true;
            this.combo_search.Location = new System.Drawing.Point(44, 269);
            this.combo_search.Name = "combo_search";
            this.combo_search.Size = new System.Drawing.Size(77, 21);
            this.combo_search.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(30, 296);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 25);
            this.button_search.TabIndex = 18;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Поиск пути";
            // 
            // pointName_textbox
            // 
            this.pointName_textbox.Location = new System.Drawing.Point(665, 94);
            this.pointName_textbox.Name = "pointName_textbox";
            this.pointName_textbox.Size = new System.Drawing.Size(81, 20);
            this.pointName_textbox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Название точки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.combo_delete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.combo2);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_search);
            this.groupBox1.Controls.Add(this.button_delete1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_delete2);
            this.groupBox1.Location = new System.Drawing.Point(540, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 381);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(118, 348);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Идентификаторы";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(46, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Сетка";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pointName_textbox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete2;
        private System.Windows.Forms.ComboBox combo_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete1;
        private System.Windows.Forms.ComboBox combo_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pointName_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

