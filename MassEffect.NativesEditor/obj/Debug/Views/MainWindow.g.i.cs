﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "268CBB0F713C4CADBA893A65C70C0EC5"
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
using Gammtek.Conduit.MassEffect3.SFXGame.CodexMap;
using Gammtek.Conduit.MassEffect3.SFXGame.QuestMap;
using Gammtek.Conduit.MassEffect3.SFXGame.StateEventMap;
using MassEffect.NativesEditor;
using MassEffect.Windows.Data;
using MassEffect.Windows.Markup;
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Catel.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MainMenu;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem CodexMapTabItem;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CodexMapComboBox;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CodexMapListBox;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid CodexMapButtonsGrid;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCodexEntryButton;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveCodexEntryButton;
        
        #line default
        #line hidden
        
        
        #line 331 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem QuestMapTab;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid QuestMapGrid;
        
        #line default
        #line hidden
        
        
        #line 348 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QuestMapComboBox;
        
        #line default
        #line hidden
        
        
        #line 356 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox QuestMapListBox;
        
        #line default
        #line hidden
        
        
        #line 427 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid QuestMapButtonsGrid;
        
        #line default
        #line hidden
        
        
        #line 438 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddToQuestMapButton;
        
        #line default
        #line hidden
        
        
        #line 444 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveFromQuestMapButton;
        
        #line default
        #line hidden
        
        
        #line 451 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid QuestMapEntryGrid;
        
        #line default
        #line hidden
        
        
        #line 470 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QuestEntryComboBox;
        
        #line default
        #line hidden
        
        
        #line 479 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox QuestEntryListBox;
        
        #line default
        #line hidden
        
        
        #line 570 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddQuestEntryButton;
        
        #line default
        #line hidden
        
        
        #line 578 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveQuestEntryButton;
        
        #line default
        #line hidden
        
        
        #line 589 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid QuestGoalGrid;
        
        #line default
        #line hidden
        
        
        #line 728 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem StateEventMapTab;
        
        #line default
        #line hidden
        
        
        #line 743 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StateEventMapComboBox;
        
        #line default
        #line hidden
        
        
        #line 750 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox StateEventMapListBox;
        
        #line default
        #line hidden
        
        
        #line 819 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStateEventButton;
        
        #line default
        #line hidden
        
        
        #line 828 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveStateEventButton;
        
        #line default
        #line hidden
        
        
        #line 838 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventMapEntryGrid;
        
        #line default
        #line hidden
        
        
        #line 893 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox StateEventElementsListBox;
        
        #line default
        #line hidden
        
        
        #line 987 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NewStateEventElementComboBox;
        
        #line default
        #line hidden
        
        
        #line 1015 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStateEventElementButton;
        
        #line default
        #line hidden
        
        
        #line 1024 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveStateEventElementButton;
        
        #line default
        #line hidden
        
        
        #line 1039 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementGrid;
        
        #line default
        #line hidden
        
        
        #line 1095 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementConsequenceGrid;
        
        #line default
        #line hidden
        
        
        #line 1120 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementFloatGrid;
        
        #line default
        #line hidden
        
        
        #line 1160 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementFunctionGrid;
        
        #line default
        #line hidden
        
        
        #line 1200 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementIntGrid;
        
        #line default
        #line hidden
        
        
        #line 1240 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementLocalBoolGrid;
        
        #line default
        #line hidden
        
        
        #line 1289 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementLocalFloatGrid;
        
        #line default
        #line hidden
        
        
        #line 1334 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementLocalIntGrid;
        
        #line default
        #line hidden
        
        
        #line 1379 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Catel.Windows.Controls.StackGrid StateEventElementSubstateGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/MassEffect.NativesEditor;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            this.MainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.MainTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.CodexMapTabItem = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            this.CodexMapComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.CodexMapListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.CodexMapButtonsGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 7:
            this.AddCodexEntryButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.RemoveCodexEntryButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.QuestMapTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 10:
            this.QuestMapGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 11:
            this.QuestMapComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.QuestMapListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 13:
            this.QuestMapButtonsGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 14:
            this.AddToQuestMapButton = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.RemoveFromQuestMapButton = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.QuestMapEntryGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 17:
            this.QuestEntryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 18:
            this.QuestEntryListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 19:
            this.AddQuestEntryButton = ((System.Windows.Controls.Button)(target));
            return;
            case 20:
            this.RemoveQuestEntryButton = ((System.Windows.Controls.Button)(target));
            return;
            case 21:
            this.QuestGoalGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 22:
            this.StateEventMapTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 23:
            this.StateEventMapComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 24:
            this.StateEventMapListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 25:
            this.AddStateEventButton = ((System.Windows.Controls.Button)(target));
            return;
            case 26:
            this.RemoveStateEventButton = ((System.Windows.Controls.Button)(target));
            return;
            case 27:
            this.StateEventMapEntryGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 28:
            this.StateEventElementsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 29:
            this.NewStateEventElementComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 30:
            this.AddStateEventElementButton = ((System.Windows.Controls.Button)(target));
            return;
            case 31:
            this.RemoveStateEventElementButton = ((System.Windows.Controls.Button)(target));
            return;
            case 32:
            this.StateEventElementGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 33:
            this.StateEventElementConsequenceGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 34:
            this.StateEventElementFloatGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 35:
            this.StateEventElementFunctionGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 36:
            this.StateEventElementIntGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 37:
            this.StateEventElementLocalBoolGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 38:
            this.StateEventElementLocalFloatGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 39:
            this.StateEventElementLocalIntGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            case 40:
            this.StateEventElementSubstateGrid = ((Catel.Windows.Controls.StackGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

