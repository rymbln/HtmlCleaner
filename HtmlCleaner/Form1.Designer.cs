namespace HtmlCleaner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetHTMLStructure = new System.Windows.Forms.Button();
            this.tagListBox = new System.Windows.Forms.CheckedListBox();
            this.attrListBox = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAllTags = new System.Windows.Forms.Button();
            this.btnSelectNoneTags = new System.Windows.Forms.Button();
            this.btnSelectAllAttributes = new System.Windows.Forms.Button();
            this.btnSelectNoneAttributes = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(362, 484);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GetHTMLStructure
            // 
            this.GetHTMLStructure.Location = new System.Drawing.Point(184, 499);
            this.GetHTMLStructure.Name = "GetHTMLStructure";
            this.GetHTMLStructure.Size = new System.Drawing.Size(191, 51);
            this.GetHTMLStructure.TabIndex = 1;
            this.GetHTMLStructure.Text = "2. Получить HTML структуру";
            this.GetHTMLStructure.UseVisualStyleBackColor = true;
            this.GetHTMLStructure.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagListBox
            // 
            this.tagListBox.FormattingEnabled = true;
            this.tagListBox.Location = new System.Drawing.Point(382, 78);
            this.tagListBox.Name = "tagListBox";
            this.tagListBox.Size = new System.Drawing.Size(118, 259);
            this.tagListBox.TabIndex = 2;
            // 
            // attrListBox
            // 
            this.attrListBox.FormattingEnabled = true;
            this.attrListBox.Location = new System.Drawing.Point(506, 78);
            this.attrListBox.Name = "attrListBox";
            this.attrListBox.Size = new System.Drawing.Size(119, 259);
            this.attrListBox.TabIndex = 3;
            // 
            // btnSelectAllTags
            // 
            this.btnSelectAllTags.Location = new System.Drawing.Point(380, 343);
            this.btnSelectAllTags.Name = "btnSelectAllTags";
            this.btnSelectAllTags.Size = new System.Drawing.Size(120, 23);
            this.btnSelectAllTags.TabIndex = 4;
            this.btnSelectAllTags.Text = "Выбрать все";
            this.btnSelectAllTags.UseVisualStyleBackColor = true;
            this.btnSelectAllTags.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelectNoneTags
            // 
            this.btnSelectNoneTags.Location = new System.Drawing.Point(381, 372);
            this.btnSelectNoneTags.Name = "btnSelectNoneTags";
            this.btnSelectNoneTags.Size = new System.Drawing.Size(119, 23);
            this.btnSelectNoneTags.TabIndex = 5;
            this.btnSelectNoneTags.Text = "Снять выделение";
            this.btnSelectNoneTags.UseVisualStyleBackColor = true;
            this.btnSelectNoneTags.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSelectAllAttributes
            // 
            this.btnSelectAllAttributes.Location = new System.Drawing.Point(505, 343);
            this.btnSelectAllAttributes.Name = "btnSelectAllAttributes";
            this.btnSelectAllAttributes.Size = new System.Drawing.Size(120, 23);
            this.btnSelectAllAttributes.TabIndex = 6;
            this.btnSelectAllAttributes.Text = "Выбрать все";
            this.btnSelectAllAttributes.UseVisualStyleBackColor = true;
            this.btnSelectAllAttributes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSelectNoneAttributes
            // 
            this.btnSelectNoneAttributes.Location = new System.Drawing.Point(506, 372);
            this.btnSelectNoneAttributes.Name = "btnSelectNoneAttributes";
            this.btnSelectNoneAttributes.Size = new System.Drawing.Size(119, 23);
            this.btnSelectNoneAttributes.TabIndex = 7;
            this.btnSelectNoneAttributes.Text = "Снять выделение";
            this.btnSelectNoneAttributes.UseVisualStyleBackColor = true;
            this.btnSelectNoneAttributes.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(362, 484);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "6. Получить очищенный HTML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(382, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "5. Что делать с nbsp ?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Заменять на пробел";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Удалять";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ничего не делать";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "1. Вставить текст из буфера";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "7. Скопировать в буфер";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 66);
            this.label1.TabIndex = 13;
            this.label1.Text = "3. Выберите теги, которые необходимо удалить";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(503, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 66);
            this.label2.TabIndex = 14;
            this.label2.Text = "4. Выберите атрибуты тегов, которые необходимо удалить";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(813, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 51);
            this.button4.TabIndex = 15;
            this.button4.Text = "8. Сохранить в файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSelectNoneAttributes);
            this.Controls.Add(this.btnSelectAllAttributes);
            this.Controls.Add(this.btnSelectNoneTags);
            this.Controls.Add(this.btnSelectAllTags);
            this.Controls.Add(this.attrListBox);
            this.Controls.Add(this.tagListBox);
            this.Controls.Add(this.GetHTMLStructure);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.Text = "HtmlCleaner v.1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetHTMLStructure;
        private System.Windows.Forms.CheckedListBox tagListBox;
        private System.Windows.Forms.CheckedListBox attrListBox;
        private System.Windows.Forms.Button btnSelectAllTags;
        private System.Windows.Forms.Button btnSelectNoneTags;
        private System.Windows.Forms.Button btnSelectAllAttributes;
        private System.Windows.Forms.Button btnSelectNoneAttributes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}

