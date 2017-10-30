using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Plov
{
    public partial class Form1 : Form
    {

        private WaterTap waterTap;
        private Knife knife;
        private Pan pan;
        private Stove stove;

        private Onion[] onion;
        private Rice[] rice;
        private Meat[] meat;
        private Carrot[] carrot;
        private Water water;
        private Salt salt;
        private Oil oil;



        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            salt = new Salt();
            oil = new Oil();
            water = new Water();
            addWater.Enabled = false;
            addRice.Enabled = false;
        } 

        private void button1_Click(object sender, EventArgs e)
        {

            onion = new Onion[Convert.ToInt32(numeric_onion.Value)];
            for (int i = 0; i < onion.Length; ++i)
            {
                onion[i] = new Onion();
                numeric_onion.Enabled = false;
                
            }


            meat = new Meat[Convert.ToInt32(numeric_meat.Value)];
            for (int i = 0; i < meat.Length; ++i)
            {
                meat[i] = new Meat();

                numeric_meat.Enabled = false;
            }

            carrot = new Carrot[Convert.ToInt32(numeric_carrot.Value)];
            for (int i = 0; i < carrot.Length; ++i)
            {
                carrot[i] = new Carrot();

                numeric_carrot.Enabled = false;
            }

            rice = new Rice[Convert.ToInt32(numeric_rice.Value)];
            for (int i = 0; i < rice.Length; ++i)
            {
                rice[i] = new Rice();

                numeric_rice.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterTapOpen.Checked)
            {
                waterTap.State = true;
            }
        }

        private void WaterTapClose_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterTapClose.Checked)
            {
                waterTap.State = false;
            }
        }

        private void wash_onion_Click(object sender, EventArgs e)
        {
            if (numeric_onion.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
                for (int i = 0; i < onion.Length; ++i)
                {
                    onion[i].Dirty = false;
                }
                
                WaterTapClose.Checked = true;
                MessageBox.Show("лук помыли, можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("лука то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void wash_meat_Click(object sender, EventArgs e)
        {
            if (numeric_meat.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < meat.Length; ++i)
                {
                    meat[i].Dirty = false;
                }

                WaterTapClose.Checked = true;
                MessageBox.Show("мясо помыли, можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("мяса то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wash_carrot_Click(object sender, EventArgs e)
        {
            if (numeric_carrot.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < carrot.Length; ++i)
                {
                    carrot[i].Dirty = false;
                }
                WaterTapClose.Checked = true;
                MessageBox.Show("морковь помыли, можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("моркови то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Wash_rice_Click(object sender, EventArgs e)
        {
            if (numeric_rice.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < rice.Length; ++i)
                {
                    rice[i].Dirty = false;
                }

                WaterTapClose.Checked = true;
                MessageBox.Show("рис помыли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("риса то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cut_onion_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("лука нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("лука нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < onion.Length; ++i)
            {
                if (onion[i].Dirty)
                {
                    MessageBox.Show("лук грязный", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!onion[i].Has_Сut)
                {
                    MessageBox.Show("лук уже порезан ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                knife.Сut_onion(onion[i]);

            }
            MessageBox.Show("лук порезан, можно жарить", "", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void cut_carrot_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("моркови нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("моркови нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                if (carrot[i].Dirty)
                {
                    MessageBox.Show("морковь грязная", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!carrot[i].Has_Сut)
                {
                    MessageBox.Show("морковь уже порезана ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                knife.Сut_carrot(carrot[i]);

            }
            MessageBox.Show("лук порезана, можно жарить", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cut_meat_Click(object sender, EventArgs e)
        {
            if (meat == null)
            {
                MessageBox.Show("мяса нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (meat.Length == 0)
            {
                MessageBox.Show("мяса нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < meat.Length; ++i)
            {
                if (meat[i].Dirty)
                {
                    MessageBox.Show("мясо грязное", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!meat[i].Has_Сut)
                {
                    MessageBox.Show("мясо уже порезано ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                knife.Cut_meat(meat[i]);

            }
            MessageBox.Show("мясо порезано, можно жарить", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox_StoveOn_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox_StoveOn.Checked)
                {
                    MessageBox.Show("Плита включена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stove.State = true;
                } 
                else {
                MessageBox.Show("Плита выключена", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void checkBox_Salt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Salt.Checked)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Солим", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox_Oil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Oil.Checked)
            {
                pan.AddOil(oil);
                MessageBox.Show("Наливаем масло", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddMeat_Click(object sender, EventArgs e)
        {
            if (meat == null)
            {
                MessageBox.Show("мяса нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (meat.Length == 0)
            {
                MessageBox.Show("мяса нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < meat.Length; ++i)
            {
                if (meat[i].Dirty)
                {
                    MessageBox.Show("мясо грязное", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (meat[i].Has_Сut)
                {
                    MessageBox.Show("мясо не порезали", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            pan.Init_Meat(meat.Length);
            for (int i = 0; i < meat.Length; ++i)
            {
             
                pan.AddMeat(meat[i]);
            }
            MessageBox.Show("Мясо в сковородке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

     

        private void AddCarrot_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("Морковь отсутствует ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("Моркови нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                if (carrot[i].Dirty)
                {
                    MessageBox.Show("Морковь грязная", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (carrot[i].Has_Сut)
                {
                    MessageBox.Show("Морковь не порезали", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
                pan.Init_Carrot(carrot.Length);

            for (int i = 0; i < carrot.Length; ++i)
            {

                pan.AddCarrot(carrot[i]);
            }
            MessageBox.Show("морковь в сковородке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddOnion_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("лук отсутствует ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("лука нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < onion.Length; ++i)
            {
                if (onion[i].Dirty)
                {
                    MessageBox.Show("лук грязный", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (onion[i].Has_Сut)
                {
                    MessageBox.Show("лук не порезали", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            pan.Init_Onion(onion.Length);
            for (int i = 0; i < onion.Length; ++i)
            {

                pan.AddOnion(onion[i]);
            }
            MessageBox.Show("Лук в сковородке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       


        private void button14_Click(object sender, EventArgs e)
        
        {
            if (stove.State)
            {
                stove.Pan = pan;

                if (pan.Check1())
                {
                        stove.Cooking();
                    MessageBox.Show("всё ок, потушили! готово!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addRice.Enabled = true;
                    addWater.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("не все составляющие добавлены на сковороду!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            } else 
                {
                MessageBox.Show("надо включить плиту!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
           
        }


        private void AddRice_Click(object sender, EventArgs e)
        {
            if (rice == null)
            {
                MessageBox.Show("рис отсутствует ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (rice.Length == 0)
            {
                MessageBox.Show("риса нет ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            for (int i = 0; i < rice.Length; ++i)
            {
                if (rice[i].Dirty)
                {
                    MessageBox.Show("рис грязный", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            pan.Init_Rice(rice.Length);
            for (int i = 0; i < rice.Length; ++i)
            {

                pan.AddRice(rice[i]);
            }
            MessageBox.Show("рис в сковородке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddWater_Click(object sender, EventArgs e)
        {
            if (waterTap.State)
            {
                pan.AddWater(water);
               
                MessageBox.Show("добавили воду", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else if (!waterTap.State)
            {
                MessageBox.Show("надо открыть кран ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cook2_Click(object sender, EventArgs e)
        {

            if (stove.State)
            {
                if (pan.Check2())
                {
                    stove.Cooking();
                    MessageBox.Show("готово!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("чего то не хватает, проверь!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
                MessageBox.Show("надо включить плиту!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
