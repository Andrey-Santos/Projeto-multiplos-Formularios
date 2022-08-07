namespace ProjParametroResposta.Forma1
{
    partial class FrmForma1Formulario2
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
            this.btnDevolver = new System.Windows.Forms.Button();
            this.txtRespostaDevolver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParametroRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(204, 166);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(156, 50);
            this.btnDevolver.TabIndex = 9;
            this.btnDevolver.Text = "Devolver para Form1";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // txtRespostaDevolver
            // 
            this.txtRespostaDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaDevolver.Location = new System.Drawing.Point(40, 120);
            this.txtRespostaDevolver.Multiline = true;
            this.txtRespostaDevolver.Name = "txtRespostaDevolver";
            this.txtRespostaDevolver.Size = new System.Drawing.Size(330, 26);
            this.txtRespostaDevolver.TabIndex = 8;
            this.txtRespostaDevolver.TextChanged += new System.EventHandler(this.txtRespostaRecebida_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resposta para Devolver:";
            // 
            // txtParametroRecebido
            // 
            this.txtParametroRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroRecebido.Location = new System.Drawing.Point(40, 56);
            this.txtParametroRecebido.Name = "txtParametroRecebido";
            this.txtParametroRecebido.Size = new System.Drawing.Size(330, 26);
            this.txtParametroRecebido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parâmetro Recebido:";
            // 
            // FrmForma1Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 228);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.txtRespostaDevolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParametroRecebido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForma1Formulario2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmForma2Formulario2";
            this.Load += new System.EventHandler(this.FrmForma2Formulario2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.TextBox txtRespostaDevolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtParametroRecebido;
    }
}