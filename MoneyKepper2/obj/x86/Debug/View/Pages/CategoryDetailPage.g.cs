﻿#pragma checksum "C:\Users\hamilton\Documents\GitHub\MoneyKepper\MoneyKeeper\MoneyKepper2\View\Pages\CategoryDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D1B4CD29396C6183A4FECAB5EB73C46C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyKepper2.View.Pages
{
    partial class CategoryDetailPage : 
        global::MoneyKepper2.View.Pages.PageBase, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.IncomesGroup = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 2:
                {
                    this.ExpensesGroup = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

