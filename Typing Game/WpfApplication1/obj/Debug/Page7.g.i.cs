﻿#pragma checksum "..\..\Page7.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "885A6362FDFD93ACBC8E59C0DB2C5574401FF63EDBB23C9A4882C16DC7240C07"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WpfApplication1 {
    
    
    /// <summary>
    /// CongratulationPage
    /// </summary>
    public partial class CongratulationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Page7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApplication1.CongratulationPage 完成界面;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Page7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AwardImage;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Page7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CaptionText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Page7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleText;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Page7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContinueButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Ballade;component/page7.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page7.xaml"
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
            this.完成界面 = ((WpfApplication1.CongratulationPage)(target));
            return;
            case 2:
            this.AwardImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.CaptionText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TitleText = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ContinueButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Page7.xaml"
            this.ContinueButton.Click += new System.Windows.RoutedEventHandler(this.ContinueOrRestart);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

