﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using dbqf.Display.Advanced;
using dbqf.WinForms;
using dbqf.WinForms.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standalone.Installers.Views
{
    public class AdvancedInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<AdvancedView>().LifestyleTransient(),
                Component.For<AdvancedAdapter<Control>>().ImplementedBy<WinFormsAdvancedAdapter>().LifestyleTransient()
            );
        }
    }
}
