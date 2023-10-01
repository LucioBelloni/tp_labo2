namespace Main
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            label5 = new Label();
            btn_cerrar = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            txtMail = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            btnCrearCuenta = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_cerrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 38);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(141, 3);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 11;
            label5.Text = "Crea  tu cuenta";
            label5.Click += label5_Click;
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(88, 266);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 20;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.Location = new Point(88, 285);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 28);
            txtNombre.TabIndex = 21;
            txtNombre.Text = "Ingrese su nombre";
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(88, 384);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 22;
            label4.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.Location = new Point(88, 403);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(245, 28);
            txtUsuario.TabIndex = 23;
            txtUsuario.Text = "Ingrese su usuario";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(88, 325);
            label1.Name = "label1";
            label1.Size = new Size(31, 16);
            label1.TabIndex = 24;
            label1.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtMail.Location = new Point(88, 344);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(245, 28);
            txtMail.TabIndex = 25;
            txtMail.Text = "minombre@ejemplo.com";
            txtMail.TextAlign = HorizontalAlignment.Center;
            txtMail.TextChanged += txtMail_TextChanged;
            txtMail.Enter += txtMail_Enter;
            txtMail.Leave += txtMail_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(88, 453);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 26;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Yu Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtContraseña.Location = new Point(88, 472);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(245, 28);
            txtContraseña.TabIndex = 27;
            txtContraseña.Text = "Ingrese una contraseña";
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.Red;
            btnCrearCuenta.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnCrearCuenta.Location = new Point(118, 516);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(204, 49);
            btnCrearCuenta.TabIndex = 28;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.FlatAppearance.BorderColor = Color.Red;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(141, 595);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 40);
            btnLogin.TabIndex = 30;
            btnLogin.Text = "Ya tengo cuenta";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(459, 682);
            Controls.Add(btnLogin);
            Controls.Add(btnCrearCuenta);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btn_cerrar;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtMail;
        private Label label2;
        private TextBox txtContraseña;
        private Button btnCrearCuenta;
        private Label label6;
        private Button btnLogin;
    }
}