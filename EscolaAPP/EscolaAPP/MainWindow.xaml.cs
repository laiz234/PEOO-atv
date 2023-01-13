using System.Windows;
using System.Windows.Controls;

namespace EscolaAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            Aluno t = new Aluno();
            t.Id = int.Parse(txtid.Text);
            t.Nome = txtnome.Text;
            t.Matricula = txtmatricula.Text;
            t.Email = txtemail.Text;
            NAluno.Inserir(t);
            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listaalunos.ItemsSource = null;
            listaalunos.ItemsSource = NAluno.Listar();
        }

        private void atualizarclick(object sender, RoutedEventArgs e)
        {
            Aluno t = new Aluno();
            t.Id = int.Parse(txtid.Text);
            t.Nome = txtnome.Text;
            t.Matricula = txtmatricula.Text;
            NAluno.Atualizar(t);
            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {
            Aluno t = new Aluno();
            t.Id = int.Parse(txtid.Text);
            NAluno.Excluir(t);
            listarclick(sender, e);
        }

        private void listaalunos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listaalunos.SelectedItem != null){
                Aluno obj = (Aluno)listaalunos.SelectedItem;
                txtid.Text = obj.Id.ToString();
                txtnome.Text = obj.Nome;
                txtemail.Text = obj.Email;
                txtmatricula.Text = obj.Matricula;
            }
        }
    }
}
