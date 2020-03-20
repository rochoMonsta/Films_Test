using Microsoft.Win32;
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

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static string PhotoLinkString;
        public static User user;
        public Page1()
        {
            InitializeComponent();
            user = User.currentUser;
            if (user != null)
                userFromLoad.Content = user.ToString();
        }

        private void PhotoLink_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                PhotoLinkString = openDialog.FileName;
            }
        }

        private void AddFilmToUser_Click(object sender, RoutedEventArgs e)
        {
            var Film = new Film()
            {
                Name = FilmName.Text,
                Mark = Convert.ToDouble(Mark.Text),
                Link = PhotoLinkString
            };
            user.Films.Add(Film);
            userFromLoad.Content = Film.ToString();
        }
    }
}
