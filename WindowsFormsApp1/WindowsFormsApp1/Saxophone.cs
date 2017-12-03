using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public class Saxophone : Wind_Musical_Instrument
    {
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
