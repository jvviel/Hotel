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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void HabilitaControlesReserva(bool status)
        {
            dtpData.Enabled = status;
            txtCliente.Enabled = status;
            cmbCliente.Enabled = status;
            dgvReserva.Enabled = !status;

            //botões
            btnInserirReserva.Enabled = !status;
            btnEditarReserva.Enabled = !status;
            btnRemoverReserva.Enabled = !status;
            btnSalvarReserva.Enabled = status;
            btnCancelarReserva.Enabled = status;
        }

        private void LimpaControlesReserva()
        {
            lblReservaId.Text = "";
            txtCliente.Text = "";
            dtpData.Value = DateTime.Now.Date;
        }

        private void HabilitaControlesItemReserva(bool status)
        {
            txtQuarto.Enabled = status;
            cmbQuarto.Enabled = status;
            dgvItemReserva.Enabled = !status;

            //botões
            btnInserirItemReserva.Enabled = !status;
            btnEditarItemReserva.Enabled = !status;
            btnRemoverItemReserva.Enabled = !status;
            btnSalvarItemReserva.Enabled = status;
            btnCancelarItemReserva.Enabled = status;
        }

        private void LimpaControlesItemReserva()
        {
            lblItemReservaId.Text = "";
            txtQuarto.Text = "";
            lblEntrada.Text = "";
            txtDias.Text = "";
            txtValor.Text = "";
            lblStatus.Text = "";
        }

        private void RecuperaDadosQuarto()
        {
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
            List<Camadas.Model.Quarto> lstQuarto = new List<Camadas.Model.Quarto>();
            Camadas.Model.Quarto quarto = new Camadas.Model.Quarto();
            lstQuarto = bllQuarto.SelectById(Convert.ToInt32(txtQuarto.Text));
            if (lstQuarto != null)
                quarto = lstQuarto[0];
            else MessageBox.Show("Quarto não encontrado");
            if (quarto.status != 'D')
            {
                MessageBox.Show("Quarto não pode ser reservado " + quarto.status);
                cmbQuarto.Focus();
            }
            else
            {
                lblStatus.Text = quarto.status.ToString();
                txtValor.Text = quarto.valor.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuarto.Text = cmbQuarto.SelectedValue.ToString();
            RecuperaDadosQuarto();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            HabilitaControlesReserva(false);
            HabilitaControlesItemReserva(false);
            LimpaControlesReserva();
            LimpaControlesItemReserva();
            Camadas.BLL.Reserva bllReserva = new Camadas.BLL.Reserva();
            Camadas.BLL.ItemReserva bllItemReserva = new Camadas.BLL.ItemReserva();

            dgvReserva.DataSource = bllReserva.Select();
            dgvItemReserva.DataSource = bllItemReserva.Select();

            //Carregamento de Combobox
            //Cliente
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCliente.Select();

            //Produto
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
            cmbQuarto.DisplayMember = "descricao";
            cmbQuarto.ValueMember = "id";
            cmbQuarto.DataSource = bllQuarto.Select();
        }

        private void btnInserirReserva_Click(object sender, EventArgs e)
        {
            LimpaControlesReserva();
            lblReservaId.Text = "0";
            HabilitaControlesReserva(true);
            dtpData.Focus();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            if (lblReservaId.Text != string.Empty)
            {
                HabilitaControlesReserva(true);
                dtpData.Focus();
            }
            else
            {
                string msg = "Não há Reserva para edição";
                MessageBox.Show(msg, "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoverReserva_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblReservaId.Text != string.Empty)
            {
                msg = "Confirma Remoção da Reserva " + lblReservaId.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblReservaId.Text);
                    Camadas.BLL.Reserva bllReserva = new Camadas.BLL.Reserva();
                    Camadas.Model.Reserva reserva = new Camadas.Model.Reserva();
                    reserva.id = id;
                    // informar outros campos caso necessite no bll
                    bllReserva.Delete(reserva);
                    dgvReserva.DataSource = "";
                    dgvReserva.DataSource = bllReserva.Select();
                }
            }
            else
            {
                msg = "Não há Reserva para remoção.";
                MessageBox.Show(msg, "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaControlesReserva();
            HabilitaControlesReserva(false);
        }

        private void btnSalvarReserva_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Reserva bllReserva = new Camadas.BLL.Reserva();
            Camadas.Model.Reserva reserva = new Camadas.Model.Reserva();
            int id = Convert.ToInt32(lblReservaId.Text);

            string msg = "";
            if (id == 0) 
                msg = "Confirma Inclusão da Reserva?";
            else msg = "Confirma Atualização da Reserva?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Salvar Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                reserva.id = id;
                reserva.data = dtpData.Value;
                reserva.cliente = Convert.ToInt32(txtCliente.Text);
                if (id == 0)   
                    bllReserva.Insert(reserva);
                else bllReserva.Update(reserva);
            }
            dgvReserva.DataSource = "";
            dgvReserva.DataSource = bllReserva.Select();  //atualiza a grid
            LimpaControlesReserva(); //limpa campos
            HabilitaControlesReserva(false);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            LimpaControlesReserva();
            HabilitaControlesReserva(false);
        }

        private void dgvReserva_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                lblReservaId.Text = dgvReserva.SelectedRows[0].Cells["id"].Value.ToString();
                txtCliente.Text = dgvReserva.SelectedRows[0].Cells["cliente"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
                dtpData.Value = Convert.ToDateTime(dgvReserva.SelectedRows[0].Cells["data"].Value.ToString());

                //atualizar gridview itens locação
                Camadas.BLL.ItemReserva bllItemReserva = new Camadas.BLL.ItemReserva();
                int reserva = Convert.ToInt32(lblReservaId.Text);
                dgvItemReserva.DataSource = "";
                dgvItemReserva.DataSource = bllItemReserva.SelectByReserva(reserva);

            }
        }

        private void dgvItemReserva_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItemReserva.SelectedRows.Count > 0)
            {
                lblItemReservaId.Text = dgvItemReserva.SelectedRows[0].Cells["id"].Value.ToString();
                txtQuarto.Text = dgvItemReserva.SelectedRows[0].Cells["quarto"].Value.ToString();
                lblEntrada.Text = dgvItemReserva.SelectedRows[0].Cells["entrada"].Value.ToString();
                txtValor.Text = dgvItemReserva.SelectedRows[0].Cells["valor"].Value.ToString();
                txtDias.Text = dgvItemReserva.SelectedRows[0].Cells["dias"].Value.ToString();
                if (Convert.ToInt32(txtDias.Text) == 0)
                {
                    lblStatus.Text = "D";
                }
                else
                {
                    lblStatus.Text = "R";
                }
                float total = Convert.ToInt32(txtDias.Text) * Convert.ToSingle(txtValor.Text);
                lblTotal.Text = total.ToString();
            }
        }

        private void btnInserirItemReserva_Click(object sender, EventArgs e)
        {
            if (lblReservaId.Text != "" && lblReservaId.Text != "0")
            {
                LimpaControlesItemReserva();
                lblItemReservaId.Text = "0";
                HabilitaControlesItemReserva(true);
                lblEntrada.Text = dtpData.Value.AddDays(1).ToString();
                txtDias.Text = "0";
                cmbQuarto.Focus();
            }
            else
            {
                string msg = "Não há reserva selecionada.";
                MessageBox.Show(msg, "Itens Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarItemReserva_Click(object sender, EventArgs e)
        {
            if (lblItemReservaId.Text != string.Empty)
            {
                HabilitaControlesItemReserva(true);
                txtQuarto.Focus();
            }
            else
            {
                string msg = "Não há Itens da Reserva para edição.";
                MessageBox.Show(msg, "Itens Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoverItemReserva_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblItemReservaId.Text != string.Empty)
            {
                msg = "Confirma Remoção de Itens da Reserva " + lblItemReservaId.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover Item Reserva", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblItemReservaId.Text);
                    Camadas.BLL.ItemReserva bllItemReserva = new Camadas.BLL.ItemReserva();
                    Camadas.Model.ItemReserva itemReserva = new Camadas.Model.ItemReserva();
                    itemReserva.id = id;
                    
                    bllItemReserva.Delete(itemReserva);
                    dgvItemReserva.DataSource = "";
                    dgvItemReserva.DataSource = bllItemReserva.Select();
                }
            }
            else
            {
                msg = "Não há Item Reserva para remoção.";
                MessageBox.Show(msg, "Item Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaControlesReserva();
            HabilitaControlesReserva(false);
        }

        private void btnSalvarItemReserva_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemReserva bllItemReserva = new Camadas.BLL.ItemReserva();
            Camadas.Model.ItemReserva itemReserva = new Camadas.Model.ItemReserva();
            int id = Convert.ToInt32(lblItemReservaId.Text);

            string msg = "";
            if (id == 0) 
                msg = "Confirma Inclusão de Item da Reserva?";
            else msg = "Confirma Atualização de Item da Reserva?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Item da Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                
                itemReserva.reserva = Convert.ToInt32(lblReservaId.Text);
                itemReserva.quarto = Convert.ToInt32(txtQuarto.Text);
                itemReserva.entrada = Convert.ToDateTime(lblEntrada.Text);
                itemReserva.valor = Convert.ToSingle(txtValor.Text);
                itemReserva.dias = Convert.ToInt32(txtDias.Text);

                if (id == 0)  //0 indica inserir 
                    bllItemReserva.Insert(itemReserva);
                else bllItemReserva.Update(itemReserva);
            }
            dgvItemReserva.DataSource = "";
            dgvItemReserva.DataSource = bllItemReserva.SelectByReserva(Convert.ToInt32(lblReservaId.Text));  //atualiza a grid
            LimpaControlesItemReserva(); //limpa campos
            HabilitaControlesItemReserva(false);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarItemReserva_Click(object sender, EventArgs e)
        {
            LimpaControlesItemReserva();
            HabilitaControlesItemReserva(false);
            Camadas.BLL.ItemReserva bllItemReserva = new Camadas.BLL.ItemReserva();
            dgvItemReserva.DataSource = bllItemReserva.SelectByReserva(Convert.ToInt32(lblReservaId.Text));
        }

        private void txtQuarto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
