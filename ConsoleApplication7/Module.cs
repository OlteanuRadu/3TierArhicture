using Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class UI_ConsoleApp_Module : Infrastructure.Module
    {
        public override void RegisterTypes()
        {

            this.UnityContainer.RegisterTypes(
                                AllClasses.FromAssemblies(new Assembly[] {
                                        typeof(Program).Assembly
                                }),
                                WithMappings.FromMatchingInterface,
                                WithName.Default,
                                WithLifetime.Transient);
        }
    }
}
