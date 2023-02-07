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
using Correios.Net;
using System.Runtime.ConstrainedExecution;

namespace InterfaceONGs
{
    public partial class frmFuncionario : Form
    {

        public string nome = "";
        public frmFuncionario()

        {
            InitializeComponent();

        }

        public frmFuncionario(string nome)
        {
            InitializeComponent();
            this.nome = nome;
            txtNomeFunc.Text = nome;
        }


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            buscarFunc();
        }

        public void carregaCEP(string cep)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            {
                WSCorreios.enderecoERP endereco = ws.consultaCEP(cep);
                txtEndereco.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;

                mkdNum.Focus();
            }

            catch (Exception)
            {

                MessageBox.Show("CEP não encontrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                mkdCEP.Text = "";
                mkdCEP.Focus();
            }


        }

        private void mkdCEP_Leave(object sender, EventArgs e)
        {
            carregaCEP(mkdCEP.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a limpeza dos registros de todos os campos", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                limparCampos();

                MessageBox.Show("Limpeza Conclúida", "Mensagem do Sistema");
            }
            else
            {
                MessageBox.Show("Limpeza Cancelada", "Mensagem do Sistema");
            }
        }

        public void limparCampos()
        {
            txtNomeFunc.Clear();
            txtComplemento.Clear();
            txtEMail.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mkdCEP.ResetText();
            mkdregistroFunc.ResetText();
            mkdSerie.ResetText();
            mkdCPF.ResetText();
            mkdCPTS.ResetText();
            mkdCel.ResetText();
            mkdNum.ResetText();
            cboCargo.ResetText();
            dtpNasc.ResetText();
            cbocodFunc.ResetText();
        }

        //KeyDown
      

