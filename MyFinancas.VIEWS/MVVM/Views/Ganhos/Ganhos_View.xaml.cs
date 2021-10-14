using MyFinancas.MODEL.Repositories;
using MyFinancas.VIEWS.MVVM.Views.Ganhos.GanhosUI;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFinancas.VIEWS.MVVM.Views
{
    /// <summary>
    /// Interaction logic for Ganhos_View.xaml
    /// </summary>
    public partial class Ganhos_View : UserControl
    {
        RepositoryMovimentacao _repositoryMovimentacao;
        public Ganhos_View()
        {
            atualizaGrade();
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GanhosUI ganhosUI = new GanhosUI();
            ganhosUI.Show();
        }

        private void atualizaGrade()
        {
            _repositoryMovimentacao = new RepositoryMovimentacao();
            grdGanhos.ItemsSource = _repositoryMovimentacao.ListarTodos();
        }
    }
}

