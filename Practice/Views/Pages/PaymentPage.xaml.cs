namespace MauiProject.Views.Pages;
public partial class PaymentPage : ContentPage
{
	public PaymentPage(PaymentViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}