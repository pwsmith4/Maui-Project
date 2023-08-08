using MauiProject.Views.Pages;
using MauiProject.Models;
namespace MauiProject.Views.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
		collectionView.ItemsSource = GetItems();
	}
	private List<Items> GetItems()
	{
		return new List<Items>
		{
		new Items { ItemName = "Green Shirt", ItemImage="green_shirt.jpeg", ItemPrice="$19.99"},
		new Items { ItemName = "Blue Shirt", ItemImage="blue_shirt.jpeg", ItemPrice="$24.99"},
		new Items { ItemName = "Red Shirt", ItemImage="redshirt2.jpeg", ItemPrice="$29.99"}
	};
	}

}

