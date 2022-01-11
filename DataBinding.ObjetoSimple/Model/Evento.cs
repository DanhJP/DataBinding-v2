using System;
using System.ComponentModel;

namespace DataBinding.ObjetoSimple.Model
{
    public class Evento : INotifyPropertyChanged 
    {
        private string _Title;
        private DateTime _Date;

        public string Title
        {
            get => _Title;
            set
            {
                if (value != _Title)
                {
                    _Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public DateTime Date
        {
            get => _Date;
            set
            {
                if (value != _Date)
                {
                    _Date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
