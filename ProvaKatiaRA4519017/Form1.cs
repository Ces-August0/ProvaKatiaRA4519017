using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaKatiaRA4519017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Hospede> listHospede = new List<Hospede>(); //lista para salvar hospede
        private void btnSalvar_Click(object sender, EventArgs e)//botao para salvar
        {
            Hospede Reserva = new Hospede();
            Reserva.codigo = Convert.ToInt32(txtcodigo.Text); //salvar dados a seram digitados
            Reserva.nome = txtnome.Text;//salvar dados a seram digitados
            Reserva.endereco = txtendereco.Text;//salvar dados a seram digitados
            Reserva.cpf = Convert.ToInt32(txtcpf.Text);//salvar dados a seram digitados
            Reserva.telefone = Convert.ToInt32(txttelefone.Text);//salvar dados a seram digitados
            listHospede.Add(Reserva);
           
        }
        private void btnLimpar_Click(object sender, EventArgs e)//botao para limpar campos
        {
            txtcodigo.Text = null;
            txtnome.Text = null;
            txtendereco.Text = null;
            txtcpf.Text = null;
            txttelefone.Text = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)//botão para pesquisar
        {
            int op = 0;
            for (int i = 0; i < listHospede.Count; i++)
            {
                if (txtcodigo.Text.Equals(listHospede[i].Reserva))
                {
                    txtcodigo.Text = listHospede[i].codigo;
                    txtnome.Text listHospede[i].nome;
                    txtendereco.Text = listHospede[i].endereco;
                    txcpf.Text = listHospede[i].cpf;
                    txttelefone.Text = listHospede[i].telefone;
                    op = 1;
                    break;
                }
            }
            if (op == 0)
            {
                MessageBox.Show("Reserva nao encontrada");
            }
        }
    }
    }
}