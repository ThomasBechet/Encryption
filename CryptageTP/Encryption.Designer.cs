namespace CryptageTP
{
    partial class Encryption
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_TextBox = new System.Windows.Forms.TextBox();
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.Key_TextBox = new System.Windows.Forms.TextBox();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_TextBox
            // 
            this.Input_TextBox.Location = new System.Drawing.Point(13, 11);
            this.Input_TextBox.Multiline = true;
            this.Input_TextBox.Name = "Input_TextBox";
            this.Input_TextBox.Size = new System.Drawing.Size(776, 169);
            this.Input_TextBox.TabIndex = 0;
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Location = new System.Drawing.Point(13, 216);
            this.Output_TextBox.Multiline = true;
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.Size = new System.Drawing.Size(775, 191);
            this.Output_TextBox.TabIndex = 1;
            // 
            // Key_TextBox
            // 
            this.Key_TextBox.Location = new System.Drawing.Point(13, 190);
            this.Key_TextBox.Name = "Key_TextBox";
            this.Key_TextBox.Size = new System.Drawing.Size(237, 20);
            this.Key_TextBox.TabIndex = 2;
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.Location = new System.Drawing.Point(266, 186);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(99, 29);
            this.Encrypt_Button.TabIndex = 3;
            this.Encrypt_Button.Text = "Encrypt";
            this.Encrypt_Button.UseVisualStyleBackColor = true;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.Location = new System.Drawing.Point(371, 186);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.Decrypt_Button.Size = new System.Drawing.Size(98, 29);
            this.Decrypt_Button.TabIndex = 4;
            this.Decrypt_Button.Text = "Decrypt";
            this.Decrypt_Button.UseVisualStyleBackColor = true;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.Decrypt_Button);
            this.Controls.Add(this.Encrypt_Button);
            this.Controls.Add(this.Key_TextBox);
            this.Controls.Add(this.Output_TextBox);
            this.Controls.Add(this.Input_TextBox);
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_TextBox;
        private System.Windows.Forms.TextBox Output_TextBox;
        private System.Windows.Forms.TextBox Key_TextBox;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.Button Decrypt_Button;
    }
}

