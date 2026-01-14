namespace WinFormsApp.MDIForm;

public partial class FormB : Form {
    private ColourChanger _colourChanger;
    public FormB() {
        InitializeComponent();
        
        _colourChanger = new ColourChanger(this);
    }

    private void FormB_Activated(object sender, EventArgs e) {
        _colourChanger.Start();
    }

    private void FormB_Deactivate(object sender, EventArgs e) {
        _colourChanger.Stop();
    }
}