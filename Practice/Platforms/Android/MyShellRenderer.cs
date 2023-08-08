using Android.Content;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;

public class MyShellRenderer : ShellRenderer
{
    public MyShellRenderer(Context context) : base(context)
    {
    }
    protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
    {
        return new MyShellBottomNavViewAppearanceTracker();
    }
}
public class MyShellBottomNavViewAppearanceTracker : IShellBottomNavViewAppearanceTracker
{
    public void Dispose()
    {
    }

    public void ResetAppearance(BottomNavigationView bottomView)
    {
    }

    public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
    {
        bottomView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
        // this line will hide the space of the title
    }
}