using System;
using System.Collections;
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

namespace ISRecipe
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }
        private ApiContext apiContext = new ApiContext();

        private void BT_Back_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
            Close();
        }

        private void BT_Registration_Click(object sender, RoutedEventArgs e)
        {
            ArrayList arrayList = new ArrayList
            {
                TB_Name.Text,
                TB_Login.Text,
                PB_Password.Password,
                TB_Email.Text
            };
            try
            {
                apiContext.AddTable("Users", arrayList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
