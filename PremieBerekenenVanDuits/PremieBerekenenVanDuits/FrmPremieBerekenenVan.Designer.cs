namespace PremieBerekenenVanDuits
{
    partial class FrmPremieBerekenenVan
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
            this.lblRegio = new System.Windows.Forms.Label();
            this.cbRegio = new System.Windows.Forms.ComboBox();
            this.lblKorting = new System.Windows.Forms.Label();
            this.txtKorting = new System.Windows.Forms.TextBox();
            this.lblEigendomswaarden = new System.Windows.Forms.Label();
            this.txtEigendomswaarden = new System.Windows.Forms.TextBox();
            this.txtKortingen = new System.Windows.Forms.TextBox();
            this.pnlVerzekeringen = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbAutoverzekering = new System.Windows.Forms.RadioButton();
            this.lblVerzekering = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.pnlVerzekeringen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegio
            // 
            this.lblRegio.AutoSize = true;
            this.lblRegio.Location = new System.Drawing.Point(13, 22);
            this.lblRegio.Name = "lblRegio";
            this.lblRegio.Size = new System.Drawing.Size(47, 16);
            this.lblRegio.TabIndex = 0;
            this.lblRegio.Text = "Regio:";
            // 
            // cbRegio
            // 
            this.cbRegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegio.FormattingEnabled = true;
            this.cbRegio.Items.AddRange(new object[] {
            "Noord",
            "Midden",
            "Zuid"});
            this.cbRegio.Location = new System.Drawing.Point(174, 19);
            this.cbRegio.Name = "cbRegio";
            this.cbRegio.Size = new System.Drawing.Size(97, 24);
            this.cbRegio.TabIndex = 1;
            this.cbRegio.MouseEnter += new System.EventHandler(this.cbRegio_MouseEnter);
            this.cbRegio.MouseLeave += new System.EventHandler(this.cbRegio_MouseLeave);
            // 
            // lblKorting
            // 
            this.lblKorting.AutoSize = true;
            this.lblKorting.Location = new System.Drawing.Point(13, 52);
            this.lblKorting.Name = "lblKorting";
            this.lblKorting.Size = new System.Drawing.Size(71, 16);
            this.lblKorting.TabIndex = 2;
            this.lblKorting.Text = "Korting(%):";
            // 
            // txtKorting
            // 
            this.txtKorting.Location = new System.Drawing.Point(174, 49);
            this.txtKorting.Name = "txtKorting";
            this.txtKorting.ReadOnly = true;
            this.txtKorting.Size = new System.Drawing.Size(97, 22);
            this.txtKorting.TabIndex = 3;
            this.txtKorting.TextChanged += new System.EventHandler(this.tbKorting_TextChanged);
            // 
            // lblEigendomswaarden
            // 
            this.lblEigendomswaarden.AutoSize = true;
            this.lblEigendomswaarden.Location = new System.Drawing.Point(13, 80);
            this.lblEigendomswaarden.Name = "lblEigendomswaarden";
            this.lblEigendomswaarden.Size = new System.Drawing.Size(131, 16);
            this.lblEigendomswaarden.TabIndex = 4;
            this.lblEigendomswaarden.Text = "Eigendomswaarden:";
            // 
            // txtEigendomswaarden
            // 
            this.txtEigendomswaarden.Location = new System.Drawing.Point(174, 77);
            this.txtEigendomswaarden.Name = "txtEigendomswaarden";
            this.txtEigendomswaarden.Size = new System.Drawing.Size(246, 22);
            this.txtEigendomswaarden.TabIndex = 5;
            this.txtEigendomswaarden.Click += new System.EventHandler(this.txtEigendomswaarden_Click);
            // 
            // txtKortingen
            // 
            this.txtKortingen.BackColor = System.Drawing.Color.Green;
            this.txtKortingen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKortingen.Location = new System.Drawing.Point(277, 19);
            this.txtKortingen.Multiline = true;
            this.txtKortingen.Name = "txtKortingen";
            this.txtKortingen.Size = new System.Drawing.Size(143, 52);
            this.txtKortingen.TabIndex = 6;
            this.txtKortingen.Text = " Noord: 25% korting\r\n Midden: 10% korting\r\n Zuid: 15% korting\r\n";
            this.txtKortingen.Visible = false;
            // 
            // pnlVerzekeringen
            // 
            this.pnlVerzekeringen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVerzekeringen.Controls.Add(this.radioButton2);
            this.pnlVerzekeringen.Controls.Add(this.radioButton1);
            this.pnlVerzekeringen.Controls.Add(this.rbAutoverzekering);
            this.pnlVerzekeringen.Location = new System.Drawing.Point(174, 105);
            this.pnlVerzekeringen.Name = "pnlVerzekeringen";
            this.pnlVerzekeringen.Size = new System.Drawing.Size(246, 126);
            this.pnlVerzekeringen.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Huisverzekering";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(151, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Inboedelverzekering";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbAutoverzekering
            // 
            this.rbAutoverzekering.AutoSize = true;
            this.rbAutoverzekering.Checked = true;
            this.rbAutoverzekering.Location = new System.Drawing.Point(12, 13);
            this.rbAutoverzekering.Name = "rbAutoverzekering";
            this.rbAutoverzekering.Size = new System.Drawing.Size(125, 20);
            this.rbAutoverzekering.TabIndex = 0;
            this.rbAutoverzekering.TabStop = true;
            this.rbAutoverzekering.Text = "Autoverzekering";
            this.rbAutoverzekering.UseVisualStyleBackColor = true;
            // 
            // lblVerzekering
            // 
            this.lblVerzekering.AutoSize = true;
            this.lblVerzekering.Location = new System.Drawing.Point(12, 120);
            this.lblVerzekering.Name = "lblVerzekering";
            this.lblVerzekering.Size = new System.Drawing.Size(82, 16);
            this.lblVerzekering.TabIndex = 8;
            this.lblVerzekering.Text = "Verzekering:";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(437, 19);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(200, 244);
            this.lbItems.TabIndex = 9;
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Location = new System.Drawing.Point(12, 240);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(408, 23);
            this.btnBerekenen.TabIndex = 10;
            this.btnBerekenen.Text = "Premie Berekenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            // 
            // FrmPremieBerekenenVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 274);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lblVerzekering);
            this.Controls.Add(this.pnlVerzekeringen);
            this.Controls.Add(this.txtKortingen);
            this.Controls.Add(this.txtEigendomswaarden);
            this.Controls.Add(this.lblEigendomswaarden);
            this.Controls.Add(this.txtKorting);
            this.Controls.Add(this.lblKorting);
            this.Controls.Add(this.cbRegio);
            this.Controls.Add(this.lblRegio);
            this.Name = "FrmPremieBerekenenVan";
            this.Text = "Premie Berekenen Van Dorresteijn";
            this.Load += new System.EventHandler(this.FrmPremieBerekenenVan_Load);
            this.pnlVerzekeringen.ResumeLayout(false);
            this.pnlVerzekeringen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegio;
        private System.Windows.Forms.ComboBox cbRegio;
        private System.Windows.Forms.Label lblKorting;
        private System.Windows.Forms.TextBox txtKorting;
        private System.Windows.Forms.Label lblEigendomswaarden;
        private System.Windows.Forms.TextBox txtEigendomswaarden;
        private System.Windows.Forms.TextBox txtKortingen;
        private System.Windows.Forms.Panel pnlVerzekeringen;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbAutoverzekering;
        private System.Windows.Forms.Label lblVerzekering;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnBerekenen;
    }
}

