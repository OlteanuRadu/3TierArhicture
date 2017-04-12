using DataAccesLayer;
using Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BLLModule : Infrastructure.Module
    {
        public override void RegisterTypes()
        {
            this.UnityContainer.RegisterTypes(
                                  AllClasses.FromAssemblies(new Assembly[] {
                                        typeof(UsersBLL<User>).Assembly
                                  }),
                                  WithMappings.FromMatchingInterface,
                                  WithName.Default,
                                  WithLifetime.Transient);
        }
    }
}
