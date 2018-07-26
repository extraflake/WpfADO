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
using WpfADO.DataAccess.Context;
using WpfADO.DataAccess.Models;
using WpfADO.DataAccess.Params;
using WpfADO.Interface.Interfaces;

namespace WpfADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ISupplier _supplier = new SupplierService();
        IKecamatan _kecamatan = new KecamatanService();
        IKelurahan _kelurahan = new KelurahanService();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadGridCombo();
        }

#region TextChangeSupplier

        private void EmptyDetail()
        {
            IdBox.Text = "";
            NamaBox.Text = "";
            NomorBox.Text = "";
            AlamatBox.Text = "";
            KecamatanComboBox.Text = "";
            KelurahanComboBox.Text = "";
            KodePosBox.Text = "";
        }

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
                Id_Kecamatan = Convert.ToInt16(KecamatanComboBox.SelectedValue),
                Id_Kelurahan = Convert.ToInt16(KelurahanComboBox.SelectedValue)
            };
            _supplier.Insert(param);
            LoadGridCombo();
            EmptyDetail();
        }

        private void UbahButton_Click(object sender, RoutedEventArgs e)
        {
            SupplierParam param = new SupplierParam()
            {
                Name = NamaBox.Text,
                Phone = NomorBox.Text,
                Address = AlamatBox.Text,
                PostalCode = KodePosBox.Text,
                Id_Kecamatan = Convert.ToInt16(KecamatanComboBox.SelectedValue),
                Id_Kelurahan = Convert.ToInt16(KelurahanComboBox.SelectedValue)
            };
            _supplier.Update(Convert.ToInt16(IdBox.Text), param);
            LoadGridCombo();
            EmptyDetail();
        }

        private void HapusButton_Click(object sender, RoutedEventArgs e)
        {
            _supplier.Delete(Convert.ToInt16(IdBox.Text));
            LoadGridCombo();
            EmptyDetail();
        }

        #endregion ButtonSupplier

#region GridAndComboBox

        public void LoadGridCombo()
        {
            SupplierGrid.ItemsSource = _supplier.Get();
            KecamatanComboBox.ItemsSource = _kecamatan.Get();
            KelurahanComboBox.ItemsSource = _kelurahan.Get();
        }

        private void SupplierGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                object item = SupplierGrid.SelectedItem;
                IdBox.Text = (SupplierGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                NamaBox.Text = (SupplierGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                NomorBox.Text = (SupplierGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                AlamatBox.Text = (SupplierGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                KelurahanComboBox.Text = (SupplierGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                KecamatanComboBox.Text = (SupplierGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                KodePosBox.Text = (SupplierGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Successfully");
            }
        }

        #endregion GridAndComboBox
    }
}
