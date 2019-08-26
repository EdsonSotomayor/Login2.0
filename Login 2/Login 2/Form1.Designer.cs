namespace Login_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.head = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Pasword = new System.Windows.Forms.TextBox();
            this.Inicio = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.Font = new System.Drawing.Font("Microsoft New Tai Lue", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.head.Location = new System.Drawing.Point(129, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(480, 83);
            this.head.TabIndex = 0;
            this.head.Text = "LOGIN AREA 51";
            this.head.Click += new System.EventHandler(this.Head_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(85, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(245, 151);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(305, 20);
            this.User.TabIndex = 3;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            this.User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            // 
            // Pasword
            // 
            this.Pasword.Location = new System.Drawing.Point(245, 210);
            this.Pasword.Name = "Pasword";
            this.Pasword.PasswordChar = '*';
            this.Pasword.Size = new System.Drawing.Size(305, 20);
            this.Pasword.TabIndex = 4;
            this.Pasword.TextChanged += new System.EventHandler(this.Pasword_TextChanged);
            this.Pasword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pasword_KeyPress);
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(76, 313);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(139, 85);
            this.Inicio.TabIndex = 5;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            this.Inicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inicio_KeyPress);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Location = new System.Drawing.Point(530, 313);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(139, 85);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "&Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Pasword);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.head);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pasword;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Salir;
    }
}

