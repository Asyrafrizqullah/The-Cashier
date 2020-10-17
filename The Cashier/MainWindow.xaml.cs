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

namespace The_Cashier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            ListBox.ItemsSource = calculator.getListItem();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = ItemNameBox.Text;
            int quantity = int.Parse(QuantityBox.Text);
            string type = TypeBox.Text;
            double price = double.Parse(PriceBox.Text);

            Item item = new Item(new Random().Next(), title, quantity, price,price, type);
            calculator.addItem(item);
            double total = calculator.getTotal();

            TotalLabel.Content = string.Format("Rp. {0}", total);
            ListBox.Items.Refresh();
        }
    }
}