
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample


Public Class MySampleViewModel
        Inherits WpfControl.Sample.SampleViewModel

Private ReadOnly m_runButtonCommand As WpfControl.Common.SimpleCommand


Public Sub New(ByVal model As MySampleModel)
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------

    MyBase.New(model)
    Me.m_runButtonCommand = New WpfControl.Common.SimpleCommand(
        Sub(ByVal parameter As Object)
            ExecuteRunButtonCommand()
        End Sub,
        Function(ByVal parameter As Object) As Boolean
            Return  Me.InputText <> ""
        End Function
    )

End Sub


''--------------------------------------------------------------------
''    RunButtonCommand  プロパティ
''
Public Overrides ReadOnly Property RunButtonCommand As ICommand
    Get
        Return  Me.m_runButtonCommand
    End Get
End Property


Protected Overrides Sub raiseCanExecuteChanged()
''--------------------------------------------------------------------
''    CanExecuteChanged を発生させる
''--------------------------------------------------------------------
    Me.m_runButtonCommand.RaiseCanExecuteChanged()
End Sub


Protected Overrides Sub ExecuteRunButtonCommand()
''--------------------------------------------------------------------
''    「実行」ボタンをクリックした時の処理
''--------------------------------------------------------------------
    RunCount(Me.InputText)
End Sub


Private Sub RunCount(ByVal message As String)
''--------------------------------------------------------------------
''    サンプル動作
''
''    入力テキスト中のアルファベットの個数を数える
''--------------------------------------------------------------------
Dim result As Integer
Dim outText As String
Dim objWrapper As SampleWrapper.Common.SampleDocument

    objWrapper = New SampleWrapper.Common.SampleDocument()
    objWrapper.setMessage(message)
    result = objWrapper.countAlphabet()

    outText = "入力した文字列中のアルファベットの個数は " & result
    Me.m_model.setOutputText(outText)

    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub


End Class
