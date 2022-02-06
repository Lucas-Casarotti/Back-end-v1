using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP_WF
{
    public partial class BuscaCEP : Form
    {
        public BuscaCEP()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                correios.AtendeClienteClient consulta = new correios.AtendeClienteClient("AtendeClientePort");
                var resultado = consulta.consultaCEP(txtCep.Text);
                if(resultado != null)
                {
                    txtEndereco.Text    = resultado.end;
                    txtComplemento.Text = resultado.complemento2;
                    txtBairro.Text      = resultado.bairro;
                    txtCidade.Text      = resultado.cidade;
                    txtEstado.Text      = resultado.uf;
                    lblInformacoes.Text = "Consulta realizada com sucesso!";

                }
            }
            catch(FaultException)
            {
                MessageBox.Show("Cep não encontrado ou inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
