using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class frm_home : Form
    {
        public struct Pessoa
        {
            public string nome;
            public string whatsapp;
            public string email;
        }

        List<Pessoa> pessoas = new List<Pessoa>();
        public Pessoa pessoa;

        public ListViewItem item_selecionado;

        string diretorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\yourpeople\";
        string diretorio_final;
        

        public frm_home()
        {
            InitializeComponent();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {

            ler_arquivo();

        }

        void ler_arquivo()
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
                File.Create(diretorio + "data.dat");
            }
            else
            {
                diretorio_final = diretorio + "data.dat";

                string[] dados_do_arquivo = File.ReadAllLines(diretorio_final);

                if(dados_do_arquivo.Length > 0)
                {
                    foreach (string d in dados_do_arquivo)
                    {
                        string[] dados_separados = d.Split('|');

                        pessoa.nome = dados_separados[0];
                        pessoa.whatsapp = dados_separados[1];
                        pessoa.email = dados_separados[2];
                        pessoas.Add(pessoa);
                    }

                    adicionar_a_list_view_do_arquivo(pessoas);
                }

            }
        }

        void adicionar_a_list_view_do_arquivo(List<Pessoa> pessoas)
        {
            foreach(Pessoa p in pessoas)
            {
                ListViewItem item = new ListViewItem(p.nome);
                item.SubItems.Add(p.whatsapp);
                item.SubItems.Add(p.email);

                if (item.Index % 2 == 0)
                    item.BackColor = Color.WhiteSmoke;
                lvw_pessoas.Items.Add(item);
            }
        }
        
        private void btn_adiconar_Click(object sender, EventArgs e)
        {
            frm_adicinar adicionar_pessoa = new frm_adicinar();
            adicionar_pessoa.ShowDialog();

            pessoa.nome = adicionar_pessoa.pessoa.nome;
            pessoa.whatsapp = adicionar_pessoa.pessoa.whatsapp;
            pessoa.email = adicionar_pessoa.pessoa.email;
            pessoas.Add(pessoa);

            ListViewItem item = new ListViewItem(pessoa.nome);
            item.SubItems.Add(pessoa.whatsapp);
            item.SubItems.Add(pessoa.email);

            if (item.Index % 2 == 0)
                item.BackColor = Color.WhiteSmoke;
            lvw_pessoas.Items.Add(item);

            string salvar_arquivo = pessoa.nome + "|" + pessoa.whatsapp + "|" + pessoa.email ;

            Console.WriteLine("ok " + diretorio_final);

            StreamWriter s = File.AppendText(diretorio_final);
            s.WriteLine("\n"+salvar_arquivo);
            s.Close();

        }

        private void lvw_pessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool item_esta_selecionado = false;

            if(lvw_pessoas.Items.Count > 0)
            {
                foreach (ListViewItem item in lvw_pessoas.SelectedItems)
                {
                    Console.WriteLine(item.Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                    item_esta_selecionado = true;
                    
                }
            }

            btn_editar.Visible = btn_exluir.Visible =  item_esta_selecionado;
            
        }

        private void btn_exluir_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvw_pessoas.SelectedItems)
            {
                lvw_pessoas.Items.Remove(item);
            }

            
        }
    }
}

