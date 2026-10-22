using lera_dem.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lera_dem
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        MyDbContext database = new MyDbContext();
        public Catalog()
        {
            InitializeComponent();
            ListProducts.ItemsSource = database.Products.Include(p => p.Product_Category).ThenInclude(p => p.Category).ToList();
        }
       
    }
}
