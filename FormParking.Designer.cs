namespace WindowsFormsBombers
{
    partial class FormParking
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
            this.buttonAirPark = new System.Windows.Forms.Button();
            this.buttonbomberpark = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxTakeFly = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFly)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAirPark
            // 
            this.buttonAirPark.Location = new System.Drawing.Point(824, 36);
            this.buttonAirPark.Name = "buttonAirPark";
            this.buttonAirPark.Size = new System.Drawing.Size(160, 50);
            this.buttonAirPark.TabIndex = 1;
            this.buttonAirPark.Text = "Припарковать самолет";
            this.buttonAirPark.UseVisualStyleBackColor = true;
            this.buttonAirPark.Click += new System.EventHandler(this.buttonAirPark_Click);
            // 
            // buttonbomberpark
            // 
            this.buttonbomberpark.Location = new System.Drawing.Point(824, 106);
            this.buttonbomberpark.Name = "buttonbomberpark";
            this.buttonbomberpark.Size = new System.Drawing.Size(160, 57);
            this.buttonbomberpark.TabIndex = 2;
            this.buttonbomberpark.Text = "Припарковать бомбардировщик";
            this.buttonbomberpark.UseVisualStyleBackColor = true;
            this.buttonbomberpark.Click += new System.EventHandler(this.buttonbomberpark_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxTakeFly);
            this.groupBox1.Controls.Add(this.buttonTake);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(806, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(800, 465);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            this.pictureBoxParking.Click += new System.EventHandler(this.pictureBoxParking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать самолет";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(90, 35);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(24, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(120, 38);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // pictureBoxTakeFly
            // 
            this.pictureBoxTakeFly.Location = new System.Drawing.Point(15, 67);
            this.pictureBoxTakeFly.Name = "pictureBoxTakeFly";
            this.pictureBoxTakeFly.Size = new System.Drawing.Size(195, 125);
            this.pictureBoxTakeFly.TabIndex = 3;
            this.pictureBoxTakeFly.TabStop = false;
            this.pictureBoxTakeFly.Click += new System.EventHandler(this.pictureBoxTakeFly_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonbomberpark);
            this.Controls.Add(this.buttonAirPark);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            this.Load += new System.EventHandler(this.FormParking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonAirPark;
        private System.Windows.Forms.Button buttonbomberpark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTakeFly;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}