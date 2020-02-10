using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstGuiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            firstLbl.Content = "Hello pacanas";
        }

        private void HandleMyFirstButtonClick(object sender, RoutedEventArgs e)
        {

            if (sender is Button)
            {
                Button senderButton = sender as Button;
                (sender as Button).Content = "Hi";
            }
            firstLbl.Content = "Nu kam paspaudei čia?";

        }

        private void HandleMyFirstButtonClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void myTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            firstLbl.Content = myTxtBox.Text;
        }
    }
}
