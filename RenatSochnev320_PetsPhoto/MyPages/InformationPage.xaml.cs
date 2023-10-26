﻿using RenatSochnev320_PetsPhoto.DB;
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
    /// Логика взаимодействия для InformationPage.xaml
    /// </summary>
    public partial class InformationPage : Page
    {
        public static List<PetsInfo> petsInfos {  get; set; }
        public InformationPage(User currentUser)
        {
            InitializeComponent();
            petsInfos = new List<PetsInfo>(DB.Connection.PetsPhotoEntities.PetsInfo.ToList().Where(x => x.Id_Pet == currentUser.Id_Pet));
        }
    }
}