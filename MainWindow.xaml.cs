﻿using Financial_Accounting.View.Forms;
using System.Windows;

namespace Financial_Accounting;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void ExitButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        this.Close();
    }
}