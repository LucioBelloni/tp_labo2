namespace Main
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label4 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            label1 = new Label();
            btnIngresar = new Button();
            cbMostrar = new CheckBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            btn_cerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(103, 326);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 20;
            label4.Text = "Contraseña";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(103, 256);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 19;
            label3.Text = "Usuario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.WhiteSmoke;
            btnRegistrar.FlatAppearance.BorderColor = Color.Red;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrar.Location = new Point(153, 527);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 40);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(153, 485);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 17;
            label1.Text = "¿No  tenés cuenta?";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Red;
            btnIngresar.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.Location = new Point(120, 417);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(204, 49);
            btnIngresar.TabIndex = 16;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // cbMostrar
            // 
            cbMostrar.AutoSize = true;
            cbMostrar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            cbMostrar.Location = new Point(273, 378);
            cbMostrar.Name = "cbMostrar";
            cbMostrar.Size = new Size(75, 21);
            cbMostrar.TabIndex = 15;
            cbMostrar.Text = "Mostrar";
            cbMostrar.UseVisualStyleBackColor = true;
            cbMostrar.CheckedChanged += cbMostrar_CheckedChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtContraseña.Location = new Point(103, 344);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(245, 28);
            txtContraseña.TabIndex = 14;
            txtContraseña.Text = "Ingrese su contraseña";
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.Location = new Point(103, 276);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(245, 28);
            txtUsuario.TabIndex = 13;
            txtUsuario.Text = "Ingrese su usuario";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_cerrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 38);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(141, 3);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 11;
            label5.Text = "Ingresa a tu cuenta";
            // 
            // btn_cerrar
            // 
            btn_cerrar.FlatAppearance.BorderColor = Color.White;
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatAppearance.MouseDownBackColor = Color.White;
            btn_cerrar.FlatAppearance.MouseOverBackColor = Color.White;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(422, 0);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(36, 35);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(cbMostrar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Button btnRegistrar;
        private Label label1;
        private Button btnIngresar;
        private CheckBox cbMostrar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private Button btn_cerrar;
    }
}