using Microsoft.Win32;
using RenatSochnev320_PetsPhoto.DB;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddPhotoPage.xaml
    /// </summary>
    public partial class AddPhotoPage : Page
    {
        public static List<Pet> pets { get; set; }
        public static PetsInfo petsInfo = new PetsInfo();
        public static User currentUser = new User();
        public AddPhotoPage(User user)
        {
            InitializeComponent();
            currentUser = user;
            pets = new List<Pet>(DB.Connection.PetsPhotoEntities.Pet.ToList());
            PetsCb.ItemsSource = pets;
            PetsCb.DisplayMemberPath = "Name";
        }

        private void AddInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder error = new StringBuilder();
                if (AddImg.Source == null)
                {
                    error.AppendLine("Загрузите изображение");
                }
                if (PetsCb.SelectedIndex == -1)
                {
                    error.AppendLine("Выберите питомца");
                }
                if (string.IsNullOrWhiteSpace(NameTb.Text))
                {
                    error.AppendLine("Напишите описание");
                }

                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                }
                else
                {
                    petsInfo.Name = NameTb.Text;
                    DB.Connection.PetsPhotoEntities.PetsInfo.Add(petsInfo);
                    DB.Connection.PetsPhotoEntities.SaveChanges();

                    MessageBox.Show("Ваше изображение добавлено");
                    AddImg.Source = null;
                    PetsCb.SelectedItem = null;
                    NameTb.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }

        }

        private void PetsCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pet selectPet = PetsCb.SelectedItem as Pet;
            if (selectPet != null)
            {

                NameTb.Text = string.Empty;
                NameTb.Text += selectPet.Name + " ";
                petsInfo.Id_Pet = selectPet.Id;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg|*.JPG|*.JPG"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                petsInfo.Photo = File.ReadAllBytes(openFileDialog.FileName);
                AddImg.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void GoInfoPageBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyPages.InformationPage(currentUser));
        }
    }
}
