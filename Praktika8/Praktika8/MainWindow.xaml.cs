using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Xml.Schema;

namespace Praktika8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void file_MouseMove(object sender, MouseEventArgs e)
        {
            //work.Text = "Похоже вы хотите нажать на меню, рада за вас";
        }

        private void backgro_MouseMove(object sender, MouseEventArgs e)
        {
            work.Text = "Хотите поменять фон?";
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            work.Text = "Хотите закрыть окно?";
        }

        private void about_MouseMove(object sender, MouseEventArgs e)
        {
            work.Text = "Вы узнаете много об этой программе.";
        }

        private void backgroTool_MouseMove(object sender, MouseEventArgs e)
        {
            work.Text = "Хотите поменять фон?";
        }

        private void closeTool_MouseMove(object sender, MouseEventArgs e)
        {
            work.Text = "Хотите закрыть окно?";
        }

        private void aboutTool_MouseMove(object sender, MouseEventArgs e)
        {
            work.Text = "Вы узнаете много об этой программе.";
        }

        private void backgro_Click(object sender, RoutedEventArgs e)
        {
            int i = rnd.Next(1, 6);
            switch (i)
            {
                case 1:
                    main_dock.Background = Brushes.Red;
                    break;
                case 2: main_dock.Background = Brushes.Blue;
                    break;
                case 3: main_dock.Background = Brushes.LightCoral;
                    break;
                case 4: main_dock.Background = Brushes.Gray;
                    break;
                case 5: main_dock.Background = Brushes.LightYellow;
                    break;
            }
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация может обновляться.\nКстати, фон можно поменять нажав на функцию меню\nили на функцию в панели инструментов.");
        }

        private void backgroTool_Click(object sender, RoutedEventArgs e)
        {
            int i = rnd.Next(1, 6);
            switch (i)
            {
                case 1:
                    main_dock.Background = Brushes.Red;
                    break;
                case 2:
                    main_dock.Background = Brushes.Blue;
                    break;
                case 3:
                    main_dock.Background = Brushes.LightCoral;
                    break;
                case 4:
                    main_dock.Background = Brushes.Gray;
                    break;
                case 5:
                    main_dock.Background = Brushes.LightYellow;
                    break;
            }
        }

        private void closeTool_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void aboutTool_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация может обновляться.\nКстати, фон можно поменять нажав на функцию меню\nили на функцию в панели инструментов.");
        }
    }
}
