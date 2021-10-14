using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MyFinancas.MODEL;
using MyFinancas.MODEL.Repositories;

namespace MyFinancas.VIEWS.MVVM.Views.Ganhos.GanhosUI
{
    /// <summary>
    /// Interaction logic for GanhosUI.xaml
    /// </summary>
    public partial class GanhosUI : Window
    {
        Movimentacao oMovimentacao;
        RepositoryMovimentacao oRepositorio = new RepositoryMovimentacao();
        public GanhosUI()
        {
            InitializeComponent();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => novoGanho();
        

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        public void novoGanho()
        {
            try
            {
                oMovimentacao = new Movimentacao();
                oMovimentacao.Descricao = txtDescricao.Text;
                oMovimentacao.Ide = Guid.NewGuid();
                oMovimentacao.Tipo = "G";
                oMovimentacao.Valor = decimal.Parse(txtValor.Text);

                oRepositorio.Cadastrar(oMovimentacao);

                Spanel.Text = "Salvo com sucesso.";
            }
            catch (Exception e)
            {
                Spanel.Text = e.InnerException.Message;
            }
        }
    }
}
