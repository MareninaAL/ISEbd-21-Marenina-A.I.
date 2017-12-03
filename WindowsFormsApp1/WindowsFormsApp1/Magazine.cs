using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Magazine
    {
        ClassArray<IInstrument> magazine;
        int countPlaces = 12;
        int placeSizeWidth = 210;
        int placeSizeHeight = 120;

        public Magazine()
        {
            magazine = new ClassArray<IInstrument>(countPlaces, null);
        }

        public int PutSaxophoneInMagazine(IInstrument Saxophone)
        {
            return magazine + Saxophone;

        }

        public IInstrument GetSaxophoneInMagazine(int ticket)
        {
            return magazine - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var Saxophone = magazine.getObject(i);
                if (Saxophone != null)
                {
                    Saxophone.SetPosition(4 + i / 4 * placeSizeWidth + 30, i % 4 * placeSizeHeight + 20);

                    Saxophone.Draw_Wind_Instrument(g);
                }
            }


        }

        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 4) * placeSizeWidth - 100, 480);
            for (int i = 0; i < countPlaces / 4; i++)
            {
                for (int j = 0; j < 4; ++j) // кол во полок 
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth + 110, 0, i * placeSizeWidth + 110, 400);
            }
        }
    }
}
