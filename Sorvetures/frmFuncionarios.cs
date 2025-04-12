using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MosaicoSolutions.ViaCep;

namespace Sorvetures
{
    public partial class frmFuncionarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        //criando um método busca cep

        public void buscaCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            var endereco = viaCEPService.ObterEndereco(cep);
            
            txtLogradouro.Text = endereco.Logradouro;
            cbbUF.Text = endereco.UF;
            txtCidade.Text = endereco.Localidade;
            mskCEP.Text = endereco.Cep;
            txtComplemento.Text = endereco.Complemento;
            cbbEstado.Text = endereco.UF;
            
        }

        public frmFuncionarios() 
        {
            InitializeComponent();

            //executando o método desabilitar campos

            desabilitarcampos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
        //Desabilitando os componentes

        public void desabilitarcampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            mskTelefone.Enabled = false;
            cbbCargo.Enabled = false;
            dtpDataDeNascimento.Enabled = false;
            mskCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            cbbEstado.Enabled = false;
            txtComplemento.Enabled = false;
            cbbUF.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }
        //Habilitando os componentes

        public void habilitarcampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;
            cbbCargo.Enabled = true;
            dtpDataDeNascimento.Enabled = true;
            mskCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            txtComplemento.Enabled = true;
            cbbUF.Enabled = true;

            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            btnLimpar.Enabled = false;
            txtNome.Focus();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarcampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("")
                || txtEmail.Text.Equals("")
                || mskCPF.Text.Equals("   .   .   -")
                || cbbCargo.Text.Equals("")
                || mskTelefone.Text.Equals("     -")
                || mskCEP.Text.Equals("     -")
                || txtLogradouro.Text.Equals("")
                || txtNumero.Text.Equals("")
                || txtCidade.Text.Equals("")
                || cbbEstado.Text.Equals("")
                || cbbUF.Text.Equals("")
                || txtComplemento.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores");
            }
            else
            {
                MessageBox.Show("Cadastro com sucesso!!!");
                desabilitarcampos();

            }
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //executando o método busca cep
                buscaCEP(mskCEP.Text);
                txtNumero.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
