
namespace LibraryProject
{
    partial class LoginForm
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
            this.uporabniskoImeTextBox = new System.Windows.Forms.TextBox();
            this.gesloTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uporabniskoImeTextBox
            // 
            this.uporabniskoImeTextBox.Location = new System.Drawing.Point(107, 54);
            this.uporabniskoImeTextBox.Name = "uporabniskoImeTextBox";
            this.uporabniskoImeTextBox.Size = new System.Drawing.Size(100, 20);
            this.uporabniskoImeTextBox.TabIndex = 0;
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.Location = new System.Drawing.Point(107, 80);
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.Size = new System.Drawing.Size(100, 20);
            this.gesloTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uporabniško ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geslo:";
            // 
            // registracijaButton
            // 
            this.registracijaButton.Location = new System.Drawing.Point(26, 124);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(75, 23);
            this.registracijaButton.TabIndex = 4;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.registracijaButton_Click);
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(122, 124);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 23);
            this.prijavaButton.TabIndex = 5;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gesloTextBox);
            this.Controls.Add(this.uporabniskoImeTextBox);
            this.Name = "LoginForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uporabniskoImeTextBox;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Button prijavaButton;
    }
}

