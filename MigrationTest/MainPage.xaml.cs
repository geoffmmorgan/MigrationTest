using Microsoft.Graphics.Canvas;
using System;
using Windows.UI.Xaml.Controls;

namespace MigrationTest
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Load();
        }

        public async void Load()
        {
            await CanvasBitmap.LoadAsync(this.BlurredImage, new Uri("http://logok.org/wp-content/uploads/2014/09/Bing-logo-880x633.png"));
        }
    }
}
