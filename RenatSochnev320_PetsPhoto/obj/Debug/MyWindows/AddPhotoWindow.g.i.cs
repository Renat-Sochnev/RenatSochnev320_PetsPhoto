﻿#pragma checksum "..\..\..\MyWindows\AddPhotoWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47A877A109E54B53281887842C1DF529E28E5B39B51C2D1AD040AB030519A4A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RenatSochnev320_PetsPhoto.MyWindows;
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


namespace RenatSochnev320_PetsPhoto.MyWindows {
    
    
    /// <summary>
    /// AddPhotoWindow
    /// </summary>
    public partial class AddPhotoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\MyWindows\AddPhotoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AddImg;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MyWindows\AddPhotoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MyWindows\AddPhotoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PetsCb;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\MyWindows\AddPhotoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTb;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MyWindows\AddPhotoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddInfoBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/RenatSochnev320_PetsPhoto;component/mywindows/addphotowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MyWindows\AddPhotoWindow.xaml"
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
            this.AddImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\MyWindows\AddPhotoWindow.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PetsCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\..\MyWindows\AddPhotoWindow.xaml"
            this.PetsCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PetsCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddInfoBtn = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\MyWindows\AddPhotoWindow.xaml"
            this.AddInfoBtn.Click += new System.Windows.RoutedEventHandler(this.AddInfoBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

