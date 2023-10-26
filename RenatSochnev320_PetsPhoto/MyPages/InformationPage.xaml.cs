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
using static System.Net.Mime.MediaTypeNames;

namespace RenatSochnev320_PetsPhoto.MyPages
{
    /// <summary>
    /// Логика взаимодействия для InformationPage.xaml
    /// </summary>
    public partial class InformationPage : Page
    {
        public static List<PetsInfo> petsInfos {  get; set; }
        public static User currentUser = new User();
        public static List<Pet> pets { get; set; }
        public InformationPage(User user)
        {
            InitializeComponent();
            currentUser = user;
            petsInfos = new List<PetsInfo>(DB.Connection.PetsPhotoEntities.PetsInfo.ToList().Where(x => x.Id_Pet == currentUser.Id_Pet));
            PetsList.ItemsSource = petsInfos;

            pets = new List<Pet>(DB.Connection.PetsPhotoEntities.Pet.ToList());
            pets.Insert(0, new Pet() { Id = 0, Name = "Все питомцы" });
            FilterCb.ItemsSource = pets;
            FilterCb.DisplayMemberPath = "Name";

        }

        private void GoAddPageBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyPages.AddPhotoPage(currentUser));
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            IEnumerable<PetsInfo> filterInfo = petsInfos;
            if (SearchTb.Text != "")
            {
                filterInfo = filterInfo.Where(x => x.Name.ToLower().StartsWith(SearchTb.Text.ToLower()));
            }

            if(FilterCb.SelectedIndex > 0)
            {
                Pet selectPet = FilterCb.SelectedItem as Pet;
                filterInfo = filterInfo.Where(x => x.Id_Pet == selectPet.Id);
            }


            PetsList.ItemsSource = filterInfo;
        }

        private void FilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
