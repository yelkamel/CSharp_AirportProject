﻿#pragma checksum "..\..\Bagage_seach.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ACC94FACDA1B9155E93B608EEFFDAD16"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.17929
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Airport.ViewModel;
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


namespace AirportProject {
    
    
    /// <summary>
    /// Bagage_seach
    /// </summary>
    public partial class Bagage_seach : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox code_iata;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox type_task_list;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox statu_temporel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox vol_depart;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Etat_ejection;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date_departure;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ligne_bag;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label show_error;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox compagnie_name;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortie_tri_ejection;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_filter;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_filter;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Bagage_seach.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid bagage_data_;
        
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
            System.Uri resourceLocater = new System.Uri("/AirportProject;component/bagage_seach.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Bagage_seach.xaml"
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
            this.code_iata = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.type_task_list = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.statu_temporel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.vol_depart = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Etat_ejection = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.date_departure = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.ligne_bag = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.show_error = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.compagnie_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.sortie_tri_ejection = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.add_filter = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\Bagage_seach.xaml"
            this.add_filter.Click += new System.Windows.RoutedEventHandler(this.add_filter_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.delete_filter = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.bagage_data_ = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\Bagage_seach.xaml"
            this.bagage_data_.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.show_bagage_details);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

