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
    public partial class frmQuarto : Form
    {
        public frmQuarto()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblId.Text = "0";
            Habilitar(true);
            txtQuarto.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto ();
            Camadas.Model.Quarto quarto = new Camadas.Model.Quarto();
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
                quarto.id = id;
                quarto.descricao = txtQuarto.Text;
                quarto.valor = Convert.ToInt32(txtValor.Text);
                quarto.status = Convert.ToChar(txtStatus.Text);

                if (id == 0)
                {
                    bllQuarto.Insert(quarto);
                    confirma = MessageBox.Show("Quarto inserido com sucesso");
                }
                else
                {
                    bllQuarto.Update(quarto);
                    confirma = MessageBox.Show("Quarto alterado com sucesso");
                }
            }
            dgvQuartos.DataSource = "";
            dgvQuartos.DataSource = bllQuarto.Select();
            limparCampos();
            Habilitar(false);
        }

        private void Habilitar(bool status)
        {
            txtQuarto.Enabled = status;
            txtValor.Enabled = status;
            txtStatus.Enabled = status;
            dgvQuartos.Enabled = !status;

            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnSalvar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = "";
            txtQuarto.Text = "";
            txtValor.Text = "";
            txtStatus.Text = "";
        }

        private void frmQuarto_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Quarto dalQuarto = new Camadas.DAL.Quarto();
            dgvQuartos.DataSource = dalQuarto.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

                Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
                List<Camadas.Model.Quarto> lstQuarto = new List<Camadas.Model.Quarto>();

                if (rdbCodigo.Checked)
                {
                    lstQuarto = bllQuarto.SelectById(Convert.ToInt32(txtPesquisa.Text));
                }
                else if (rdbNome.Checked)
                {
                    lstQuarto = bllQuarto.SelectByNome(txtPesquisa.Text);
                }

                dgvQuartos.DataSource = "";
                dgvQuartos.DataSource = lstQuarto;

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
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
            dgvQuartos.DataSource = "";
            dgvQuartos.DataSource = bllQuarto.Select();
        }

        private void dgvQuartos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvQuartos.SelectedRows.Count > 0)
            {
                lblId.Text = dgvQuartos.SelectedRows[0].Cells["id"].Value.ToString();
               txtQuarto.Text = dgvQuartos.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtValor.Text = dgvQuartos.SelectedRows[0].Cells["valor"].Value.ToString();
                txtStatus.Text = dgvQuartos.SelectedRows[0].Cells["status"].Value.ToString();

            }
        }

        private void dgvQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                txtQuarto.Focus();
            }
            else
            {
                string msg = "Não há registro selecionado para edição...";
                MessageBox.Show(msg, "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
            Camadas.Model.Quarto quarto = new Camadas.Model.Quarto();
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Deseja Remover o Quarto Selecionado?";
                DialogResult resp;
                DialogResult confirma;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    quarto.id = Convert.ToInt32(lblId.Text);
                    bllQuarto.Delete(quarto);
                    confirma = MessageBox.Show("Quarto removido com sucesso");

                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvQuartos.DataSource = "";
            dgvQuartos.DataSource = bllQuarto.Select();
            limparCampos();
            Habilitar(false);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
