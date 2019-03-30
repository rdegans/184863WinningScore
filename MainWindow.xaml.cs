/*Name : Riley de Gans
* Date: March 29th, 2019
* Description: A program that determines the winner of a game
*/
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

namespace _184863WinningScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader sr = new System.IO.StreamReader("score.txt", true);
            int[] scores = new int[7];
            int counter = 1;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();int.TryParse(sr.ReadLine(), out scores[counter]);
                counter++;
            }
            int appleScore = scores[1] * 3 + scores[2] * 2 + scores[3];
            int bananaScore = scores[4] * 3 + scores[5] * 2 + scores[6];
            if(appleScore > bananaScore)
            {
                MessageBox.Show("A");
            }
            else if (appleScore == bananaScore)
            {
                MessageBox.Show("T");
            }
            else
            {
                MessageBox.Show("B");
            }
        }
    }
}
