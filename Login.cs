namespace Chat_App_Project;

public partial class Login : Form
{
    TextBox txtUsername = new TextBox();
    TextBox txtPassword = new TextBox();

    public Login()
    {
        InitializeComponent();
        #region Login Button
        Button btnLogin = new Button();
        btnLogin.Location = new Point(ClientSize.Width-150, ClientSize.Height-150);
        btnLogin.Text = "Login";
        btnLogin.Click += new EventHandler(btnLogin_Click);
        btnLogin.Size = new Size(100, 100);
        #endregion

        #region Username Label
        Label lblUsername = new Label();
        lblUsername.Text = "Username";
        lblUsername.Location = new Point(50, 50);
        #endregion

        #region Username Textbox
        txtUsername.Location = new Point(50, 80);
        txtUsername.Size = new Size(300, 25);
        #endregion

        #region Password Label
        Label lblPassword = new Label();
        lblPassword.Text = "Password";
        lblPassword.Location = new Point(50, 150);
        #endregion

        #region Password Textbox
        txtPassword.Location = new Point(50, 180);
        txtPassword.Size = new Size(300, 25);
        txtPassword.UseSystemPasswordChar = true;
        #endregion

        #region Add Controls
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        #endregion

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (username == "admin" && password == "admin")
        {
            MessageBox.Show("Login Successful");
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        else
        {
            MessageBox.Show("Login Failed");
        }
    }
}
