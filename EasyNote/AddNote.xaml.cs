using EasyNote.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EasyNote
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNote : Page
    {
        Frame rootFrame;
        GaleryItem item;
        
        public AddNote()
        {
            this.InitializeComponent();           
            rootFrame = Window.Current.Content as Frame;            

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility
                = AppViewBackButtonVisibility.Visible;

            SystemNavigationManager.GetForCurrentView().BackRequested += AddNote_BackRequested;
        }

        
        private void AddNote_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if(e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }
                
        private void add(object sender, RoutedEventArgs e)
        {

        }
    }
}
