
namespace boasVindas
{
    partial class frm_aula_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_boas_vindas = new System.Windows.Forms.Button();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_boas_vindas
            // 
            this.btn_boas_vindas.Location = new System.Drawing.Point(78, 76);
            this.btn_boas_vindas.Name = "btn_boas_vindas";
            this.btn_boas_vindas.Size = new System.Drawing.Size(109, 23);
            this.btn_boas_vindas.TabIndex = 0;
            this.btn_boas_vindas.Text = "Clique Aqui";
            this.btn_boas_vindas.UseVisualStyleBackColor = true;
            this.btn_boas_vindas.Click += new System.EventHandler(this.btn_boas_vindas_Click);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Location = new System.Drawing.Point(78, 134);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(0, 15);
            this.lbl_mensagem.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(106, 15);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Digite o seu nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 28);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(241, 23);
            this.txt_nome.TabIndex = 3;
            // 
            // frm_aula_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 263);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_mensagem);
            this.Controls.Add(this.btn_boas_vindas);
            this.Name = "frm_aula_1";
            this.Text = "Aula 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_boas_vindas;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
    }
}

