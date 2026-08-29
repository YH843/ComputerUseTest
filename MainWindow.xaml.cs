using System.Windows;

namespace ComputerUseWpfDemo;

public partial class MainWindow : Window
{
    private int _clickCount;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void ActionButton_Click(object sender, RoutedEventArgs e)
    {
        _clickCount++;
        StatusText.Text = $"Clicked: {_clickCount}";
        ActionButton.Content = "CLICKED!";
    }
}
