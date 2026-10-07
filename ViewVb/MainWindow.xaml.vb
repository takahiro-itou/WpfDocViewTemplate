
Imports System
Imports System.Windows
Imports System.Windows.Media.Imaging


Public Class MainWindow

Private m_model As MySampleModel

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
    Me.m_model = New MySampleModel()
    SampleControl1.ViewModel = New WpfControl.Sample.SampleViewModel(m_model)
End Sub


Private Sub MainWindow_Loaded(ByVal sender As Object, e As RoutedEventArgs) _
    Handles Me.Loaded
''--------------------------------------------------------------------
''    ウィンドウのロードイベント
''--------------------------------------------------------------------
Dim customIcon As String

    customIcon  = System.IO.Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Resources", "MainWindow.ico")

    If System.IO.File.Exists(customIcon) Then
        Try
            Me.Icon = New BitmapImage(New Uri(customIcon, UriKind.Absolute))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(
                $"Failed custom icon: {ex.Message}")
        End Try
    End If

End Sub


End Class