        private void txtNome_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCPF.Focus();
            }
        }

        private void mkdCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpNasc.Focus();
            }


        }

        private void dtpNasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdregistroFunc.Focus();
            }
        }

        private void mkdregistroFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCPTS.Focus();
            }
        }

        private void mkdCPTS_KeyDown_1(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                mkdSerie.Focus();
            }
        }

        private void mkdSerie_KeyDown_1(object sender, KeyEventArgs e)
        {
            mkdCel.Focus();
        }

        private void mkdCel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEMail.Focus();
            }
        }

        private void txtEMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCEP.Focus();
            }
        }

        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carregaCEP(mkdCEP.Text);
                mkdNum.Focus();
            }
        }

        private void mkdNum_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComplemento.Focus();
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboCargo.Focus();
            }
        }


        //Ações de Botões 


        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();


                comm.CommandText = "insert into tbFuncionario (Nome,CPF,dataNascimento,registroFunc,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Cargo)" + "values (@Nome,@CPF,@dataNascimento,@registroFunc,@CTPS,@Serie,@Tel,@Email,@Endereco,@Numero,@Complemento,@CEP,@Bairro,@Cidade,@Cargo)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();

                comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNomeFunc.Text;
                comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 16).Value = mkdCPF.Text;
                comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dtpNasc.Value;
                comm.Parameters.Add("@registroFunc", MySqlDbType.VarChar, 7).Value = mkdregistroFunc.Text;
                comm.Parameters.Add("@CTPS", MySqlDbType.VarChar, 35).Value = mkdCPTS.Text;
                comm.Parameters.Add("@Serie", MySqlDbType.VarChar, 4).Value = mkdSerie.Text;
                comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 15).Value = mkdCPF.Text;
                comm.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = txtEMail.Text;
                comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 80).Value = txtEndereco.Text;
                comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 7).Value = mkdNum.Text;
                comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 45).Value = txtComplemento.Text;
                comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = mkdCEP.Text;
                comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairro.Text;
                comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidade.Text;
                comm.Parameters.Add("@Cargo", MySqlDbType.VarChar, 15).Value = cboCargo.Text;

                comm.Connection = Conexao.obterConexao();

                comm.ExecuteNonQuery();

                if (MessageBox.Show("Confirma o cadastrado do funcionário ?", "Menssagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    MessageBox.Show("Funcionário Cadastrado", "Mensagem do Sistema");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Cadastrado Cancelado", "Mensagem do Sistema");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos os campos para cadastrar o Funcionário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Conexao.fecharConexao();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult vresp;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionario where codFunc = @codFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 7).Value = cbocodFunc.Text;

            vresp = MessageBox.Show("Deseja apagar o registro?","Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (vresp == DialogResult.Yes)
            {
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Registos excluído com sucesso!!", "Mensagem do sistema",MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception)
                {

                    MessageBox.Show("Impossível excluir o funcionário, é necessário excluir o usuário de acesso ao sistema primeiro", "Mensagem do sistema",MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }


        public string codFunc = null;

        public void AlterarFunc(string codFunc)
        {

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "update tbFuncionario set Nome = @Nome,CPF = @CPF,dataNascimento = @dataNascimento, registroFunc = @registroFunc,CTPS = @CTPS,Serie = @Serie,Tel = @Tel,Email = @Email ,Endereco = @Endereco,Numero = @Numero,Complemento =@Complemento,CEP = @CEP,Bairro = @Bairro,Cidade = @Cidade,Cargo = @Cargo  where codFunc = " + cbocodFunc.Text + ";";

            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 16).Value = mkdCPF.Text;
            comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dtpNasc.Value;
            comm.Parameters.Add("@registroFunc", MySqlDbType.VarChar, 7).Value = mkdregistroFunc.Text;
            comm.Parameters.Add("@CTPS", MySqlDbType.VarChar, 35).Value = mkdCPTS.Text;
            comm.Parameters.Add("@Serie", MySqlDbType.VarChar, 4).Value = mkdSerie.Text;
            comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 15).Value = mkdCel.Text;
            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = txtEMail.Text;
            comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 80).Value = txtEndereco.Text;
            comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 7).Value = mkdNum.Text;
            comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 45).Value = txtComplemento.Text;
            comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = mkdCEP.Text;
            comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairro.Text;
            comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidade.Text;
            comm.Parameters.Add("@Cargo", MySqlDbType.VarChar, 15).Value = cboCargo.Text;

            try
            {


            comm.ExecuteNonQuery();

            if (MessageBox.Show("Confirma a alteração do Registro do Funcionário","Mensagem do Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar os registros", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Conexao.fecharConexao();
            }
            catch (Exception)
            {

                MessageBox.Show("Existe campos vázios","Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            cbocodFunc.Focus();

            AlterarFunc(codFunc);
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAdministrador abrirAdmin = new frmAdministrador();
            abrirAdmin.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionario pesquisarFunc = new frmPesquisarFuncionario();
            pesquisarFunc.ShowDialog();
        }


        

        //`Nome`,`CPF`,`dataNascimento`,`registroFunc`,`CTPS`,`Serie`,`Tel`,`Email`,`Endereco`,`Numero`,`Complemento`,`CEP`,`Bairro`,`Cidade`,`Cargo`
        private void buscarFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codFunc` FROM `tbFuncionario`order by codFunc";
            comm.Connection = Conexao.obterConexao();
            
            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            cbocodFunc.Text = "";

            while (dr.Read())
            {
                cbocodFunc.Items.Add(dr.GetInt32(0));
            }
            Conexao.fecharConexao();

           
        }
        private void buscainfs()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionario  where  codFunc like '%"+ cbocodFunc.Text +"%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            txtNomeFunc.Clear();
            mkdCPF.ResetText();
            dtpNasc.ResetText();
            mkdregistroFunc.ResetText();
            mkdCPTS.ResetText();
            mkdSerie.ResetText();
            mkdCel.ResetText();
            txtEMail.Clear();
            txtEndereco.Clear();
            mkdNum.ResetText();
            txtComplemento.Clear();
            mkdCEP.ResetText();
            txtBairro.Clear();
            txtCidade.Clear();
            cboCargo.Text = "";

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                txtNomeFunc.Text = dr.GetString(1);
                mkdCPF.Text = dr.GetString(2);
                dtpNasc.Text = dr.GetString(3);
                mkdregistroFunc.Text = dr.GetString(4);
                mkdCPTS.Text = dr.GetString(5);
                mkdSerie.Text = dr.GetString(6);
                mkdCel.Text = dr.GetString(7);
                txtEMail.Text = dr.GetString(8);
                txtEndereco.Text = dr.GetString(9);
                mkdNum.Text = dr.GetString(10);
                txtComplemento.Text = dr.GetString(11);
                mkdCEP.Text = dr.GetString(12);
                txtBairro.Text = dr.GetString(13);
                txtCidade.Text = dr.GetString(14);
                cboCargo.Text = dr.GetString(15);
            }
            Conexao.fecharConexao();

        }

        string pegainfs;
        string pegaFunc;
        private void cbocodFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbocodFunc.SelectedItem.ToString();
            string indic = cbocodFunc.Text.ToString();

            string pegainfs = indic;
            string pegaFunc = indice;
        }

        private void cbocodFunc_TextChanged(object sender, EventArgs e)
        {
            buscainfs();
        }
       
    }
}
