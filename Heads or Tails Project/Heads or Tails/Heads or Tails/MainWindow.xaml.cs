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

namespace Heads_or_Tails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer("coinflip.wav");
        Random ran = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //player.Play();
            if(ran.Next(0, 2) == 0)
            {
                ans.Content = "Heads";
            }
            else
            {
                ans.Content = "Tails";
            }
        }

        private void Label_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
