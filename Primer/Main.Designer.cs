namespace Primer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip4 = new MenuStrip();
            comprarCriptoToolStripMenuItem = new ToolStripMenuItem();
            mercadosToolStripMenuItem = new ToolStripMenuItem();
            billeteraToolStripMenuItem = new ToolStripMenuItem();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            panelBilletera = new Panel();
            lblDisponibleAr = new Label();
            lblDisponibleUsd = new Label();
            lblTotalCuentaPesos = new Label();
            label3 = new Label();
            label2 = new Label();
            lblCuenta = new Label();
            txtDepositar = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            btnDepositar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip4.SuspendLayout();
            panelBilletera.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip4);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 75);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip4
            // 
            menuStrip4.Dock = DockStyle.None;
            menuStrip4.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            menuStrip4.Items.AddRange(new ToolStripItem[] { comprarCriptoToolStripMenuItem, mercadosToolStripMenuItem, billeteraToolStripMenuItem, accionesToolStripMenuItem });
            menuStrip4.Location = new Point(180, 22);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(415, 29);
            menuStrip4.TabIndex = 16;
            menuStrip4.Text = "menuStrip4";
            menuStrip4.ItemClicked += menuStrip4_ItemClicked_1;
            // 
            // comprarCriptoToolStripMenuItem
            // 
            comprarCriptoToolStripMenuItem.Name = "comprarCriptoToolStripMenuItem";
            comprarCriptoToolStripMenuItem.Size = new Size(136, 25);
            comprarCriptoToolStripMenuItem.Text = "Comprar Cripto";
            // 
            // mercadosToolStripMenuItem
            // 
            mercadosToolStripMenuItem.Name = "mercadosToolStripMenuItem";
            mercadosToolStripMenuItem.Size = new Size(100, 25);
            mercadosToolStripMenuItem.Text = "Mercados ";
            // 
            // billeteraToolStripMenuItem
            // 
            billeteraToolStripMenuItem.Name = "billeteraToolStripMenuItem";
            billeteraToolStripMenuItem.Size = new Size(84, 25);
            billeteraToolStripMenuItem.Text = "Billetera";
            billeteraToolStripMenuItem.Click += billeteraToolStripMenuItem_Click;
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(87, 25);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(994, 24);
            menuStrip2.TabIndex = 14;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(994, 24);
            menuStrip3.TabIndex = 15;
            menuStrip3.Text = "menuStrip3";
            // 
            // panelBilletera
            // 
            panelBilletera.Controls.Add(lblDisponibleAr);
            panelBilletera.Controls.Add(lblDisponibleUsd);
            panelBilletera.Controls.Add(lblTotalCuentaPesos);
            panelBilletera.Controls.Add(label3);
            panelBilletera.Controls.Add(label2);
            panelBilletera.Controls.Add(lblCuenta);
            panelBilletera.Controls.Add(txtDepositar);
            panelBilletera.Controls.Add(textBox2);
            panelBilletera.Controls.Add(textBox1);
            panelBilletera.Controls.Add(button3);
            panelBilletera.Controls.Add(button2);
            panelBilletera.Controls.Add(btnDepositar);
            panelBilletera.Location = new Point(338, 139);
            panelBilletera.Name = "panelBilletera";
            panelBilletera.Size = new Size(644, 436);
            panelBilletera.TabIndex = 17;
            panelBilletera.Paint += panelBilletera_Paint;
            // 
            // lblDisponibleAr
            // 
            lblDisponibleAr.AutoSize = true;
            lblDisponibleAr.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblDisponibleAr.Location = new Point(245, 128);
            lblDisponibleAr.Name = "lblDisponibleAr";
            lblDisponibleAr.Size = new Size(69, 25);
            lblDisponibleAr.TabIndex = 11;
            lblDisponibleAr.Text = "AR$ 0 ";
            lblDisponibleAr.Click += lblDisponibleAr_Click;
            // 
            // lblDisponibleUsd
            // 
            lblDisponibleUsd.AutoSize = true;
            lblDisponibleUsd.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblDisponibleUsd.Location = new Point(391, 128);
            lblDisponibleUsd.Name = "lblDisponibleUsd";
            lblDisponibleUsd.Size = new Size(70, 25);
            lblDisponibleUsd.TabIndex = 10;
            lblDisponibleUsd.Text = "US$ 0 ";
            lblDisponibleUsd.Click += lblDisponibleUsd_Click;
            // 
            // lblTotalCuentaPesos
            // 
            lblTotalCuentaPesos.AutoSize = true;
            lblTotalCuentaPesos.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTotalCuentaPesos.Location = new Point(62, 128);
            lblTotalCuentaPesos.Name = "lblTotalCuentaPesos";
            lblTotalCuentaPesos.Size = new Size(64, 25);
            lblTotalCuentaPesos.TabIndex = 9;
            lblTotalCuentaPesos.Text = "AR$ 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(359, 70);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 8;
            label3.Text = "US$ Disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(233, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 7;
            label2.Text = "Disponible";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblCuenta.Location = new Point(21, 70);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(170, 25);
            lblCuenta.TabIndex = 6;
            lblCuenta.Text = "Total de la cuenta";
            // 
            // txtDepositar
            // 
            txtDepositar.Location = new Point(21, 233);
            txtDepositar.Name = "txtDepositar";
            txtDepositar.Size = new Size(152, 23);
            txtDepositar.TabIndex = 5;
            txtDepositar.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(345, 267);
            button3.Name = "button3";
            button3.Size = new Size(152, 27);
            button3.TabIndex = 2;
            button3.Text = "CALCULAR DOLAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(184, 267);
            button2.Name = "button2";
            button2.Size = new Size(152, 27);
            button2.TabIndex = 1;
            button2.Text = "EXTRAER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnDepositar.Location = new Point(21, 267);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(152, 27);
            btnDepositar.TabIndex = 0;
            btnDepositar.Text = "DEPOSITAR";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 603);
            Controls.Add(panelBilletera);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "asd";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            panelBilletera.ResumeLayout(false);
            panelBilletera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem comprarCriptoToolStripMenuItem;
        private ToolStripMenuItem mercadosToolStripMenuItem;
        private ToolStripMenuItem billeteraToolStripMenuItem;
        private Panel panelBilletera;
        private Label label3;
        private Label label2;
        private Label lblCuenta;
        private TextBox txtDepositar;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button btnDepositar;
        private Label lblDisponibleAr;
        private Label lblDisponibleUsd;
        private Label lblTotalCuentaPesos;
        private ToolStripMenuItem accionesToolStripMenuItem;
    }
}