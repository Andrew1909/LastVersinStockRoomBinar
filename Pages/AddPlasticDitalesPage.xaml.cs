using StockroomBinar.BD;
using StockroomBinar.Class;
using StockroomBinar.DialogWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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

namespace StockroomBinar.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPlasticDitalesPage.xaml
    /// </summary>
    public partial class AddPlasticDitalesPage : Page
    {
        public IDPlasticProducts idPlasticProducts = new IDPlasticProducts();
        public PlasticProducts plasticProducts = new PlasticProducts();
        public ProductsForEngraving forEngraving = new ProductsForEngraving();
        public RecyclingPlastic recyclingPlastic = new RecyclingPlastic();
        public Notifications notifications = new Notifications();

        decimal SupportsWidth;
        int CountEngraving;
        string NameDitaliesID = "";
        string ColorNamePlast = "";
        string Manufactr = "";
        string TypePlast = "";
        decimal SupportsWight1=0;
        int IDPlast;

        bool IgnorCountplast = false;

        //char[] alpha = {"ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuioplkjhgfdsazxcvbnm".ToCharArray();

        public AddPlasticDitalesPage()
        {
            InitializeComponent();

            var a = Connect.bd.IDPlasticProducts.Where(p => p.ID != 0).Count();  //заносим данные ID деталей из пластика из БД в combobox 
            AddNameDitalies.Items.Add("Выберите изделие");
            for (int j = 1; j <= int.Parse(a.ToString()); j++)
            {
                var s = Connect.bd.IDPlasticProducts.Where(p => p.IDInside == j).Count();
                if (s != 0)
                {
                    var a1 = Connect.bd.IDPlasticProducts.First(p => p.IDInside == j);
                    AddNameDitalies.Items.Add(a1.NameProduct.ToString());
                }
            }

             a = Connect.bd.PlasticStor.Where(p => p.ID != 0).Count();
            AddColordNamePlastic.Items.Add("Выберите цвет платика");
            for (int j = 1; j <= int.Parse(a.ToString()); j++)
            {
                var s = Connect.bd.PlasticStor.Where(p => p.IDInsaid == j).Count();
                if (s != 0)
                {
                    var a1 = Connect.bd.PlasticStor.First(p => p.IDInsaid == j);
                    AddColordNamePlastic.Items.Add(a1.ColorName.ToString()+" Тип: "+a1.PlasticType.ToString()+" Производитель: "+a1.Manufacturer.ToString());
                }
            }
            AddColordNamePlastic.SelectedIndex = 0;
            AddNameDitalies.SelectedIndex = 0;
            Plus.Visibility = Visibility.Hidden;
            NextTextSupports.Visibility = Visibility.Hidden;
            EngravingText.Visibility = Visibility.Hidden;
        }



        void plasticStorageSort()
        {
            var plast = Connect.bd.PlasticStor.Where(p => p.ID != 0).Count(); //считаем количество пластика
            for (int i = 0; i < int.Parse(plast.ToString()); i++)
            {
                var plast2 = Connect.bd.PlasticStor.Where(p => p.Weight.Value <= 0.2m).Count();//считаем количество пластика для списания. МИНИМАЛЬНОЕ ЧИСЛО СПИСАНИЯ ТУТ
                if (plast2 != 0)
                {
                    var objX = Connect.bd.PlasticStor.First(p => p.Weight.Value <= 0.2m);
                    var objY = Connect.bd.RecyclingPlastic.Where(p => p.ColorNameRecucling == objX.ColorName && p.PlasticTypeRecucling == objX.PlasticType && p.ManufacturerRecucling == objX.Manufacturer).Count();
                    if (objY != 0)
                    {
                        AddNatification(objX.ID);
                        var objY1 = Connect.bd.RecyclingPlastic.First(p => p.ColorNameRecucling == objX.ColorName && p.PlasticTypeRecucling == objX.PlasticType && p.ManufacturerRecucling == objX.Manufacturer);
                        recyclingPlastic = objY1;
                        recyclingPlastic.WeightRecucling = recyclingPlastic.WeightRecucling + objX.Weight;
                        Connect.bd.SaveChanges();
                        Connect.bd.PlasticStor.Remove(objX);
                        Connect.bd.SaveChanges();
                    }
                    else
                    {
                        var objM = Connect.bd.RecyclingPlastic.Where(p => p.IDInside != 0).Count();
                        AddNatification(objX.ID);
                        recyclingPlastic.ID = objX.ID;
                        recyclingPlastic.ColorNameRecucling = objX.ColorName;
                        recyclingPlastic.PlasticTypeRecucling = objX.PlasticType;
                        recyclingPlastic.ManufacturerRecucling = objX.Manufacturer;
                        recyclingPlastic.WeightRecucling = objX.Weight;
                        var plast3 = Connect.bd.PlasticStor.Where(p => p.ColorName == objX.ColorName).Count();
                        if (plast3 > 1)
                        {
                            recyclingPlastic.PlasticStatus = 1;
                        }
                        else recyclingPlastic.PlasticStatus = 0;
                        recyclingPlastic.StatusRecucling = false;
                        if (objM == 0) recyclingPlastic.IDInside = 1;
                        else recyclingPlastic.IDInside = Connect.bd.RecyclingPlastic.Select(p => p.IDInside).Max() + 1;
                        Connect.bd.RecyclingPlastic.Add(recyclingPlastic);
                        Connect.bd.SaveChanges();
                        Connect.bd.PlasticStor.Remove(objX);
                        Connect.bd.SaveChanges();
                    }

                }
            }
        }


        void AddNatification(int id)
        {
            var objX = Connect.bd.PlasticStor.First(p => p.ID == id);
            notifications.Descriptiont = $"Пластик {objX.ColorName} от производятеля {objX.Manufacturer} закончился";
            Connect.bd.Notifications.Add(notifications);
            Connect.bd.SaveChanges();
        }

        private void AddNewNameDitales_Click(object sender, RoutedEventArgs e)
        {
            AddNewDitalesWindow DitalesWindow = new AddNewDitalesWindow();
            if (DitalesWindow.ShowDialog() == true)
            {
                var check = Connect.bd.IDPlasticProducts.Where(p=>p.NameProduct== DitalesWindow.NewDitales.ToString()).Count();
                var objA = Connect.bd.IDPlasticProducts.Where(p => p.ID != 0).Count();
                if (check == 0)
                {
                    idPlasticProducts.NameProduct = DitalesWindow.NewDitales.ToString();
                    idPlasticProducts.IDInside = objA + 1;
                    Connect.bd.IDPlasticProducts.Add(idPlasticProducts);
                    Connect.bd.SaveChanges();
                    MessageBox.Show("Изделие добавлено!");
                    MyFrame.Navigate(new AddPlasticDitalesPage());
                }
                else MessageBox.Show("Такое изделие уже есть!");
            }
        }

        private void AddDitalis_Click(object sender, RoutedEventArgs e)
        {
            if (AddNameDitalies.SelectedIndex == 0 || AddColordNamePlastic.SelectedIndex == 0 || AddWidthDitales.Text == null  || AddTimeDitalis.Text == null || AddCountDitalis.Text == null)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                int index1 = AddNameDitalies.SelectedIndex;
                if (AddNameDitalies.SelectedIndex == index1)
                {
                    if (index1 > 0) //запиывем в переменные выборы из комбобокса
                    {
                        var a1 = Connect.bd.IDPlasticProducts.First(p => p.IDInside == index1);
                        NameDitaliesID = a1.NameProduct;
                    }
                }
                index1 = AddColordNamePlastic.SelectedIndex;

       
                if (AddColordNamePlastic.SelectedIndex == index1)
                {
                    if (index1 > 0)
                    {
                        var a1 = Connect.bd.PlasticStor.First(p => p.IDInsaid == index1);
                        ColorNamePlast = a1.ColorName;
                        Manufactr = a1.Manufacturer;
                        TypePlast = a1.PlasticType;
                        IDPlast = index1;
                    }
                }

                if (IgnorCountplast == true)
                {
                    var objA = Connect.bd.PlasticProducts.Where(p => p.ProductTypeID == NameDitaliesID && p.ColorName == ColorNamePlast && p.ManufacturerPlasticPrint == Manufactr && p.TypePlasticPrint == TypePlast).Count(); //проверяем, есть ли в БД уже эта деталь     
                        if (objA != 0)
                        {
                            //есть ли такая деталь с той же датой производства

                            var objB = Connect.bd.PlasticProducts.First(p => p.ProductTypeID == NameDitaliesID && p.ColorName == ColorNamePlast && p.ManufacturerPlasticPrint == Manufactr && p.TypePlasticPrint == TypePlast);
                            if (CountEngraving != 0)
                            {
                                plasticStorageSort();
                                EngraveringFunc(objB.ID, 1);
                                objB.ProductWeight = (decimal.Parse(AddWidthDitales.Text));
                                objB.SupportsWeight = SupportsWight1;
                                objB.CountOnStoock = int.Parse(AddCountDitalis.Text) + objB.CountOnStoock;
                                objB.EngravingStatus = objB.EngravingStatus + (int.Parse(AddCountDitalis.Text) - CountEngraving);
                                Connect.bd.SaveChanges();
                                MessageBox.Show("Детали добавлены к существующей записи!");
                                CuountCoils();
                                MyFrame.Navigate(new PlasticDitalesPage());
                            }
                            else
                            {
                                plasticStorageSort();
                                objB.ProductWeight = decimal.Parse(AddWidthDitales.Text);
                                objB.SupportsWeight = SupportsWight1;
                                objB.CountOnStoock = int.Parse(AddCountDitalis.Text) + objB.CountOnStoock;
                                objB.EngravingStatus = objB.CountOnStoock;
                                Connect.bd.SaveChanges();
                                MessageBox.Show("Детали добавлены к существующей записи!");
                                CuountCoils();
                                MyFrame.Navigate(new PlasticDitalesPage());
                            }
                        }
                        else
                        {
                            AddNewDeitales();
                            CuountCoils();
                        }  
                }


                if (IgnorCountplast == false)
                {
                    var objA = Connect.bd.PlasticProducts.Where(p => p.ProductTypeID == NameDitaliesID && p.ColorName == ColorNamePlast && p.ManufacturerPlasticPrint == Manufactr && p.TypePlasticPrint == TypePlast).Count(); //проверяем, есть ли в БД уже эта деталь
                    var objC = Connect.bd.PlasticStor.First(p => p.IDInsaid == IDPlast);
                    decimal WeightSum = (decimal.Parse(SupportsWight1.ToString()) + decimal.Parse(AddWidthDitales.Text)) * decimal.Parse(AddCountDitalis.Text);
                    if (WeightSum <= objC.Weight)//хватит ли платика на складе
                    {
                        objC.Weight = objC.Weight - WeightSum;
                        Connect.bd.SaveChanges();
                        if (objA != 0)
                        {
                            //есть ли такая деталь с той же датой производства

                            var objB = Connect.bd.PlasticProducts.First(p => p.ProductTypeID == NameDitaliesID && p.ColorName == ColorNamePlast && p.ManufacturerPlasticPrint == Manufactr && p.TypePlasticPrint == TypePlast);
                            if (CountEngraving != 0)
                            {
                                plasticStorageSort();
                                EngraveringFunc(objB.ID, 1);
                                objB.ProductWeight = (decimal.Parse(AddWidthDitales.Text));
                                objB.SupportsWeight = SupportsWight1;
                                objB.CountOnStoock = int.Parse(AddCountDitalis.Text) + objB.CountOnStoock;
                                objB.EngravingStatus = objB.EngravingStatus + (int.Parse(AddCountDitalis.Text) - CountEngraving);
                                Connect.bd.SaveChanges();
                                MessageBox.Show("Детали добавлены к существующей записи!");
                                CuountCoils();
                                MyFrame.Navigate(new PlasticDitalesPage());
                            }
                            else
                            {
                                plasticStorageSort();
                                objB.ProductWeight = decimal.Parse(AddWidthDitales.Text);
                                objB.SupportsWeight = SupportsWight1;
                                objB.CountOnStoock = int.Parse(AddCountDitalis.Text) + objB.CountOnStoock;
                                objB.EngravingStatus = objB.CountOnStoock;
                                Connect.bd.SaveChanges();
                                MessageBox.Show("Детали добавлены к существующей записи!");
                                CuountCoils();
                                MyFrame.Navigate(new PlasticDitalesPage());
                            }
                        }
                        else
                        {
                            AddNewDeitales();
                            CuountCoils();
                        }
                    }
                    else MessageBox.Show("Нехватает платика!");
                }
            }

                
        }

        void CuountCoils() //пересчитываем катушки с учетом остатка платика
        {
            var plast = Connect.bd.PlasticStor.Where(p => p.ID != 0).Count(); //считаем количество пластика
            plast++;


            for (int j = 1; j < plast; j++)
            {
                //var objA = Connect.bd.PlasticStor.Where(p => p.NumberСoils < p.Weight).Count();
                var objA = Connect.bd.PlasticStor.First(p => p.IDInsaid == j);
                double min = double.Parse(objA.NumberСoils.ToString()) - double.Parse(objA.Weight.ToString());
                string min2 = min.ToString();
                if (min >= 1)
                {
                    string[] words = min2.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    objA.NumberСoils = objA.NumberСoils - int.Parse(words[0].ToString());
                    Connect.bd.SaveChanges();
                }

            }
        }

        void AddNewDeitales()
        {
            plasticStorageSort();
            var objM = Connect.bd.PlasticProducts.Where(p => p.IDInside != 0).Count();
            if (objM == 0) plasticProducts.IDInside = 1;
            if(objM!= 0) plasticProducts.IDInside = objM + 1;
            plasticProducts.ProductWeight = decimal.Parse(AddWidthDitales.Text);
            if (SupportsWight1 == 0) plasticProducts.SupportsWeight = 0;
            else plasticProducts.SupportsWeight = SupportsWight1;
            plasticProducts.CountOnStoock = int.Parse(AddCountDitalis.Text);
            if (CountEngraving != 0) plasticProducts.EngravingStatus = int.Parse(AddCountDitalis.Text) - CountEngraving;
            else plasticProducts.EngravingStatus = int.Parse(AddCountDitalis.Text); ;
            plasticProducts.TimePrint = AddTimeDitalis.Text;
            plasticProducts.ProductTypeID = NameDitaliesID;
            plasticProducts.ColorName = ColorNamePlast;
            plasticProducts.TypePlasticPrint = TypePlast;
            plasticProducts.ManufacturerPlasticPrint = Manufactr;
            Connect.bd.PlasticProducts.Add(plasticProducts);
            Connect.bd.SaveChanges();
            MessageBox.Show("Деталь добавлена!");
            if (CountEngraving != 0)
            {
                var objB = Connect.bd.PlasticProducts.First(p => p.ProductTypeID == NameDitaliesID && p.ColorName == ColorNamePlast && p.ManufacturerPlasticPrint == Manufactr && p.TypePlasticPrint == TypePlast);
                EngraveringFunc(objB.ID, 1);//отправляем чать на гравировку
            }
            MyFrame.Navigate(new PlasticDitalesPage());
        }

        void EngraveringFunc(int id, int TableID)
        {
            var objA = Connect.bd.ProductsForEngraving.Where(p => p.IDInside == id && p.TypeDitalesID == TableID).Count();
            if (objA != 0)
            {
               var objA1 = Connect.bd.ProductsForEngraving.First(p => p.IDInside == id && p.TypeDitalesID == TableID);
                objA1.Count = objA1.Count + CountEngraving;
                Connect.bd.SaveChanges();

            }
            else
            {
                forEngraving.ProductTypeID = NameDitaliesID;
                forEngraving.IDInside = id;
                forEngraving.Count = CountEngraving;
                forEngraving.ReadyCount = 0;
                forEngraving.TypeDitalesID = 1;//указывем из какой таблицы пришла деталь
                Connect.bd.ProductsForEngraving.Add(forEngraving);
                Connect.bd.SaveChanges();
            }   
        }

        private void AddColordNamePlastic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           



        }

        private void Suports_Checked(object sender, RoutedEventArgs e)
        {
            SupportsAddWindow SupportsWindow = new SupportsAddWindow();
            if (SupportsWindow.ShowDialog() == true)
            {
                Plus.Visibility = Visibility.Visible;
                NextTextSupports.Visibility = Visibility.Visible;
                SupportsWight.Text = SupportsWindow.Supports.ToString();
                SupportsWight1= decimal.Parse(SupportsWindow.Supports.ToString());
            }
            else
            {
                Suports.IsChecked = false;
            }
        }

        private void Suports_Unchecked(object sender, RoutedEventArgs e)
        {
            SupportsWight.Text = string.Empty;
            Plus.Visibility = Visibility.Hidden;
            NextTextSupports.Visibility = Visibility.Hidden;
            SupportsWight1 = 0;
        }

        private void AddNameDitalies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index2 = AddNameDitalies.SelectedIndex;
          
            if (AddNameDitalies.SelectedIndex == index2)
            {
                if (index2 > 0)
                {
                    var objB = Connect.bd.IDPlasticProducts.First(p => p.IDInside == index2);
                    var objA = Connect.bd.PlasticProducts.Where(p => p.ProductTypeID == objB.NameProduct).Count();
                    if (objA != 0)
                    {
                        var ObjB = Connect.bd.PlasticProducts.First(p => p.ProductTypeID == objB.NameProduct);
                       
                        AddWidthDitales.Text = ObjB.ProductWeight.ToString();
                       // AddTimeDitalis.Text = ObjB.TimePrint.ToString();

                        if (ObjB.SupportsWeight != 0)
                        {       
                            SupportsWight1 = decimal.Parse(ObjB.SupportsWeight.ToString());
                            Plus.Visibility = Visibility.Visible;
                            NextTextSupports.Visibility = Visibility.Visible;
                            SupportsWight.Text = SupportsWight1.ToString();
                        }
                        else
                        {
                            Plus.Visibility = Visibility.Hidden;
                            NextTextSupports.Visibility = Visibility.Hidden;
                            SupportsWight.Text = string.Empty;
                        }
                        
                    }
                }
            }
        }

        private void Engraving_Checked(object sender, RoutedEventArgs e)
        {
            CountEngravingWindow EngiviringsWindow = new CountEngravingWindow();
            if (EngiviringsWindow.ShowDialog() == true)
            {
               
                EngravingCountsText.Text = EngiviringsWindow.EniviringCount.ToString();
                EngravingText.Visibility = Visibility.Visible;
                CountEngraving = int.Parse(EngiviringsWindow.EniviringCount);
            }
            else
            {
                Engraving.IsChecked = false;
            }
        }

        private void Engraving_Unchecked(object sender, RoutedEventArgs e)
        {
            CountEngraving = 0;
            EngravingText.Visibility = Visibility.Hidden;
        }

        private void AddWidthDitales_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != ",")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void AddTimeDitalis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != ":")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void AddCountDitalis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val))
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void RegectCountPlast_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RegectCountPlast_Checked_1(object sender, RoutedEventArgs e)
        {

            IgnorCountplast = true;
      

        }

        private void RegectCountPlast_Unchecked(object sender, RoutedEventArgs e)
        {
            IgnorCountplast = false;
         
        }
    }
}
