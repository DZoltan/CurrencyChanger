using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyChanger
{
    class Calculating
    {
        Deseralizer rates = new Deseralizer();


        public double calculate_currency(string from, double cash, string to)
        {
            double calculated_cash = 0;

            double from_currency = currency_rates(from);
            double to_currency = currency_rates(to);
            double currency_rate = to_currency / from_currency;

            calculated_cash = cash * currency_rate;


            return Math.Round(calculated_cash,2);

        } 

        private double currency_rates(string currency)
        {
            double _cash = 0;

            switch (currency)
            {
                case "EUR": _cash = 1; break;
                case "GBP": _cash = rates._rated.rates.GBP; break;
                case "HKD": _cash = rates._rated.rates.HKD; break;
                case "IDR": _cash = rates._rated.rates.IDR; break;
                case "ILS": _cash = rates._rated.rates.ILS;  break;
                case "DKK": _cash = rates._rated.rates.DKK; break;
                case "INR": _cash = rates._rated.rates.INR; break;
                case "CHF": _cash = rates._rated.rates.CHF; break;
                case "MXN": _cash = rates._rated.rates.MXN; break;
                case "CZK": _cash = rates._rated.rates.CZK; break;
                case "SGD": _cash = rates._rated.rates.SGD; break;
                case "THB": _cash = rates._rated.rates.THB; break;
                case "HRK": _cash = rates._rated.rates.HRK; break;
                case "MYR": _cash = rates._rated.rates.MYR; break;
                case "NOK": _cash = rates._rated.rates.NOK; break;
                case "CNY": _cash = rates._rated.rates.CNY; break;
                case "BGN": _cash = rates._rated.rates.BGN; break;
                case "PHP": _cash = rates._rated.rates.PHP; break;
                case "SEK": _cash = rates._rated.rates.SEK; break;
                case "PLN": _cash = rates._rated.rates.PLN; break;
                case "ZAR": _cash = rates._rated.rates.ZAR; break;
                case "CAD": _cash = rates._rated.rates.CAD; break;
                case "ISK": _cash = rates._rated.rates.ISK; break;
                case "BRL": _cash = rates._rated.rates.BRL; break;
                case "RON": _cash = rates._rated.rates.RON; break;
                case "NZD": _cash = rates._rated.rates.NZD; break;
                case "TRY": _cash = rates._rated.rates.TRY; break;
                case "JPY": _cash = rates._rated.rates.JPY; break;
                case "RUB": _cash = rates._rated.rates.RUB; break;
                case "KRW": _cash = rates._rated.rates.KRW; break;
                case "USD": _cash = rates._rated.rates.USD; break;
                case "HUF": _cash = rates._rated.rates.HUF; break;
                case "AUD": _cash = rates._rated.rates.AUD; break;
                default: _cash = 404; break;
            }

            return _cash;
        }
    }
}
