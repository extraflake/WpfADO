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
using WpfADO.BussinessLogic.Services;
using WpfADO.DataAccess.Models;
using WpfADO.DataAccess.Params;

namespace WpfADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SupplierService _serviceSupplier = new SupplierService();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NomorBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SimpanButton_Click(object sender, RoutedEventArgs e)
        {
            SupplierParam param = new SupplierParam
            {
                Name = NamaBox.Text,
                Phone = NomorBox.Text,
                Address = AlamatBox.Text,
                PostalCode = KodePosBox.Text,
                Id_Kecamatan = 6,
                Id_Kelurahan = 2
            };
            _serviceSupplier.Insert(param);
        }

        private void UbahButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HapusButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
