﻿#pragma checksum "..\..\..\..\..\MVVM\View\MonstresView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33AEF7952B4724AF41CDB62AAD2FEEFEAABE0BF7"
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
    /// MonstresView
    /// </summary>
    public partial class MonstresView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel ImageStackPanel;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel RightPanelSpells;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PokemonDetailsHeader;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PokemonHealth;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PokemonSpellsHeader;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SpellsList;
        
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
            System.Uri resourceLocater = new System.Uri("/PokeBattle_Hamed;component/mvvm/view/monstresview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\MonstresView.xaml"
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
            this.ImageStackPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 2:
            this.RightPanelSpells = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.PokemonDetailsHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PokemonHealth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PokemonSpellsHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.SpellsList = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

