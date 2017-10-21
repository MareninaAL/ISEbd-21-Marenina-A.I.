using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public  interface IInstrument 
    {

        void SetPosition(int x, int y );

        void Draw_Wind_Instrument(Graphics g);
        
         void DrawDoing (Graphics g) ;


       
        void Volume (int x);

        int  GetVolume();


    }
}
