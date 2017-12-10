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
    public partial class FormSelectTr : Form
    {

        public delegate void myDel(IInstrument Wind_Musical_Instrument);
        IInstrument wind_Musical_Instrument = null;
        public IInstrument getWind_Musical_Instrument { get { return wind_Musical_Instrument; } }

        private event myDel EventAddwind_Musical_Instrument;

        public void AddEvent(myDel ev)
        {
            if (EventAddwind_Musical_Instrument == null)
            {
                EventAddwind_Musical_Instrument = new myDel(ev);
            }
            else
            {
                EventAddwind_Musical_Instrument += ev;
            }
        }

        public FormSelectTr()
        {
               InitializeComponent();
            Cancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void Drawwind_Musical_Instrument()
        {
            if (wind_Musical_Instrument != null)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                wind_Musical_Instrument.SetPosition(65, 40);
                wind_Musical_Instrument.Draw_Wind_Instrument(gr);
                pictureBox2.Image = bmp;
            }
        }

        private void lableSaxophone_MouseDown(object sender, MouseEventArgs e)
        {
            label_Saxophone.DoDragDrop(label_Saxophone.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void lableTrumpet_MouseDown(object sender, MouseEventArgs e)
        {
            label_Trumpet.DoDragDrop(label_Trumpet.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void panel1_dragdrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Trumpet":
                    wind_Musical_Instrument = new Wind_Musical_Instrument(1500, Color.Black, 10000, 35);

                    break;
                case "Saxophone":
                    wind_Musical_Instrument = new Saxophone(150, Color.Black, Color.Pink, 10000, 40, true, true, true);
                    break;
            }

            Drawwind_Musical_Instrument();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (wind_Musical_Instrument != null)
            {
                wind_Musical_Instrument.setMainColor((Color)e.Data.GetData(typeof(Color)));
                Drawwind_Musical_Instrument();
            }
        }



        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (wind_Musical_Instrument != null)
            {

                if (wind_Musical_Instrument is Saxophone)
                {
                    (wind_Musical_Instrument as Saxophone).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Drawwind_Musical_Instrument();
                }

            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if (EventAddwind_Musical_Instrument != null)
            {
                EventAddwind_Musical_Instrument(wind_Musical_Instrument);
            }
            Close();
        }

    }
}
