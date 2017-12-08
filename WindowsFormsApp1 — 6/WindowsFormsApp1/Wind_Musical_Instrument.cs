using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public  class Wind_Musical_Instrument : Musical_Instrument
    {
                    public override double  Weight
                    {
                      get
                        {
                return base.Weight;
                        }
                        protected set
                        {
                if (value >500 && value <1500)
                {
                    base.Weight = value;
                } else
                {
                     base.Weight=1500;
                }

                        }
                    }

        public override double Price
        {
            get
            {
                return base.Price;
            }
            protected set
            {
                if (value > 5000 && value < 15001)
                {
                    base.Price = value;
                }
                else
                {
                    base.Price = 15000;
                }

            }
        }

        public override double MaxCountVolume 
        {
            get
            {
                return base.MaxCountVolume;
            }
            protected set
            {
                if (value > 35 && value < 71)
                {
                    base.MaxCountVolume = value;
                }
                else
                {
                    base.MaxCountVolume =70;
                }

            }
        }

       

        public Wind_Musical_Instrument (double Weight, Color color, double Price, int MaxCountVolume)
        {
            this.Weight = Weight;
            this.Colorbody = color;
            this.Price = Price;
            this.MaxCountVolume = MaxCountVolume; 
            Random rand = new Random(); 
            startPosX = rand.Next(30,310); 
             startPosY = rand.Next(30, 180);

        }

        public Wind_Musical_Instrument(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                Weight = Convert.ToInt32(strs[0]);
                Colorbody = Color.FromName(strs[1]);
                Price = Convert.ToInt32(strs[2]);
                MaxCountVolume = Convert.ToInt32(strs[3]);
            }
            Random rand = new Random();
            startPosX = rand.Next(30, 310);
            startPosY = rand.Next(30, 180);
        }

        public override string GetInfo()
        {
            return Weight + ";" + Colorbody.Name + ";"
                + Price + ";" + MaxCountVolume;
        }

        public override void DrawDoing(Graphics g) //
        {
            
            Brush spoiler = new SolidBrush(Color.Black);
            g.FillEllipse(spoiler, startPosX + 60, startPosY, 11, 11);
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, startPosX+70, startPosY-25, startPosX+70, startPosY );
            g.DrawLine(pen, startPosX + 70, startPosY - 25, startPosX + 75, startPosY-25);


            g.DrawLine(pen, startPosX + 90, startPosY + 12, startPosX + 90, startPosY - 10);
            g.DrawLine(pen, startPosX + 90, startPosY - 10, startPosX + 100, startPosY - 10);
            g.DrawLine(pen, startPosX + 100, startPosY - 10, startPosX + 100, startPosY + 18);
            g.FillEllipse(spoiler, startPosX + 80, startPosY+10, 11, 11);
            g.FillEllipse(spoiler, startPosX + 94, startPosY + 10, 11, 11);


            Draw_Wind_Instrument(g);
        }

        public override void Draw_Wind_Instrument(Graphics g)
        {
            DrawTrumpet(g); 
        }



        protected virtual void DrawTrumpet(Graphics g)
        {
            
           Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, startPosX, startPosY, startPosX+2, startPosY-7);
            g.DrawLine(pen, startPosX+10, startPosY, startPosX + 8, startPosY - 7);

            g.DrawLine(pen, startPosX, startPosY, startPosX, startPosY+45);
            g.DrawLine(pen, startPosX+10, startPosY, startPosX+10, startPosY + 45);

            g.DrawLine(pen, startPosX, startPosY+45, startPosX-7, startPosY + 51);
            g.DrawLine(pen, startPosX + 10, startPosY+45, startPosX + 18, startPosY + 51);
            Brush spoiler = new SolidBrush(Colorbody); 
            g.FillEllipse(spoiler, startPosX-7, startPosY+49, 25, 8);
        }

    }
}
