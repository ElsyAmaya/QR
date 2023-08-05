
using System;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;


namespace QR
{
    public partial class MainPage : ContentPage
    {
        ZXingBarcodeImageView qr;

        public MainPage()
        {
            InitializeComponent();

        }
     
        private async void ButtonGenerarQRClicked(object sender, EventArgs e)
        {
            qr = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            qr.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            qr.BarcodeOptions.Width = 500;
            qr.BarcodeOptions.Height = 500;
            qr.BarcodeValue = "https://youtu.be/q1f2vzn8xbA";
            stKQR.Children.Add(qr);

           
        }


       

    }
}
