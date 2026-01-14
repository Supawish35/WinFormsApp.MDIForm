using System.ComponentModel;
using System.Diagnostics;

namespace WinFormsApp.MDIForm;

public partial class FormA : Form {
    private ColourChanger _colourChanger;

    public FormA() {
        InitializeComponent();

        _colourChanger = new ColourChanger(this);
    }

    private void FormA_Activated(object sender, EventArgs e) {
        _colourChanger.Start();
    }

    private void FormA_Deactivate(object sender, EventArgs e) {
        _colourChanger.Stop();
    }

    
}