using System.Collections.Generic;
using System.Windows;
using DataBinding.Collections.Model;

namespace DataBinding.Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            LoadUsers();
            usersListBox.ItemsSource = users;
        }


        private void LoadUsers()
        {
            users.Add(new User() { Name = "Peter Parker" });
            users.Add(new User() { Name = "Tony Stark" });
            users.Add(new User() { Name = "Natasha Romanoff" });
        }


        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(userTextBox.Text))
            {
                User user = new User() { Name = userTextBox.Text };
                users.Add(user);
                usersListBox.SelectedItem = user;
                UpdateView();

            }
        }

        private void changeUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                User user = usersListBox.SelectedItem as User;
                user.Name = userTextBox.Text;
                usersListBox.SelectedItem = user;
                UpdateView();
            }
        }

        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                users.Remove(usersListBox.SelectedItem as User);
                {
                    userTextBox.Text = "";
                    UpdateView();
                }
            }
        }

        private void UpdateView()
        {
            usersListBox.Items.Refresh();
            if (users.Count > 0)
            {
                deleteUserButton.IsEnabled = true;
                changeUserButton.IsEnabled = true;
            }
            else
            {
                usersListBox.SelectedIndex = -1;
                deleteUserButton.IsEnabled = false; 
                changeUserButton.IsEnabled = false;
            }
        }

        private void usersListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                userTextBox.Text = (usersListBox.SelectedItem as User).Name;
            }

        }
    }
}
