using System;
using System.Windows;
using System.Windows.Documents;
using MailSender.Components;

namespace MailSender
{
    public partial class MainWindow
    {
        public MainWindow() => InitializeComponent();

        private void OnExitClick(object Sender, RoutedEventArgs E) => Close();

        private void TabController_OnLeftButtonClick(object Sender, EventArgs e)
        {
            if(!(Sender is TabController tab_controller)) return;

            if(tab_controller.IsLeftButtonVisible)
                MainTabControl.SelectedIndex--;

            tab_controller.IsLeftButtonVisible = MainTabControl.SelectedIndex > 0;
            tab_controller.IsRightButtonVisible = MainTabControl.SelectedIndex < MainTabControl.Items.Count;
        }

        private void TabController_OnRightButtonClick(object Sender, EventArgs e)
        {
            if(!(Sender is TabController tab_controller)) return;

            if(tab_controller.IsRightButtonVisible)
                MainTabControl.SelectedIndex++;

            tab_controller.IsLeftButtonVisible = MainTabControl.SelectedIndex > 0;
            tab_controller.IsRightButtonVisible = MainTabControl.SelectedIndex < MainTabControl.Items.Count - 1;
        }


        private void BtnClock_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedItem = TabPlanner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(BodyText.Text))
            {
                MessageBox.Show("Письмо не заполнено");
                MainTabControl.SelectedIndex = 2;
            }
        }
    }
}
