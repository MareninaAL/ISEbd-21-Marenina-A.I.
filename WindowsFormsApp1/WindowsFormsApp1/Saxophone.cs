using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public class Saxophone : Wind_Musical_Instrument, IComparable<Saxophone>, IEquatable<Wind_Musical_Instrument>
    {
        public int CompareTo(Saxophone other)
        {
            var res = (this is Wind_Musical_Instrument).CompareTo(other is Wind_Musical_Instrument);
            if (res != 0)
            {
                return res;
            }
            if (dopColor != other.dopColor)
            {
                return dopColor.Name.CompareTo(other.dopColor.Name);
            }
            if (Colorbody != other.Colorbody)
            {
                return Colorbody.Name.CompareTo(other.Colorbody.Name);
            }
            if (button != other.button)
            {
                return button.CompareTo(other.button);
            }
            if (bend != other.bend)
            {
                return bend.CompareTo(other.bend);
            }

            if (mouthpiece != other.mouthpiece)
            {
                return mouthpiece.CompareTo(other.mouthpiece);
            }
            return 0;
        }

        public bool Equals(Saxophone other)
        {
            var res = (this is Wind_Musical_Instrument).Equals(other is Wind_Musical_Instrument);
            if (!res)
            {
                return res;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            if (Colorbody != other.Colorbody)
            {
                return false;
            }
            if (button != other.button)
            {
                return false;
            }
            if (bend != other.bend)
            {
                return false;
            }

            if (mouthpiece != other.mouthpiece)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Saxophone Wind_Musical_Instrument_obj = obj as Saxophone;
            if (Wind_Musical_Instrument_obj == null)
            {
                return false;
            }
            else
            {
                return Equals(Wind_Musical_Instrument_obj);
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        private Color dopColor;
        private bool button ;
        private bool bend; 
        private bool mouthpiece; 

        public Saxophone(double Weight, Color color, Color dopColor, int Price, int MaxCountVolume,  bool bend, bool button, bool mouthpiece) : base(Weight, color, Price, MaxCountVolume)
        {
            this.dopColor = dopColor; 
            this.bend = bend;
            this.button = button;
            this.mouthpiece = mouthpiece; 
        }

        public Saxophone(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                Weight = Convert.ToInt32(strs[0]);
                Colorbody = Color.FromName(strs[1]);
                Price = Convert.ToInt32(strs[2]);
                MaxCountVolume = Convert.ToInt32(strs[3]);
                dopColor = Color.FromName(strs[4]);
                bend = Convert.ToBoolean(strs[5]);
                button = Convert.ToBoolean(strs[6]);
                mouthpiece = Convert.ToBoolean(strs[7]);
            }
        }

        public override string GetInfo()
        {
            return Weight + ";" + Colorbody.Name + ";" + Price + ";" + MaxCountVolume + ";"
                 + dopColor.Name + ";" + bend + ";" + button + ";" + mouthpiece;
        }

        public void SetDopColor(Color color)
        {
            dopColor = color;
        }


        protected override void DrawTrumpet(Graphics g)
        {
          
            base.DrawTrumpet(g);

           
            if (bend)
            {
                
                Pen pen = new Pen(Color.Black);
                g.DrawLine(pen, startPosX , startPosY+50, startPosX , startPosY + 80);
                g.DrawArc(pen, startPosX, startPosY + 50, 45, 65,30,180);
                g.DrawLine(pen, startPosX+43, startPosY + 94, startPosX+43, startPosY + 75);
                g.DrawEllipse(pen, startPosX + 16, startPosY + 65, 28, 15);
                g.DrawLine(pen, startPosX + 12, startPosY + 60, startPosX + 12, startPosY + 85);
                g.DrawLine(pen, startPosX + 12, startPosY + 85, startPosX + 15, startPosY + 70);


            }

            if (button)
            {
                

                 Brush spoiler = new SolidBrush(dopColor); 
                g.FillEllipse(spoiler, startPosX +2, startPosY + 15 , 7 , 7);
                g.FillEllipse(spoiler, startPosX + 2, startPosY + 29, 7, 7);
                g.FillEllipse(spoiler, startPosX + 2, startPosY + 41, 7, 7);
                g.FillEllipse(spoiler, startPosX + 9, startPosY + 15, 7, 7);
                g.FillEllipse(spoiler, startPosX + 9, startPosY + 29, 7, 7);
                g.FillEllipse(spoiler, startPosX + 9, startPosY + 41, 7, 7);

                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, startPosX + 2, startPosY + 15, 8, 8);
                g.DrawEllipse(pen, startPosX + 2, startPosY + 29, 8, 8);
                g.DrawEllipse(pen, startPosX + 2, startPosY + 41, 8, 8);
                g.DrawEllipse(pen, startPosX + 9, startPosY + 15, 8, 8);
                g.DrawEllipse(pen, startPosX + 9, startPosY + 29, 8, 8);
                g.DrawEllipse(pen, startPosX + 9, startPosY + 41, 8, 8);
            }

            if (mouthpiece)
            {
                Pen pen = new Pen(Color.Black);

                g.DrawLine(pen, startPosX+2 , startPosY -7 , startPosX -7, startPosY-23 );
                g.DrawLine(pen, startPosX+8, startPosY-7, startPosX - 7, startPosY - 30);
            }

        }
    }


}
