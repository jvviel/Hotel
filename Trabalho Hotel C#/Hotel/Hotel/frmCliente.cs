using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtFone.Enabled = status;
            dgvClientes.Enabled = !status;

            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnSalvar.Enabled = status;
            btnCancelar.Enabled = status;

        } 

        private void limparCampos()
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtFone.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dgvClientes.DataSource = dalCli.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count > 0)
            {
                lblId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtCidade.Text = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvClientes.SelectedRows[0].Cells["estado"].Value.ToString();
                txtFone.Text = dgvClientes.SelectedRows[0].Cells["fone"].Value.ToString();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblId.Text = "0";
            Habilitar(true);
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                Habilitar(true);
                txtNome.Focus();
            }
            else
            {
                string msg = "Não há registro selecionado para edição...";
                MessageBox.Show(msg, "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            int id = Convert.ToInt32(lblId.Text);

            string msg;
            if (id == 0)
                msg = "Deseja salvar os dados?";
            else msg = "Confirma alteração dos dados?";

            DialogResult resp;
            DialogResult confirma;
            resp = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                cliente.id = id;
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.fone = txtFone.Text;

                if (id == 0)
                {
                    bllCli.Insert(cliente);
                    confirma = MessageBox.Show("Cliente inserido com sucesso");
                }
                else
                {
                    bllCli.Update(cliente);
                    confirma = MessageBox.Show("Cliente alterado com sucesso");
                }
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
            limparCampos();
            Habilitar(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Deseja Remover o Cliente Selecionado?";
                DialogResult resp;
                DialogResult confirma;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    cliente.id = Convert.ToInt32(lblId.Text);
                    bllCli.Delete(cliente);
                    confirma = MessageBox.Show("Cliente removido com sucesso");
                    
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
            limparCampos();
            Habilitar(false);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != String.Empty)
            {

                Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
                List<Camadas.Model.Cliente> lstCliente = new List<Camadas.Model.Cliente>();

                if (rdbCodigo.Checked)
                {
                    lstCliente = bllCli.SelectById(Convert.ToInt32(txtPesquisa.Text));
                }
                else if (rdbNome.Checked)
                {
                    lstCliente = bllCli.SelectByNome(txtPesquisa.Text);
                }

                dgvClientes.DataSource = "";
                dgvClientes.DataSource = lstCliente;

            }
            else
            {
                string msg = "Campo pesquisa está vazio";
                MessageBox.Show(msg, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
        }
    }
}
