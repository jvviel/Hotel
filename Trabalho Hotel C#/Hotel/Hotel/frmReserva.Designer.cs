namespace Hotel
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnSalvarReserva = new System.Windows.Forms.Button();
            this.btnRemoverReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnInserirReserva = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblReservaId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlItemReserva = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvItemReserva = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelarItemReserva = new System.Windows.Forms.Button();
            this.btnSalvarItemReserva = new System.Windows.Forms.Button();
            this.btnRemoverItemReserva = new System.Windows.Forms.Button();
            this.btnEditarItemReserva = new System.Windows.Forms.Button();
            this.btnInserirItemReserva = new System.Windows.Forms.Button();
            this.cmbQuarto = new System.Windows.Forms.ComboBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.lblItemReservaId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.pnlItemReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlReserva.Controls.Add(this.txtCliente);
            this.pnlReserva.Controls.Add(this.dgvReserva);
            this.pnlReserva.Controls.Add(this.btnCancelarReserva);
            this.pnlReserva.Controls.Add(this.btnSalvarReserva);
            this.pnlReserva.Controls.Add(this.btnRemoverReserva);
            this.pnlReserva.Controls.Add(this.btnEditarReserva);
            this.pnlReserva.Controls.Add(this.btnInserirReserva);
            this.pnlReserva.Controls.Add(this.cmbCliente);
            this.pnlReserva.Controls.Add(this.dtpData);
            this.pnlReserva.Controls.Add(this.lblReservaId);
            this.pnlReserva.Controls.Add(this.label4);
            this.pnlReserva.Controls.Add(this.label3);
            this.pnlReserva.Controls.Add(this.label2);
            this.pnlReserva.Controls.Add(this.label1);
            this.pnlReserva.Location = new System.Drawing.Point(41, 12);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(803, 319);
            this.pnlReserva.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(237, 89);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(69, 29);
            this.txtCliente.TabIndex = 13;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // dgvReserva
            // 
            this.dgvReserva.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(94, 186);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(621, 123);
            this.dgvReserva.TabIndex = 12;
            this.dgvReserva.DoubleClick += new System.EventHandler(this.dgvReserva_DoubleClick);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarReserva.Image")));
            this.btnCancelarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarReserva.Location = new System.Drawing.Point(593, 133);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(109, 36);
            this.btnCancelarReserva.TabIndex = 11;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnSalvarReserva
            // 
            this.btnSalvarReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarReserva.Image")));
            this.btnSalvarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarReserva.Location = new System.Drawing.Point(477, 134);
            this.btnSalvarReserva.Name = "btnSalvarReserva";
            this.btnSalvarReserva.Size = new System.Drawing.Size(92, 36);
            this.btnSalvarReserva.TabIndex = 10;
            this.btnSalvarReserva.Text = "Salvar";
            this.btnSalvarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarReserva.UseVisualStyleBackColor = false;
            this.btnSalvarReserva.Click += new System.EventHandler(this.btnSalvarReserva_Click);
            // 
            // btnRemoverReserva
            // 
            this.btnRemoverReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemoverReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverReserva.Image")));
            this.btnRemoverReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverReserva.Location = new System.Drawing.Point(342, 134);
            this.btnRemoverReserva.Name = "btnRemoverReserva";
            this.btnRemoverReserva.Size = new System.Drawing.Size(111, 36);
            this.btnRemoverReserva.TabIndex = 9;
            this.btnRemoverReserva.Text = "Remover";
            this.btnRemoverReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverReserva.UseVisualStyleBackColor = false;
            this.btnRemoverReserva.Click += new System.EventHandler(this.btnRemoverReserva_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarReserva.Image")));
            this.btnEditarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarReserva.Location = new System.Drawing.Point(229, 134);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(89, 36);
            this.btnEditarReserva.TabIndex = 8;
            this.btnEditarReserva.Text = "Editar";
            this.btnEditarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarReserva.UseVisualStyleBackColor = false;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // btnInserirReserva
            // 
            this.btnInserirReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnInserirReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirReserva.Image")));
            this.btnInserirReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirReserva.Location = new System.Drawing.Point(112, 134);
            this.btnInserirReserva.Name = "btnInserirReserva";
            this.btnInserirReserva.Size = new System.Drawing.Size(93, 36);
            this.btnInserirReserva.TabIndex = 7;
            this.btnInserirReserva.Text = "Inserir";
            this.btnInserirReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirReserva.UseVisualStyleBackColor = false;
            this.btnInserirReserva.Click += new System.EventHandler(this.btnInserirReserva_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(324, 86);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(288, 32);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(237, 54);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(375, 29);
            this.dtpData.TabIndex = 5;
            // 
            // lblReservaId
            // 
            this.lblReservaId.BackColor = System.Drawing.SystemColors.Window;
            this.lblReservaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReservaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservaId.Location = new System.Drawing.Point(237, 22);
            this.lblReservaId.Name = "lblReservaId";
            this.lblReservaId.Size = new System.Drawing.Size(73, 23);
            this.lblReservaId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados da Reserva";
            // 
            // pnlItemReserva
            // 
            this.pnlItemReserva.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlItemReserva.Controls.Add(this.lblTotal);
            this.pnlItemReserva.Controls.Add(this.label12);
            this.pnlItemReserva.Controls.Add(this.btnSair);
            this.pnlItemReserva.Controls.Add(this.dgvItemReserva);
            this.pnlItemReserva.Controls.Add(this.label11);
            this.pnlItemReserva.Controls.Add(this.btnCancelarItemReserva);
            this.pnlItemReserva.Controls.Add(this.btnSalvarItemReserva);
            this.pnlItemReserva.Controls.Add(this.btnRemoverItemReserva);
            this.pnlItemReserva.Controls.Add(this.btnEditarItemReserva);
            this.pnlItemReserva.Controls.Add(this.btnInserirItemReserva);
            this.pnlItemReserva.Controls.Add(this.cmbQuarto);
            this.pnlItemReserva.Controls.Add(this.lblEntrada);
            this.pnlItemReserva.Controls.Add(this.txtDias);
            this.pnlItemReserva.Controls.Add(this.txtValor);
            this.pnlItemReserva.Controls.Add(this.txtQuarto);
            this.pnlItemReserva.Controls.Add(this.lblItemReservaId);
            this.pnlItemReserva.Controls.Add(this.lblStatus);
            this.pnlItemReserva.Controls.Add(this.label10);
            this.pnlItemReserva.Controls.Add(this.label9);
            this.pnlItemReserva.Controls.Add(this.label8);
            this.pnlItemReserva.Controls.Add(this.label7);
            this.pnlItemReserva.Controls.Add(this.label6);
            this.pnlItemReserva.Controls.Add(this.label5);
            this.pnlItemReserva.Location = new System.Drawing.Point(41, 337);
            this.pnlItemReserva.Name = "pnlItemReserva";
            this.pnlItemReserva.Size = new System.Drawing.Size(803, 329);
            this.pnlItemReserva.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(712, 290);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 31);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvItemReserva
            // 
            this.dgvItemReserva.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItemReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemReserva.Location = new System.Drawing.Point(84, 211);
            this.dgvItemReserva.Name = "dgvItemReserva";
            this.dgvItemReserva.Size = new System.Drawing.Size(609, 110);
            this.dgvItemReserva.TabIndex = 19;
            this.dgvItemReserva.DoubleClick += new System.EventHandler(this.dgvItemReserva_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(518, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Status:";
            // 
            // btnCancelarItemReserva
            // 
            this.btnCancelarItemReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarItemReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarItemReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarItemReserva.Image")));
            this.btnCancelarItemReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarItemReserva.Location = new System.Drawing.Point(676, 161);
            this.btnCancelarItemReserva.Name = "btnCancelarItemReserva";
            this.btnCancelarItemReserva.Size = new System.Drawing.Size(109, 35);
            this.btnCancelarItemReserva.TabIndex = 17;
            this.btnCancelarItemReserva.Text = "Cancelar";
            this.btnCancelarItemReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarItemReserva.UseVisualStyleBackColor = false;
            this.btnCancelarItemReserva.Click += new System.EventHandler(this.btnCancelarItemReserva_Click);
            // 
            // btnSalvarItemReserva
            // 
            this.btnSalvarItemReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvarItemReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarItemReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarItemReserva.Image")));
            this.btnSalvarItemReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarItemReserva.Location = new System.Drawing.Point(570, 161);
            this.btnSalvarItemReserva.Name = "btnSalvarItemReserva";
            this.btnSalvarItemReserva.Size = new System.Drawing.Size(91, 35);
            this.btnSalvarItemReserva.TabIndex = 16;
            this.btnSalvarItemReserva.Text = "Salvar";
            this.btnSalvarItemReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarItemReserva.UseVisualStyleBackColor = false;
            this.btnSalvarItemReserva.Click += new System.EventHandler(this.btnSalvarItemReserva_Click);
            // 
            // btnRemoverItemReserva
            // 
            this.btnRemoverItemReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemoverItemReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItemReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverItemReserva.Image")));
            this.btnRemoverItemReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverItemReserva.Location = new System.Drawing.Point(444, 161);
            this.btnRemoverItemReserva.Name = "btnRemoverItemReserva";
            this.btnRemoverItemReserva.Size = new System.Drawing.Size(111, 35);
            this.btnRemoverItemReserva.TabIndex = 15;
            this.btnRemoverItemReserva.Text = "Remover";
            this.btnRemoverItemReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItemReserva.UseVisualStyleBackColor = false;
            this.btnRemoverItemReserva.Click += new System.EventHandler(this.btnRemoverItemReserva_Click);
            // 
            // btnEditarItemReserva
            // 
            this.btnEditarItemReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarItemReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItemReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarItemReserva.Image")));
            this.btnEditarItemReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarItemReserva.Location = new System.Drawing.Point(342, 161);
            this.btnEditarItemReserva.Name = "btnEditarItemReserva";
            this.btnEditarItemReserva.Size = new System.Drawing.Size(87, 35);
            this.btnEditarItemReserva.TabIndex = 14;
            this.btnEditarItemReserva.Text = "Editar";
            this.btnEditarItemReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarItemReserva.UseVisualStyleBackColor = false;
            this.btnEditarItemReserva.Click += new System.EventHandler(this.btnEditarItemReserva_Click);
            // 
            // btnInserirItemReserva
            // 
            this.btnInserirItemReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnInserirItemReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirItemReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirItemReserva.Image")));
            this.btnInserirItemReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirItemReserva.Location = new System.Drawing.Point(237, 161);
            this.btnInserirItemReserva.Name = "btnInserirItemReserva";
            this.btnInserirItemReserva.Size = new System.Drawing.Size(90, 35);
            this.btnInserirItemReserva.TabIndex = 13;
            this.btnInserirItemReserva.Text = "Inserir";
            this.btnInserirItemReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirItemReserva.UseVisualStyleBackColor = false;
            this.btnInserirItemReserva.Click += new System.EventHandler(this.btnInserirItemReserva_Click);
            // 
            // cmbQuarto
            // 
            this.cmbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuarto.FormattingEnabled = true;
            this.cmbQuarto.Location = new System.Drawing.Point(224, 44);
            this.cmbQuarto.Name = "cmbQuarto";
            this.cmbQuarto.Size = new System.Drawing.Size(288, 32);
            this.cmbQuarto.TabIndex = 12;
            this.cmbQuarto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEntrada
            // 
            this.lblEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.lblEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(116, 92);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(126, 24);
            this.lblEntrada.TabIndex = 11;
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(116, 167);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 29);
            this.txtDias.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(116, 126);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 29);
            this.txtValor.TabIndex = 9;
            // 
            // txtQuarto
            // 
            this.txtQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarto.Location = new System.Drawing.Point(116, 47);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(100, 29);
            this.txtQuarto.TabIndex = 8;
            this.txtQuarto.TextChanged += new System.EventHandler(this.txtQuarto_TextChanged);
            // 
            // lblItemReservaId
            // 
            this.lblItemReservaId.BackColor = System.Drawing.SystemColors.Window;
            this.lblItemReservaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemReservaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemReservaId.Location = new System.Drawing.Point(116, 12);
            this.lblItemReservaId.Name = "lblItemReservaId";
            this.lblItemReservaId.Size = new System.Drawing.Size(57, 23);
            this.lblItemReservaId.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(589, 44);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 32);
            this.lblStatus.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Itens da Reserva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Dias:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quarto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Total R$:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(366, 109);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 34);
            this.lblTotal.TabIndex = 22;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 669);
            this.ControlBox = false;
            this.Controls.Add(this.pnlItemReserva);
            this.Controls.Add(this.pnlReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.pnlItemReserva.ResumeLayout(false);
            this.pnlItemReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnSalvarReserva;
        private System.Windows.Forms.Button btnRemoverReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnInserirReserva;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblReservaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlItemReserva;
        private System.Windows.Forms.ComboBox cmbQuarto;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label lblItemReservaId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarItemReserva;
        private System.Windows.Forms.Button btnSalvarItemReserva;
        private System.Windows.Forms.Button btnRemoverItemReserva;
        private System.Windows.Forms.Button btnEditarItemReserva;
        private System.Windows.Forms.Button btnInserirItemReserva;
        private System.Windows.Forms.DataGridView dgvItemReserva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
    }
}