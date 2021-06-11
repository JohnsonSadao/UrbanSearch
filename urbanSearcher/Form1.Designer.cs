
namespace urbanSearcher
{
    partial class Form1
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
            this.tbLocalName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLocalName
            // 
            this.tbLocalName.Location = new System.Drawing.Point(120, 12);
            this.tbLocalName.Name = "tbLocalName";
            this.tbLocalName.Size = new System.Drawing.Size(252, 22);
            this.tbLocalName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(12, 46);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(447, 392);
            this.rtbResultado.TabIndex = 2;
            this.rtbResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do local:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLocalName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbLocalName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label1;
    }
}

