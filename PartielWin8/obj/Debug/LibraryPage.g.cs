﻿

#pragma checksum "C:\Users\Thomas\Documents\Visual Studio 2013\Projects\PartielWin8\PartielWin8\LibraryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C5E398766081DA8BDFEC8DE929283742"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartielWin8
{
    partial class LibraryPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 27 "..\..\LibraryPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BackButton_Clicked;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 29 "..\..\LibraryPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.SelectedItem;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 43 "..\..\LibraryPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.deleting;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 44 "..\..\LibraryPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.borrowing;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

