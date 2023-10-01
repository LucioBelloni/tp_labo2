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
            btn = new Button();
            btnRegistrar = new Button();
            pictureBox1 = new PictureBox();
            menuStrip4 = new MenuStrip();
            comprarCriptoToolStripMenuItem = new ToolStripMenuItem();
            mercadosToolStripMenuItem = new ToolStripMenuItem();
            tradeToolStripMenuItem = new ToolStripMenuItem();
            spotToolStripMenuItem = new ToolStripMenuItem();
            margenToolStripMenuItem = new ToolStripMenuItem();
            p2PToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            botsDeTradingToolStripMenuItem1 = new ToolStripMenuItem();
            aPIToolStripMenuItem1 = new ToolStripMenuItem();
            blockTradingToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btn);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip4);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 75);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // btn
            // 
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderColor = Color.Red;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Red;
            btn.FlatAppearance.MouseOverBackColor = Color.Red;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn.ForeColor = SystemColors.ActiveCaptionText;
            btn.Location = new Point(840, 15);
            btn.Name = "btn";
            btn.Size = new Size(135, 36);
            btn.TabIndex = 20;
            btn.Text = "Iniciar sesión";
            btn.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.FlatAppearance.BorderColor = Color.Red;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrar.Location = new Point(981, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(97, 36);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
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
            menuStrip4.Items.AddRange(new ToolStripItem[] { comprarCriptoToolStripMenuItem, mercadosToolStripMenuItem, tradeToolStripMenuItem });
            menuStrip4.Location = new Point(180, 22);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(307, 29);
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
            // tradeToolStripMenuItem
            // 
            tradeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spotToolStripMenuItem, margenToolStripMenuItem, p2PToolStripMenuItem, botsDeTradingToolStripMenuItem1, aPIToolStripMenuItem1, blockTradingToolStripMenuItem1 });
            tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            tradeToolStripMenuItem.Size = new Size(63, 25);
            tradeToolStripMenuItem.Text = "Trade";
            // 
            // spotToolStripMenuItem
            // 
            spotToolStripMenuItem.Name = "spotToolStripMenuItem";
            spotToolStripMenuItem.Size = new Size(194, 26);
            spotToolStripMenuItem.Text = "Spot";
            // 
            // margenToolStripMenuItem
            // 
            margenToolStripMenuItem.Name = "margenToolStripMenuItem";
            margenToolStripMenuItem.Size = new Size(180, 26);
            margenToolStripMenuItem.Text = "Margen";
            // 
            // p2PToolStripMenuItem
            // 
            p2PToolStripMenuItem.Name = "p2PToolStripMenuItem";
            p2PToolStripMenuItem.Size = new Size(180, 26);
            p2PToolStripMenuItem.Text = "P2P";
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
            menuStrip1.Size = new Size(1086, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1086, 24);
            menuStrip2.TabIndex = 14;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1086, 24);
            menuStrip3.TabIndex = 15;
            menuStrip3.Text = "menuStrip3";
            // 
            // botsDeTradingToolStripMenuItem1
            // 
            botsDeTradingToolStripMenuItem1.Name = "botsDeTradingToolStripMenuItem1";
            botsDeTradingToolStripMenuItem1.Size = new Size(194, 26);
            botsDeTradingToolStripMenuItem1.Text = "Bots de trading";
            // 
            // aPIToolStripMenuItem1
            // 
            aPIToolStripMenuItem1.Name = "aPIToolStripMenuItem1";
            aPIToolStripMenuItem1.Size = new Size(194, 26);
            aPIToolStripMenuItem1.Text = "API";
            // 
            // blockTradingToolStripMenuItem1
            // 
            blockTradingToolStripMenuItem1.Name = "blockTradingToolStripMenuItem1";
            blockTradingToolStripMenuItem1.Size = new Size(194, 26);
            blockTradingToolStripMenuItem1.Text = "Block Trading";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 699);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "asd";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button btn;
        private Button btnRegistrar;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem comprarCriptoToolStripMenuItem;
        private ToolStripMenuItem mercadosToolStripMenuItem;
        private ToolStripMenuItem tradeToolStripMenuItem;
        private ToolStripMenuItem spotToolStripMenuItem;
        private ToolStripMenuItem margenToolStripMenuItem;
        private ToolStripMenuItem p2PToolStripMenuItem;
        private ToolStripMenuItem botsDeTradingToolStripMenuItem1;
        private ToolStripMenuItem aPIToolStripMenuItem1;
        private ToolStripMenuItem blockTradingToolStripMenuItem1;
    }
}