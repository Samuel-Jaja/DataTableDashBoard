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

namespace WPFConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool CypherCrescentIdCard { get; set; } = false;
        public bool CypherCrescentNigeria { get; set; } = true;
        public bool HasThickBorder { get; set; } = true;




        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
