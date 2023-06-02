using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanEmployee : ManagedPanel {
        private List<EmployeeTypeModel> employeeTypes = null;
        private List<EmployeeRoleModel> employeeRoles = null;
        public PanEmployee()
        {
            InitializeComponent();
            if (DataAccess.instance != null)
            {
                GetEmployeeTypes();
                GetEmployeeRoles();
                PopulateEmp();
                EndButtonText();
            }
        }

        /// <summary>
        /// Enables/Disables the buttons based on the given boolean.
        /// </summary>
        /// <param name="shouldButtonsBeEnabled"></param>
        public void HandleToggleButtons(bool shouldButtonsBeEnabled) {
            btn_clear.Enabled = shouldButtonsBeEnabled;
            btn_add.Enabled = shouldButtonsBeEnabled;
            btn_update.Enabled = shouldButtonsBeEnabled;
            btn_end.Enabled = shouldButtonsBeEnabled;
            cbx_types.Enabled = shouldButtonsBeEnabled;
            txt_Login.Visible = shouldButtonsBeEnabled;
            lbl_Login.Visible = shouldButtonsBeEnabled;
        }

        private void PopulateEmp()
        {
            if (chk_box_past_emp.Checked)
                lst_employee.DataSource = DataAccess.instance.GetEmployee().Where(x => x.EndDate != null).ToList();
            else 
                lst_employee.DataSource = DataAccess.instance.GetEmployee().Where(x => x.EndDate == null).ToList();
        } 

        private void GetEmployeeTypes()
        {
            employeeTypes = DataAccess.instance.GetEmployeeTypes();
            cbx_types.DataSource = employeeTypes;
        }

        private void GetEmployeeRoles()
        {
            employeeRoles = DataAccess.instance.GetEmployeeRoles();
            lstbx_roles.DataSource = employeeRoles;
        }

        private void EndButtonText() =>
            btn_end.Text = (chk_box_past_emp.CheckState == CheckState.Unchecked) ? "Disabled" : "Enable";
        
        private void lst_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Login.Text = ((EmployeeModel)lst_employee.SelectedItem).UserName;
            txt_fname.Text = ((EmployeeModel)lst_employee.SelectedItem).FirstName;
            txt_lname.Text = ((EmployeeModel)lst_employee.SelectedItem).LastName;
            txt_address1.Text = ((EmployeeModel)lst_employee.SelectedItem).Address1;
            txt_address2.Text = ((EmployeeModel)lst_employee.SelectedItem).Address2;
            txt_city.Text = ((EmployeeModel)lst_employee.SelectedItem).City;
            txt_state.Text = ((EmployeeModel)lst_employee.SelectedItem).State;
            txt_zipcode.Text = ((EmployeeModel)lst_employee.SelectedItem).ZipCode;
            txt_phone.Text = ((EmployeeModel)lst_employee.SelectedItem).PhoneNumber;
            txt_email.Text = ((EmployeeModel)lst_employee.SelectedItem).Email;
            txt_startdate.Text = ((EmployeeModel)lst_employee.SelectedItem).StartDate.ToString("MM/dd/yyyy");
            txt_enddate.Text = ((EmployeeModel)lst_employee.SelectedItem).EndDate?.ToString("MM/dd/yyyy");
            btn_end.Text = ((EmployeeModel)lst_employee.SelectedItem).EndDate == null?"Disabled":"Enabled";
            cbx_types.SelectedItem = employeeTypes.FirstOrDefault(x => x.TypeID == ((EmployeeModel)lst_employee.SelectedItem).EmployeeType.TypeID);

            for (int i = 0; i < lstbx_roles.Items.Count; i++)
                lstbx_roles.SetItemChecked(i, ((EmployeeModel)lst_employee.SelectedItem).EmployeeType.Roles.Any(x => x.RoleID == ((EmployeeRoleModel)lstbx_roles.Items[i]).RoleID ));
        }

        private void cbx_typesSelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstbx_roles.Items.Count; i++)
                lstbx_roles.SetItemChecked(i, ((EmployeeTypeModel)cbx_types.SelectedItem).Roles.Any(x => x.RoleID == ((EmployeeRoleModel)lstbx_roles.Items[i]).RoleID));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            EmployeeModel newEmp = new EmployeeModel();
            if (string.IsNullOrEmpty(txt_fname.Text))
            {
                txt_fname.Focus();
                txt_fname.SelectAll();
                MessageBox.Show("First Name Can Not Be Left Blank");
                return;
            }
            else
                newEmp.FirstName = txt_fname.Text;

            if (string.IsNullOrEmpty(txt_lname.Text))
            {
                txt_lname.Focus();
                txt_lname.SelectAll();
                MessageBox.Show("Last Name Can Not Be Left Blank");
                return;
            }
            else
                newEmp.LastName = txt_lname.Text;

            if(string.IsNullOrWhiteSpace (txt_Login.Text))
                txt_Login.Text = (txt_lname.Text.Trim(), txt_fname.Text.Trim()).ToString();

            txt_Login.Text = txt_Login.Text.Trim(); 

            if (!CheckUserName(txt_Login.Text))
            {
                txt_Login.Focus();
                txt_Login.SelectAll();
                MessageBox.Show("Login is already in use.  Enter a new Login");
                return;
            }

            newEmp.Address1 = txt_address1.Text;
            newEmp.Address2 = txt_address2.Text;
            newEmp.City = txt_city.Text;
            newEmp.State = txt_state.Text;
            newEmp.ZipCode= txt_zipcode.Text;
            newEmp.PhoneNumber = txt_phone.Text;
            newEmp.Email = txt_email.Text;
            newEmp.PinNumber = 123;
            newEmp.StartDate = (DateTime.TryParse(txt_startdate.Text, out DateTime startdate) ?startdate : DateTime.Now);
            newEmp.EmployeeType = (EmployeeTypeModel)cbx_types.SelectedItem;

            DataAccess.instance.InsertEmployee(newEmp);
            PopulateEmp();
        }

        private bool CheckUserName(string userName, uint currentId = 0)
        {
            EmployeeModel emp = DataAccess.instance.GetEmployee(userName);
            
            return null == emp || emp.EmpID == currentId;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            EmployeeModel updateEmp = (EmployeeModel)lst_employee.SelectedItem;
            updateEmp.UserName = txt_Login.Text;

            if (!CheckUserName(txt_Login.Text, updateEmp.EmpID))
            {
                txt_Login.Focus();
                txt_Login.SelectAll();
                MessageBox.Show("Login is already in use.  Enter a new Login");
                return;
            }

            if (string.IsNullOrEmpty(txt_fname.Text))
            {
                txt_fname.Focus();
                txt_fname.SelectAll();
                MessageBox.Show("First Name Can Not Be Left Blank");
                return;
            }
            else
                updateEmp.FirstName = txt_fname.Text;

            if (string.IsNullOrEmpty(txt_lname.Text))
            {
                txt_lname.Focus();
                txt_lname.SelectAll();
                MessageBox.Show("Last Name Can Not Be Left Blank");
                return;
            }
            else
                updateEmp.LastName = txt_lname.Text;

            updateEmp.Address1 = txt_address1.Text;
            updateEmp.Address2 = txt_address2.Text;
            updateEmp.City = txt_city.Text;
            updateEmp.State = txt_state.Text;
            updateEmp.ZipCode = txt_zipcode.Text;
            updateEmp.Email = txt_email.Text;
            updateEmp.EmployeeType = (EmployeeTypeModel)cbx_types.SelectedItem;
            
            DataAccess.instance.UpdateEmployee(updateEmp);
            PopulateEmp();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            EmployeeModel Emp = (EmployeeModel)lst_employee.SelectedItem;
         
            Emp.EndDate = btn_end.Text != "Enable" ? (DateTime?)DateTime.Now : null;

            DataAccess.instance.UpdateEmployee(Emp);
            PopulateEmp();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Login.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_address1.Text = "";
            txt_address2.Text = "";
            txt_city.Text = "";
            txt_state.Text = "";
            txt_zipcode.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_startdate.Text = "";
            txt_fname.Focus();
        }

        private void chk_box_past_emp_CheckedChanged(object sender, EventArgs e)
        {
            PopulateEmp();
            EndButtonText();
        }
    }
}
