namespace _2.Dönem_2.Ödev
{
    partial class Form1
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
            this.btnArkadas = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblListX = new System.Windows.Forms.Label();
            this.lblListY = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArkadas
            // 
            this.btnArkadas.BackColor = System.Drawing.SystemColors.Control;
            this.btnArkadas.Location = new System.Drawing.Point(25, 244);
            this.btnArkadas.Name = "btnArkadas";
            this.btnArkadas.Size = new System.Drawing.Size(113, 33);
            this.btnArkadas.TabIndex = 0;
            this.btnArkadas.Text = "ARKADAŞ MI";
            this.btnArkadas.UseVisualStyleBackColor = false;
            this.btnArkadas.Click += new System.EventHandler(this.btnArkadas_Click);
            // 
            // btnSon
            // 
            this.btnSon.BackColor = System.Drawing.SystemColors.Control;
            this.btnSon.Location = new System.Drawing.Point(158, 244);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(75, 33);
            this.btnSon.TabIndex = 1;
            this.btnSon.Text = "SON";
            this.btnSon.UseVisualStyleBackColor = false;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(40, 71);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(40, 132);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 17);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(123, 71);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(123, 132);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 5;
            // 
            // lblListX
            // 
            this.lblListX.AutoSize = true;
            this.lblListX.Location = new System.Drawing.Point(453, 55);
            this.lblListX.Name = "lblListX";
            this.lblListX.Size = new System.Drawing.Size(0, 17);
            this.lblListX.TabIndex = 6;
            // 
            // lblListY
            // 
            this.lblListY.AutoSize = true;
            this.lblListY.Location = new System.Drawing.Point(725, 55);
            this.lblListY.Name = "lblListY";
            this.lblListY.Size = new System.Drawing.Size(0, 17);
            this.lblListY.TabIndex = 7;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(263, 315);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 17);
            this.lblToplam.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblListY);
            this.Controls.Add(this.lblListX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnArkadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArkadas;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblListX;
        private System.Windows.Forms.Label lblListY;
        private System.Windows.Forms.Label lblToplam;
    }
}

