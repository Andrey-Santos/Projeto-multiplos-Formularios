namespace ProjParametroResposta.Forma2
{
    partial class FrmForma2Formulario1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRespostaRecebida = new System.Windows.Forms.TextBox();
            this.txtParametroEnviar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(202, 73);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(133, 50);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar para Form2";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRespostaRecebida
            // 
            this.txtRespostaRecebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaRecebida.Location = new System.Drawing.Point(16, 141);
            this.txtRespostaRecebida.Multiline = true;
            this.txtRespostaRecebida.Name = "txtRespostaRecebida";
            this.txtRespostaRecebida.Size = new System.Drawing.Size(329, 26);
            this.txtRespostaRecebida.TabIndex = 7;
            // 
            // txtParametroEnviar
            // 
            this.txtParametroEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroEnviar.Location = new System.Drawing.Point(16, 30);
            this.txtParametroEnviar.Name = "txtParametroEnviar";
            this.txtParametroEnviar.Size = new System.Drawing.Size(329, 26);
            this.txtParametroEnviar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parâmetro para Enviar:";
            // 
            // FrmForma2Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 228);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRespostaRecebida);
            this.Controls.Add(this.txtParametroEnviar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForma2Formulario1";
            this.Text = "FrmForma2Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRespostaRecebida;
        private System.Windows.Forms.TextBox txtParametroEnviar;
        private System.Windows.Forms.Label label1;
    }
}