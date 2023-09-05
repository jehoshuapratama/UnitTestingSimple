using Simple_Unit_Test.Presenter;
using Simple_Unit_Test.View.Interfaces;

namespace Simple_Unit_Test
{
    internal partial class frmUnitTesting : Form, IPersonView
    {
        string message = string.Empty;
        public string FirstName { get => txbFirstName.Text; set => txbFirstName.Text = value; }
        public string LastName { get => txbLastName.Text; set => txbLastName.Text = value; }
        public string Email { get => txbEmailAddress.Text; set => txbEmailAddress.Text = value; }
        public string PhoneNumber { get => txbPhoneNumber.Text; set => txbPhoneNumber.Text = value; }
        public string Nationality { get => txbNationality.Text; set => txbNationality.Text = value; }
        public bool EmailFocus { get => txbEmailAddress.Focused;}
        public bool PhoneNumberFocus { get => txbPhoneNumber.Focused;}
        public string Message { get => message; set => message = value; }
        public PersonPresenter Presenter { private get; set; }
        

        public frmUnitTesting()
        {
            InitializeComponent();
            var presenter = new Presenter.PersonPresenter(this);
            presenter.InitialMessage();
            MessageBox.Show(message, "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Presenter.Submit();
            MessageBox.Show(message, "Submit Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            message = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Presenter.ClearBox();
        }
    }
}