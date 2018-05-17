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

namespace todolist
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // 产生一个方块
            TodoItem tolist = new TodoItem();
            

            // 放到 Todostack
            TodoList.Children.Add(tolist);

            
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            List<string> all = new List<string>();
            foreach(TodoItem tolist in TodoList.Children)
            {
                all.Add(tolist.GetTaskName());
            }

            System.IO.File.WriteAllLines(@"C:\git\todola.txt", all );

        }
    }
}
