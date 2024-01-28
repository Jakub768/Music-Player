using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
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

namespace Music_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MediaPlayer player;
        private TimeSpan trackPos;
        public MainWindow()
        {
            InitializeComponent();
            player = new MediaPlayer();
        }

        private void loadFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Audio files (*.wav)|*.wav|All files (*.*)|*.*";

            if (openFile.ShowDialog() == true)
            {
                Filename.Text = openFile.SafeFileName;
                player.Open(new Uri(openFile.FileName));
            }
        }

        private void playTrack(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void stopTrack(object sender, RoutedEventArgs e)
        {
        }

        private void pauseTrack(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
