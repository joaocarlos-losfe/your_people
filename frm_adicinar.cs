using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class frm_adicinar : Form
    {
        public struct Pessoa
        {
            public string nome;
            public string whatsapp;
            public string email;
        }

        public Pessoa pessoa;

        public frm_adicinar()
        {
            InitializeComponent();
        }

        private void frm_adicinar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pessoa.nome = txt_nome.Text;
            pessoa.whatsapp = txt_whatsapp.Text;
            pessoa.email = txt_email.Text;

            MessageBox.Show("adicionado com sucesso: " + pessoa.nome + " " + pessoa.whatsapp + " " + pessoa.email);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
