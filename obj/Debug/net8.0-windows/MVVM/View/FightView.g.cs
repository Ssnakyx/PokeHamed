﻿#pragma checksum "..\..\..\..\..\MVVM\View\FightView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78544514DBA1523CB584298240647A740C86F14A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WpfApp1.MVVM.View {
    
    
    /// <summary>
    /// FightView
    /// </summary>
    public partial class FightView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ScoreLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlayerMonsterName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlayerMonsterHealth;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PlayerMonsterImage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PlayerMonsterSpells;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OpponentMonsterName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OpponentMonsterHealth;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\MVVM\View\FightView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image OpponentMonsterImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PokeBattle_Hamed;component/mvvm/view/fightview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\FightView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ScoreLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.PlayerMonsterName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.PlayerMonsterHealth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PlayerMonsterImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.PlayerMonsterSpells = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.OpponentMonsterName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.OpponentMonsterHealth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.OpponentMonsterImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

