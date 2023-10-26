using RenatSochnev320_PetsPhoto.DB;
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

namespace RenatSochnev320_PetsPhoto.MyPages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<User> users {  get; set; }
        public AuthorizationPage()
        {
            InitializeComponent();
            users = new List<User>(DB.Connection.PetsPhotoEntities.User.ToList());
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PasswordPb.Password;
            User currentUser = users.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (currentUser != null)
            {
                NavigationService.Navigate(new MyPages.InformationPage(currentUser));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
