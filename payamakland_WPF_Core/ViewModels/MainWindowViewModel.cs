using Prism.Mvvm;
using Prism.Commands;
using System;
using Prism.Regions;

namespace payamakland_WPF_Core.ViewModels
{
    //private readonly IRegionManager _regionManager;

    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand GotoComboBoxCommand { get; set; }
        public DelegateCommand GotoListBoxCommand { get; set; }
        public DelegateCommand GotoTabControlCommand { get; set; }
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            GotoComboBoxCommand = new DelegateCommand(GotoComboBox);
            GotoListBoxCommand = new DelegateCommand(GotoListBox);
            GotoTabControlCommand = new DelegateCommand(GotoTabControl);
        }

        private void GotoTabControl()
        {
            _regionManager.RequestNavigate("ContentRegion", "TabControl");
        }

        private void GotoListBox()
        {
            _regionManager.RequestNavigate("ContentRegion", "ListBox");
        }

        private void GotoComboBox()
        {
            _regionManager.RequestNavigate("ContentRegion", "ComboBox");
        }
    }
}
