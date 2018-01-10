using NLog;
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
        FormSelectTr form;
        private Logger log;

        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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
            log.Info("переход на уровень ниже. Текущий уровень" + magazine.GetcurrentLevel);
            Draw();

        }

        private void LevelUp_Click(object sender, EventArgs e)
        {
            magazine.LevelUp();
            listBoxLevels.SelectedIndex = magazine.GetcurrentLevel;
            log.Info("переход на уровень выше. Текущий уровень" + magazine.GetcurrentLevel);
            Draw();

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
                    try
                    {
                        IInstrument wind_Musical_Instrument = magazine.GetSaxophoneInMagazine(Convert.ToInt32(maskedTextBox1.Text));
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        wind_Musical_Instrument.SetPosition(15, 25);
                        wind_Musical_Instrument.Draw_Wind_Instrument(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                        log.Info("куплен объект с места №" + Convert.ToInt32(maskedTextBox1.Text));
                    }
                    catch (MagazineIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Info("произошла ошибка. неправильно введенный номер места");
                    }
                }
               
            }
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            form = new FormSelectTr();
            form.AddEvent(addInstrument);
            log.Info("Открытие нового окна, для выполнения заказа");
            form.Show();

        }

        private void addInstrument(IInstrument wind_Musical_Instrument)
        {
            if (wind_Musical_Instrument != null)
            {
                try
                {
                    int place = magazine.PutSaxophoneInMagazine(wind_Musical_Instrument);
                    Draw();
                    MessageBox.Show("Ваше место " + place);
                    log.Info("добавили элемент на место №" + place);
                }
                catch (MagazineOverFlowException ex) {
                    MessageBox.Show(ex.Message, "Ошибка переполнения ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("произошла ошибка переполнения");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (magazine.LoadData(openFileDialog1.FileName))
                {
                    log.Info("загрузка из файла");
                    MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    log.Info("загрузка из файла не свершилась");
                    MessageBox.Show("не загрузилось :((((", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (magazine.SaveData(saveFileDialog1.FileName))
                {
                    log.Info("coхранение в файл");
                    MessageBox.Show("Сохранение прошло успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    log.Info("попытка сохранения в файл не свершилась");
                    MessageBox.Show("не сохранилось :((((", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Sort_Click(object sender, EventArgs e)
        {
            magazine.Sort();
        }
    }
}
