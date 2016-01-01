namespace Vinarija_app
{
    partial class NoviDnevnik
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
            this.spremi = new System.Windows.Forms.Button();
            this.odustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAktivnosti = new System.Windows.Forms.TextBox();
            this.txtOpazanja = new System.Windows.Forms.TextBox();
            this.txtIdVinograd = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(124, 227);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(75, 23);
            this.spremi.TabIndex = 0;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // odustani
            // 
            this.odustani.Location = new System.Drawing.Point(215, 227);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(75, 23);
            this.odustani.TabIndex = 1;
            this.odustani.Text = "Odustani";
            this.odustani.UseVisualStyleBackColor = true;
            this.odustani.Click += new System.EventHandler(this.odustani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktivnosti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opažanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vinograd:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(53, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtAktivnosti
            // 
            this.txtAktivnosti.Location = new System.Drawing.Point(91, 83);
            this.txtAktivnosti.Multiline = true;
            this.txtAktivnosti.Name = "txtAktivnosti";
            this.txtAktivnosti.Size = new System.Drawing.Size(199, 52);
            this.txtAktivnosti.TabIndex = 10;
            // 
            // txtOpazanja
            // 
            this.txtOpazanja.Location = new System.Drawing.Point(91, 141);
            this.txtOpazanja.Multiline = true;
            this.txtOpazanja.Name = "txtOpazanja";
            this.txtOpazanja.Size = new System.Drawing.Size(199, 42);
            this.txtOpazanja.TabIndex = 11;
            // 
            // txtIdVinograd
            // 
            this.txtIdVinograd.Location = new System.Drawing.Point(91, 189);
            this.txtIdVinograd.Name = "txtIdVinograd";
            this.txtIdVinograd.Size = new System.Drawing.Size(53, 20);
            this.txtIdVinograd.TabIndex = 12;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(91, 57);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(199, 20);
            this.txtDatum.TabIndex = 13;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\..\\Help\\help.html";
            // 
            // NoviDnevnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vinarija_app.Properties.Resources._222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 262);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtIdVinograd);
            this.Controls.Add(this.txtOpazanja);
            this.Controls.Add(this.txtAktivnosti);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.spremi);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "NoviDnevnik";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoviDnevnik";
            this.Load += new System.EventHandler(this.NoviDnevnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.Button odustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAktivnosti;
        private System.Windows.Forms.TextBox txtOpazanja;
        private System.Windows.Forms.TextBox txtIdVinograd;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}