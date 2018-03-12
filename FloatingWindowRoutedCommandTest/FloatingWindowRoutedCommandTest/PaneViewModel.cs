using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FloatingWindowRoutedCommandTest
{
    class PaneViewModel : INotifyPropertyChanged
    {
        private StringBuilder log = new StringBuilder();

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddLog(string message)
        {
            this.log.AppendLine(message);
            NotifyPropertyChanged("Log");
        } 

        public string Log
        {
            get
            {
                return log.ToString();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
