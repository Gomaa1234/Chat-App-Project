namespace Chat_App_Project;

partial class Login
{
    private System.ComponentModel.IContainer components = null;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Login

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(680, 330);
        this.StartPosition = FormStartPosition.CenterScreen;
        // this.FormBorderStyle = FormBorderStyle.None;
        this.Text = "Login";
    }
    #endregion
}
