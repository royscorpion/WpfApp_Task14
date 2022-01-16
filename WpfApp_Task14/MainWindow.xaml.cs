using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp_Task14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Молоко",
                ProductCost = 74.99,
                ProductImage = "Data/milk.jpg",
                ProductCategory = ProductCategories.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductCost = 29.99,
                ProductImage = "Data/bread.jpg",
                ProductCategory = ProductCategories.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Чайник",
                ProductCost = 1999,
                ProductImage = "Data/electric_kettle.jpg",
                ProductCategory = ProductCategories.БытоваяТехника
            });
            products.Add(new Product()
            {
                ProductName = "Чай черный",
                ProductCost = 108.09,
                ProductImage = "Data/tea_Curtis_SunnyLemon_20p.jpg",
                ProductCategory = ProductCategories.ЧайКофеКакао
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Кружка",
                ProductCost = 269.99,
                ProductImage = "Data/cup.jpg",
                ProductCategory = ProductCategories.Посуда
            });
        }
    }
}
