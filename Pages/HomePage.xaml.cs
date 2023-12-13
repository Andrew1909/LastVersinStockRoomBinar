using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using StockroomBinar.BD;
using StockroomBinar.Class;
using StockroomBinar.DialogWindow;

namespace StockroomBinar.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public Notifications notifications = new Notifications();
        public NotesUser notesUser = new NotesUser();
        public HomePage()
        {
            InitializeComponent();

            transform2.BeginAnimation(RotateTransform.AngleProperty,
            new DoubleAnimation
            {
                From = 0,
                To = 45,
                Duration = TimeSpan.FromSeconds(5)
            });

            transform1.BeginAnimation(RotateTransform.AngleProperty,
            new DoubleAnimation
            {
                From = 0,
                To = 45,
                Duration = TimeSpan.FromSeconds(5)
            });

            var objV = Connect.bd.NotesUser.Where(p => p.Status == true).Count();
            if (objV != 0)
            {
                for (int h = 0; h < objV; h++)
                {
                    var objX = Connect.bd.NotesUser.Where(p => p.Status == true).First();
                    Connect.bd.NotesUser.Remove(objX);
                    Connect.bd.SaveChanges();
                }

            }



            var objA = Connect.bd.Deliveries.Where(p => p.ID != 0).Count(); //проверяем данные о поставках для отображения
            if (objA == 0)
            {
                ListViewItem lv = new ListViewItem();
                lv.Content = "Данные о поставках отсутствуют";
                DeliversView.Items.Add(lv);
            }
            else DeliversView.ItemsSource = Connect.bd.Deliveries.OrderBy(p => p.Date).ToList();

            NotoficationDeliver();


            var objE = Connect.bd.NotesUser.Where(p => p.ID != 0).Count();
            if (objE == 0)
            {
                ListViewItem lv = new ListViewItem();
                lv.Content = "Напоминаний нет";
                NotessView.Items.Add(lv);
            }
            else
            {
                NotessView.ItemsSource = Connect.bd.NotesUser.ToList();
            }
            CountPlastOnStock.Text = (Connect.bd.PlasticStor.Where(p => p.ID != 0).Count()).ToString();

            CountDitalsOnStock.Text = (Connect.bd.DitalesProduction.Where(p => p.ID != 0).Count()+ Connect.bd.PlasticProducts.Where(p => p.ID != 0).Count()).ToString();

            var countDeliverAll = Connect.bd.Deliveries.Where(p => p.Date != null).Count();
            AllDeliverCount.Text = countDeliverAll.ToString();
        }

   

        void NotoficationDeliver()
        {
            DateTime a = DateTime.Now;
            var objA = Connect.bd.Deliveries.Where(p => p.Date < a).Count();
            if (objA != 0)
            {
                for (int j = 0; j < objA; j++)
                {

                    var objB = Connect.bd.Deliveries.First(p => p.Date < a);
                    string DescriptionNatification = $"Поставка для {objB.СustomerТame} просрочена";
                    var objC = Connect.bd.Notifications.Where(p => p.Descriptiont == DescriptionNatification).Count();
                    if (objC == 0)
                    {
                        notifications.Descriptiont = $"Поставка для {objB.СustomerТame} просрочена";
                        Connect.bd.Notifications.Add(notifications);
                        Connect.bd.SaveChanges();
                    }

                }
            }
        }


       
        private void info_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchInfoNat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LockInfoNatif_Click(object sender, RoutedEventArgs e)
        {
            var a = DeliversView.SelectedItem as Deliveries;
            if (a != null)
            {
                MyFrame.Navigate(new DeliveresInfoPage(a));
            }

        }

        private void DeleteNotifications_Click(object sender, RoutedEventArgs e)
        {
            //var a = NotificationsView.SelectedItem as Notifications;
            //if (a != null)
            //{
            //    Connect.bd.Notifications.Remove(a);
            //    Connect.bd.SaveChanges();
            //    NotificationsView.ItemsSource = Connect.bd.Notifications.ToList();
            //}
           //var objA = Connect.bd.Notifications.Where(p => p.ID != 0).Count(); //проверяем данные о уведомлениях для отображения
           // if (objA == 0)
           // {
           //     ListViewItem lv = new ListViewItem();
           //     lv.Content = "Уведомлений нет";
           //     NotificationsView.Items.Add(lv);
           // }
           // else NotificationsView.ItemsSource = Connect.bd.Notifications.ToList();
        }

        private void DoneNotes_Checked(object sender, RoutedEventArgs e)
        {
            var a = NotessView.SelectedItem as NotesUser;
            if (a != null)
            {
                notesUser = a;
                notesUser.Status = true;
                Connect.bd.SaveChanges();
                NotessView.ItemsSource = Connect.bd.NotesUser.ToList();
            }
        }

        private void DoneNotes_Unchecked(object sender, RoutedEventArgs e)
        {
            var a = NotessView.SelectedItem as NotesUser;
            if (a != null)
            {
                notesUser = a;
                notesUser.Status = false;
                Connect.bd.SaveChanges();

            }
            NotessView.ItemsSource = Connect.bd.NotesUser.ToList();
        }

        private void AddNotes_Click(object sender, RoutedEventArgs e)
        {
            AddNotesWindow TypeWindow = new AddNotesWindow();
            if (TypeWindow.ShowDialog() == true)
            {
                notesUser.Descriptions = TypeWindow.NewNotes.Text;
                notesUser.Status = false;
                Connect.bd.NotesUser.Add(notesUser);
                Connect.bd.SaveChanges();
            }
            MyFrame.Navigate(new HomePage());
        }

        private void AddNotes_MouseEnter(object sender, MouseEventArgs e)
        {
            //var button = sender as Button;
            //var WidthAnimation = new DoubleAnimation() { To = 210, Duration = TimeSpan.FromSeconds(0.3) };
            //var HeightAnimation = new DoubleAnimation() { To = 42, Duration = TimeSpan.FromSeconds(0.3) };

            //button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            //button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }

        private void AddNotes_MouseLeave(object sender, MouseEventArgs e)
        {
            //var button = sender as Button;
            //var WidthAnimation = new DoubleAnimation() { To = 200, Duration = TimeSpan.FromSeconds(0.2) };
            //var HeightAnimation = new DoubleAnimation() { To = 32, Duration = TimeSpan.FromSeconds(0.2) };

            //button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            //button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as StackPanel;
            var WidthAnimation = new DoubleAnimation() { To = 400, Duration = TimeSpan.FromSeconds(0.3) };
            var HeightAnimation = new DoubleAnimation() { To = 55, Duration = TimeSpan.FromSeconds(0.3) };

            button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }

        private void StackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            var button = sender as StackPanel;
            var WidthAnimation = new DoubleAnimation() { To = 190, Duration = TimeSpan.FromSeconds(0.3) };
            var HeightAnimation = new DoubleAnimation() { To = 40, Duration = TimeSpan.FromSeconds(0.3) };

            button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }
    }
}
