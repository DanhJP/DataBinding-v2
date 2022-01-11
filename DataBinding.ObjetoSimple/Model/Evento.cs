using System;

namespace DataBinding.ObjetoSimple.Model
{
    public class Evento
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
                }
            }
        }


    }
}
