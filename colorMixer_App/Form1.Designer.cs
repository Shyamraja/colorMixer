namespace colorMixer_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSelectedScreen1 = new System.Windows.Forms.Panel();
            this.tBxBlue = new System.Windows.Forms.MaskedTextBox();
            this.tBxGreen = new System.Windows.Forms.MaskedTextBox();
            this.tBxRed = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlSelectedScreen2 = new System.Windows.Forms.Panel();
            this.tBxBlue1 = new System.Windows.Forms.MaskedTextBox();
            this.tBxGreen1 = new System.Windows.Forms.MaskedTextBox();
            this.tBxRed1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelMixedColor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelRandomlySelectedColors = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(435, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Mixer App\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(125, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select First Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(682, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Second Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(664, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSelectedScreen1);
            this.groupBox1.Controls.Add(this.tBxBlue);
            this.groupBox1.Controls.Add(this.tBxGreen);
            this.groupBox1.Controls.Add(this.tBxRed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(31, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(390, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected first Color";
            // 
            // pnlSelectedScreen1
            // 
            this.pnlSelectedScreen1.Location = new System.Drawing.Point(251, 53);
            this.pnlSelectedScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSelectedScreen1.Name = "pnlSelectedScreen1";
            this.pnlSelectedScreen1.Size = new System.Drawing.Size(131, 181);
            this.pnlSelectedScreen1.TabIndex = 9;
            // 
            // tBxBlue
            // 
            this.tBxBlue.Location = new System.Drawing.Point(104, 193);
            this.tBxBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxBlue.Name = "tBxBlue";
            this.tBxBlue.Size = new System.Drawing.Size(138, 30);
            this.tBxBlue.TabIndex = 8;
            // 
            // tBxGreen
            // 
            this.tBxGreen.Location = new System.Drawing.Point(104, 127);
            this.tBxGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxGreen.Name = "tBxGreen";
            this.tBxGreen.Size = new System.Drawing.Size(138, 30);
            this.tBxGreen.TabIndex = 7;
            // 
            // tBxRed
            // 
            this.tBxRed.Location = new System.Drawing.Point(104, 61);
            this.tBxRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxRed.Name = "tBxRed";
            this.tBxRed.Size = new System.Drawing.Size(138, 30);
            this.tBxRed.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Blue";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Green";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Red";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlSelectedScreen2);
            this.groupBox2.Controls.Add(this.tBxBlue1);
            this.groupBox2.Controls.Add(this.tBxGreen1);
            this.groupBox2.Controls.Add(this.tBxRed1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(608, 403);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(390, 250);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected second Color";
            // 
            // pnlSelectedScreen2
            // 
            this.pnlSelectedScreen2.Location = new System.Drawing.Point(244, 50);
            this.pnlSelectedScreen2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSelectedScreen2.Name = "pnlSelectedScreen2";
            this.pnlSelectedScreen2.Size = new System.Drawing.Size(138, 162);
            this.pnlSelectedScreen2.TabIndex = 10;
            // 
            // tBxBlue1
            // 
            this.tBxBlue1.Location = new System.Drawing.Point(98, 182);
            this.tBxBlue1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxBlue1.Name = "tBxBlue1";
            this.tBxBlue1.Size = new System.Drawing.Size(138, 30);
            this.tBxBlue1.TabIndex = 8;
            // 
            // tBxGreen1
            // 
            this.tBxGreen1.Location = new System.Drawing.Point(98, 115);
            this.tBxGreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxGreen1.Name = "tBxGreen1";
            this.tBxGreen1.Size = new System.Drawing.Size(138, 30);
            this.tBxGreen1.TabIndex = 7;
            // 
            // tBxRed1
            // 
            this.tBxRed1.Location = new System.Drawing.Point(98, 50);
            this.tBxRed1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBxRed1.Name = "tBxRed1";
            this.tBxRed1.Size = new System.Drawing.Size(138, 30);
            this.tBxRed1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Blue";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Green";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Red";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelMixedColor);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(23, 679);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(398, 214);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mixed Result";
            // 
            // panelMixedColor
            // 
            this.panelMixedColor.Location = new System.Drawing.Point(175, 33);
            this.panelMixedColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMixedColor.Name = "panelMixedColor";
            this.panelMixedColor.Size = new System.Drawing.Size(161, 159);
            this.panelMixedColor.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mix Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.mixSelectedColors);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelRandomlySelectedColors);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(608, 679);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(398, 214);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Random Mixed Result";
            // 
            // panelRandomlySelectedColors
            // 
            this.panelRandomlySelectedColors.Location = new System.Drawing.Point(175, 33);
            this.panelRandomlySelectedColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRandomlySelectedColors.Name = "panelRandomlySelectedColors";
            this.panelRandomlySelectedColors.Size = new System.Drawing.Size(161, 159);
            this.panelRandomlySelectedColors.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 55);
            this.button2.TabIndex = 0;
            this.button2.Text = "Mix Colors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.mixColours);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Color Mixer App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Panel pnlSelectedScreen1;
        private MaskedTextBox tBxBlue;
        private MaskedTextBox tBxGreen;
        private MaskedTextBox tBxRed;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private MaskedTextBox tBxBlue1;
        private MaskedTextBox tBxGreen1;
        private MaskedTextBox tBxRed1;
        private Label label7;
        private Label label8;
        private Label label9;
        //private Panel panel2;
        private GroupBox groupBox3;
        //private Panel panel3;
        private Button button1;
        private Panel pnlSelectedScreen2;
        //private Panel panelSelec;
        private Panel panelMixedColor;
        private GroupBox groupBox4;
        private Panel panelRandomlySelectedColors;
        private Button button2;
    }
}