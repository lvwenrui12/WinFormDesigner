using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.CodeDom.Compiler;
using System.CodeDom;
using Microsoft.CSharp;
using Microsoft.VisualBasic;

namespace Loader
{
    /// <summary>
    /// This service resolved the types and is required when using the
    /// CodeDomHostLoader
    /// </summary>
	public class TypeResolutionService : ITypeResolutionService
	{
        Hashtable ht = new Hashtable();

		public TypeResolutionService()
		{
		}

		public System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name)
		{
			return GetAssembly(name, true);
		}
		public System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name, bool throwOnErrors)
		{
			return Assembly.GetAssembly(typeof(Form));
		}
		public string GetPathOfAssembly(System.Reflection.AssemblyName name)
		{
			return null;
		}
		public Type GetType(string name)
		{
			return this.GetType(name, true);
		}
		public Type GetType(string name, bool throwOnError)
		{
			return this.GetType(name, throwOnError, false);
		}

        /// <summary>
        /// This method is called when dropping controls from the toolbox
        /// to the host that is loaded using CodeDomHostLoader. For
        /// simplicity we just go through System.Windows.Forms assembly
        /// </summary>
		public Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
            if (ht.ContainsKey(name))
                return (Type)ht[name];

            Assembly winForms = Assembly.GetAssembly(typeof(Button));
            Type[] types = winForms.GetTypes();
            string typeName = String.Empty;
            foreach (Type type in types)
            {
                typeName = "system.windows.forms." + type.Name.ToLower();
                if (typeName == name.ToLower())
                {
                    ht[name] = type;
                    return type;
                }
            }
            return Type.GetType(name);
		}
		public void ReferenceAssembly(System.Reflection.AssemblyName name)
		{
		}

	}// class
}// namespace
