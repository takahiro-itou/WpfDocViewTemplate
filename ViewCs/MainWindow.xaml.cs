
namespace  ViewCs  {

public  partial class  MainWindow : Window
{

    //----------------------------------------------------------------
    /**   デフォルトコンストラクタ。
    **
    **/
    public  MainWindow()
    {
        InitializeComponent();
        this.m_model = New MySampleModel();
        this.SampleControl1.ViewModel =
            new WpfControl.Sample.SampleViewModel(this.m_model);
    }

    private MySampleModel   m_model;
}

}   //  End of namespace  ViewCs
