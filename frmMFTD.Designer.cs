namespace MFTD
{
    partial class frmMFTD
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
            this.lblCadPessoas = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbboxTipo = new System.Windows.Forms.ComboBox();
            this.chkboxCliente = new System.Windows.Forms.CheckBox();
            this.chkboxFornecedor = new System.Windows.Forms.CheckBox();
            this.chkboxVendedor = new System.Windows.Forms.CheckBox();
            this.lblInscEstadual = new System.Windows.Forms.Label();
            this.txtboxInscMun = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textBox1txtboxCPF = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtboxRG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxInscEst = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbboxSexo = new System.Windows.Forms.ComboBox();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.dtpickerDtNasc = new System.Windows.Forms.DateTimePicker();
            this.lblRazSocial = new System.Windows.Forms.Label();
            this.txtboxRazSocial = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblTelCom = new System.Windows.Forms.Label();
            this.txtboxTelCom = new System.Windows.Forms.TextBox();
            this.txtboxTelRes = new System.Windows.Forms.TextBox();
            this.lblTelRes = new System.Windows.Forms.Label();
            this.txtboxTelCel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtboxEnd = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtboxComplemento = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtboxBairro = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtboxCEP = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbboxEstado = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cmbboxCidade = new System.Windows.Forms.ComboBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtbboxObservacao = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.pnlObservacao = new System.Windows.Forms.Panel();
            this.pnlObservacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadPessoas
            // 
            this.lblCadPessoas.AutoSize = true;
            this.lblCadPessoas.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPessoas.ForeColor = System.Drawing.Color.White;
            this.lblCadPessoas.Location = new System.Drawing.Point(12, 9);
            this.lblCadPessoas.Name = "lblCadPessoas";
            this.lblCadPessoas.Size = new System.Drawing.Size(57, 13);
            this.lblCadPessoas.TabIndex = 0;
            this.lblCadPessoas.Text = "Cadastro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.MistyRose;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(28, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(75, 82);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(373, 20);
            this.txtbNome.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.MistyRose;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(28, 34);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 15);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbboxTipo
            // 
            this.cmbboxTipo.FormattingEnabled = true;
            this.cmbboxTipo.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cmbboxTipo.Location = new System.Drawing.Point(75, 34);
            this.cmbboxTipo.Name = "cmbboxTipo";
            this.cmbboxTipo.Size = new System.Drawing.Size(244, 21);
            this.cmbboxTipo.TabIndex = 4;
            // 
            // chkboxCliente
            // 
            this.chkboxCliente.AutoSize = true;
            this.chkboxCliente.BackColor = System.Drawing.Color.MistyRose;
            this.chkboxCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxCliente.Location = new System.Drawing.Point(349, 36);
            this.chkboxCliente.Name = "chkboxCliente";
            this.chkboxCliente.Size = new System.Drawing.Size(58, 17);
            this.chkboxCliente.TabIndex = 5;
            this.chkboxCliente.Text = "Cliente";
            this.chkboxCliente.UseVisualStyleBackColor = false;
            // 
            // chkboxFornecedor
            // 
            this.chkboxFornecedor.AutoSize = true;
            this.chkboxFornecedor.BackColor = System.Drawing.Color.MistyRose;
            this.chkboxFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxFornecedor.Location = new System.Drawing.Point(433, 36);
            this.chkboxFornecedor.Name = "chkboxFornecedor";
            this.chkboxFornecedor.Size = new System.Drawing.Size(80, 17);
            this.chkboxFornecedor.TabIndex = 6;
            this.chkboxFornecedor.Text = "Fornecedor";
            this.chkboxFornecedor.UseVisualStyleBackColor = false;
            // 
            // chkboxVendedor
            // 
            this.chkboxVendedor.AutoSize = true;
            this.chkboxVendedor.BackColor = System.Drawing.Color.MistyRose;
            this.chkboxVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxVendedor.Location = new System.Drawing.Point(540, 35);
            this.chkboxVendedor.Name = "chkboxVendedor";
            this.chkboxVendedor.Size = new System.Drawing.Size(72, 17);
            this.chkboxVendedor.TabIndex = 7;
            this.chkboxVendedor.Text = "Vendedor";
            this.chkboxVendedor.UseVisualStyleBackColor = false;
            // 
            // lblInscEstadual
            // 
            this.lblInscEstadual.AutoSize = true;
            this.lblInscEstadual.BackColor = System.Drawing.Color.MistyRose;
            this.lblInscEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscEstadual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInscEstadual.Location = new System.Drawing.Point(462, 85);
            this.lblInscEstadual.Name = "lblInscEstadual";
            this.lblInscEstadual.Size = new System.Drawing.Size(57, 13);
            this.lblInscEstadual.TabIndex = 8;
            this.lblInscEstadual.Text = "Insc. Mun.";
            // 
            // txtboxInscMun
            // 
            this.txtboxInscMun.Location = new System.Drawing.Point(531, 83);
            this.txtboxInscMun.Name = "txtboxInscMun";
            this.txtboxInscMun.Size = new System.Drawing.Size(230, 20);
            this.txtboxInscMun.TabIndex = 9;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.MistyRose;
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCPF.Location = new System.Drawing.Point(28, 113);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // textBox1txtboxCPF
            // 
            this.textBox1txtboxCPF.Location = new System.Drawing.Point(75, 110);
            this.textBox1txtboxCPF.Name = "textBox1txtboxCPF";
            this.textBox1txtboxCPF.Size = new System.Drawing.Size(167, 20);
            this.textBox1txtboxCPF.TabIndex = 11;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.MistyRose;
            this.lblRG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRG.Location = new System.Drawing.Point(259, 117);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 12;
            this.lblRG.Text = "RG";
            // 
            // txtboxRG
            // 
            this.txtboxRG.Location = new System.Drawing.Point(288, 110);
            this.txtboxRG.Name = "txtboxRG";
            this.txtboxRG.Size = new System.Drawing.Size(160, 20);
            this.txtboxRG.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(462, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Insc. Est.";
            // 
            // txtboxInscEst
            // 
            this.txtboxInscEst.Location = new System.Drawing.Point(531, 110);
            this.txtboxInscEst.Name = "txtboxInscEst";
            this.txtboxInscEst.Size = new System.Drawing.Size(230, 20);
            this.txtboxInscEst.TabIndex = 15;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.MistyRose;
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSexo.Location = new System.Drawing.Point(28, 140);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo";
            // 
            // cmbboxSexo
            // 
            this.cmbboxSexo.FormattingEnabled = true;
            this.cmbboxSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbboxSexo.Location = new System.Drawing.Point(75, 137);
            this.cmbboxSexo.Name = "cmbboxSexo";
            this.cmbboxSexo.Size = new System.Drawing.Size(167, 21);
            this.cmbboxSexo.TabIndex = 17;
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.BackColor = System.Drawing.Color.MistyRose;
            this.lblDtNasc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDtNasc.Location = new System.Drawing.Point(270, 141);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(89, 13);
            this.lblDtNasc.TabIndex = 18;
            this.lblDtNasc.Text = "Data Nascimento";
            // 
            // dtpickerDtNasc
            // 
            this.dtpickerDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerDtNasc.Location = new System.Drawing.Point(375, 141);
            this.dtpickerDtNasc.MaxDate = new System.DateTime(2017, 9, 23, 0, 0, 0, 0);
            this.dtpickerDtNasc.Name = "dtpickerDtNasc";
            this.dtpickerDtNasc.Size = new System.Drawing.Size(108, 20);
            this.dtpickerDtNasc.TabIndex = 19;
            this.dtpickerDtNasc.Value = new System.DateTime(2017, 9, 23, 0, 0, 0, 0);
            // 
            // lblRazSocial
            // 
            this.lblRazSocial.AutoSize = true;
            this.lblRazSocial.BackColor = System.Drawing.Color.MistyRose;
            this.lblRazSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRazSocial.Location = new System.Drawing.Point(28, 173);
            this.lblRazSocial.Name = "lblRazSocial";
            this.lblRazSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazSocial.TabIndex = 20;
            this.lblRazSocial.Text = "Razão Social";
            // 
            // txtboxRazSocial
            // 
            this.txtboxRazSocial.Location = new System.Drawing.Point(104, 170);
            this.txtboxRazSocial.Name = "txtboxRazSocial";
            this.txtboxRazSocial.Size = new System.Drawing.Size(344, 20);
            this.txtboxRazSocial.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.MistyRose;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(478, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-mail";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(531, 170);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(230, 20);
            this.txtboxEmail.TabIndex = 23;
            // 
            // lblTelCom
            // 
            this.lblTelCom.AutoSize = true;
            this.lblTelCom.BackColor = System.Drawing.Color.MistyRose;
            this.lblTelCom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelCom.Location = new System.Drawing.Point(28, 202);
            this.lblTelCom.Name = "lblTelCom";
            this.lblTelCom.Size = new System.Drawing.Size(74, 13);
            this.lblTelCom.TabIndex = 24;
            this.lblTelCom.Text = "Tel. Comercial";
            // 
            // txtboxTelCom
            // 
            this.txtboxTelCom.Location = new System.Drawing.Point(104, 199);
            this.txtboxTelCom.Name = "txtboxTelCom";
            this.txtboxTelCom.Size = new System.Drawing.Size(158, 20);
            this.txtboxTelCom.TabIndex = 25;
            // 
            // txtboxTelRes
            // 
            this.txtboxTelRes.Location = new System.Drawing.Point(364, 199);
            this.txtboxTelRes.Name = "txtboxTelRes";
            this.txtboxTelRes.Size = new System.Drawing.Size(158, 20);
            this.txtboxTelRes.TabIndex = 27;
            // 
            // lblTelRes
            // 
            this.lblTelRes.AutoSize = true;
            this.lblTelRes.BackColor = System.Drawing.Color.MistyRose;
            this.lblTelRes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelRes.Location = new System.Drawing.Point(275, 202);
            this.lblTelRes.Name = "lblTelRes";
            this.lblTelRes.Size = new System.Drawing.Size(83, 13);
            this.lblTelRes.TabIndex = 26;
            this.lblTelRes.Text = "Tel. Residencial";
            // 
            // txtboxTelCel
            // 
            this.txtboxTelCel.Location = new System.Drawing.Point(603, 202);
            this.txtboxTelCel.Name = "txtboxTelCel";
            this.txtboxTelCel.Size = new System.Drawing.Size(158, 20);
            this.txtboxTelCel.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(537, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tel. Celular";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.MistyRose;
            this.lblEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnd.Location = new System.Drawing.Point(28, 246);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 30;
            this.lblEnd.Text = "Endereço";
            // 
            // txtboxEnd
            // 
            this.txtboxEnd.Location = new System.Drawing.Point(104, 243);
            this.txtboxEnd.Name = "txtboxEnd";
            this.txtboxEnd.Size = new System.Drawing.Size(418, 20);
            this.txtboxEnd.TabIndex = 31;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.MistyRose;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumero.Location = new System.Drawing.Point(542, 246);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 32;
            this.lblNumero.Text = "Número";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(603, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 33;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.MistyRose;
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComplemento.Location = new System.Drawing.Point(28, 272);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 34;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtboxComplemento
            // 
            this.txtboxComplemento.Location = new System.Drawing.Point(105, 269);
            this.txtboxComplemento.Name = "txtboxComplemento";
            this.txtboxComplemento.Size = new System.Drawing.Size(343, 20);
            this.txtboxComplemento.TabIndex = 35;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.MistyRose;
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBairro.Location = new System.Drawing.Point(497, 272);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 36;
            this.lblBairro.Text = "Bairro";
            // 
            // txtboxBairro
            // 
            this.txtboxBairro.Location = new System.Drawing.Point(545, 269);
            this.txtboxBairro.Name = "txtboxBairro";
            this.txtboxBairro.Size = new System.Drawing.Size(216, 20);
            this.txtboxBairro.TabIndex = 37;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.MistyRose;
            this.lblCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCEP.Location = new System.Drawing.Point(28, 297);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 38;
            this.lblCEP.Text = "CEP";
            // 
            // txtboxCEP
            // 
            this.txtboxCEP.Location = new System.Drawing.Point(75, 294);
            this.txtboxCEP.Name = "txtboxCEP";
            this.txtboxCEP.Size = new System.Drawing.Size(129, 20);
            this.txtboxCEP.TabIndex = 39;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.MistyRose;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(222, 297);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 40;
            this.lblEstado.Text = "Estado";
            // 
            // cmbboxEstado
            // 
            this.cmbboxEstado.FormattingEnabled = true;
            this.cmbboxEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Roraima",
            "Rondônia",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cmbboxEstado.Location = new System.Drawing.Point(268, 294);
            this.cmbboxEstado.Name = "cmbboxEstado";
            this.cmbboxEstado.Size = new System.Drawing.Size(215, 21);
            this.cmbboxEstado.TabIndex = 41;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.MistyRose;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCidade.Location = new System.Drawing.Point(497, 297);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 42;
            this.lblCidade.Text = "Cidade";
            // 
            // cmbboxCidade
            // 
            this.cmbboxCidade.FormattingEnabled = true;
            this.cmbboxCidade.Items.AddRange(new object[] {
            "Rio Branco",
            "Maceió",
            "Macapá",
            "Manaus",
            "Salvador",
            "Fortaleza",
            "Brasília",
            "Vitória",
            "Goiânia",
            "São Luís",
            "Cuiabá",
            "Campo Grande",
            "Belo Horizonte",
            "Belém",
            "João Pessoa",
            "Curitiba",
            "Recife",
            "Teresina",
            "Boa Vista",
            "Porto Velho",
            "Rio de Janeiro",
            "Natal",
            "Porta Alegre",
            "Florianópolis",
            "São Paulo",
            "Aracajú",
            "Palmas"});
            this.cmbboxCidade.Location = new System.Drawing.Point(545, 297);
            this.cmbboxCidade.Name = "cmbboxCidade";
            this.cmbboxCidade.Size = new System.Drawing.Size(216, 21);
            this.cmbboxCidade.TabIndex = 43;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.MistyRose;
            this.lblObservacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObservacao.Location = new System.Drawing.Point(13, 16);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 44;
            this.lblObservacao.Text = "Observação";
            // 
            // txtbboxObservacao
            // 
            this.txtbboxObservacao.Location = new System.Drawing.Point(84, 16);
            this.txtbboxObservacao.Multiline = true;
            this.txtbboxObservacao.Name = "txtbboxObservacao";
            this.txtbboxObservacao.Size = new System.Drawing.Size(662, 60);
            this.txtbboxObservacao.TabIndex = 45;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Red;
            this.btnNovo.Location = new System.Drawing.Point(507, 82);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 46;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Red;
            this.btnSalvar.Location = new System.Drawing.Point(588, 82);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 47;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(669, 82);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 48;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.MistyRose;
            this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDados.Location = new System.Drawing.Point(16, 27);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(760, 308);
            this.pnlDados.TabIndex = 49;
            // 
            // pnlObservacao
            // 
            this.pnlObservacao.BackColor = System.Drawing.Color.MistyRose;
            this.pnlObservacao.Controls.Add(this.btnExcluir);
            this.pnlObservacao.Controls.Add(this.txtbboxObservacao);
            this.pnlObservacao.Controls.Add(this.btnSalvar);
            this.pnlObservacao.Controls.Add(this.lblObservacao);
            this.pnlObservacao.Controls.Add(this.btnNovo);
            this.pnlObservacao.Location = new System.Drawing.Point(15, 341);
            this.pnlObservacao.Name = "pnlObservacao";
            this.pnlObservacao.Size = new System.Drawing.Size(760, 118);
            this.pnlObservacao.TabIndex = 50;
            // 
            // frmMFTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MFTD.Properties.Resources.fundo_sistema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 724);
            this.Controls.Add(this.cmbboxCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.cmbboxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtboxCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtboxBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtboxComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtboxEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtboxTelCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxTelRes);
            this.Controls.Add(this.lblTelRes);
            this.Controls.Add(this.txtboxTelCom);
            this.Controls.Add(this.lblTelCom);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxRazSocial);
            this.Controls.Add(this.lblRazSocial);
            this.Controls.Add(this.dtpickerDtNasc);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.cmbboxSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtboxInscEst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.textBox1txtboxCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtboxInscMun);
            this.Controls.Add(this.lblInscEstadual);
            this.Controls.Add(this.chkboxVendedor);
            this.Controls.Add(this.chkboxFornecedor);
            this.Controls.Add(this.chkboxCliente);
            this.Controls.Add(this.cmbboxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblCadPessoas);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlObservacao);
            this.DoubleBuffered = true;
            this.Name = "frmMFTD";
            this.Text = "MF Tec Digital - Sistema";
            this.Load += new System.EventHandler(this.frmMFTD_Load);
            this.pnlObservacao.ResumeLayout(false);
            this.pnlObservacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadPessoas;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbboxTipo;
        private System.Windows.Forms.CheckBox chkboxCliente;
        private System.Windows.Forms.CheckBox chkboxFornecedor;
        private System.Windows.Forms.CheckBox chkboxVendedor;
        private System.Windows.Forms.Label lblInscEstadual;
        private System.Windows.Forms.TextBox txtboxInscMun;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textBox1txtboxCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtboxRG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxInscEst;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbboxSexo;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.DateTimePicker dtpickerDtNasc;
        private System.Windows.Forms.Label lblRazSocial;
        private System.Windows.Forms.TextBox txtboxRazSocial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblTelCom;
        private System.Windows.Forms.TextBox txtboxTelCom;
        private System.Windows.Forms.TextBox txtboxTelRes;
        private System.Windows.Forms.Label lblTelRes;
        private System.Windows.Forms.TextBox txtboxTelCel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtboxEnd;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtboxComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtboxBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtboxCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbboxEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cmbboxCidade;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtbboxObservacao;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlObservacao;

    }
}

