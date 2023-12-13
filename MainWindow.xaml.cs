using StockroomBinar.Class;
using StockroomBinar.Pages;
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
using Tulpep.NotificationWindow;
using System.Windows.Threading;

namespace StockroomBinar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int countNatifications=0;
        private PopupNotifier popup = null;
        public MainWindow()
        {
            InitializeComponent();
            startclock();
            var CountNat = Connect.bd.Notifications.Where(p => p.ID != 0).Count();
            countNatifications = CountNat;

            if (CountNat == 0)
            {
                CountNotitfication.Visibility = Visibility.Hidden;
            }
            if (CountNat != 0)
            {
                CountNotitfication.Visibility = Visibility.Visible;
                CountNotitfication.Text=countNatifications.ToString();
            }

            //popup= new PopupNotifier();
            //popup.TitleText = "Добро пожаловать!";
            //popup.ContentText = "С первым заходом!";

            MyFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MyFrameNotifications.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MyFrame.Navigate(new HomePage());
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\BinarStokroom");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
         //dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Profiles");
         //   if (!dirInfo.Exists)
         //   {
         //       dirInfo.Create();
         //   }
         //   dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Profiles\\Profiles3Dprint");
         //   if (!dirInfo.Exists)
         //   {
         //       dirInfo.Create();
         //   }
         //   dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Profiles\\ProfilesEgraving");
         //   if (!dirInfo.Exists)
         //   {
         //       dirInfo.Create();
            //}

            dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Reports");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Blueprints");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Blueprints\\Construction Blueprints");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo = new DirectoryInfo("C:\\BinarStokroom\\Blueprints\\ESK Blueprints");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            //popup.Popup();
        }
        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }
        private void tickevent(object sender, EventArgs e)
        {
            var CountNat = Connect.bd.Notifications.Where(p => p.ID != 0).Count();
            countNatifications = CountNat;

            if (CountNat == 0)
            {
                CountNotitfication.Visibility = Visibility.Hidden;
            }
            if (CountNat != 0)
            {
                CountNotitfication.Visibility = Visibility.Visible;
                CountNotitfication.Text = countNatifications.ToString();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlasticOnStock_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PlasticStorage());
            //Pastick.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#303841");


        }

        private void Recycling_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new WasteRecyclingPage());
            //Pastick.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#303841");
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Defective_Click(object sender, RoutedEventArgs e)
        {
            //Pastick.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#303841");
            MyFrame.Navigate(new DefectiveCoilsPage());


        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new HomePage());
        }

        private void SettingWindow_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new SettingPage());
        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new СalculatorPage());
        }

        private void Delivering_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new StatisticsOnOrdersPage(0)) ;
        }

        private void PlasticDitals_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PlasticDitalesPage());
        }

        private void DitalsFromProduction_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new DeitalesProductionPage());
        }

        private void Engraving_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new EngravingPage());
        }

        private void EngravingProfils_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new EngravingProfilPage());
        }

        private void RecyclingProjils_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {

        }

        private void PrintProfils_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Print3DProfilsPage());
        }

        private void Printers3D_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new For3DPrintingPage());
        }

        private void ESKBlueprints_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new ESKBlueprintsPage());
        }

        private void KonstruktionsBlueprints_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new ConstructionBlueprintsPage());
        }

        private void CloudLick_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://drive.google.com/drive/folders/1kEauMrjkOQsKvLsHDyfpmgjrCMhdSyZc?usp=sharing");
        }

        private void BinarSite_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://www.binar.ru/");
        }

        int idNot = 0;
        private void NotificationeWindow_Click(object sender, RoutedEventArgs e)
        {
            if (idNot == 1)
            {
                MyFrameNotifications.Visibility = Visibility.Hidden;
                MyFrameNotifications.NavigationService.RemoveBackEntry();
                idNot = 10;
                NotificationeWindow.Background = new SolidColorBrush(Color.FromRgb(48, 56, 65));
            }
            if (idNot == 0)
            {
                MyFrameNotifications.Visibility = Visibility.Visible;
                MyFrameNotifications.Navigate(new NotificationsPage());
                NotificationeWindow.Background= new SolidColorBrush(Color.FromRgb(70, 68, 81));

                idNot = 1;

            }
            if(idNot == 10)
            {
                idNot = 0;
            }
            

        }
    }
}
