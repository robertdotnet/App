﻿using Microsoft.Maui.Controls;
using NavPoint.Core.ViewModels;

namespace NavPoint;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new Locations();
    }
}
