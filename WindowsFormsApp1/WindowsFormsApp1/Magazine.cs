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
        List<ClassArray<IInstrument>> magazineStages;
        ClassArray<IInstrument> magazine;
        int countPlaces = 12;
        int placeSizeWidth = 210;
        int placeSizeHeight = 120;
        int currentLevel;

        public int GetcurrentLevel { get { return currentLevel; } }

        public Magazine(int countStages)
        {
            magazineStages = new List<ClassArray<IInstrument>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                magazine = new ClassArray<IInstrument>(countPlaces, null);
                magazineStages.Add(magazine);
            }


        }

        public void LevelUp()
        {
            if (currentLevel + 1 < magazineStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }

        }

        public int PutSaxophoneInMagazine(IInstrument Saxophone)
        {
            return magazineStages[currentLevel] + Saxophone;

        }

        public IInstrument GetSaxophoneInMagazine(int ticket)
        {
            return magazineStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var Saxophone = magazineStages[currentLevel][i];
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
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Black), (countPlaces / 4) * placeSizeWidth - 80, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 4) * placeSizeWidth - 100, 480);
            for (int i = 0; i < countPlaces / 4; i++)
            {
                for (int j = 0; j < 4; ++j) 
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 4)
                    {

                        g.DrawString((i * 4 + j).ToString(), new Font("Arial", 30), new SolidBrush(Color.Black), i * placeSizeWidth + 60, j * placeSizeHeight + 0);

                    }
                }
                g.DrawLine(pen, i * placeSizeWidth + 110, 0, i * placeSizeWidth + 110, 400);
            }
        }
    }
}
