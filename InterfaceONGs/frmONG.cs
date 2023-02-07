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
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using Correios.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;
using Org.BouncyCastle.Utilities.Collections;


namespace InterfaceONGs
{
    public partial class frmONG : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmONG()
        {
            InitializeComponent();
        }

        private void frmONG_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            pesquisaFuncionarios();
            buscarcodONG();
        }


        private void limparCampos()
        {
            cbocodFuncONG.ResetText();
            cboCategoriaONG.ResetText();
            txtnomeFuncONG.Clear();
            txtNomeONG.Clear();
            txtEmailONG.Clear();
            txtEnderecoONG.Clear();
            txtComplementoONG.Clear();
            txtsobreONG.Clear();
            txtSiteONG.Clear();
            txtBairroONG.Clear();
            txtCidadeONG.Clear();
            txtRedeSocialONG.Clear();
            mkdTelONG.Clear();
            mkdNumONG.Clear();
            mkdCNPJONG.Clear();
            mkdCEPONG.Clear();
            txtSenhaONG.Clear();

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbONG (Nome,Email,Senha,Tel,CNPJ,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Categoria,Descricao,WebSite,RedeSocial,codFunc)" + "values (@Nome,@Email,SHA2(@senha,256),@Tel,@CNPJ,@Endereco,@Numero,@Complemento,@CEP,@Bairro,@Cidade,@Categoria,@Descricao,@WebSite,@RedeSocial,@codFunc)";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();

            comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNomeONG.Text;
            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = txtEmailONG.Text;
            comm.Parameters.Add("@Senha", MySqlDbType.VarChar, 100).Value = txtSenhaONG.Text;
            comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 18).Value = mkdTelONG.Text;
            comm.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 25).Value = mkdCNPJONG.Text;
            comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 100).Value = txtEnderecoONG.Text;
            comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 10).Value = mkdNumONG.Text;
            comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 40).Value = txtComplementoONG.Text;
            comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 10).Value = mkdCEPONG.Text;
            comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairroONG.Text;
            comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidadeONG.Text;
            comm.Parameters.Add("@Categoria", MySqlDbType.VarChar, 15).Value = cboCategoriaONG.Text;
            comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 150).Value = txtsobreONG.Text;
            comm.Parameters.Add("@WebSite", MySqlDbType.VarChar, 75).Value = txtSiteONG.Text;
            comm.Parameters.Add("@RedeSocial", MySqlDbType.VarChar, 35).Value = txtRedeSocialONG.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 10).Value = cbocodFuncONG.Text;


            comm.Connection = Conexao.obterConexao();
            try
            {

                comm.ExecuteNonQuery();
                if (MessageBox.Show("Confirmar o cadastramento da ONG?", "Cadastro de ONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MessageBox.Show("ONG Cadastrado", "Cadastro de ONG", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("ONG não Cadastrada", "Cadastro de ONG", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Campos obrigatórios para concluir o cadastrado da ONG estão incorretos", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            Conexao.fecharConexao();

        }

        public string codONG = null;

        public void alterarONG(string codONG)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbONG set Nome = @Nome,Email = @Email, Senha = MD5(@senha) ,Tel = @Tel,CNPJ= @CNPJ,Endereco= @Endereco,Numero = @Numero,Complemento = @Complemento,CEP = @CEP ,Bairro = @Bairro,Cidade = @Cidade, Categoria = @Categoria,Descricao = @Descricao,WebSite =@WebSite, RedeSocial =@RedeSocial where codONG =" + cbocodONG.Text + "; ";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();

            comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNomeONG.Text;
            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = txtEmailONG.Text;
            comm.Parameters.Add("@Senha", MySqlDbType.VarChar, 100).Value = txtSenhaONG.Text;
            comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 18).Value = mkdTelONG.Text;
            comm.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 25).Value = mkdCNPJONG.Text;
            comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 100).Value = txtEnderecoONG.Text;
            comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 10).Value = mkdNumONG.Text;
            comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 40).Value = txtComplementoONG.Text;
            comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 10).Value = mkdCEPONG.Text;
            comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairroONG.Text;
            comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidadeONG.Text;
            comm.Parameters.Add("@Categoria", MySqlDbType.VarChar, 15).Value = cboCategoriaONG.Text;
            comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 150).Value = txtsobreONG.Text;
            comm.Parameters.Add("@WebSite", MySqlDbType.VarChar, 75).Value = txtSiteONG.Text;
            comm.Parameters.Add("@RedeSocial", MySqlDbType.VarChar, 35).Value = txtRedeSocialONG.Text;

            comm.ExecuteNonQuery();

            if (MessageBox.Show("Confirma a alteração dos dados da ONG", "Messangem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                MessageBox.Show("A alteração foi cancelada", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            Conexao.fecharConexao();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarONG(codONG);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar a limpeza dos campos de cadastramento da ONG?", "Cadastro de ONG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                limparCampos();

                MessageBox.Show("Limpeza Concluída", "Mensagem Sistema");
            }
            else
            {
                MessageBox.Show("Limpeza Cancelada", "Mensagem Sistema");
            }
        }

        private void buscarcodONG()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codONG` FROM `tbONG`order by codONG";
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            cbocodONG.Text = "";

            while (dr.Read())
            {
                cbocodONG.Items.Add(dr.GetInt32(0));
            }
            Conexao.fecharConexao();
        }

        private void buscainfsONG()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbONG  where  codONG like '%" + cbocodONG.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            txtNomeONG.Clear();
            txtEmailONG.Clear();
            txtSenhaONG.Clear();
            mkdTelONG.ResetText();
            txtEmailONG.Text = "";
            mkdNumONG.Text = "";
            txtComplementoONG.Text = "";
            mkdCEPONG.Text = "";
            txtBairroONG.Text = "";
            txtCidadeONG.Text = "";
            cboCategoriaONG.Text = "";
            txtSiteONG.Text = "";
            txtsobreONG.Text = "";
            txtRedeSocialONG.Text = "";


            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                txtNomeONG.Text = dr.GetString(1);
                txtEmailONG.Text = dr.GetString(2);
                txtSenhaONG.Text = dr.GetString(3);
                mkdTelONG.Text = dr.GetString(4);
                mkdCNPJONG.Text = dr.GetString(5);
                txtEnderecoONG.Text = dr.GetString(6);
                mkdNumONG.Text = dr.GetString(7);
                txtComplementoONG.Text = dr.GetString(8);
                mkdCEPONG.Text = dr.GetString(9);
                txtBairroONG.Text = dr.GetString(10);
                txtCidadeONG.Text = dr.GetString(11);
                cboCategoriaONG.Text = dr.GetString(12);
                txtsobreONG.Text = dr.GetString(13);
                txtSiteONG.Text = dr.GetString(14);
                txtRedeSocialONG.Text = dr.GetString(15);
                cbocodFuncONG.Text = dr.GetString(0);
            }
            Conexao.fecharConexao();

        }

        string pegainfs;
        string pegacodONG;

        private void cbocodONG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbocodONG.SelectedItem.ToString();
            string indic = cbocodONG.Text.ToString();

            string pegainfs = indic;
            string pegacodONG = indice;
        }


        private void cbocodONG_TextChanged(object sender, EventArgs e)
        {
            buscainfsONG();
        }





        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmailONG.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenhaONG.Focus();
            }
        }
        private void txtSenhaONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdTelONG.Focus();
            }

        }



        private void mkdTelFixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCNPJONG.Focus();
            }
        }

        private void mkdCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEnderecoONG.Focus();
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdNumONG.Focus();
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComplementoONG.Focus();
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cboCategoriaONG.Focus();
            }

        }

        private void cboCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsobreONG.Focus();
            }
        }

        private void txtsobreONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSiteONG.Focus();
            }

        }

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRedeSocialONG.Focus();
            }
        }

        public void pesquisaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codFunc`, `Nome` FROM `tbfuncionario`";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            cbocodFuncONG.Items.Clear();
            while (dr.Read())
            {
                cbocodFuncONG.Items.Add(dr.GetInt32(0));

            }
            Conexao.fecharConexao();
        }

        public string pegaCodFunc = "";

        private void cbocodFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbocodFuncONG.SelectedItem.ToString();
            pegaCodFunc = indice;


            if (cbocodFuncONG.SelectedIndex == 0)
            {
                txtnomeFuncONG.Text = "Thaina Araujo";
            }
            if (cbocodFuncONG.SelectedIndex == 1)
            {
                txtnomeFuncONG.Text = "Victória Amorim";
            }
            if (cbocodFuncONG.SelectedIndex == 2)
            {
                txtnomeFuncONG.Text = "Erik Costa";
            }
            if (cbocodFuncONG.SelectedIndex == 3)
            {
                txtnomeFuncONG.Text = "Caio Consiglio";
            }
            if (cbocodFuncONG.SelectedIndex == 4)
            {
                txtnomeFuncONG.Text = "José Hugo";
            }
        }



        public void carregaCEP(string cep)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            {
                WSCorreios.enderecoERP endereco = ws.consultaCEP(cep);
                txtEnderecoONG.Text = endereco.end;
                txtBairroONG.Text = endereco.bairro;
                txtCidadeONG.Text = endereco.cidade;

                mkdNumONG.Focus();
            }

            catch (Exception)
            {

                MessageBox.Show("CEP não encontrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                mkdCEPONG.Text = "";
                mkdCEPONG.Focus();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdministrador Paginaadmin = new frmAdministrador();
            Paginaadmin.Show();
            this.Hide();
        }

        private void mkdCEP_Leave(object sender, EventArgs e)
        {
            carregaCEP(mkdCEPONG.Text);
        }

        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carregaCEP(mkdCEPONG.Text);
                mkdNumONG.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbONG where CNPJ = @CNPJ";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 25).Value = mkdCNPJONG.Text;
            comm.ExecuteNonQuery();


            if (MessageBox.Show("Confirma a exclusão da ONG do Banco de dados ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Dados da ONG Excluído com Sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Dados da ONG para Exclusão Cancelada !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }


    }
}
