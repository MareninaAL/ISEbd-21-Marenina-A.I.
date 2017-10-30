namespace Laba1Plov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeric_onion = new System.Windows.Forms.NumericUpDown();
            this.numeric_carrot = new System.Windows.Forms.NumericUpDown();
            this.numeric_rice = new System.Windows.Forms.NumericUpDown();
            this.Buy = new System.Windows.Forms.Button();
            this.groupBoxMagazine = new System.Windows.Forms.GroupBox();
            this.label_meat = new System.Windows.Forms.Label();
            this.numeric_meat = new System.Windows.Forms.NumericUpDown();
            this.label_rice = new System.Windows.Forms.Label();
            this.label_carrot = new System.Windows.Forms.Label();
            this.label_onion = new System.Windows.Forms.Label();
            this.groupBoxKnife = new System.Windows.Forms.GroupBox();
            this.cut_meat = new System.Windows.Forms.Button();
            this.cut_carrot = new System.Windows.Forms.Button();
            this.cut_onion = new System.Windows.Forms.Button();
            this.groupBoxWaterTap = new System.Windows.Forms.GroupBox();
            this.WaterTapClose = new System.Windows.Forms.RadioButton();
            this.wash_onion = new System.Windows.Forms.Button();
            this.WaterTapOpen = new System.Windows.Forms.RadioButton();
            this.wash_rice = new System.Windows.Forms.Button();
            this.wash_carrot = new System.Windows.Forms.Button();
            this.wash_meat = new System.Windows.Forms.Button();
            this.groupBoxStove = new System.Windows.Forms.GroupBox();
            this.checkBox_StoveOn = new System.Windows.Forms.CheckBox();
            this.Cook2 = new System.Windows.Forms.Button();
            this.Cook1 = new System.Windows.Forms.Button();
            this.groupBoxPan = new System.Windows.Forms.GroupBox();
            this.checkBox_Oil = new System.Windows.Forms.CheckBox();
            this.checkBox_Salt = new System.Windows.Forms.CheckBox();
            this.label_add = new System.Windows.Forms.Label();
            this.addMeat = new System.Windows.Forms.Button();
            this.addCarrot = new System.Windows.Forms.Button();
            this.addWater = new System.Windows.Forms.Button();
            this.addRice = new System.Windows.Forms.Button();
            this.addOnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_onion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_carrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_rice)).BeginInit();
            this.groupBoxMagazine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_meat)).BeginInit();
            this.groupBoxKnife.SuspendLayout();
            this.groupBoxWaterTap.SuspendLayout();
            this.groupBoxStove.SuspendLayout();
            this.groupBoxPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeric_onion
            // 
            this.numeric_onion.Location = new System.Drawing.Point(12, 17);
            this.numeric_onion.Name = "numeric_onion";
            this.numeric_onion.Size = new System.Drawing.Size(53, 20);
            this.numeric_onion.TabIndex = 0;
            // 
            // numeric_carrot
            // 
            this.numeric_carrot.Location = new System.Drawing.Point(12, 43);
            this.numeric_carrot.Name = "numeric_carrot";
            this.numeric_carrot.Size = new System.Drawing.Size(53, 20);
            this.numeric_carrot.TabIndex = 1;
            // 
            // numeric_rice
            // 
            this.numeric_rice.Location = new System.Drawing.Point(12, 69);
            this.numeric_rice.Name = "numeric_rice";
            this.numeric_rice.Size = new System.Drawing.Size(53, 20);
            this.numeric_rice.TabIndex = 2;
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(73, 140);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(137, 27);
            this.Buy.TabIndex = 3;
            this.Buy.Text = "покупка";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxMagazine
            // 
            this.groupBoxMagazine.Controls.Add(this.label_meat);
            this.groupBoxMagazine.Controls.Add(this.numeric_meat);
            this.groupBoxMagazine.Controls.Add(this.label_rice);
            this.groupBoxMagazine.Controls.Add(this.label_carrot);
            this.groupBoxMagazine.Controls.Add(this.label_onion);
            this.groupBoxMagazine.Controls.Add(this.Buy);
            this.groupBoxMagazine.Controls.Add(this.numeric_rice);
            this.groupBoxMagazine.Controls.Add(this.numeric_carrot);
            this.groupBoxMagazine.Controls.Add(this.numeric_onion);
            this.groupBoxMagazine.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMagazine.Name = "groupBoxMagazine";
            this.groupBoxMagazine.Size = new System.Drawing.Size(216, 174);
            this.groupBoxMagazine.TabIndex = 4;
            this.groupBoxMagazine.TabStop = false;
            this.groupBoxMagazine.Text = "магазин";
            // 
            // label_meat
            // 
            this.label_meat.AutoSize = true;
            this.label_meat.Location = new System.Drawing.Point(98, 97);
            this.label_meat.Name = "label_meat";
            this.label_meat.Size = new System.Drawing.Size(33, 13);
            this.label_meat.TabIndex = 8;
            this.label_meat.Text = "мясо";
            // 
            // numeric_meat
            // 
            this.numeric_meat.Location = new System.Drawing.Point(12, 95);
            this.numeric_meat.Name = "numeric_meat";
            this.numeric_meat.Size = new System.Drawing.Size(53, 20);
            this.numeric_meat.TabIndex = 7;
            // 
            // label_rice
            // 
            this.label_rice.AutoSize = true;
            this.label_rice.Location = new System.Drawing.Point(98, 76);
            this.label_rice.Name = "label_rice";
            this.label_rice.Size = new System.Drawing.Size(25, 13);
            this.label_rice.TabIndex = 6;
            this.label_rice.Text = "рис";
            // 
            // label_carrot
            // 
            this.label_carrot.AutoSize = true;
            this.label_carrot.Location = new System.Drawing.Point(98, 50);
            this.label_carrot.Name = "label_carrot";
            this.label_carrot.Size = new System.Drawing.Size(51, 13);
            this.label_carrot.TabIndex = 5;
            this.label_carrot.Text = "морковь";
            // 
            // label_onion
            // 
            this.label_onion.AutoSize = true;
            this.label_onion.Location = new System.Drawing.Point(98, 19);
            this.label_onion.Name = "label_onion";
            this.label_onion.Size = new System.Drawing.Size(24, 13);
            this.label_onion.TabIndex = 4;
            this.label_onion.Text = "лук";
            // 
            // groupBoxKnife
            // 
            this.groupBoxKnife.Controls.Add(this.cut_meat);
            this.groupBoxKnife.Controls.Add(this.cut_carrot);
            this.groupBoxKnife.Controls.Add(this.cut_onion);
            this.groupBoxKnife.Location = new System.Drawing.Point(234, 12);
            this.groupBoxKnife.Name = "groupBoxKnife";
            this.groupBoxKnife.Size = new System.Drawing.Size(158, 115);
            this.groupBoxKnife.TabIndex = 5;
            this.groupBoxKnife.TabStop = false;
            this.groupBoxKnife.Text = "нож";
            // 
            // cut_meat
            // 
            this.cut_meat.Location = new System.Drawing.Point(6, 82);
            this.cut_meat.Name = "cut_meat";
            this.cut_meat.Size = new System.Drawing.Size(137, 27);
            this.cut_meat.TabIndex = 11;
            this.cut_meat.Text = "резать мясо";
            this.cut_meat.UseVisualStyleBackColor = true;
            this.cut_meat.Click += new System.EventHandler(this.cut_meat_Click);
            // 
            // cut_carrot
            // 
            this.cut_carrot.Location = new System.Drawing.Point(6, 52);
            this.cut_carrot.Name = "cut_carrot";
            this.cut_carrot.Size = new System.Drawing.Size(137, 27);
            this.cut_carrot.TabIndex = 9;
            this.cut_carrot.Text = "резать морковь";
            this.cut_carrot.UseVisualStyleBackColor = true;
            this.cut_carrot.Click += new System.EventHandler(this.cut_carrot_Click);
            // 
            // cut_onion
            // 
            this.cut_onion.Location = new System.Drawing.Point(6, 19);
            this.cut_onion.Name = "cut_onion";
            this.cut_onion.Size = new System.Drawing.Size(137, 27);
            this.cut_onion.TabIndex = 10;
            this.cut_onion.Text = "резать лук";
            this.cut_onion.UseVisualStyleBackColor = true;
            this.cut_onion.Click += new System.EventHandler(this.cut_onion_Click);
            // 
            // groupBoxWaterTap
            // 
            this.groupBoxWaterTap.Controls.Add(this.WaterTapClose);
            this.groupBoxWaterTap.Controls.Add(this.wash_onion);
            this.groupBoxWaterTap.Controls.Add(this.WaterTapOpen);
            this.groupBoxWaterTap.Controls.Add(this.wash_rice);
            this.groupBoxWaterTap.Controls.Add(this.wash_carrot);
            this.groupBoxWaterTap.Controls.Add(this.wash_meat);
            this.groupBoxWaterTap.Location = new System.Drawing.Point(413, 12);
            this.groupBoxWaterTap.Name = "groupBoxWaterTap";
            this.groupBoxWaterTap.Size = new System.Drawing.Size(169, 167);
            this.groupBoxWaterTap.TabIndex = 6;
            this.groupBoxWaterTap.TabStop = false;
            this.groupBoxWaterTap.Text = "Кран";
            // 
            // WaterTapClose
            // 
            this.WaterTapClose.AutoSize = true;
            this.WaterTapClose.Location = new System.Drawing.Point(101, 13);
            this.WaterTapClose.Name = "WaterTapClose";
            this.WaterTapClose.Size = new System.Drawing.Size(51, 17);
            this.WaterTapClose.TabIndex = 17;
            this.WaterTapClose.TabStop = true;
            this.WaterTapClose.Text = "выкл";
            this.WaterTapClose.UseVisualStyleBackColor = true;
            this.WaterTapClose.CheckedChanged += new System.EventHandler(this.WaterTapClose_CheckedChanged);
            // 
            // wash_onion
            // 
            this.wash_onion.Location = new System.Drawing.Point(32, 36);
            this.wash_onion.Name = "wash_onion";
            this.wash_onion.Size = new System.Drawing.Size(137, 27);
            this.wash_onion.TabIndex = 15;
            this.wash_onion.Text = "мыть лук";
            this.wash_onion.UseVisualStyleBackColor = true;
            this.wash_onion.Click += new System.EventHandler(this.wash_onion_Click);
            // 
            // WaterTapOpen
            // 
            this.WaterTapOpen.AutoSize = true;
            this.WaterTapOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.WaterTapOpen.Location = new System.Drawing.Point(52, 13);
            this.WaterTapOpen.Name = "WaterTapOpen";
            this.WaterTapOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WaterTapOpen.Size = new System.Drawing.Size(43, 17);
            this.WaterTapOpen.TabIndex = 16;
            this.WaterTapOpen.TabStop = true;
            this.WaterTapOpen.Text = "вкл";
            this.WaterTapOpen.UseVisualStyleBackColor = true;
            this.WaterTapOpen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // wash_rice
            // 
            this.wash_rice.Location = new System.Drawing.Point(32, 134);
            this.wash_rice.Name = "wash_rice";
            this.wash_rice.Size = new System.Drawing.Size(137, 27);
            this.wash_rice.TabIndex = 14;
            this.wash_rice.Text = "мыть рис";
            this.wash_rice.UseVisualStyleBackColor = true;
            this.wash_rice.Click += new System.EventHandler(this.Wash_rice_Click);
            // 
            // wash_carrot
            // 
            this.wash_carrot.Location = new System.Drawing.Point(32, 102);
            this.wash_carrot.Name = "wash_carrot";
            this.wash_carrot.Size = new System.Drawing.Size(137, 27);
            this.wash_carrot.TabIndex = 13;
            this.wash_carrot.Text = "мыть морковь";
            this.wash_carrot.UseVisualStyleBackColor = true;
            this.wash_carrot.Click += new System.EventHandler(this.wash_carrot_Click);
            // 
            // wash_meat
            // 
            this.wash_meat.Location = new System.Drawing.Point(32, 69);
            this.wash_meat.Name = "wash_meat";
            this.wash_meat.Size = new System.Drawing.Size(137, 27);
            this.wash_meat.TabIndex = 12;
            this.wash_meat.Text = "мыть мясо";
            this.wash_meat.UseVisualStyleBackColor = true;
            this.wash_meat.Click += new System.EventHandler(this.wash_meat_Click);
            // 
            // groupBoxStove
            // 
            this.groupBoxStove.Controls.Add(this.checkBox_StoveOn);
            this.groupBoxStove.Controls.Add(this.Cook2);
            this.groupBoxStove.Controls.Add(this.Cook1);
            this.groupBoxStove.Location = new System.Drawing.Point(19, 231);
            this.groupBoxStove.Name = "groupBoxStove";
            this.groupBoxStove.Size = new System.Drawing.Size(208, 176);
            this.groupBoxStove.TabIndex = 7;
            this.groupBoxStove.TabStop = false;
            this.groupBoxStove.Text = "плита";
            // 
            // checkBox_StoveOn
            // 
            this.checkBox_StoveOn.AutoSize = true;
            this.checkBox_StoveOn.Location = new System.Drawing.Point(123, 18);
            this.checkBox_StoveOn.Name = "checkBox_StoveOn";
            this.checkBox_StoveOn.Size = new System.Drawing.Size(44, 17);
            this.checkBox_StoveOn.TabIndex = 12;
            this.checkBox_StoveOn.Text = "вкл";
            this.checkBox_StoveOn.UseVisualStyleBackColor = true;
            this.checkBox_StoveOn.CheckedChanged += new System.EventHandler(this.checkBox_StoveOn_CheckedChanged);
            // 
            // Cook2
            // 
            this.Cook2.Location = new System.Drawing.Point(5, 110);
            this.Cook2.Name = "Cook2";
            this.Cook2.Size = new System.Drawing.Size(137, 27);
            this.Cook2.TabIndex = 10;
            this.Cook2.Text = "приготовить плов";
            this.Cook2.UseVisualStyleBackColor = true;
            this.Cook2.Click += new System.EventHandler(this.Cook2_Click);
            // 
            // Cook1
            // 
            this.Cook1.Location = new System.Drawing.Point(6, 63);
            this.Cook1.Name = "Cook1";
            this.Cook1.Size = new System.Drawing.Size(137, 27);
            this.Cook1.TabIndex = 9;
            this.Cook1.Text = "потушить овощи и мясо";
            this.Cook1.UseVisualStyleBackColor = true;
            this.Cook1.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBoxPan
            // 
            this.groupBoxPan.Controls.Add(this.checkBox_Oil);
            this.groupBoxPan.Controls.Add(this.checkBox_Salt);
            this.groupBoxPan.Controls.Add(this.label_add);
            this.groupBoxPan.Controls.Add(this.addMeat);
            this.groupBoxPan.Controls.Add(this.addCarrot);
            this.groupBoxPan.Controls.Add(this.addWater);
            this.groupBoxPan.Controls.Add(this.addRice);
            this.groupBoxPan.Controls.Add(this.addOnion);
            this.groupBoxPan.Location = new System.Drawing.Point(312, 204);
            this.groupBoxPan.Name = "groupBoxPan";
            this.groupBoxPan.Size = new System.Drawing.Size(208, 203);
            this.groupBoxPan.TabIndex = 8;
            this.groupBoxPan.TabStop = false;
            this.groupBoxPan.Text = "сковородка";
            // 
            // checkBox_Oil
            // 
            this.checkBox_Oil.AutoSize = true;
            this.checkBox_Oil.Location = new System.Drawing.Point(6, 110);
            this.checkBox_Oil.Name = "checkBox_Oil";
            this.checkBox_Oil.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Oil.TabIndex = 14;
            this.checkBox_Oil.Text = "масло";
            this.checkBox_Oil.UseVisualStyleBackColor = true;
            this.checkBox_Oil.CheckedChanged += new System.EventHandler(this.checkBox_Oil_CheckedChanged);
            // 
            // checkBox_Salt
            // 
            this.checkBox_Salt.AutoSize = true;
            this.checkBox_Salt.Location = new System.Drawing.Point(6, 71);
            this.checkBox_Salt.Name = "checkBox_Salt";
            this.checkBox_Salt.Size = new System.Drawing.Size(50, 17);
            this.checkBox_Salt.TabIndex = 13;
            this.checkBox_Salt.Text = "соль";
            this.checkBox_Salt.UseVisualStyleBackColor = true;
            this.checkBox_Salt.CheckedChanged += new System.EventHandler(this.checkBox_Salt_CheckedChanged);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(37, 16);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(134, 13);
            this.label_add.TabIndex = 9;
            this.label_add.Text = "добавить на сковороду ..";
            // 
            // addMeat
            // 
            this.addMeat.Location = new System.Drawing.Point(65, 38);
            this.addMeat.Name = "addMeat";
            this.addMeat.Size = new System.Drawing.Size(137, 27);
            this.addMeat.TabIndex = 8;
            this.addMeat.Text = "мясо";
            this.addMeat.UseVisualStyleBackColor = true;
            this.addMeat.Click += new System.EventHandler(this.AddMeat_Click);
            // 
            // addCarrot
            // 
            this.addCarrot.Location = new System.Drawing.Point(65, 71);
            this.addCarrot.Name = "addCarrot";
            this.addCarrot.Size = new System.Drawing.Size(137, 27);
            this.addCarrot.TabIndex = 7;
            this.addCarrot.Text = "морковь";
            this.addCarrot.UseVisualStyleBackColor = true;
            this.addCarrot.Click += new System.EventHandler(this.AddCarrot_Click);
            // 
            // addWater
            // 
            this.addWater.Location = new System.Drawing.Point(65, 170);
            this.addWater.Name = "addWater";
            this.addWater.Size = new System.Drawing.Size(137, 27);
            this.addWater.TabIndex = 6;
            this.addWater.Text = "вода";
            this.addWater.UseVisualStyleBackColor = true;
            this.addWater.Click += new System.EventHandler(this.AddWater_Click);
            // 
            // addRice
            // 
            this.addRice.Location = new System.Drawing.Point(65, 137);
            this.addRice.Name = "addRice";
            this.addRice.Size = new System.Drawing.Size(137, 27);
            this.addRice.TabIndex = 5;
            this.addRice.Text = "рис";
            this.addRice.UseVisualStyleBackColor = true;
            this.addRice.Click += new System.EventHandler(this.AddRice_Click);
            // 
            // addOnion
            // 
            this.addOnion.Location = new System.Drawing.Point(65, 104);
            this.addOnion.Name = "addOnion";
            this.addOnion.Size = new System.Drawing.Size(137, 27);
            this.addOnion.TabIndex = 4;
            this.addOnion.Text = "лук";
            this.addOnion.UseVisualStyleBackColor = true;
            this.addOnion.Click += new System.EventHandler(this.AddOnion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 430);
            this.Controls.Add(this.groupBoxPan);
            this.Controls.Add(this.groupBoxStove);
            this.Controls.Add(this.groupBoxWaterTap);
            this.Controls.Add(this.groupBoxKnife);
            this.Controls.Add(this.groupBoxMagazine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_onion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_carrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_rice)).EndInit();
            this.groupBoxMagazine.ResumeLayout(false);
            this.groupBoxMagazine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_meat)).EndInit();
            this.groupBoxKnife.ResumeLayout(false);
            this.groupBoxWaterTap.ResumeLayout(false);
            this.groupBoxWaterTap.PerformLayout();
            this.groupBoxStove.ResumeLayout(false);
            this.groupBoxStove.PerformLayout();
            this.groupBoxPan.ResumeLayout(false);
            this.groupBoxPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_onion;
        private System.Windows.Forms.NumericUpDown numeric_carrot;
        private System.Windows.Forms.NumericUpDown numeric_rice;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.GroupBox groupBoxMagazine;
        private System.Windows.Forms.Label label_meat;
        private System.Windows.Forms.NumericUpDown numeric_meat;
        private System.Windows.Forms.Label label_rice;
        private System.Windows.Forms.Label label_carrot;
        private System.Windows.Forms.Label label_onion;
        private System.Windows.Forms.GroupBox groupBoxKnife;
        private System.Windows.Forms.Button cut_meat;
        private System.Windows.Forms.Button cut_carrot;
        private System.Windows.Forms.Button cut_onion;
        private System.Windows.Forms.GroupBox groupBoxWaterTap;
        private System.Windows.Forms.Button wash_onion;
        private System.Windows.Forms.Button wash_rice;
        private System.Windows.Forms.Button wash_carrot;
        private System.Windows.Forms.Button wash_meat;
        private System.Windows.Forms.GroupBox groupBoxStove;
        private System.Windows.Forms.Button Cook2;
        private System.Windows.Forms.Button Cook1;
        private System.Windows.Forms.GroupBox groupBoxPan;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Button addMeat;
        private System.Windows.Forms.Button addCarrot;
        private System.Windows.Forms.Button addWater;
        private System.Windows.Forms.Button addRice;
        private System.Windows.Forms.Button addOnion;
        private System.Windows.Forms.RadioButton WaterTapClose;
        private System.Windows.Forms.RadioButton WaterTapOpen;
        private System.Windows.Forms.CheckBox checkBox_StoveOn;
        private System.Windows.Forms.CheckBox checkBox_Salt;
        private System.Windows.Forms.CheckBox checkBox_Oil;
    }
}

