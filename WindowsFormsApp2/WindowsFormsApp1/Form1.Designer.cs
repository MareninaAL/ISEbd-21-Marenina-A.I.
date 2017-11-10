namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Weight = new System.Windows.Forms.Label();
            this.Color_label = new System.Windows.Forms.Label();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.Sound = new System.Windows.Forms.Button();
            this.SetTrumpet = new System.Windows.Forms.Button();
            this.newColor_label = new System.Windows.Forms.Label();
            this.DopColorButton = new System.Windows.Forms.Button();
            this.SetSaxophone = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.textBoxMaxVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(12, 292);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(41, 13);
            this.label_Weight.TabIndex = 1;
            this.label_Weight.Text = "Weight";
            // 
            // Color_label
            // 
            this.Color_label.AutoSize = true;
            this.Color_label.Location = new System.Drawing.Point(12, 326);
            this.Color_label.Name = "Color_label";
            this.Color_label.Size = new System.Drawing.Size(31, 13);
            this.Color_label.TabIndex = 2;
            this.Color_label.Text = "Color";
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(59, 289);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(62, 20);
            this.TextBoxWeight.TabIndex = 3;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(59, 322);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectColor.TabIndex = 4;
            this.buttonSelectColor.Text = "Color";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sound
            // 
            this.Sound.Location = new System.Drawing.Point(486, 318);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(75, 28);
            this.Sound.TabIndex = 5;
            this.Sound.Text = "Звук";
            this.Sound.UseVisualStyleBackColor = true;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // SetTrumpet
            // 
            this.SetTrumpet.Location = new System.Drawing.Point(15, 357);
            this.SetTrumpet.Name = "SetTrumpet";
            this.SetTrumpet.Size = new System.Drawing.Size(92, 23);
            this.SetTrumpet.TabIndex = 6;
            this.SetTrumpet.Text = "Задать трубу";
            this.SetTrumpet.UseVisualStyleBackColor = true;
            this.SetTrumpet.Click += new System.EventHandler(this.SetTrumpet_Click_1);
            // 
            // newColor_label
            // 
            this.newColor_label.AutoSize = true;
            this.newColor_label.Location = new System.Drawing.Point(295, 306);
            this.newColor_label.Name = "newColor_label";
            this.newColor_label.Size = new System.Drawing.Size(54, 13);
            this.newColor_label.TabIndex = 7;
            this.newColor_label.Text = "new Color";
            // 
            // DopColorButton
            // 
            this.DopColorButton.Location = new System.Drawing.Point(298, 323);
            this.DopColorButton.Name = "DopColorButton";
            this.DopColorButton.Size = new System.Drawing.Size(75, 23);
            this.DopColorButton.TabIndex = 8;
            this.DopColorButton.Text = "Color";
            this.DopColorButton.UseVisualStyleBackColor = true;
            this.DopColorButton.Click += new System.EventHandler(this.newColorButton_Click_1);
            // 
            // SetSaxophone
            // 
            this.SetSaxophone.Location = new System.Drawing.Point(272, 357);
            this.SetSaxophone.Name = "SetSaxophone";
            this.SetSaxophone.Size = new System.Drawing.Size(119, 23);
            this.SetSaxophone.TabIndex = 9;
            this.SetSaxophone.Text = "Задать саксофон";
            this.SetSaxophone.UseVisualStyleBackColor = true;
            this.SetSaxophone.Click += new System.EventHandler(this.SetSaxophone_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(399, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Bend";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(399, 306);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Buttons";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(399, 329);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "mouthpiece";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(212, 289);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(62, 20);
            this.TextBoxPrice.TabIndex = 13;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(147, 292);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(31, 13);
            this.Price_label.TabIndex = 14;
            this.Price_label.Text = "Price";
            // 
            // textBoxMaxVolume
            // 
            this.textBoxMaxVolume.Location = new System.Drawing.Point(212, 324);
            this.textBoxMaxVolume.Name = "textBoxMaxVolume";
            this.textBoxMaxVolume.Size = new System.Drawing.Size(62, 20);
            this.textBoxMaxVolume.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Volume";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "показать сразу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxVolume);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SetSaxophone);
            this.Controls.Add(this.DopColorButton);
            this.Controls.Add(this.newColor_label);
            this.Controls.Add(this.SetTrumpet);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.Color_label);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.Label Color_label;
        private System.Windows.Forms.TextBox TextBoxWeight;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button Sound;
        private System.Windows.Forms.Button SetTrumpet;
        private System.Windows.Forms.Label newColor_label;
        private System.Windows.Forms.Button DopColorButton;
        private System.Windows.Forms.Button SetSaxophone;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox textBoxMaxVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

