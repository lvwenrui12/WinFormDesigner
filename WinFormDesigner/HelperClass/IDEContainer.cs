using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WinFormDesigner
{
    class IDEContainer : Container
    {
        class IDESite : ISite
        {
            private string name = "";
            private IComponent component;
            private IDEContainer container;

            public IDESite(IComponent sitedComponent, IDEContainer site, string aName)
            {
                component = sitedComponent;
                container = site;
                name = aName;
            }

            public IComponent Component
            {
                get { return component; }
            }
            public IContainer Container
            {
                get { return container; }
            }

            public bool DesignMode
            {
                get { return false; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public object GetService(Type serviceType)
            {
                return container.GetService(serviceType);
            }
        }

        public IDEContainer(IServiceProvider sp)
        {
            serviceProvider = sp;
        }

        protected override object GetService(Type serviceType)
        {
            object service = base.GetService(serviceType);
            if (service == null)
            {
                service = serviceProvider.GetService(serviceType);
            }
            return service;
        }

        public ISite CreateSite(IComponent component)
        {
            return CreateSite(component, "UNKNOWN_SITE");
        }

        protected override ISite CreateSite(IComponent component, string name)
        {
            ISite site = base.CreateSite(component, name);
            if (site == null)
            {
            }
            return new IDESite(component, this, name);
        }

        private IServiceProvider serviceProvider;
    }
}
