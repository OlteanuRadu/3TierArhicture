

using BussinessLayer;
using DataAccesLayer;
using DocumentPicker;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zylpha.BundleLayer.FileActions;
using Zylpha.BundleLayer.Models;
using Zylpha.BundleLayer.Utils;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            OnStartUp()
                    .Resolve<UI_ConsoleApp_Consumer>().UIMethod();


            Console.ReadKey();
        }

        static IUnityContainer OnStartUp()
        {
            var bLLModule = new BLLModule();
            var dalModule = new DalModule();
            var uiModule = new UI_ConsoleApp_Module();
            return uiModule.UnityContainer;
        }
    }

    public class UI_ConsoleApp_Consumer : IUI_ConsoleApp_Consumer
    {
        [Microsoft.Practices.Unity.Dependency]
        public UsersBLL<User> UserBLL { get; set; }
        
        public void UIMethod()
        {
            this.UserBLL.SomeBLMethod().ForEach(_ => { Console.WriteLine($"{_.FirstName} {_.LastName}" ); });
           
        }
    }

    public interface IUI_ConsoleApp_Consumer
    {
        void UIMethod();
    }
}
