using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public  interface IInstrument // обычный инструмент
    {

        void SetPosition(int x, int y );

        void Draw_Wind_Instrument(Graphics g);

        // инструмент  нужен что бы что то с ним делать 
         void DrawDoing (Graphics g) ;


        ///громкость в децибелах
        void Volume (int x);

        int  GetVolume();


    }
}
