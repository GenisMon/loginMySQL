namespace loginMySQL
{
    partial class Registros
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(112, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(135, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Create an account";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 18);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "User:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 164);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(82, 18);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Password:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(12, 209);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(82, 36);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Confirm \r\nPassword:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(100, 109);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(255, 26);
            this.txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(255, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(100, 219);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '*';
            this.txtConPassword.Size = new System.Drawing.Size(255, 26);
            this.txtConPassword.TabIndex = 6;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(47, 309);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(117, 46);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "Sign in";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 390);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnCancelar;
    }
}