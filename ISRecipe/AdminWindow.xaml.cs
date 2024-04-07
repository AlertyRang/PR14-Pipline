using System;
using System.Collections.Generic;
using System.Data;
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

namespace ISRecipe
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private ApiContext apiContext = new ApiContext();

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            DataTable table = new DataTable();
            ListViewItem item = sender as ListViewItem;
            switch (item.Content.ToString())
            {
                case "Users":
                    table = apiContext.ShowTable("Users");
                    DG_View.ItemsSource = table.DefaultView;
                    break;
                case "Recipes":
                    table = apiContext.ShowTable("Recipes");
                    DG_View.ItemsSource = table.DefaultView;
                    break;
            }
        }
    }
}
