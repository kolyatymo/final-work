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
    /// Interaction logic for ChangeGroup.xaml
    /// </summary>
    public partial class ChangeGroup : Window
    {
        private readonly IT_Step context;
        public ChangeGroup()
        {
            InitializeComponent();
            context = new IT_Step();
            ShowGroups();
            
        }
        private void ShowGroups()
        {
            grid.ItemsSource = context.Groups.ToList();
            gridTitle.Text = "Groups List";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Commands commands = new Commands();
            int idT = int.Parse(idTTextBox.Text);
            int idG = int.Parse(idGTextBox.Text);
            commands.AddGroupToTeacher(idT, idG);
            MessageBox.Show("Teacher Group Add");
        }
    }
}
