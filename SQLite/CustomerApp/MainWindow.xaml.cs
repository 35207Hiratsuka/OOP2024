using CustomerApp.Objects;
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
using System.IO;
using Microsoft.Win32;
using static System.Net.WebRequestMethods;
using System.Globalization;
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

        private byte[] ImageToByteArray(BitmapImage bitmapImage) {
            using(MemoryStream ms = new MemoryStream()) {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(ms);
                return ms.ToArray();
            }
        }
        private BitmapImage ByteArrayToImage(byte[] byteArray) {
            using(MemoryStream ms = new MemoryStream(byteArray)) {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = ms;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                return bitmap;
            }
        }

            private void RegistButton_Click(object sender, RoutedEventArgs e) {
            if(NameTextBox.Text == null) {
                MessageBox.Show("名前が入力されていません");
                return;
            }
            var customer = new Customer() { Name = NameTextBox.Text, Phone = PhoneTextBox.Text, Address = AddressTextBox.Text, Picture = PicturePreviewBox.Source != null ? ImageToByteArray((BitmapImage)PicturePreviewBox.Source) : null, };
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
            }else if(NameTextBox.Text == null) {
                MessageBox.Show("名前が入力されていません");
                return;
            }

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;
            item.Picture = PicturePreviewBox.Source != null ? ImageToByteArray((BitmapImage)PicturePreviewBox.Source) : null;
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
                PicturePreviewBox.Source = null;
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
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if(selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                if(selectedCustomer.Picture != null) {
                    PicturePreviewBox.Source = ByteArrayToImage(selectedCustomer.Picture);
                } else {
                    PicturePreviewBox.Source = null;
                }
            }
        }

            private void PictureSelectBt_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*", Title = "画像を選択してください" };
            if(openFileDialog.ShowDialog() == true) {
                string selectedFileName = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                PicturePreviewBox.Source = bitmap;
            }
        }

        private void PictureDeleteBt_Click(object sender, RoutedEventArgs e) {
            PicturePreviewBox.Source = null;
        }
    }
}
