using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISRecipe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private ApiContext apiContext = new ApiContext();

        private void BT_Add_Click(object sender, RoutedEventArgs e)
        {
            if(GR_Add.Visibility == Visibility.Visible)
                GR_Add.Visibility = Visibility.Hidden;
            else GR_Add.Visibility = Visibility.Visible;
        }

        private void BT_History_Click(object sender, RoutedEventArgs e)
        {
            HistoryWindow history = new HistoryWindow();
            history.Show();
            Close();
        }

        private void TB_Search_GotFocus(object sender, RoutedEventArgs e)
        {
            TB_Search.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable table = apiContext.ShowTable("Recipes");
            if (table != null)
            {
                foreach (DataRow tables in table.Rows)
                {
                    ListViewItem listItem = new ListViewItem();
                    listItem.Content = tables[1].ToString();
                    LV_Recipe.Items.Add(listItem);
                }
            }
        }

        private void LV_Recipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView list = (ListView)sender;
            ListViewItem listItem = (ListViewItem)list.SelectedItem;
            TB_Name.Text = listItem.Content.ToString();
        }

        private void BT_Add_F_Click(object sender, RoutedEventArgs e)
        {
            ArrayList arrayList = new ArrayList
            {
                TB_Name_Add.Text,
                TB_Portion_Add.Text,
                TB_Time_Add.Text,
                TB_Description_Add.Text,
                TB_Tag_Add.Text,
                TB_Category_Add.Text,
                "User",
                "User"
            };
            apiContext.AddTable("Recipes", arrayList);
        }
    }
}
