using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    internal class Program
    {
        private static Label _label;
        private static int _count;

        [STAThread]
        public static void Main(string[] args)
        {
            var app= new Application();
            var window = new Window();

            var button = new Button{Content = "Trykk på meg!"};
            _label = new Label {Content = "0"};

            button.Click += ButtonClick;

            var panel = new StackPanel();
            panel.Children.Add(button);
            panel.Children.Add(_label);

            window.Content = panel;

            app.Run(window);

        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
