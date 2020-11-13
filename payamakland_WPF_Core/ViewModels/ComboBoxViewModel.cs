using payamakland_WPF_Core.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace payamakland_WPF_Core.ViewModels
{
    public class ComboBoxViewModel : BindableBase
    {
        private ObservableCollection<Person> _items = new ObservableCollection<Person>();
        public ObservableCollection<Person> Items
        {
            get {return _items; }
            set { SetProperty(ref _items, value); } 
        }

        
        public ComboBoxViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Items.Add(new Person { Name = "مشتری" + i, LName = "موبایل شماره" + i, Mobile="0915436765" + i });
            }

           
        }
    }
}
