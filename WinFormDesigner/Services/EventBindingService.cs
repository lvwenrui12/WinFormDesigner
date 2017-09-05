// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 915 $</version>
// </file>

using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;

//using ICSharpCode.SharpDevelop.DefaultEditor.Gui.Editor;
//using ICSharpCode.SharpDevelop.Gui;

namespace ICSharpCode.FormsDesigner.Services
{
    public class EventBindingService : System.ComponentModel.Design.EventBindingService
    {

        public EventBindingService(IServiceProvider provider) : base(provider)
        {
        }

        protected override string CreateUniqueMethodName(IComponent component, EventDescriptor e)
        {
            return String.Format("{0}_{1}", Char.ToUpper(component.Site.Name[0]) + component.Site.Name.Substring(1), e.DisplayName);
        }

        // sohuld look around in form class for compatiable methodes
        protected override ICollection GetCompatibleMethods(EventDescriptor e)
        {
            ArrayList al = new ArrayList();
            MethodInfo methodInfo = e.EventType.GetMethod("Invoke");
            if (null != methodInfo)
                al.Add(methodInfo.Name);
            return al;
        }

        protected override bool ShowCode()
        {
            //IWorkbenchWindow window = WorkbenchSingleton.Workbench.ActiveWorkbenchWindow;
            //if (window == null) {
            //    return false;
            //}

            //FormsDesignerViewContent formDesigner = window.ActiveViewContent as FormsDesignerViewContent;

            //if (formDesigner != null) {
            //    formDesigner.ShowSourceCode();
            //    return true;
            //}
            return false;
        }

        protected override bool ShowCode(int lineNumber)
        {
            //IWorkbenchWindow window = WorkbenchSingleton.Workbench.ActiveWorkbenchWindow;
            //if (window == null) {
            //    return false;
            //}

            //FormsDesignerViewContent formDesigner = window.ActiveViewContent as FormsDesignerViewContent;

            //if (formDesigner != null) {
            //    formDesigner.ShowSourceCode(lineNumber);
            //    return true;
            //}
            return false;
        }

        protected override bool ShowCode(IComponent component, EventDescriptor edesc, string methodName)
        {
            System.Windows.Forms.MessageBox.Show("to add:" + component.Site.Name + "\r\n" + methodName);
            return false;
        }


    }
}
