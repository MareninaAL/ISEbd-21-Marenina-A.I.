using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes
                        ("CountLeveles:" + magazineStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in magazineStages)
                    {
                        info = new UTF8Encoding(true).GetBytes
                        ("Level:" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var wind_Musical_Instrument = level[i];
                            if (wind_Musical_Instrument != null)
                            {
                                if (wind_Musical_Instrument.GetType().Name == "Wind_Musical_Instrument")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Trumpet:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (wind_Musical_Instrument.GetType().Name == "Saxophone")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Saxophone:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(wind_Musical_Instrument.GetInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);

                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (magazineStages != null)
                    {
                        magazineStages.Clear();
                    }
                    magazineStages = new List<ClassArray<IInstrument>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 0; i < strs.Length; ++i)
                {

                    if (strs[i] == "Level:")
                    {
                        counter++;
                        magazineStages.Add(new ClassArray<IInstrument>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Trumpet")
                    {
                        IInstrument wind_Musical_Instrument = new Wind_Musical_Instrument(strs[i].Split(':')[1]);
                        int number = magazineStages[counter] + wind_Musical_Instrument;
                        if (number == -1)
                        {
                            return false;
                        }

                    }
                    else if (strs[i].Split(':')[0] == "Saxophone")
                    {
                        IInstrument wind_Musical_Instrument = new Saxophone(strs[i].Split(':')[1]);
                        int number = magazineStages[counter] + wind_Musical_Instrument;
                        if (number == -1)
                        {
                            return false;
                        }

                    }
                }
            }

            return true;
        }
    }
}
