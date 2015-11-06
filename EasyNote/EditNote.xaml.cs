using EasyNote.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class EditNote : Page
    {
        GaleryItem item;
        Frame rootFrame;

        public EditNote()
        {
            this.InitializeComponent();

            rootFrame = Window.Current.Content as Frame;

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility
                = AppViewBackButtonVisibility.Visible;

            SystemNavigationManager.GetForCurrentView().BackRequested += OpenNote_BackRequested;
        }

        private void OpenNote_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            item = e.Parameter as GaleryItem;
            titulo.Text = item.Titulo;
            contenido.Text = item.Contenido;

        }

        private void edit(object sender, RoutedEventArgs e)
        {
            item.Titulo = titulo.Text;
            item.Contenido = contenido.Text;
            rootFrame.GoBack();

           
        }
    }
}
