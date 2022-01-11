using DataBinding.ObjetoSimple.Model;
using System;
using System.Windows;


namespace DataBinding.ObjetoSimple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Evento evento;
        public MainWindow()
        {
            InitializeComponent();

            evento = new Evento()
            {
                Title = "Reunión de trabajo",
                Date = new DateTime(2021, 10, 12)
            };
            //UpdateUI();
            //nombreTextBox.Text = evento.Title;
            //fechaDatePicker.SelectedDate = evento.Date;
            DataContext = evento;
        }

        private void UpdateUI()
        {
            eventoTextBox.Text = evento.Title;
            fechaDatePicker.SelectedDate = evento.Date;
        }

        private void modificarEventoButton_Click(object sender, RoutedEventArgs e)
        {
            evento.Title = evento.Title.ToUpper();
            evento.Date = evento.Date.AddDays(1);
            //UpdateUI();
        }
    }
}
