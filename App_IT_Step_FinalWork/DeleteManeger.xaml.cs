using Library_Db_IT_Step_FinalWork;
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

namespace App_IT_Step_FinalWork
{
    /// <summary>
    /// Interaction logic for DeleteManeger.xaml
    /// </summary>
    public partial class DeleteManeger : Window
    {

        private readonly IT_Step context;
        public DeleteManeger()
        {
            InitializeComponent();
            context = new IT_Step();
            ShowManager();
        }
        private void ShowManager()
        {
            grid.ItemsSource = context.Managers.ToList();
            gridTitle.Text = "Manager List";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Commands commands = new Commands();
            int idM = int.Parse(idMTextBox.Text);
            commands.DeleteManager(idM);
            MessageBox.Show("Manager wad Deleted");
        }

    }
}
