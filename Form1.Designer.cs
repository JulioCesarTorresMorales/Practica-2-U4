namespace Practica_2_U4
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            txtPapas = new TextBox();
            txtRefresco = new TextBox();
            txtTe = new TextBox();
            txtSandwich = new TextBox();
            txtHotDog = new TextBox();
            txtHamburguesa = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccion por pedidos";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 144);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(89, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro Pedido";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 110);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(197, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "No.3(Sandwich, Refresco, Papas)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(187, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "No.2(Hotdog, Refresco, Papas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(221, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "No.1(Hamburguesa, Refresco, Papas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(txtPapas);
            groupBox2.Controls.Add(txtRefresco);
            groupBox2.Controls.Add(txtTe);
            groupBox2.Controls.Add(txtSandwich);
            groupBox2.Controls.Add(txtHotDog);
            groupBox2.Controls.Add(txtHamburguesa);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(448, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 373);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alimentos Seleccionados";
            // 
            // txtPapas
            // 
            txtPapas.Location = new Point(26, 316);
            txtPapas.Name = "txtPapas";
            txtPapas.Size = new Size(100, 23);
            txtPapas.TabIndex = 8;
            // 
            // txtRefresco
            // 
            txtRefresco.Location = new Point(26, 257);
            txtRefresco.Name = "txtRefresco";
            txtRefresco.Size = new Size(100, 23);
            txtRefresco.TabIndex = 11;
            txtRefresco.TextChanged += textBox5_TextChanged;
            // 
            // txtTe
            // 
            txtTe.Location = new Point(26, 207);
            txtTe.Name = "txtTe";
            txtTe.Size = new Size(100, 23);
            txtTe.TabIndex = 10;
            // 
            // txtSandwich
            // 
            txtSandwich.Location = new Point(26, 159);
            txtSandwich.Name = "txtSandwich";
            txtSandwich.Size = new Size(100, 23);
            txtSandwich.TabIndex = 9;
            // 
            // txtHotDog
            // 
            txtHotDog.Location = new Point(26, 106);
            txtHotDog.Name = "txtHotDog";
            txtHotDog.Size = new Size(100, 23);
            txtHotDog.TabIndex = 8;
            txtHotDog.TextChanged += textBox2_TextChanged;
            // 
            // txtHamburguesa
            // 
            txtHamburguesa.Location = new Point(26, 60);
            txtHamburguesa.Name = "txtHamburguesa";
            txtHamburguesa.Size = new Size(100, 23);
            txtHamburguesa.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(142, 316);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 6;
            label7.Text = "Papas fritas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 265);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Refresco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 210);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 4;
            label5.Text = "Te";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 162);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Sandwich";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "HotDog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 60);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Hamburguesa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 241);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 2;
            label8.Text = "Total a cobrar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(12, 269);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.Location = new Point(26, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Location = new Point(147, 320);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(240, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(240, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(240, 144);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(240, 202);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(240, 258);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(240, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cobro de servicios de comida";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private TextBox txtPapas;
        private TextBox txtRefresco;
        private TextBox txtTe;
        private TextBox txtSandwich;
        private TextBox txtHotDog;
        private TextBox txtHamburguesa;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}