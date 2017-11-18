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
        Magazine magazine;

        public Form1()
        {
            InitializeComponent();
            magazine = new Magazine(4);
            for (int i = 1; i < 5; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = magazine.GetcurrentLevel;
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                magazine.Draw(gr, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }
        }


        private void LevelDown_Click(object sender, EventArgs e)
        {
            magazine.LevelDown();
            listBoxLevels.SelectedIndex = magazine.GetcurrentLevel;
            Draw();

        }

        private void LevelUp_Click(object sender, EventArgs e)
        {
            magazine.LevelUp();
            listBoxLevels.SelectedIndex = magazine.GetcurrentLevel;
            Draw();

        }

        private void SetTrumpet_Click_1(object sender, EventArgs e)
        {
     
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var wind_Musical_Instrument = new Wind_Musical_Instrument(1500, dialog.Color, 10000, 35);
                int place = magazine.PutSaxophoneInMagazine(wind_Musical_Instrument);
                Draw();
                MessageBox.Show("Место полки : " + place);
            }
        }


      


        private void SetSaxophone_Click_1(object sender, EventArgs e)
        {
   
            ColorDialog dialogDop = new ColorDialog();
            if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var wind_Musical_Instrument = new Saxophone(150, Color.Black, dialogDop.Color, 10000, 40, true, true, true);
                int place = magazine.PutSaxophoneInMagazine(wind_Musical_Instrument);
                Draw();
                MessageBox.Show("Место полки: " + place);
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                String level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    IInstrument wind_Musical_Instrument = magazine.GetSaxophoneInMagazine(Convert.ToInt32(maskedTextBox1.Text));
                    if (wind_Musical_Instrument != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        wind_Musical_Instrument.SetPosition(15, 25);
                        wind_Musical_Instrument.Draw_Wind_Instrument(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("пустое место");
                    }
                }
               
            }
        }
    }
}
