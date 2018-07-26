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
using WpfADO.Common.Interfaces;
using WpfADO.DataAccess.Models;
using WpfADO.DataAccess.Params;

namespace WpfADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ISupplier _supplier = new SupplierService();
        public MainWindow()
        {
            InitializeComponent();
        }

#region TextChangeSupplier

        private void NomorBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

#endregion TextChangeSupplier

#region ButtonSupplier

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
            _supplier.Insert(param);          
        }

        private void UbahButton_Click(object sender, RoutedEventArgs e)
        {
            SupplierParam param = new SupplierParam()
            {
                Name = NamaBox.Text,
                Phone = NomorBox.Text,
                Address = AlamatBox.Text,
                PostalCode = KodePosBox.Text,
                Id_Kecamatan = 6,
                Id_Kelurahan = 2
            };
            _supplier.Update(Convert.ToInt16(IdBox.Text), param);
        }

        private void HapusButton_Click(object sender, RoutedEventArgs e)
        {
            _supplier.Delete(Convert.ToInt16(IdBox.Text));
        }

#endregion ButtonSupplier
    }
}
