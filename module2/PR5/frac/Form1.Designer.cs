
namespace frac
{
    // Я здесь ничего не трогала и вы не трогайте.
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(157, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 784);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1463, 632);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Множество Кантора";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1431, 534);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(348, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Треугольник Серпинского";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1471, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ковер Серпинского";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1490, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Кривая Коха";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1473, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обдуваемое ветром фрактальное дерево";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(227, 816);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(332, 90);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(599, 816);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(334, 39);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Уровень рекурсии";
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 888);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "Чтобы перерисовать нажмите на\r\n кнопку отрисовки еще раз";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1745, 1094);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 70);
            this.button6.TabIndex = 9;
            this.button6.Text = "help";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(953, 816);
            this.trackBar2.Maximum = 90;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(332, 90);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Value = 45;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1291, 816);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(334, 39);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Угол1 = ";
            //this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 909);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1291, 912);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(334, 39);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Угол2 = ";
            //this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(953, 912);
            this.trackBar3.Maximum = 90;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(332, 90);
            this.trackBar3.TabIndex = 13;
            this.trackBar3.Value = 45;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1291, 998);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(334, 39);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "Длина = ";
            //this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(953, 998);
            this.trackBar4.Maximum = 300;
            this.trackBar4.Minimum = 10;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(332, 90);
            this.trackBar4.TabIndex = 16;
            this.trackBar4.Value = 150;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(944, 995);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 15;
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1291, 1094);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(360, 39);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Соотношение отрезков = ";
            //this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(953, 1094);
            this.trackBar5.Maximum = 75;
            this.trackBar5.Minimum = 50;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(332, 90);
            this.trackBar5.TabIndex = 19;
            this.trackBar5.Value = 55;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(944, 1091);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(253, 980);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(270, 46);
            this.button7.TabIndex = 21;
            this.button7.Text = "спасти и сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1240);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Как же я ненавижу фракталы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
    }
}

