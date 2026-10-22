using lera_dem.Database;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lera_dem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyDbContext Database = new MyDbContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Guest(object sender, RoutedEventArgs e)
        {
            Window window = new Guest();
            this.Close();
            window.Show();  
        }

        private void Button_Click_Catalog(object sender, RoutedEventArgs e)
        {
            //if (FamilyInputBox.Text == null || FamilyInputBox.Text == "") return;
            //foreach (var item in Database.Users.ToList())
            //{
            //    if (FamilyInputBox.Text == item.LastName)
            //    {
            //        Window window = new Catalog();
            //        this.Close();
            //        window.Show();
            //    }
            //}
            Window window = new Catalog();
            this.Close();
            window.Show();
        }
    }
}
