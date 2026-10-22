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
using Testik.Models;

namespace lera_dem
{
    /// <summary>
    /// Логика взаимодействия для Guest.xaml
    /// </summary>
    public partial class Guest : Window
    {
        MyDbContext database = new MyDbContext();
        public Guest()
        {
            InitializeComponent();

            // Загружаем товары со связанными категориями
            var allProducts = database.Products
                .Include(p => p.Product_Category)
                .ThenInclude(p => p.Category)
                .ToList();

            // ТРЕБОВАНИЕ ТЗ: Оставляем только доступные для покупки товары (у которых статус CanBuying равен Yes)
            // Также можно подстраховаться проверкой на количество: p.CountBuying > 0
            var activeProducts = allProducts
                .Where(p => p.CanBuying == CanBuying.Yes)
                .ToList();

            // Выводим отфильтрованный список в ListBox
            ListProducts.ItemsSource = activeProducts;
        }


    }
}
