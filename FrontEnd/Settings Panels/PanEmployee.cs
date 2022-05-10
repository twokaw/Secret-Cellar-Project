using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanEmployee : UserControl
    {
        private List<EmployeeTypeModel> employeeTypes = null;
        public PanEmployee()
        {
            InitializeComponent();
            PopulateEmp();
            GetEmployeeTypes();
            //types = DataAccess.instance.EmployeeType();
        }
       

        private void PopulateEmp() => lst_employee.DataSource = DataAccess.instance.GetEmployee();
        private void GetEmployeeTypes()
        {
            cbc_types.DataSource = DataAccess.instance.GetEmployeeTypes();
        }

        private void lst_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_empID.Text = ((EmployeeModel)lst_employee.SelectedItem).EmpID.ToString();
            txt_fname.Text = ((EmployeeModel)lst_employee.SelectedItem).FirstName;
            txt_lname.Text = ((EmployeeModel)lst_employee.SelectedItem).LastName;
            txt_address1.Text = ((EmployeeModel)lst_employee.SelectedItem).Address1;
            txt_address2.Text = ((EmployeeModel)lst_employee.SelectedItem).Address2;
            txt_city.Text = ((EmployeeModel)lst_employee.SelectedItem).City;
            txt_state.Text = ((EmployeeModel)lst_employee.SelectedItem).State;
            txt_zipcode.Text = ((EmployeeModel)lst_employee.SelectedItem).ZipCode;
            txt_phone.Text = ((EmployeeModel)lst_employee.SelectedItem).PhoneNumber;
            txt_startdate.Text = ((EmployeeModel)lst_employee.SelectedItem).StartDate.ToString();
            txt_enddate.Text = ((EmployeeModel)lst_employee.SelectedItem).EndDate.ToString();
            cbc_types.Text = ((EmployeeModel)lst_employee.SelectedItem).EmployeeType.ToString();

        }
    }
}
