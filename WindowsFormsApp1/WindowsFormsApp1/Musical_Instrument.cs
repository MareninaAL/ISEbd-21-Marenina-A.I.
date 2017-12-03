using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Musical_Instrument : IInstrument
    {

        protected float startPosY; 
        protected float startPosX;

        protected int countVolume; 

        public abstract void Draw_Wind_Instrument(Graphics g);

        public abstract void DrawDoing(Graphics g);


        public void SetPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public virtual double Weight { protected set; get;  } 

        public Color Colorbody { protected set; get; } 
        

        public virtual double Price { protected set; get; } 

        public virtual double MaxCountVolume { protected set; get; }


        public void Volume(int count )
        {
           if (countVolume + count < MaxCountVolume)
            {
                countVolume += count; 
            }
        }


        public int GetVolume()
        {
            int count = countVolume;
            countVolume = 0;
            return count; 
        }

        public virtual void setMainColor(Color color)
        {

            Colorbody = color;
        }

    }
}
