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

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void Vhodbtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Regesrtbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Reg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisrtationPage());
        }

        private void Reg_MouseEnter(object sender, MouseEventArgs e)
        {
            Reg.Foreground=new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Reg_MouseLeave(object sender, MouseEventArgs e)
        {
            Reg.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
