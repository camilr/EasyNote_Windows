using EasyNote.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EasyNote
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility 
                = AppViewBackButtonVisibility.Collapsed;
            grid.SelectedIndex = -1;
        }

        private ObservableCollection<MenuItem> menuList;

        public ObservableCollection<MenuItem> MenuList
        {
            get
            {
                if (menuList == null)
                {
                    menuList = new ObservableCollection<MenuItem>();

                    MenuItem item = new MenuItem() { Name = "Favoritos", Icon = "Favorite" };
                    MenuItem item1 = new MenuItem() { Name = "Agregar", Icon = "Add" };                   

                    menuList.Add(item);
                    menuList.Add(item1);                   
                }
                return menuList;
            }
            set { menuList = value; }
        }
        private ObservableCollection<GaleryItem> galery;

        public ObservableCollection<GaleryItem> Galery
        {
            get
            {
                if (galery == null)
                {
                    galery = new ObservableCollection<GaleryItem>();
                    GaleryItem item = new GaleryItem() { Titulo = "Recordar", Contenido = "Lunes" };

                    galery.Add(item);
                }
                return galery;
            }
            set { galery = value; }
        }


        private void showMenu(object sender, RoutedEventArgs e)
        {
            if (split.IsPaneOpen)
            {
                split.IsPaneOpen = false;
            }
            else
                split.IsPaneOpen = true;

        }

        private void goToAdd(object sender, SelectionChangedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(AddNote));
            
        }

        private void goToOpenNote(object sender, SelectionChangedEventArgs e)
        {
            if(grid.SelectedIndex >= 0) { 
                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(OpenNote), Galery.ElementAt(grid.SelectedIndex));            
              }

        }
    }
}
