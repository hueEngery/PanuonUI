﻿#pragma checksum "..\..\..\9_Special\PUMessageBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E76029F8C48927D0CC13550E618BF79401648B78"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Panuon.UI;
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


namespace Panuon.UI {
    
    
    /// <summary>
    /// PUMessageBox
    /// </summary>
    public partial class PUMessageBox : Panuon.UI.PUWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtContent;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdAwait;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PULoading loading;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtAwait;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid groupTip;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PUButton btnOK;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid groupConfirm;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PUButton BtnYes;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\9_Special\PUMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PUButton BtnNo;
        
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
            System.Uri resourceLocater = new System.Uri("/Panuon.UI;component/9_special/pumessagebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\9_Special\PUMessageBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.txtContent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.grdAwait = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.loading = ((Panuon.UI.PULoading)(target));
            return;
            case 4:
            this.txtAwait = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.groupTip = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.btnOK = ((Panuon.UI.PUButton)(target));
            return;
            case 7:
            this.groupConfirm = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.BtnYes = ((Panuon.UI.PUButton)(target));
            return;
            case 9:
            this.BtnNo = ((Panuon.UI.PUButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

