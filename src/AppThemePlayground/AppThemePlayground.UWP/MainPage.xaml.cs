﻿namespace AppThemePlayground.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new AppThemePlayground.App());
        }
    }
}
