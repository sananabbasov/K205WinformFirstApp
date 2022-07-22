namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var userEmail = "sanan@compar.az";
            var userPassword = "123456";


            var txtEmail = TxtEmail.Text;
            var txtPassword = TxtPassword.Text;

            if (userEmail == txtEmail && userPassword == txtPassword)
            {
                Dashboard dashboard = new();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ve ya sifre sehfdi","Diqqet",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}