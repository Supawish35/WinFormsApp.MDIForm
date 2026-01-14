namespace WinFormsApp.MDIForm;

public partial class Main : Form {
    public Main() {
        InitializeComponent();
    }

    private void OpenChildForm(Form formName) {
        foreach (Form f in this.MdiChildren) {
            if (f.GetType() == formName.GetType()) {
                f.Activate();
                return;
            }
        }

        formName.MdiParent = this;
        formName.WindowState = FormWindowState.Normal;
        formName.Show();
    }

    private void mnuFormA_Click(object sender, EventArgs e) {
        OpenChildForm(new FormA());
        //FormA f = new FormA();
        //f.MdiParent = this;
        //f.Show();
    }

    private void mnuFormB_Click(object sender, EventArgs e) {
        OpenChildForm(new FormB());
        //FormB f = new FormB();
        //f.MdiParent = this;
        //f.Show();
    }

    private void mnuFormC_Click(object sender, EventArgs e) {
        OpenChildForm(new FormC());
        //FormC f = new FormC();
        //f.MdiParent = this;
        //f.Show();
    }

    private void mnuExit_Click(object sender, EventArgs e) {
        Application.Exit();
    }

    private void mnuFormMaximize_Click(object sender, EventArgs e) {
        this.WindowState = FormWindowState.Maximized;
    }

    private void mnuFormMinimize_Click(object sender, EventArgs e) {
        this.WindowState = FormWindowState.Minimized;
    }

    private void mnuFormNormal_Click(object sender, EventArgs e) {
        this.WindowState = FormWindowState.Normal;
    }

    private void mnuArrangeCascade_Click(object sender, EventArgs e) {
        this.LayoutMdi(MdiLayout.Cascade);
    }

    private void mnuTileHorizontal_Click(object sender, EventArgs e) {
        this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void mnuTileVertical_Click(object sender, EventArgs e) {
        this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void mnuCloseActiveForm_Click(object sender, EventArgs e) {
        if (this.ActiveMdiChild != null) {
            this.ActiveMdiChild.Close();
        }
    }

    private void mnuCloseAllChild_Click(object sender, EventArgs e) {
        foreach (Form frm in this.MdiChildren) {
            frm.Close();
        }
    }
}