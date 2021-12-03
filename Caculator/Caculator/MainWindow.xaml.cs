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

namespace Caculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result; 
        public MainWindow()
        {
            InitializeComponent();

            AcBtn.Click += AcBtn_Click;
            negativeBtn.Click += NegativeBtn_Click;
            percentBtn.Click += PercentBtn_Click;
            equalBtn.Click += EqualBtn_Click;
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PercentBtn_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * (-1);
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcBtn_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if(sender == zeroBtn)
            {
                selectedValue = 0;
            }
            if (sender == oneBtn)
            {
                selectedValue = 1;
            }
            if (sender == twoBtn)
            {
                selectedValue = 2;
            }
            if (sender == threeBtn)
            {
                selectedValue = 3;
            }
            if (sender == fourBtn)
            {
                selectedValue = 4;
            }
            if (sender == fiveBtn)
            {
                selectedValue = 5;
            }
            if (sender == sixBtn)
            {
                selectedValue = 6;
            }
            if (sender == sevenBtn)
            {
                selectedValue = 7;
            }
            if (sender == eightBtn)
            {
                selectedValue = 8;
            }
            if (sender == nineBtn)
            {
                selectedValue = 9;
            }


            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
            
        }

        private void OperationBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }
        }
    }
}
