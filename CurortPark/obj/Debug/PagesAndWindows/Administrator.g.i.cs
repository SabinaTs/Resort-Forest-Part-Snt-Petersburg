#pragma checksum "..\..\..\PagesAndWindows\Administrator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "112681F249F0AAC37D8E0C9EAA283D6B6B7984F633AD3A6D7AFEC85B3B8BF6D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CurortPark.PagesAndWindows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CurortPark.PagesAndWindows {
    
    
    /// <summary>
    /// Administrator
    /// </summary>
    public partial class Administrator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\PagesAndWindows\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button report;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\PagesAndWindows\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\PagesAndWindows\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button managers;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\PagesAndWindows\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button data;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\PagesAndWindows\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hist;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CurortPark;component/pagesandwindows/administrator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PagesAndWindows\Administrator.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.report = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\PagesAndWindows\Administrator.xaml"
            this.report.Click += new System.Windows.RoutedEventHandler(this.ReportBtn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\PagesAndWindows\Administrator.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.ExitBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            this.managers = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\PagesAndWindows\Administrator.xaml"
            this.managers.Click += new System.Windows.RoutedEventHandler(this.ManagerEditBtn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.data = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\PagesAndWindows\Administrator.xaml"
            this.data.Click += new System.Windows.RoutedEventHandler(this.DataBtn);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hist = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\PagesAndWindows\Administrator.xaml"
            this.hist.Click += new System.Windows.RoutedEventHandler(this.HistoryBtn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

