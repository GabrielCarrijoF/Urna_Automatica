namespace WindowsFormsApp4
{
    partial class Urna
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urna));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_number = new System.Windows.Forms.TextBox();
            this.button_null = new System.Windows.Forms.Button();
            this.button_branco = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.lab_1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // text_number
            // 
            this.text_number.Location = new System.Drawing.Point(388, 155);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(119, 20);
            this.text_number.TabIndex = 1;
            this.text_number.TextChanged += new System.EventHandler(this.text_number_TextChanged);
            this.text_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
            // 
            // button_null
            // 
            this.button_null.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_null.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_null.Location = new System.Drawing.Point(385, 199);
            this.button_null.Name = "button_null";
            this.button_null.Size = new System.Drawing.Size(55, 26);
            this.button_null.TabIndex = 2;
            this.button_null.Text = "Nulo";
            this.button_null.UseVisualStyleBackColor = false;
            // 
            // button_branco
            // 
            this.button_branco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_branco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_branco.Location = new System.Drawing.Point(446, 199);
            this.button_branco.Name = "button_branco";
            this.button_branco.Size = new System.Drawing.Size(61, 26);
            this.button_branco.TabIndex = 3;
            this.button_branco.Text = "Branco";
            this.button_branco.UseVisualStyleBackColor = false;
//            this.button_branco.Click += new System.EventHandler(this.button_branco_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Lime;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(388, 233);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(111, 27);
            this.button_confirm.TabIndex = 4;
            this.button_confirm.Text = "Confirmar";
            this.button_confirm.UseVisualStyleBackColor = false;
            // 
            // lab_1
            // 
            this.lab_1.CausesValidation = false;
            this.lab_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_1.Location = new System.Drawing.Point(233, 293);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(125, 71);
            this.lab_1.TabIndex = 5;
            this.lab_1.Text = "Vazio";
            this.lab_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab2
            // 
            this.lab2.CausesValidation = false;
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(384, 293);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(125, 27);
            this.lab2.TabIndex = 6;
            this.lab2.Text = "Vazio";
            this.lab2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Urna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab_1);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_branco);
            this.Controls.Add(this.button_null);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Urna";
            this.Text = "Urna";
            this.Load += new System.EventHandler(this.Urna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.Button button_null;
        private System.Windows.Forms.Button button_branco;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label lab_1;
        private System.Windows.Forms.Label lab2;
    }
}

