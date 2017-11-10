using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Color color;
        Color dopColor;
        int Weight;
        int Price;
        int MaxCountVolume; 

        private IInstrument inst;


        public Form1()
        {
            InitializeComponent();
            color = Color.Gray;
            dopColor = Color.Yellow;
            Weight = 1500;
             Price = 15000; // цена 15 000 
            MaxCountVolume = 70; // максимум децибел 70
            DopColorButton.BackColor = dopColor;
            buttonSelectColor.BackColor = color;
        }

        private bool checkFields()
        {

            if (!int.TryParse(TextBoxWeight.Text, out Weight) /*|| weight<100*/)
            {
                return false;
            }
            if (!int.TryParse(TextBoxPrice.Text, out Price))
            {
                return false;
            }
            if (!int.TryParse(textBoxMaxVolume.Text, out MaxCountVolume))
            {
                return false;
            }
            return true;
        }

        private void newColorButton_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               dopColor = cd.Color;
                DopColorButton.BackColor = dopColor;
            }
        }


        private void button1_Click(object sender, EventArgs e) //buttonSelectDopColor
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;

            }

        }

        private void SetTrumpet_Click_1(object sender, EventArgs e)// труба (картинка без изменений)
        {
            if (checkFields())
            {
                inst = new Wind_Musical_Instrument(Weight, color, Price, MaxCountVolume);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inst.Draw_Wind_Instrument(gr);
                pictureBox1.Image = bmp;
            }
        }


      


        private void SetSaxophone_Click_1(object sender, EventArgs e)//саксофон(картинк с изменениями)
        {
            if (checkFields())
            {
                inst = new Saxophone(Weight, color, dopColor, Price, MaxCountVolume,  checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inst.Draw_Wind_Instrument(gr);
                pictureBox1.Image = bmp;
            }
        }



       

        private void Sound_Click(object sender, EventArgs e) // появление звука
        {
            if (inst != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inst.DrawDoing(gr);
                pictureBox1.Image = bmp;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inst = new Saxophone(150, Color.Black, Color.Yellow, 10000, 40, true, true, true);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inst.Draw_Wind_Instrument(gr);
            pictureBox1.Image = bmp;
        }
    }
}
