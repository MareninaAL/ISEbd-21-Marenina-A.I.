namespace WindowsFormsApp1
{
    partial class FormSelectTr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Saxophone = new System.Windows.Forms.Label();
            this.label_Trumpet = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GroupColor = new System.Windows.Forms.GroupBox();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.Choose.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Saxophone
            // 
            this.label_Saxophone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Saxophone.Location = new System.Drawing.Point(6, 16);
            this.label_Saxophone.Name = "label_Saxophone";
            this.label_Saxophone.Size = new System.Drawing.Size(90, 40);
            this.label_Saxophone.TabIndex = 0;
            this.label_Saxophone.Text = "Saxophone";
            this.label_Saxophone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableSaxophone_MouseDown);
            // 
            // label_Trumpet
            // 
            this.label_Trumpet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Trumpet.Location = new System.Drawing.Point(6, 71);
            this.label_Trumpet.Name = "label_Trumpet";
            this.label_Trumpet.Size = new System.Drawing.Size(90, 35);
            this.label_Trumpet.TabIndex = 1;
            this.label_Trumpet.Text = "Trumpet";
            this.label_Trumpet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableTrumpet_MouseDown);
            // 
            // Choose
            // 
            this.Choose.Controls.Add(this.label_Saxophone);
            this.Choose.Controls.Add(this.label_Trumpet);
            this.Choose.Location = new System.Drawing.Point(10, 24);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(130, 130);
            this.Choose.TabIndex = 2;
            this.Choose.TabStop = false;
            this.Choose.Text = "Choose";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(33, 156);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(33, 199);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelBaseColor);
            this.panel1.Controls.Add(this.labelDopColor);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(146, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 281);
            this.panel1.TabIndex = 1;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_dragdrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(34, 240);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(132, 28);
            this.labelBaseColor.TabIndex = 3;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(34, 201);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(132, 28);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(14, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 172);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // GroupColor
            // 
            this.GroupColor.Controls.Add(this.panelRed);
            this.GroupColor.Controls.Add(this.panelOrange);
            this.GroupColor.Controls.Add(this.panelGreen);
            this.GroupColor.Controls.Add(this.panelYellow);
            this.GroupColor.Controls.Add(this.panelPink);
            this.GroupColor.Controls.Add(this.panelBlue);
            this.GroupColor.Location = new System.Drawing.Point(364, 12);
            this.GroupColor.Name = "GroupColor";
            this.GroupColor.Size = new System.Drawing.Size(142, 210);
            this.GroupColor.TabIndex = 6;
            this.GroupColor.TabStop = false;
            this.GroupColor.Text = "Цвета";
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(55, 79);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(36, 40);
            this.panelRed.TabIndex = 1;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(100, 79);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(36, 40);
            this.panelOrange.TabIndex = 2;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(55, 26);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(36, 39);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(13, 25);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(36, 40);
            this.panelYellow.TabIndex = 0;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(13, 79);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(36, 40);
            this.panelPink.TabIndex = 1;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(100, 26);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(36, 39);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormSelectTr
            // 
            this.ClientSize = new System.Drawing.Size(518, 300);
            this.Controls.Add(this.GroupColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Choose);
            this.Name = "FormSelectTr";
            this.Choose.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Saxophone;
        private System.Windows.Forms.Label label_Trumpet;
        private System.Windows.Forms.GroupBox Choose;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Label labelDopColor;


    }
}