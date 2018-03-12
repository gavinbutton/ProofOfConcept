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

namespace FloatingWindowRoutedCommandTest
{
    /// <summary>
    /// Interaction logic for MainContentView.xaml
    /// </summary>
    public partial class MainContentView : UserControl
    {
        private PaneViewModel vm = new PaneViewModel();
        public MainContentView()
        {
            InitializeComponent();
            this.paneC.DataContext = this.vm;
        }
        
        private void OnExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var message = $"Executed {DateTime.Now}";
            System.Diagnostics.Debug.WriteLine(message);
            this.vm.AddLog(message);
        }

        private void CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
