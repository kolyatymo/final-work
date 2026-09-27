using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Library_Db_IT_Step_FinalWork;

namespace App_IT_Step_FinalWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private readonly IT_Step context;
        public MainWindow()
        {
            InitializeComponent();
            context = new IT_Step();
        }

        private void Print_Students(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Students.ToList();
        }

        private void Print_Managers(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Managers.ToList();
        }

        private void Print_Director(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Directors.ToList();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowTeachers();

            ChangeGroup changeGroup = new ChangeGroup();
            changeGroup.Show();
        }

        private void ShowTeachers()
        {
            grid.ItemsSource = context.Teachers.ToList();
            gridTitle.Text = "Teachers List";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ShowTeachers();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Teachers.ToList();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            DeleteTeacher deleteTeacher = new DeleteTeacher();
            deleteTeacher.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            DeleteManeger deleteManeger = new DeleteManeger();
            deleteManeger.Show();
        }
    }
}