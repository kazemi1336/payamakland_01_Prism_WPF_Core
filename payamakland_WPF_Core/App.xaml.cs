using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;
using payamakland_WPF_Core.Views;
using Prism.Ioc;
using System;
using System.Windows;

namespace payamakland_WPF_Core
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ComboBox>();
            containerRegistry.RegisterForNavigation<ListBox>();
            containerRegistry.RegisterForNavigation<TabControl>();
        }
        internal void UpdateSkin(SkinType skin)
        {
            SharedResourceDictionary.SharedDictionaries.Clear();
            Resources.MergedDictionaries.Add(ResourceHelper.GetSkin(skin));
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
            });
            Current.MainWindow?.OnApplyTemplate();
        }
    }
}
