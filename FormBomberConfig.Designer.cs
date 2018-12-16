namespace WindowsFormsBombers
{
    partial class FormBomberConfig
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
            this.pictureBoxBomber = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelbomber = new System.Windows.Forms.Label();
            this.labelPlain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeldopColor = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBomber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBomber
            // 
            this.pictureBoxBomber.Location = new System.Drawing.Point(47, 26);
            this.pictureBoxBomber.Name = "pictureBoxBomber";
            this.pictureBoxBomber.Size = new System.Drawing.Size(160, 103);
            this.pictureBoxBomber.TabIndex = 0;
            this.pictureBoxBomber.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelbomber);
            this.groupBox1.Controls.Add(this.labelPlain);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип самолета";
            // 
            // labelbomber
            // 
            this.labelbomber.AllowDrop = true;
            this.labelbomber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbomber.Location = new System.Drawing.Point(34, 99);
            this.labelbomber.Name = "labelbomber";
            this.labelbomber.Size = new System.Drawing.Size(113, 53);
            this.labelbomber.TabIndex = 3;
            this.labelbomber.Text = "Бомбардировщик";
            this.labelbomber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelbomber_MouseDown);
            // 
            // labelPlain
            // 
            this.labelPlain.AllowDrop = true;
            this.labelPlain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlain.Location = new System.Drawing.Point(34, 36);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(113, 49);
            this.labelPlain.TabIndex = 2;
            this.labelPlain.Text = "Самолет";
            this.labelPlain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlain_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.labeldopColor);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Controls.Add(this.pictureBoxBomber);
            this.panel1.Location = new System.Drawing.Point(259, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 277);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlain_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlain_DragEnter);
            // 
            // labeldopColor
            // 
            this.labeldopColor.AllowDrop = true;
            this.labeldopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldopColor.Location = new System.Drawing.Point(67, 202);
            this.labeldopColor.Name = "labeldopColor";
            this.labeldopColor.Size = new System.Drawing.Size(119, 39);
            this.labeldopColor.TabIndex = 2;
            this.labeldopColor.Text = "Доп. цвет";
            this.labeldopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeldopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labeldopColor_DragDrop);
            this.labeldopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(67, 146);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(119, 40);
            this.labelColor.TabIndex = 1;
            this.labelColor.Text = "Основной Цвет";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelColor_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelGold);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(580, 30);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(200, 268);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.Location = new System.Drawing.Point(91, 202);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(53, 49);
            this.panelGold.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(21, 202);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(53, 49);
            this.panelGray.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(91, 146);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(53, 49);
            this.panelYellow.TabIndex = 5;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(91, 91);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(53, 49);
            this.panelBlue.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(21, 147);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(53, 49);
            this.panelRed.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(21, 91);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(53, 49);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(91, 36);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(53, 49);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(21, 36);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(53, 49);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelColor_DragDrop);
            this.panelBlack.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(59, 228);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 24);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(59, 258);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBomberConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 346);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBomberConfig";
            this.Text = "FormBomberConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBomber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBomber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelbomber;
        private System.Windows.Forms.Label labelPlain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldopColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}