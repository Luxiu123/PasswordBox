using CommunityToolkit.Mvvm.ComponentModel;
using System.Timers;
using System.Xml.Linq;

namespace PasswordBox;

public sealed partial class MainWindow : Window {
    private AppWindow CurrentAppWindow;

    public MainWindow() {
        this.InitializeComponent();
        CurrentAppWindow = GetAppWindowForCurrentWindow();
        CurrentAppWindow.Title = "App title";
        CurrentAppWindow.Resize(new(1000, 600));
        SetTitleBarColors();
        MainFrame.Navigate(typeof(PasswordListPage));
    }

    private AppWindow GetAppWindowForCurrentWindow() {
        IntPtr hWnd = WindowNative.GetWindowHandle(this);
        WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
        return AppWindow.GetFromWindowId(wndId);
    }

    private bool SetTitleBarColors() {
        CurrentAppWindow ??= GetAppWindowForCurrentWindow();
        var titleBar = CurrentAppWindow.TitleBar;

        titleBar.BackgroundColor = Colors.Transparent;
        titleBar.ButtonBackgroundColor = Colors.Transparent;
        titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        titleBar.InactiveBackgroundColor = Colors.Transparent;
        titleBar.ExtendsContentIntoTitleBar = true;
        titleBar.IconShowOptions = IconShowOptions.HideIconAndSystemMenu;
        return true;
    }
}
