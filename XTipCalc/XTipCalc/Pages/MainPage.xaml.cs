using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XTipCalc.Models;

namespace XTipCalc.Pages
{
    public partial class MainPage : ContentPage
    {
        TipInfo info = new TipInfo()
        {
            TipPercent = 12
        };
        public MainPage()
        {
            InitializeComponent();

            TipPercent.Text = info.TipPercent.ToString();
            TipPercentSlider.Value = Convert.ToDouble(info.TipPercent);

            info.TipValueChanged += (sender, e) =>
            {
                TipValue.Text = info.TipValue.ToString();
                Total.Text = (info.TipValue + info.Total).ToString();
            };

            ReceiptTotal.TextChanged += (sender, e) =>
            {
                info.Total = Parse(ReceiptTotal.Text);
            };

            TipPercent.TextChanged += (sender, e) =>
            {
                info.TipPercent = Parse(TipPercent.Text);
            };

            Subtotal.TextChanged += (sender, e) =>
            {
                info.Subtotal = Parse(Subtotal.Text);
            };

            TipPercentSlider.ValueChanged += (sender, e) =>
            {
                TipPercent.Text = e.NewValue.ToString();
                TipPercentSlider.Value = e.NewValue;
            };
        }

        static decimal Parse(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0m;

            try
            {
                return Convert.ToDecimal(text);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);

                return 0m;
            }
        }
    }
}
