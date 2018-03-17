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
using Currency_Exchange;

namespace Currency_Exchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Currency_Service.ConverterSoapClient client = new Currency_Service.ConverterSoapClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            decimal broj;
            if (comboBoxFrom.SelectedIndex < 0)
            {
                MessageBox.Show("Pick Currenncy","Warning");
                return false;
            }
            if (comboBoxTo.SelectedIndex < 0)
            {
                MessageBox.Show("Pick Currenncy", "Warning");
                return false;
            }
            if (!datePikerDatee.SelectedDate.HasValue)
            {
                MessageBox.Show("Pick the Valid Date", "Warning");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text) || !decimal.TryParse(textBoxAmount.Text, out broj))
            {
                MessageBox.Show("Enter the valid amount","Warning");
                return false;
            }           
            return true;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in client.GetCurrencies())
            {
                comboBoxCurrency.Items.Add(item);
                comboBoxFrom.Items.Add(item);
                comboBoxTo.Items.Add(item);
            }
        }

        private void buttonGet_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxCurrency.SelectedIndex > -1 && datepikerDate.SelectedDate.HasValue)
            {
                string currency = comboBoxCurrency.SelectedItem.ToString();
                decimal rez = client.GetCurrencyRate(currency, datepikerDate.SelectedDate.Value);

                textBoxCurrencyRate.Text = $"{rez} {currency}";
            }
            else
            {
                MessageBox.Show("Pick Currency and Date", "Warrning ");
            }
        }

        private void buttonConvert_Click(object sender, RoutedEventArgs e)
        {
           
            if (Validation())
            {
                string cur_from = comboBoxFrom.SelectedItem.ToString();
                string cur_to = comboBoxTo.SelectedItem.ToString();
                decimal ammount = decimal.Parse(textBoxAmount.Text);
                var rez = client.GetConversionAmount(cur_from, cur_to, datePikerDatee.SelectedDate.Value,ammount);

                textBoxRez.Text = rez.ToString($"0.000 {cur_to}");
            }
        }
    }
}
