using System;

namespace Net8Perf.Views;

public partial class SecondView : ContentPage
{
	public SecondView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"details");
    }
}