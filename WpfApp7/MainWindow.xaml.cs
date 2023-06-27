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

//Миньков Владимир 6_2 14 вариант базовый уровень
namespace LinkedListWpfExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            
            LinkedList<double> list = new LinkedList<double>();
            list.AddLast(-2.5);
            list.AddLast(-1.0);
            list.AddLast(3.5);
            list.AddLast(2.0);
            list.AddLast(1.0);

            
            LinkedListNode<double> node = list.First;
            while (node != null && node.Value <= 0)
            {
                node = node.Next;
            }
            if (node != null && node != list.First)
            {
                list.Remove(node.Previous);
            }

            
            lblResult.Content = string.Join(" ", list.Select(x => x.ToString()));
        }
    }
}
