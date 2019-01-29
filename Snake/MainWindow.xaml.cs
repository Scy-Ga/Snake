using Snake.Models;
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

namespace Snake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Arena arena;
        public MainWindow()
        {
            InitializeComponent();

            arena = new Arena(this);
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            arena.Start();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            arena.Stop();
        }
    }
}
