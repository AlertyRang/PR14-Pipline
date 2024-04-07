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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private ApiContext apiContext = new ApiContext();

        private void BT_Vhod_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Login.Text == "Admin" && PB_Password.Password == "Admin")
            {
                AdminWindow admin = new AdminWindow();
                admin.Show();
                Close();
            }
            DataTable tabler = apiContext.ShowTable("Users");
            foreach (DataRow table in tabler.Rows)
            {
                if (TB_Login.Text == table[2].ToString() && PB_Password.Password == table[3].ToString())
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    Close();
                }
            }
        }

        private void BT_Registration_Click(object sender, RoutedEventArgs e)
        {
            RegWindow reg = new RegWindow();
            reg.Show();
            Close();
        }
    }
}
