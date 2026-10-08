//  -*-  coding: utf-8-with-signature-unix     -*-  //
/*************************************************************************
**                                                                      **
**                    ---  WPF Template Project  ---                    **
**                                                                      **
**          Copyright (C), 2025-2026, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/

using   System;
using   System.Windows;
using   System.Windows.Media.Imaging;


namespace  ViewCs  {

//========================================================================
//
//    MainWindow  class
//

public  partial class  MainWindow : Window
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

//----------------------------------------------------------------
/**   デフォルトコンストラクタ。
**
**/
public  MainWindow()
{
    InitializeComponent();

    this.m_model = new MySampleModel();
    this.SampleControl1.ViewModel =
        new WpfControl.Sample.SampleViewModel(this.m_model);

    this.Loaded += MainWindow_Loaded;
}


//========================================================================
//
//    Event Handlers.
//

private  void
MainWindow_Loaded(object sender, RoutedEventArgs e)
{
    string  customIcon  = System.IO.Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Resources", "MainWindow.ico");
    if ( System.IO.File.Exists(customIcon) ) {
        try {
            this.Icon = new BitmapImage(
                    new Uri(customIcon, UriKind.Absolute));
        } catch ( Exception ex ) {
            System.Diagnostics.Debug.WriteLine(
                $"Failed custom icon: {ex.Message}");
        }
    }
}


//========================================================================
//
//    Member Variables.
//

private   MySampleModel     m_model;


}   //  End class  MainWindow

}   //  End of namespace  ViewCs
