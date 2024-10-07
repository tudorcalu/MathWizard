namespace Manigu
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            bthome = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 51, 73);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(507, 849);
            button1.Name = "button1";
            button1.Size = new Size(187, 80);
            button1.TabIndex = 0;
            button1.Text = "Incarcare Variante";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(285, 846);
            button2.Name = "button2";
            button2.Size = new Size(239, 80);
            button2.TabIndex = 2;
            button2.Text = "Reimprospatare Exercitiu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(273, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1045, 779);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(bthome);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 928);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 55);
            button5.BackgroundImage = Properties.Resources.menu_rounded_60px;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Transparent;
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(9, 95);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(257, 85);
            button5.TabIndex = 2;
            button5.Text = "Meniu";
            button5.TextImageRelation = TextImageRelation.TextAboveImage;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.settings_48px;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(10, 350);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(257, 85);
            button4.TabIndex = 6;
            button4.Text = "       Schimbare Tip";
            button4.TextImageRelation = TextImageRelation.TextAboveImage;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // bthome
            // 
            bthome.BackColor = Color.FromArgb(24, 30, 55);
            bthome.BackgroundImage = Properties.Resources.browse_page_48px;
            bthome.BackgroundImageLayout = ImageLayout.None;
            bthome.FlatAppearance.BorderSize = 0;
            bthome.FlatStyle = FlatStyle.Flat;
            bthome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bthome.ForeColor = Color.Transparent;
            bthome.ImageAlign = ContentAlignment.MiddleLeft;
            bthome.Location = new Point(13, 253);
            bthome.Margin = new Padding(4, 5, 4, 5);
            bthome.Name = "bthome";
            bthome.Size = new Size(257, 85);
            bthome.TabIndex = 1;
            bthome.Text = "Vizionare";
            bthome.TextImageRelation = TextImageRelation.TextAboveImage;
            bthome.UseVisualStyleBackColor = false;
            bthome.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Tick += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(701, 839);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(139, 67);
            button3.TabIndex = 7;
            button3.Text = "Rezolvat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(883, 849);
            button6.Name = "button6";
            button6.Size = new Size(166, 46);
            button6.TabIndex = 8;
            button6.Text = "Incomplet";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1132, 928);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button bthome;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private Button button5;
        private Button button3;
        private Button button6;
    }
}