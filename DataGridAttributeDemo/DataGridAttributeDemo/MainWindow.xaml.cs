﻿namespace DataGridAttributeDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = DemoViewModel.GetDemoList();
        }
    }
}