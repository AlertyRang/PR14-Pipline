﻿#pragma checksum "..\..\RegWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB9030D784254D46CF791EDA4CE7979B135A0A8F0EF127AB511F20BE64ABA914"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ISRecipe;
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


namespace ISRecipe {
    
    
    /// <summary>
    /// RegWindow
    /// </summary>
    public partial class RegWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Login;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PB_Password;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Name;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Email;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Back;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Registration;
        
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
            System.Uri resourceLocater = new System.Uri("/ISRecipe;component/regwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegWindow.xaml"
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
            this.TB_Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PB_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.TB_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TB_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BT_Back = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\RegWindow.xaml"
            this.BT_Back.Click += new System.Windows.RoutedEventHandler(this.BT_Back_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BT_Registration = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\RegWindow.xaml"
            this.BT_Registration.Click += new System.Windows.RoutedEventHandler(this.BT_Registration_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

