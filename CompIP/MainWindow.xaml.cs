using CompIP.BusinessLayer.Interfaces;
using CompIP.BusinessLayer.Models;
using CompIP.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CompIP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<OrganizationViewModel> organizations;
        IOrganizationService organizationService;
        public MainWindow()
        {
            InitializeComponent();
            organizationService = new OrganizationService("TestDbConnection");
            organizations = organizationService.GetAll();

            cBoxGroup.DataContext = organizations;
        }
    }
}
