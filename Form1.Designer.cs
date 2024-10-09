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
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btsetari = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            bthome = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            button6 = new Button();
            bindingSource1 = new BindingSource(components);
            setari1 = new setari();
            schimbare1 = new Schimbare();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.refresh_60px;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(273, 822);
            button2.Name = "button2";
            button2.Size = new Size(333, 100);
            button2.TabIndex = 2;
            button2.Text = "        Reimprospatare";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(269, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(854, 779);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(btsetari);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox1);
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
            // btsetari
            // 
            btsetari.BackgroundImage = Properties.Resources.info_48px1;
            btsetari.BackgroundImageLayout = ImageLayout.None;
            btsetari.FlatAppearance.BorderSize = 0;
            btsetari.FlatStyle = FlatStyle.Flat;
            btsetari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btsetari.ForeColor = Color.White;
            btsetari.Location = new Point(17, 827);
            btsetari.Margin = new Padding(4, 5, 4, 5);
            btsetari.Name = "btsetari";
            btsetari.Size = new Size(213, 90);
            btsetari.TabIndex = 9;
            btsetari.Text = "Setari";
            btsetari.UseVisualStyleBackColor = true;
            btsetari.Click += btsetari_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(24, 30, 55);
            pictureBox2.BackgroundImage = Properties.Resources.wizard_100px;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(17, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 163);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 30, 55);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(17, 193);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 43);
            textBox1.TabIndex = 7;
            textBox1.Text = "Math Wizard";
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
            button5.Location = new Point(9, 280);
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
            button4.Location = new Point(4, 573);
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
            bthome.Location = new Point(4, 478);
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
            button3.BackgroundImage = Properties.Resources.done_52px;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(629, 827);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(210, 85);
            button3.TabIndex = 7;
            button3.Text = "     Rezolvat";
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.close_60px;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(883, 822);
            button6.Name = "button6";
            button6.Size = new Size(233, 95);
            button6.TabIndex = 8;
            button6.Text = "       Incomplet";
            button6.UseVisualStyleBackColor = true;
            // 
            // setari1
            // 
            setari1.BackColor = Color.FromArgb(46, 51, 73);
            setari1.Dock = DockStyle.Fill;
            setari1.Location = new Point(266, 0);
            setari1.Margin = new Padding(6, 8, 6, 8);
            setari1.Name = "setari1";
            setari1.Size = new Size(865, 928);
            setari1.TabIndex = 9;
            // 
            // schimbare1
            // 
            schimbare1.BackColor = Color.FromArgb(46, 51, 73);
            schimbare1.Dock = DockStyle.Fill;
            schimbare1.Location = new Point(266, 0);
            schimbare1.Margin = new Padding(6, 8, 6, 8);
            schimbare1.Name = "schimbare1";
            schimbare1.Size = new Size(865, 928);
            schimbare1.TabIndex = 10;
            schimbare1.Load += schimbare1_Load_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1131, 928);
            Controls.Add(schimbare1);
            Controls.Add(setari1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Button button2;
        public PictureBox pictureBox1;
        public Panel panel1;
        public Button bthome;
        public Button button4;
        public System.Windows.Forms.Timer timer1;
        public Button button5;
        public Button button3;
        public Button button6;
        public PictureBox pictureBox2;
        public TextBox textBox1;
        public BindingSource bindingSource1;
        public Button btsetari;
        public setari setari1;
        public Schimbare schimbare1;
    }
}