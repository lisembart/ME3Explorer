﻿#pragma checksum "..\..\..\Views\BioQuestMapView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81B92B0B865C69AEC8233303FDEC54B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Catel.MVVM;
using Catel.MVVM.Converters;
using Catel.MVVM.Providers;
using Catel.MVVM.Views;
using Catel.Windows;
using Catel.Windows.Controls;
using Catel.Windows.Data;
using Catel.Windows.Interactivity;
using Catel.Windows.Markup;
using Catel.Windows.Media.Effects;
using Gammtek.Conduit.MassEffect3.SFXGame.QuestMap;
using MassEffect.NativesEditor.ViewModels;
using MassEffect.Windows.Data;
using Microsoft.Expression.Interactivity.Core;
using Microsoft.Expression.Interactivity.Input;
using Microsoft.Expression.Interactivity.Layout;
using Microsoft.Expression.Interactivity.Media;
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
using System.Windows.Interactivity;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace MassEffect.NativesEditor.Views {
    
    
    /// <summary>
    /// BioQuestMapView
    /// </summary>
    public partial class BioQuestMapView : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestMapGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QuestMapComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox QuestMapListBox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestMapButtonsGrid;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddToQuestMapButton;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveFromQuestMapButton;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestMapEntryGrid;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QuestEntryComboBox;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox QuestEntryListBox;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddQuestEntryButton;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveQuestEntryButton;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\Views\BioQuestMapView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestGoalGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/MassEffect.NativesEditor;component/views/bioquestmapview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\BioQuestMapView.xaml"
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
            this.QuestMapGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.QuestMapComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.QuestMapListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.QuestMapButtonsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.AddToQuestMapButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.RemoveFromQuestMapButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.QuestMapEntryGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.QuestEntryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.QuestEntryListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.AddQuestEntryButton = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.RemoveQuestEntryButton = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.QuestGoalGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

