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
            TipPercent = 15
        };
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
