using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace texteditor
{
    // Маленькая но удаленькая форма для выбора интервала автосейва.
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void SetValue(int val)
        {
            label1.Text = val.ToString() + " min";
            trackBar1.Value = val;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        // При нажатии на кнопку закрываем форму.
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Min = trackBar1.Value;
            this.Close();
        }

        // Выводим значение трекбара.
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.Min = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString()+ " min";
        }
    }
}
