using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texteditor
{
    public partial class Form1 : Form
    {
        // Имя текущего файла.
        string filename;

        // Список всех файлов и их статус.
        List<(string Name, bool isSaved)> SavedList;

        // Интервал автосейва.
        public static int Min;

        public Form1()
        {
            InitializeComponent();
            filename = "new file";
            SavedList = new List<(string Name, bool isSaved)> { };
            tabControl1.TabPages[0].Name = "new file";
            Min = 2;
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Записываем в списочек самую первую вкладку.
            SavedList.Add((tabControl1.SelectedTab.Name, false));
        }


        // Метод для создания новой вкладки.
        protected void Create_Click(object sender, EventArgs e)
        {
            // Создаем новую вкладку.
            TabPage page = new TabPage("new file" + tabControl1.TabPages.Count);
            page.Name = page.Text;
            tabControl1.TabPages.Add(page);

            // Создаем новый текстбокс.
            RichTextBox eatTheRichTextBox = new RichTextBox();
            eatTheRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            eatTheRichTextBox.Location = new System.Drawing.Point(30, 55);
            eatTheRichTextBox.Name = "richTextBox1";
            eatTheRichTextBox.Size = new System.Drawing.Size(1437, 614);
            eatTheRichTextBox.TabIndex = 0;
            eatTheRichTextBox.Text = "";
            eatTheRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            eatTheRichTextBox.ContextMenuStrip = contextMenuStrip1;

            // Добавляем этот текстбокс на новую вкладку.
            page.Controls.Add(eatTheRichTextBox);

            // Добавляем файл в списочек.
            SavedList.Add((page.Name, false));

        }


        // Метод вызываемый после любого изменения текста в текстбоксе.
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Отмечаем что файл не сохранен.
            for (int i = 0; i < SavedList.Count; i++)
            {
                if (SavedList[i].Name.Equals(tabControl1.SelectedTab.Name))
                    SavedList[i] = (tabControl1.SelectedTab.Name, false);
            }
        }

        // Пункт меню file>save сохраняющий файл.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Едим богатых и получаем текущую вкладку.
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            filename = tabControl1.SelectedTab.Name;
            // Сохраняем.
            saveFile(sender, e, eatTheRichTextBox);
        }

        // Метод сохраняющий файл.
        void saveFile(object sender, EventArgs e, RichTextBox eatTheRichTextBox)
        {
            try
            {
                // Если файл уже существует то просто сохраняем его.
                if (File.Exists(filename))
                {
                    // Сохраняем ртф.
                    if (Path.GetExtension(filename) == ".rtf")
                    {
                        eatTheRichTextBox.SaveFile(filename, RichTextBoxStreamType.RichText);
                        
                    }
                    // Сохраняем все остальное.
                    else
                    {
                        eatTheRichTextBox.SaveFile(filename, RichTextBoxStreamType.PlainText);
                    }

                    // Записываем в списочек (и уже не карандашиком) что файл сохранен.
                    for (int i = 0; i < SavedList.Count; i++)
                    {
                        if (SavedList[i].Name.Equals(tabControl1.SelectedTab.Name))
                            SavedList[i] = (filename, true);
                    }
                }
                // Для новогофайла вызываем метод сохранить как.
                else
                {
                    saveAsFile(sender, e, eatTheRichTextBox);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Пункт меню file>save as сохраняющий файл как.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Едим богатых и получаем текущую вкладку.
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            filename = tabControl1.SelectedTab.Name;
            // Сохраняем.
            saveAsFile(sender, e, eatTheRichTextBox);

        }

        // Метод который сохраняет файл как.
        void saveAsFile(object sender, EventArgs e, RichTextBox eatTheRichTextBox)
        {  
            // Если отмена то завершаем метод.
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                // Получаем данные из диалога.
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt| RTF (*.rtf*)|*.rtf*";
                filename = saveFileDialog1.FileName;

                //Сохраняем как ртф или как просто текст.
                if (Path.GetExtension(saveFileDialog1.FileName) == ".rtf")
                {
                    eatTheRichTextBox.SaveFile(filename, RichTextBoxStreamType.RichText);
                    
                }
                else
                {
                    eatTheRichTextBox.SaveFile(filename, RichTextBoxStreamType.PlainText);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Отмечаем в списочке что файл сохранен.
            for (int i = 0; i < SavedList.Count; i++)
            {
                if (SavedList[i].Name.Equals(tabControl1.SelectedTab.Name))
                    SavedList[i] = (filename, true);
            }

            // Меняем имя и текст вкладки.
            string[] filenameClear = filename.Split(Path.DirectorySeparatorChar);
            tabControl1.SelectedTab.Text = filenameClear[filenameClear.Length - 1];
            tabControl1.SelectedTab.Name = filename;


        }

        //  Метод для открытия уже существующего файла.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Диалог открытия файла.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Получаем текущий текстбокс.
                    RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();

                   // Получаем имя файла.
                    filename = openFileDialog1.FileName;

                    // Загружаем файл в текстбокс.
                    if (Path.GetExtension(filename) == ".rtf")
                    {
                        eatTheRichTextBox.LoadFile(filename, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        eatTheRichTextBox.LoadFile(filename, RichTextBoxStreamType.PlainText);
                    }


                    // Записываем файл в списочек.
                    for (int i = 0; i < SavedList.Count; i++)
                    {
                        if (SavedList[i].Name.Equals(tabControl1.SelectedTab.Name))
                            SavedList[i] = (filename, true);
                    }

                    // Устанавливаем данные вкладки.
                    string[] filenameClear = filename.Split(Path.DirectorySeparatorChar);
                    tabControl1.SelectedTab.Text = filenameClear[filenameClear.Length - 1];
                    tabControl1.SelectedTab.Name = filename;

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        
        // Метод закрытия формы.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string notSaved = "unsaved changes in files:\n";
            bool unSavedbool = false;
            try
            {
                // Получаем список несохраненных изменений.
                for (int i = 0; i < SavedList.Count; i++)
                {
                    if (SavedList[i].isSaved == false)
                    {
                        notSaved += SavedList[i].Name + "\n";
                        unSavedbool = true;
                    }

                }
                // Если он не пустой то предлагаем сохранить.
                if (unSavedbool)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(notSaved, "do you want to save unsaved changes?", buttons);

                    // Отмена закрытия формы.
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }

                    // Сохранение файлов.
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < SavedList.Count; i++)
                        {
                            if (SavedList[i].isSaved == false)
                            {
                                tabControl1.SelectTab(SavedList[i].Name);
                                RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
                                filename = SavedList[i].Name;
                                saveFile(sender, e, eatTheRichTextBox);

                            }

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Метод который копирует текст.
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            Clipboard.SetData(DataFormats.Rtf, eatTheRichTextBox.SelectedRtf);

        }

        // Метод который вырезает текст.
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            eatTheRichTextBox.Cut();
        }

        // Метод который вставляет текст.
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
                eatTheRichTextBox.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();

            }

        }

        // Метод который выделяет все.
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            eatTheRichTextBox.SelectAll();
            eatTheRichTextBox.Focus();

        }

        // Метод отмены изменения.
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            eatTheRichTextBox.Undo();

        }

        // Метод отмены отмены.
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            eatTheRichTextBox.Redo();

        }


        // Метод который делает текст жирным.
        private void formatBoldStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            if (!eatTheRichTextBox.SelectionFont.Bold)
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style & ~FontStyle.Bold);
            }

        }

        // Метод который делает текст curseивным.
        private void formatItalicsStripMenuItem2_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            if (!eatTheRichTextBox.SelectionFont.Italic)
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style & ~FontStyle.Italic);
            }

        }

        // Метод который зачеркивает текст.
        private void formatStrikeStripMenuItem4_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            if (!eatTheRichTextBox.SelectionFont.Strikeout)
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style | FontStyle.Strikeout);
            }
            else
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style & ~FontStyle.Strikeout);
            }

        }

        // Метод который подчеркивает текст.
        private void formatUnderlineStripMenuItem3_Click(object sender, EventArgs e)
        {
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
            if (!eatTheRichTextBox.SelectionFont.Underline)
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style | FontStyle.Underline);
            }
            else
            {
                eatTheRichTextBox.SelectionFont = new Font(eatTheRichTextBox.SelectionFont, eatTheRichTextBox.SelectionFont.Style & ~FontStyle.Underline);
            }
        }

        // Меню для выбора комик санса (ну и других шрифтов если у вас нет вкуса).
        private void menuFontStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Получаем текстбокс.
            RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();

            // Запускаем диалог выбора шрифта.
            fontDialog1.ShowColor = true;
            fontDialog1.Font = eatTheRichTextBox.Font;
            fontDialog1.Color = eatTheRichTextBox.ForeColor;


            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // Устанавливаем шрифт и цвет.
                eatTheRichTextBox.Font = fontDialog1.Font;
                eatTheRichTextBox.ForeColor = fontDialog1.Color;
            }
        }


        // Метод для переходв на темную сторону (тему).
        private void themeDarkStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Красим все красивым графитовым (мы же не лохи все черным заливать).
            this.BackColor = Color.FromArgb(84, 84, 84);
            this.menuStrip1.BackColor = Color.FromArgb(54, 54, 54);
            this.menuStrip1.ForeColor = Color.FromArgb(54, 54, 54);
            this.button1.BackColor = Color.FromArgb(54, 54, 54);
            this.button1.ForeColor = Color.White;

            // Красим меню.
            foreach (ToolStripMenuItem c in this.menuStrip1.Items)
            {
                c.BackColor = Color.FromArgb(54, 54, 54);
                c.ForeColor = Color.White;

                // И подменю.
                foreach (ToolStripDropDownItem c2 in c.DropDownItems)
                {
                    c2.BackColor = Color.FromArgb(54, 54, 54);
                    c2.ForeColor = Color.White;

                    // И подподменю.
                    foreach (ToolStripDropDownItem c3 in c2.DropDownItems)
                    {
                        c3.BackColor = Color.FromArgb(54, 54, 54);
                        c3.ForeColor = Color.White;
                    }
                }
            }
        }

        // Метод для перехода на светлую тему.
        private void themeLightStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Красим все в цвет  Control (будто у нас все под контролем).
            this.BackColor = SystemColors.Control;
            this.menuStrip1.BackColor = SystemColors.Control;
            this.menuStrip1.ForeColor = SystemColors.Control;
            this.button1.BackColor = SystemColors.Control;
            this.button1.ForeColor = Color.Black;

            // Красим меню.
            foreach (ToolStripMenuItem c in this.menuStrip1.Items)
            {
                c.BackColor = SystemColors.Control;
                c.ForeColor = Color.Black;

                // И подменю.
                foreach (ToolStripDropDownItem c2 in c.DropDownItems)
                {
                    c2.BackColor = SystemColors.Control;
                    c2.ForeColor = Color.Black;

                    // И подподменю.
                    foreach (ToolStripDropDownItem c3 in c2.DropDownItems)
                    {
                        c3.BackColor = SystemColors.Control;
                        c3.ForeColor = Color.Black;
                    }
                }
            }

        }


        // Метод отслеживающий нажатия клавиш.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие esc - выход.
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            // Нажатие ctrl + A - сохранение всего.
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                // Проходим по списку вкладок.
                for (int i = 0; i < SavedList.Count; i++)
                {
                    // Выбираем несохраненное.
                    if (SavedList[i].isSaved == false)
                    {
                        // Получаем данную вкладку.
                        tabControl1.SelectTab(SavedList[i].Name);
                        RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
                        filename = SavedList[i].Name;

                        // Спасаем и сохраняем.
                        saveFile(sender, e, eatTheRichTextBox);

                    }

                }
            }
            // Нажатие ctrl + W - открытие нового окна (типо w - window круто да).
            if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                var newForm = new Form1();
                newForm.Show();
            }
        }

        // Метод сохраняющий все раз в интервал таймера.
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Проходим по списку вкладок.
            for (int i = 0; i < SavedList.Count; i++)
            {
                // Выбираем несохраненное.
                if (SavedList[i].isSaved == false)
                {
                    // Получаем данную вкладку.
                    tabControl1.SelectTab(SavedList[i].Name);
                    RichTextBox eatTheRichTextBox = tabControl1.SelectedTab.Controls.OfType<RichTextBox>().Reverse().FirstOrDefault();
                    filename = SavedList[i].Name;

                    // Спасаем и сохраняем.
                    saveFile(sender, e, eatTheRichTextBox);

                }

            }

        }

        // Пункт меню settings>autosave который устанавливает интервал автосейва.
        private void settingsAutosaveStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            // Форма с трекбаром.
            Form2 trackBar = new Form2();
            trackBar.SetValue(Min);
            trackBar.Show();
            
            // Переводим часы.
            timer1.Stop();
            timer1.Interval = Min * 60000;
            timer1.Start();
        }


        // Пункт меню help>hotkeys с горячими клавишами.
        private void faqStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ctl + N - new file\nctl + O - open file\nctl + S - save file\n" +
                "ctl + Z - undo\nctl + shift + Z - redo(undo your undo)\nctl + X - cut(e)\n" +
                "ctl + C - copy\nctl + V - paste\nctl + A - save everything\n" +
                "ctl + W - new window\nescape - exit\n", "hotkeys");
        }

        // Пункт меню help>about author с нытьем.
        private void aboutStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я ненавижу виндовс формы и все что с ними связано. Этот пир снова был написан на виртуалке которая съела все" +
                " место на моем компе (в топе самый жадных людей она идет сразу после сами знаете кого).\n" +
                "Чтобы сыграть душевнобольного человека, Хоакин Феникс 2 недели угадывал шорткаты на винде(я до сих пор не знаю как ставить точку на русской раскладке).\n\n" +
                "Доп функционал:\n- сtrl + z\n- открывает.cs файлы\n- разработчик не вышел в окно после двух недель на винде(бадум-тсс)", "анонимное нытье");
        }


    }
}
