using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

namespace QQwert1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btGenerator_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            canvasCode.Children.Clear();
            
            for(int i=1; i < 12; i++)
            {
                canvasCode.Children.Add(NewLine(i));
            }
            labelCode.Content = random.Next(100000, 999999).ToString();
            labelCode.Content += random.Next(100000, 999999).ToString();
        }

        private Line NewLine(int x)
        {
            Random random = new Random();

            var l = new Line()
            {
                X1 = 50 + 10 * x,
                X2 = 50 + 10 * x,
                Y1 = 0,
                Y2 = 200,

                Stroke=Brushes.Black,
                StrokeThickness=random.Next(1, 15),
            };
            return l; 
        }
    }
}
