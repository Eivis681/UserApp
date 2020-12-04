using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserApp
{
    public partial class _Default : Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerButton_Click(object sender, EventArgs e)
        {

            if (nameField.Text.Equals(""))
            {
                errorLabel.Text = "Iveskite varda";
                return;
            }
            if (surnameField.Text.Equals(""))
            {
                errorLabel.Text = "Iveskite pavarde";
                return;
            }
            if (asmensKodoFiels.Text.Equals(""))
            {
                errorLabel.Text = "Iveskite asmens koda";
                return;
            }
            if (RadioButton1.Checked==false && RadioButton2.Checked==false)
            {
                errorLabel.Text = "Pasirinkite lyti";
                return;
            }
            if (addressField.Text.Equals(""))
            {
                errorLabel.Text = "Iveskite adresa";
                return;
            }
            if (phoneField.Text.Equals(""))
            {
                errorLabel.Text = "Iveskite telefono numeri";
                return;
            }
            CheckPersonalCode checkPersonalCode = new CheckPersonalCode();
            string lytis = null;
            if (RadioButton1.Checked == true)
            {
                lytis = "Vyras";
            }
            else lytis = "Moteris";
            string code = asmensKodoFiels.Text.Replace(" ", string.Empty);
            string response = checkPersonalCode.checkCode(code,lytis);
            if (response=="Good")
            {

            }
            else
            {
                errorLabel.Text = response;
                return;
            }
            CheckPhoneNumber checkPhoneNumber = new CheckPhoneNumber();
            string phone = phoneField.Text.Replace(" ", string.Empty);
            string phoneResponse=checkPhoneNumber.checkNumber(phone);
            if (phoneResponse=="Good")
            {

            }
            else
            {
                errorLabel.Text = phoneResponse;
                return;
            }

            GetData getData = new GetData();
            List<string> studentCodes = getData.getStudentCodes();
            foreach(string c in studentCodes)
            {
                if (c==asmensKodoFiels.Text)
                {
                    errorLabel.Text = "Toks studentas jau egzistuoja sarasuose";
                    return;
                }
            }
            AddData addData = new AddData();
            addData.addStudent(nameField.Text, surnameField.Text, asmensKodoFiels.Text, lytis, addressField.Text, phoneField.Text, studijuField.SelectedItem.Text, formaField.SelectedItem.Text);
            errorLabel.Text = "Studentas pridetas prie sarasu";
        }
    }
}