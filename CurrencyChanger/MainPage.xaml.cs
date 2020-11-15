using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CurrencyChanger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Calculating calculate = new Calculating();
        List<string> CurrencyList = new List<string> { "HUF", "EUR", "GBP", "USD", "HKD", "IDR", "ILS", "DKK", "INR" ,"CHF", "MXN",
        "CZK" , "SGD", "THB" , "HRK", "MYR", "NOK", "CNY", "BGN", "PHP", "SEK", "PLN", "ZAR", "CAD" , "ISK", "BRL", "RON", "NZD",
        "TRY", "JPY", "RUB", "KRW", "AUD"};
        public MainPage()
        {
            //Json_save save = new Json_save();
            this.InitializeComponent();
            calculate_btn.IsEnabled = false;

        }

        private void swap_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                to_cash.Text = "";
                from_cash.Text = "";
                string temp = to_currency.SelectedItem.ToString();
                to_currency.SelectedItem = from_currency.SelectedItem;
                from_currency.SelectedItem = temp;
            }
            catch (NullReferenceException exc)
            {
                errormsg_txt.Text = "Nem adtál meg valutát!";
            }
        }

        private void calculate_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                to_cash.Text = calculate.calculate_currency(from_currency.SelectedItem.ToString(), double.Parse(from_cash.Text), to_currency.SelectedItem.ToString()).ToString();
                errormsg_txt.Text = "";
            }
            catch (NullReferenceException exc)
            {
                errormsg_txt.Text = "Nem adtál meg valutát!" ;
            }
        }

        private void from_cash_TextChanged(object sender, TextChangedEventArgs e)
        {
            double checked_cash;
            if(from_cash.Text == "")
            {
                calculate_btn.IsEnabled = false;
                errormsg_txt.Text = "";
            }
            else if(!Double.TryParse(from_cash.Text, out checked_cash))
            {
                calculate_btn.IsEnabled = false;
                errormsg_txt.Text = "A megadott érték nem szám!";

            }
            else if (from_cash.Text.Contains(","))
            {
                calculate_btn.IsEnabled = false;
                errormsg_txt.Text = "Használj tizedespontot! (pl: 12,5 helyett 12.5)";
            }
            else
            {
                calculate_btn.IsEnabled = true;
                errormsg_txt.Text = "";
            }
        }

        private void from_currency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
