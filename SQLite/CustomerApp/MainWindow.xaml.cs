﻿using CustomerApp.Objects;
using SQLite;
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
using System.ComponentModel;
using System.Drawing;

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private List<Customer> _customers;

        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
        }
        
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = PictureBox,
            };

            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
                ReadDatabase();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if(item == null) {
                MessageBox.Show("編集する行を選択してください");
                return;
            }

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;
            item.Picture = PictureBox;

            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(item);
            }

            ReadDatabase();

        }

        private void ReadDatabase() {
            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;

                NameTextBox.Clear();
                PhoneTextBox.Clear();
                AddressTextBox.Clear();
                PictureBox.Source = null;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterText = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterText;

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDatabase();
            }
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(CustomerListView.SelectedIndex >= 0) {
                NameTextBox.Text = _customers[CustomerListView.SelectedIndex].Name;
                PhoneTextBox.Text = _customers[CustomerListView.SelectedIndex].Phone;
                AddressTextBox.Text = _customers[CustomerListView.SelectedIndex].Address;
                PictureBox.Source = _customers[CustomerListView.SelectedIndex].Picture.Source;
            }
        }

        private void PictureSelectBt_Click(object sender, RoutedEventArgs e) {
             //PictureBox.Source = Image.FromFile
        }

        private void PictureDeleteBt_Click(object sender, RoutedEventArgs e) {
            PictureBox.Source = null;
        }
    }
}
