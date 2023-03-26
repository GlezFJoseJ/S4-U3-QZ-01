namespace CHEQ
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DGVMOS = new System.Windows.Forms.DataGridView();
            this.BTXX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTREG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.LS = new System.Windows.Forms.Label();
            this.LSN = new System.Windows.Forms.Label();
            this.LSD = new System.Windows.Forms.Label();
            this.TBX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMOS
            // 
            this.DGVMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMOS.Location = new System.Drawing.Point(25, 117);
            this.DGVMOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVMOS.Name = "DGVMOS";
            this.DGVMOS.RowHeadersWidth = 51;
            this.DGVMOS.RowTemplate.Height = 24;
            this.DGVMOS.Size = new System.Drawing.Size(639, 304);
            this.DGVMOS.TabIndex = 0;
            // 
            // BTXX
            // 
            this.BTXX.BackColor = System.Drawing.Color.Transparent;
            this.BTXX.Image = ((System.Drawing.Image)(resources.GetObject("BTXX.Image")));
            this.BTXX.Location = new System.Drawing.Point(608, 29);
            this.BTXX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTXX.Name = "BTXX";
            this.BTXX.Size = new System.Drawing.Size(56, 47);
            this.BTXX.TabIndex = 2;
            this.BTXX.UseVisualStyleBackColor = false;
            this.BTXX.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // BTREG
            // 
            this.BTREG.BackColor = System.Drawing.Color.Transparent;
            this.BTREG.Image = ((System.Drawing.Image)(resources.GetObject("BTREG.Image")));
            this.BTREG.Location = new System.Drawing.Point(680, 376);
            this.BTREG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTREG.Name = "BTREG";
            this.BTREG.Size = new System.Drawing.Size(51, 45);
            this.BTREG.TabIndex = 4;
            this.BTREG.UseVisualStyleBackColor = false;
            this.BTREG.Click += new System.EventHandler(this.BTREG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(707, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(707, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo a favor";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(707, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo negativo";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(707, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saldo disponible";
            this.label5.Visible = false;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label56.Location = new System.Drawing.Point(886, 98);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(66, 24);
            this.label56.TabIndex = 9;
            this.label56.Text = "label6";
            this.label56.Visible = false;
            // 
            // LS
            // 
            this.LS.AutoSize = true;
            this.LS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LS.Location = new System.Drawing.Point(889, 155);
            this.LS.Name = "LS";
            this.LS.Size = new System.Drawing.Size(66, 24);
            this.LS.TabIndex = 10;
            this.LS.Text = "label7";
            this.LS.Visible = false;
            this.LS.Click += new System.EventHandler(this.LS_Click);
            // 
            // LSN
            // 
            this.LSN.AutoSize = true;
            this.LSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSN.Location = new System.Drawing.Point(893, 206);
            this.LSN.Name = "LSN";
            this.LSN.Size = new System.Drawing.Size(66, 24);
            this.LSN.TabIndex = 11;
            this.LSN.Text = "label8";
            this.LSN.Visible = false;
            // 
            // LSD
            // 
            this.LSD.AutoSize = true;
            this.LSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSD.Location = new System.Drawing.Point(893, 254);
            this.LSD.Name = "LSD";
            this.LSD.Size = new System.Drawing.Size(66, 24);
            this.LSD.TabIndex = 12;
            this.LSD.Text = "label9";
            this.LSD.Visible = false;
            // 
            // TBX
            // 
            this.TBX.Location = new System.Drawing.Point(183, 37);
            this.TBX.Margin = new System.Windows.Forms.Padding(4);
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(277, 22);
            this.TBX.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 441);
            this.Controls.Add(this.TBX);
            this.Controls.Add(this.LSD);
            this.Controls.Add(this.LSN);
            this.Controls.Add(this.LS);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTREG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTXX);
            this.Controls.Add(this.DGVMOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMOS;
        private System.Windows.Forms.Button BTXX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTREG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label LS;
        private System.Windows.Forms.Label LSN;
        private System.Windows.Forms.Label LSD;
        private System.Windows.Forms.TextBox TBX;
    }
}