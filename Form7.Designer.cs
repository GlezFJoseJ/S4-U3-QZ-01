namespace CHEQ
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.TBX = new System.Windows.Forms.TextBox();
            this.BTREG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTXX = new System.Windows.Forms.Button();
            this.DGVMOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOS)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX
            // 
            this.TBX.Location = new System.Drawing.Point(128, 44);
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(209, 20);
            this.TBX.TabIndex = 24;
            // 
            // BTREG
            // 
            this.BTREG.BackColor = System.Drawing.Color.Transparent;
            this.BTREG.Image = ((System.Drawing.Image)(resources.GetObject("BTREG.Image")));
            this.BTREG.Location = new System.Drawing.Point(500, 319);
            this.BTREG.Margin = new System.Windows.Forms.Padding(2);
            this.BTREG.Name = "BTREG";
            this.BTREG.Size = new System.Drawing.Size(38, 37);
            this.BTREG.TabIndex = 19;
            this.BTREG.UseVisualStyleBackColor = false;
            this.BTREG.Click += new System.EventHandler(this.BTREG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTXX
            // 
            this.BTXX.BackColor = System.Drawing.Color.Transparent;
            this.BTXX.Image = ((System.Drawing.Image)(resources.GetObject("BTXX.Image")));
            this.BTXX.Location = new System.Drawing.Point(446, 37);
            this.BTXX.Margin = new System.Windows.Forms.Padding(2);
            this.BTXX.Name = "BTXX";
            this.BTXX.Size = new System.Drawing.Size(42, 38);
            this.BTXX.TabIndex = 17;
            this.BTXX.UseVisualStyleBackColor = false;
            this.BTXX.Click += new System.EventHandler(this.BTXX_Click);
            // 
            // DGVMOS
            // 
            this.DGVMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMOS.Location = new System.Drawing.Point(9, 109);
            this.DGVMOS.Margin = new System.Windows.Forms.Padding(2);
            this.DGVMOS.Name = "DGVMOS";
            this.DGVMOS.RowHeadersWidth = 51;
            this.DGVMOS.RowTemplate.Height = 24;
            this.DGVMOS.Size = new System.Drawing.Size(479, 247);
            this.DGVMOS.TabIndex = 16;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 390);
            this.Controls.Add(this.TBX);
            this.Controls.Add(this.BTREG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTXX);
            this.Controls.Add(this.DGVMOS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX;
        private System.Windows.Forms.Button BTREG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTXX;
        private System.Windows.Forms.DataGridView DGVMOS;
    }
}