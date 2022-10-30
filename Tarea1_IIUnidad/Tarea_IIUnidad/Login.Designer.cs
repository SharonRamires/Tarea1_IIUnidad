namespace Tarea_IIUnidad
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.correotextBox = new System.Windows.Forms.TextBox();
            this.contraseñatextBox = new System.Windows.Forms.TextBox();
            this.iniciarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // correotextBox
            // 
            this.correotextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correotextBox.Location = new System.Drawing.Point(59, 120);
            this.correotextBox.Name = "correotextBox";
            this.correotextBox.Size = new System.Drawing.Size(261, 27);
            this.correotextBox.TabIndex = 3;
            // 
            // contraseñatextBox
            // 
            this.contraseñatextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contraseñatextBox.Location = new System.Drawing.Point(59, 205);
            this.contraseñatextBox.Name = "contraseñatextBox";
            this.contraseñatextBox.PasswordChar = '*';
            this.contraseñatextBox.Size = new System.Drawing.Size(261, 27);
            this.contraseñatextBox.TabIndex = 4;
            // 
            // iniciarbutton
            // 
            this.iniciarbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iniciarbutton.Image = global::Tarea_IIUnidad.Properties.Resources.iniciar_sesion1;
            this.iniciarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iniciarbutton.Location = new System.Drawing.Point(118, 270);
            this.iniciarbutton.Name = "iniciarbutton";
            this.iniciarbutton.Size = new System.Drawing.Size(124, 27);
            this.iniciarbutton.TabIndex = 5;
            this.iniciarbutton.Text = "INICIAR";
            this.iniciarbutton.UseVisualStyleBackColor = true;
            this.iniciarbutton.Click += new System.EventHandler(this.iniciarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(394, 405);
            this.Controls.Add(this.iniciarbutton);
            this.Controls.Add(this.contraseñatextBox);
            this.Controls.Add(this.correotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox correotextBox;
        private TextBox contraseñatextBox;
        private Button iniciarbutton;
        private ErrorProvider errorProvider1;
    }
}