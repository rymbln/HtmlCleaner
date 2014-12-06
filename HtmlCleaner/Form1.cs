using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string str = "";

        private void button1_Click(object sender, EventArgs e)
        {

            str = this.textBox1.Text;
            // Получаем список всех имеющихся тегов
            var tagList = new List<HtmlTag>();
            // Scan links on this page
            HtmlTag tag;

            HtmlParser parse = new HtmlParser(str);
            while (parse.ParseNext("*", out tag))
            {
                tagList.Add(tag);

            }

            // Формируем коллекции тегов и аттрибутов для вывода на интерфейс
            var tagCollection = new List<string>();
            var attrCollection = new List<string>();
            foreach (var t in tagList)
            {
                tagCollection.Add(t.Name);
                foreach (var a in t.Attributes)
                {
                    attrCollection.Add(a.Key);
                }
            }

            tagCollection = tagCollection.OrderBy(o => o).Distinct().ToList();
            attrCollection = attrCollection.OrderBy(o => o).Distinct().ToList();

            // Обновляем элементы интерфейса
            this.tagListBox.Items.AddRange(tagCollection.ToArray());
            this.tagListBox.Refresh();
            this.attrListBox.Items.Clear();
            this.attrListBox.Items.AddRange(attrCollection.ToArray());
            this.attrListBox.Refresh();



           

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.tagListBox.Items.Count; i++)
            {
                tagListBox.SetItemChecked(i, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.tagListBox.Items.Count; i++)
            {
                tagListBox.SetItemChecked(i, false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.attrListBox.Items.Count; i++)
            {
                attrListBox.SetItemChecked(i, true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.attrListBox.Items.Count; i++)
            {
                attrListBox.SetItemChecked(i, false
                    );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            str = this.textBox1.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            foreach (var item in tagListBox.CheckedItems)
            {
                str = Cleaner.RemoveHtmlTag(str, item.ToString()); 
            }
            foreach (var item in attrListBox.CheckedItems)
            {
                str = Cleaner.RemoveHtmlAttribute(str, item.ToString());
            }
            if (this.radioButton2.Checked)
            {
                str = str.Replace("&nbsp;", "");
            }
            if (this.radioButton2.Checked)
            {
                str = str.Replace("&nbsp;", " ");
            }

            this.textBox2.Text = str;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text=Clipboard.GetText();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(str);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML документ (*.html)|*.html|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(str);
                streamWriter.Close();
            }
        }
    }
}
