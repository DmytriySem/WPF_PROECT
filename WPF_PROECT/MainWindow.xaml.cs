using System;
using System.Collections.Generic;
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

namespace WPF_PROECT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox txtBox = null;
        /// <summary>
        /// First comment   
        /// </summary>
        public void ShowHello()
        {
            txtBox = new TextBox() { Text = "HelloWorld" };
            grid.Children.Add(txtBox);
        }
        public MainWindow()
        {
            InitializeComponent();

            ShowHello();
        }
    }
}
