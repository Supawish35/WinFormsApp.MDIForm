using System.ComponentModel;

namespace WinFormsApp.MDIForm;

partial class FormB {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        SuspendLayout();
        // 
        // FormB
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Yellow;
        ClientSize = new System.Drawing.Size(800, 450);
        Text = "FormB";
        Activated += FormB_Activated;
        Deactivate += FormB_Deactivate;
        ResumeLayout(false);
    }

    #endregion
}