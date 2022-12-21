using System;
using System.Windows.Forms;
using Shared;


namespace SecretCellar {
    public partial class frmManagerOverride : ManagedForm {
        public frmManagerOverride(string title) {
            InitializeComponent();
            Text = title;
        }



        /// <summary>
        /// If the current user is an admin then it returns true, otherwise creates a new frmManagerOverride and shows the form. 
        /// If the result equals OK then it returns true, otherwise it returns false.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool DidOverride(string title) {
            if (DataAccess.currentUser.EmployeeType.TypeName == "admin") return true;

            frmManagerOverride managerOverride = new frmManagerOverride(title);
            return managerOverride.ShowDialog() == DialogResult.OK;
        }


        /// <summary>
        /// Cancels the manager override.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e) { Close(); }


        /// <summary>
        /// Checks that the entered manager id is correct and closes the form with a dialogResult of OK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Confirm_Click(object sender, EventArgs e) {
            if (int.TryParse(textBox_ManagerPassword.Text, out int pin)) {
                EmployeeModel employee = DataAccess.instance.GetEmployee().Find(emp => { return emp.PinNumber == pin; });
                
                if (employee == null || employee.EmployeeType.TypeName != "admin") {
                    MessageBox.Show("Employee is not an admin.", "Error");
                    textBox_ManagerPassword.Text = "";
                    textBox_ManagerPassword.Focus();
                    return;
                }
                
                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("Entered id is not in the correct format.", "Error");
                textBox_ManagerPassword.Text = "";
                textBox_ManagerPassword.Focus();
            }
        }

        private void frmManagerOverride_Load(object sender, EventArgs e) {

        }
    }
}
