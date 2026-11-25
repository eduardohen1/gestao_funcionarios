using GestaoFuncarios.Model;

namespace GestaoFuncarios
{
    public partial class Form1 : Form
    {
        private readonly List<Funcionario> lstFuncionario = new();
        private int posicao = -1;

        public Form1()
        {
            InitializeComponent();

            cmbTipoFuncionario.Items.Add("CLT");
            cmbTipoFuncionario.Items.Add("Comissionado");
            cmbTipoFuncionario.SelectedIndex = 0;

            cmbTipoFuncionario.SelectedIndexChanged +=
                (s, e) => atualizarCamposTipo();

            atualizarCamposTipo();
            limparCampos();

        }

        private void atualizarCamposTipo()
        {
            bool clt = cmbTipoFuncionario.SelectedIndex == 0;
            if (clt)
            {
                txtTotalVendas.Enabled = false;
                txtComissao.Enabled = false;
            }
            else
            {
                txtTotalVendas.Enabled = true;
                txtComissao.Enabled = true;
            }
        }

        private void limparCampos()
        {
            txtMatricula.Clear();
            txtNome.Clear();
            txtSalarioBase.Clear();
            txtComissao.Clear();
            txtTotalVendas.Clear();

            cmbTipoFuncionario.SelectedIndex = 0;
        }

        private void exibirFuncionario()
        {
            if(posicao < 0 || posicao >= lstFuncionario.Count)
            {
                limparCampos();
                return; //matar a função
            }
            Funcionario funcionario = lstFuncionario[posicao];

            txtMatricula.Text = funcionario.Matricula.ToString();
            txtNome.Text = funcionario.Nome.ToString();
            txtSalarioBase.Text = funcionario.SalarioBase.ToString();

            //instanceof -- java
            if(funcionario is FuncionarioComissionado fc)
            {
                cmbTipoFuncionario.SelectedIndex = 1;
                txtTotalVendas.Text = fc.TotalVendas.ToString();
                txtComissao.Text = fc.PercentualComissao.ToString();

            }
            else
            {
                cmbTipoFuncionario.SelectedIndex = 0;
                txtTotalVendas.Clear();
                txtComissao.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularRemuneracao_Click(object sender, EventArgs e)
        {
            if(posicao < 0 || posicao >= lstFuncionario.Count)
            {
                MessageBox.Show("Selecione um funcionário gravado!");
                return;
            }
            Funcionario funcionario = lstFuncionario[posicao];
            txtSalarioCalculado.Text = $"{funcionario.CalcularSalario():C2}";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            posicao = -1;
            limparCampos();
        }

        private bool validarTela()
        {
            bool resposta = true;

            if(txtMatricula.Text.Length == 0)
            {
                resposta = false;
            }
            else
            {
                //se não for inteiro, dar erro
                if (!int.TryParse(txtMatricula.Text, out int matricula))
                    resposta = false;
            }
            if (txtNome.Text.Length == 0)
                resposta = false;


            return resposta;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validarTela())
            {
                MessageBox.Show("Campos em branco. Verifique!");
                return;
            }
            Funcionario funcionario;
            if(cmbTipoFuncionario.SelectedIndex == 0)
            {
                //clt
                int matricula = int.Parse(txtMatricula.Text);
                decimal salario = decimal.Parse(txtSalarioBase.Text);
                funcionario = new FuncionarioCLT(matricula,
                    txtNome.Text, salario);

            }
            else
            {
                //comissionado
                int matricula = int.Parse(txtMatricula.Text);
                decimal salario = decimal.Parse(txtSalarioBase.Text);
                decimal totalVendas = decimal.Parse(txtTotalVendas.Text);
                decimal comissao = decimal.Parse(txtComissao.Text);
                funcionario = new FuncionarioComissionado(
                    matricula, txtNome.Text, salario,
                    totalVendas, comissao
                    );
            }
            if(posicao == -1)
            {
                lstFuncionario.Add(funcionario);
                posicao = lstFuncionario.Count - 1;
            }
            else
            {
                lstFuncionario[posicao] = funcionario;
            }
            exibirFuncionario();
            MessageBox.Show("Registro gravado com sucesso!");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(posicao > 0)
            {
                posicao--; //posicao = posicao -1
                exibirFuncionario();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if(posicao < lstFuncionario.Count - 1)
            {
                posicao++;
                exibirFuncionario();
            }
        }
    }
}