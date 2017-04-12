using BussinessLayer;
using DataAccesLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UI_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //var t  = Init().Resolve<MainWindow>().UserBLL;



            base.OnStartup(e);
        }

        private IUnityContainer Init()
        {
            new DalModule();
            new BLLModule();
            var t =new UIWPF_Module();
          return  t.UnityContainer;
        }
    }
}
