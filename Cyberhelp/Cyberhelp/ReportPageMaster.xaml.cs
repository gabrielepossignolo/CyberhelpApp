using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cyberhelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportPageMaster : ContentPage
    {
        public ListView ListView;

        public ReportPageMaster()
        {
            InitializeComponent();

            BindingContext = new ReportPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ReportPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ReportPageMenuItem> MenuItems { get; set; }

            public ReportPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ReportPageMenuItem>(new[]
                {
                    new ReportPageMenuItem { Id = 0, Title = "Page 1" },
                    new ReportPageMenuItem { Id = 1, Title = "Page 2" },
                    new ReportPageMenuItem { Id = 2, Title = "Page 3" },
                    new ReportPageMenuItem { Id = 3, Title = "Page 4" },
                    new ReportPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}