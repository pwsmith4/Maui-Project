using MauiProject.ViewModels;
using Splat;

namespace MauiProject
{
    public static class AppLocator
    {
        public static MainViewModel MainViewModel => Locator.Current.GetService<MainViewModel>();
        public static double DisplayHeight { get; set; }

        public static void Initialize()
        {
            Locator.CurrentMutable.Register(()=>new MainViewModel());
        }
    }
}
