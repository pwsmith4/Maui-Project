namespace MauiProject.Views.Pages;


public partial class ProfilePage : ContentPage
{ 
	public ProfilePage()
	{
		InitializeComponent();
	}
	public ProfilePage(ProfileViewModel viewModel)
	{
	
			InitializeComponent();
			BindingContext = viewModel;

	}
}