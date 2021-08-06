using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace SecretCellar.Orders_Panels {
	public partial class Panel_History : UserControl {
        private string searchForCustomerText = "Search for customer";



        public Panel_History() {
			InitializeComponent();

            lstbox_customer.DataSource = DataAccess.instance?.GetCustomer();
            lstbox_customer.DisplayMember = "FullName";
        }


        /////////////////////////////////////////////////////////////
        //REMOVE THE PLACEHOLDER TEXT WHEN CLICKING INTO THE TEXT BOX
        /////////////////////////////////////////////////////////////
        private void textBox_CustomerName_Enter(object sender, EventArgs e) {
            if (textBox_CustomerName.Text == searchForCustomerText) {
                textBox_CustomerName.Text = "";
            }
        }


        /////////////////////////////////////////////////////
        //RESET THE PLACEHOLDER TEXT IF THE TEXT BOX IS EMPTY
        /////////////////////////////////////////////////////
        private void textBox_CustomerName_History_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_CustomerName.Text)) {
                textBox_CustomerName.Text = searchForCustomerText;

                lstbox_customer.DataSource = DataAccess.instance.GetCustomer(true);
            }
        }


        ////////////////
        //ON TEXT CHANGE
        ////////////////
        private void textBox_CustomerName_TextChanged(object sender, EventArgs e) {
			lstbox_customer.DataSource = DataAccess.instance.GetCustomer(textBox_CustomerName.Text, true);
			/*Select(x => new {
                customerID = x.CustomerID,
                cust_name = $"{x.LastName}, {x.FirstName}"
            }).
              ToList();*/
		}



	}
}
