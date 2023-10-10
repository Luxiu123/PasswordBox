using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace PasswordBox.View;

public sealed partial class PasswordListPage : Page {
    public ObservableCollection<PasswordInfo> PasswordInfos { get; } = new();

    public PasswordListPage() {
        this.InitializeComponent();
        Loaded += ViewLoadedHandler;
    }

    private void ViewLoadedHandler(object sender, RoutedEventArgs e) {
        for (int i = 0; i < 10; i++) {
            PasswordInfos.Add(new() {
                AppName = i.ToString(),
                Account = "Account " + i
            });
        }
    }
}
