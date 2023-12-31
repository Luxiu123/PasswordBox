using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PasswordBox.View {
    public sealed partial class PasswordListItem : UserControl {



        public PasswordInfo PasswordInfo {
            get { return (PasswordInfo)GetValue(PasswordInfoProperty); }
            set { SetValue(PasswordInfoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PasswordInfo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordInfoProperty =
            DependencyProperty.Register("PasswordInfo", typeof(PasswordInfo), typeof(PasswordListItem), new PropertyMetadata(null));



        public PasswordListItem() {
            this.InitializeComponent();
        }
    }
}
