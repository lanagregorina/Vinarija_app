namespace Vinarija_app
{
    partial class NovaBerba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtVinogradSorte = new System.Windows.Forms.TextBox();
            this.spremi = new System.Windows.Forms.Button();
            this.odustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Šifra sorte vinograda:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(106, 34);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(106, 68);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(130, 20);
            this.txtDatum.TabIndex = 5;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(106, 101);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(130, 20);
            this.txtKolicina.TabIndex = 6;
            // 
            // txtVinogradSorte
            // 
            this.txtVinogradSorte.Location = new System.Drawing.Point(125, 134);
            this.txtVinogradSorte.Name = "txtVinogradSorte";
            this.txtVinogradSorte.Size = new System.Drawing.Size(111, 20);
            this.txtVinogradSorte.TabIndex = 7;
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(85, 196);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(75, 23);
            this.spremi.TabIndex = 8;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // odustani
            // 
            this.odustani.Location = new System.Drawing.Point(177, 196);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(75, 23);
            this.odustani.TabIndex = 9;
            this.odustani.Text = "Odustani";
            this.odustani.UseVisualStyleBackColor = true;
            this.odustani.Click += new System.EventHandler(this.odustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\Help\\help.html";
            // 
            // NovaBerba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vinarija_app.Properties.Resources.vinograd_600x400;
            this.ClientSize = new System.Drawing.Size(298, 248);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.txtVinogradSorte);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "NovaBerba";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaBerba";
            this.Load += new System.EventHandler(this.NovaBerba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtVinogradSorte;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}