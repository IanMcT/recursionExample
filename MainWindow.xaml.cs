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
/*
 * Demonstration of excursion by 
 * determining if a number is prime or not
 */

namespace recusionExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int checkPrime = 1201;
            MessageBox.Show(checkPrime.ToString() + " is prime: " + isPrime(checkPrime).ToString());
        }
        public bool isPrime(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n < 1)
            {
                throw new Exception("Number must be a positive integer");
            }
            
                return isPime(n, n - 1);
        }

        public bool isPime(int n, int c)
        {
            if (c == 1) {
                return true;
            }else if (n % c == 0)
            {
                return false;
            }
            else {
                return isPime(n, c - 1);
            }
        }
    }
}
