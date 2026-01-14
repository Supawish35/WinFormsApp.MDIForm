namespace WinFormsApp.MDIForm;

public partial class FormC : Form {
    private ColourChanger _colourChanger;
    public FormC() {
        InitializeComponent();
        
        _colourChanger = new ColourChanger(this);
    }

    private void FormC_Activated(object sender, EventArgs e) {
        _colourChanger.Start();
    }

    private void FormC_Deactivate(object sender, EventArgs e) {
        _colourChanger.Stop();
    }
}