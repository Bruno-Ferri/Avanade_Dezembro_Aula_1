using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boasVindas
{
    public partial class frm_aula_1 : Form
    {
        public frm_aula_1()
        {
            InitializeComponent();
        }

        private void btn_boas_vindas_Click(object sender, EventArgs e)
        {
            string nome_usuario;
            nome_usuario = txt_nome.Text;
            MessageBox.Show($"Bem vindo ao C# {nome_usuario}!", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_mensagem.Text=$"Bem vindo ao C# {nome_usuario}!";
        }
    }
}
