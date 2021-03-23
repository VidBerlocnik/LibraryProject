
namespace LibraryProject
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ClaniTabPage = new System.Windows.Forms.TabPage();
            this.vraciloIzposojaTabPage = new System.Windows.Forms.TabPage();
            this.iskanjeGradivaTabPage = new System.Windows.Forms.TabPage();
            this.dodajGradivoTabPage = new System.Windows.Forms.TabPage();
            this.dodajClanaTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ClaniTabPage);
            this.tabControl1.Controls.Add(this.vraciloIzposojaTabPage);
            this.tabControl1.Controls.Add(this.iskanjeGradivaTabPage);
            this.tabControl1.Controls.Add(this.dodajGradivoTabPage);
            this.tabControl1.Controls.Add(this.dodajClanaTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // ClaniTabPage
            // 
            this.ClaniTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClaniTabPage.Name = "ClaniTabPage";
            this.ClaniTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClaniTabPage.Size = new System.Drawing.Size(792, 424);
            this.ClaniTabPage.TabIndex = 0;
            this.ClaniTabPage.Text = "Člani";
            this.ClaniTabPage.UseVisualStyleBackColor = true;
            // 
            // vraciloIzposojaTabPage
            // 
            this.vraciloIzposojaTabPage.Location = new System.Drawing.Point(4, 22);
            this.vraciloIzposojaTabPage.Name = "vraciloIzposojaTabPage";
            this.vraciloIzposojaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vraciloIzposojaTabPage.Size = new System.Drawing.Size(792, 424);
            this.vraciloIzposojaTabPage.TabIndex = 1;
            this.vraciloIzposojaTabPage.Text = "Vracilo/izposoja";
            this.vraciloIzposojaTabPage.UseVisualStyleBackColor = true;
            // 
            // iskanjeGradivaTabPage
            // 
            this.iskanjeGradivaTabPage.Location = new System.Drawing.Point(4, 22);
            this.iskanjeGradivaTabPage.Name = "iskanjeGradivaTabPage";
            this.iskanjeGradivaTabPage.Size = new System.Drawing.Size(792, 424);
            this.iskanjeGradivaTabPage.TabIndex = 2;
            this.iskanjeGradivaTabPage.Text = "Iskanje gradiva";
            this.iskanjeGradivaTabPage.UseVisualStyleBackColor = true;
            // 
            // dodajGradivoTabPage
            // 
            this.dodajGradivoTabPage.Location = new System.Drawing.Point(4, 22);
            this.dodajGradivoTabPage.Name = "dodajGradivoTabPage";
            this.dodajGradivoTabPage.Size = new System.Drawing.Size(792, 424);
            this.dodajGradivoTabPage.TabIndex = 3;
            this.dodajGradivoTabPage.Text = "Dodaj gradivo";
            this.dodajGradivoTabPage.UseVisualStyleBackColor = true;
            // 
            // dodajClanaTabPage
            // 
            this.dodajClanaTabPage.Location = new System.Drawing.Point(4, 22);
            this.dodajClanaTabPage.Name = "dodajClanaTabPage";
            this.dodajClanaTabPage.Size = new System.Drawing.Size(792, 424);
            this.dodajClanaTabPage.TabIndex = 4;
            this.dodajClanaTabPage.Text = "Dodaj člana";
            this.dodajClanaTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ClaniTabPage;
        private System.Windows.Forms.TabPage vraciloIzposojaTabPage;
        private System.Windows.Forms.TabPage iskanjeGradivaTabPage;
        private System.Windows.Forms.TabPage dodajGradivoTabPage;
        private System.Windows.Forms.TabPage dodajClanaTabPage;
    }
}