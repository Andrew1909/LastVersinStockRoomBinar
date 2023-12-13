using StockroomBinar.BD;
using StockroomBinar.Class;
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
using System.Windows.Threading;

namespace StockroomBinar.Pages
{
    /// <summary>
    /// Логика взаимодействия для NotificationsPage.xaml
    /// </summary>
    public partial class NotificationsPage : Page
    {
        int natificationID = 0;
        public Notifications notifications = new Notifications();
        public NotificationsPage()
        {
            InitializeComponent();
            startclock();
            //var objA = Connect.bd.Notifications.Where(p => p.ID != 0).Count(); //проверяем данные о уведомлениях для отображения
            //if (objA == 0)
            //{
            //    ListViewItem lv = new ListViewItem();
            //    lv.Content = "Уведомлений нет";
            //    NotificationsView.Items.Add(lv);
            //}
            NotificationsView.ItemsSource = Connect.bd.Notifications.ToList();
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
             NotificationsView.ItemsSource = Connect.bd.Notifications.ToList();
        }

        private void DeleteNotifications_Click(object sender, RoutedEventArgs e)
        {
            var a = NotificationsView.SelectedItem as Notifications;
            if (a != null)
            {
                Connect.bd.Notifications.Remove(a);
                Connect.bd.SaveChanges();
                NotificationsView.ItemsSource = Connect.bd.Notifications.ToList();
            }
            //var objA = Connect.bd.Notifications.Where(p => p.ID != 0).Count(); //проверяем данные о уведомлениях для отображения
            //if (objA == 0)
            //{
            //    ListViewItem lv = new ListViewItem();
            //    lv.Content = "Уведомлений нет";
            //    NotificationsView.Items.Add(lv);
            //}
            else NotificationsView.ItemsSource = Connect.bd.Notifications.ToList();
        }
    }
}
