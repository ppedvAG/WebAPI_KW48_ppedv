﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24199446FA8EDC857B24150A68678CB9FC16B12F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Chat.Desktop;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Chat.Desktop {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 79 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateChatRoom;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxRooms;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgAvatar;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtUsername;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignout;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRoomName;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteRoom;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewMessages;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSend;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtOnlineCounter;
        
        #line default
        #line hidden
        
        
        #line 283 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewUsers;
        
        #line default
        #line hidden
        
        
        #line 315 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchUser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Chat.Desktop;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((Chat.Desktop.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCreateChatRoom = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\MainWindow.xaml"
            this.btnCreateChatRoom.Click += new System.Windows.RoutedEventHandler(this.btnCreateChatRoom_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListBoxRooms = ((System.Windows.Controls.ListBox)(target));
            
            #line 94 "..\..\..\MainWindow.xaml"
            this.ListBoxRooms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxRooms_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.txtUsername = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnSignout = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\..\MainWindow.xaml"
            this.btnSignout.Click += new System.Windows.RoutedEventHandler(this.btnSignout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtRoomName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnDeleteRoom = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\MainWindow.xaml"
            this.btnDeleteRoom.Click += new System.Windows.RoutedEventHandler(this.btnDeleteRoom_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ListViewMessages = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.btnSend = ((System.Windows.Controls.Button)(target));
            
            #line 238 "..\..\..\MainWindow.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.btnSend_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtMessage = ((System.Windows.Controls.TextBox)(target));
            
            #line 255 "..\..\..\MainWindow.xaml"
            this.txtMessage.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtMessage_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtOnlineCounter = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.ListViewUsers = ((System.Windows.Controls.ListView)(target));
            
            #line 284 "..\..\..\MainWindow.xaml"
            this.ListViewUsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewUsers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txtSearchUser = ((System.Windows.Controls.TextBox)(target));
            
            #line 316 "..\..\..\MainWindow.xaml"
            this.txtSearchUser.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchUser_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

