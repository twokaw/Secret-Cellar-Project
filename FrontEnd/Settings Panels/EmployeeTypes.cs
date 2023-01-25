using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar.Settings_Panels
{
    public partial class PanEmployeeTypes : ManagedPanel
    {
        private List<EmployeeTypeModel> employeeTypes = null;
        private List<EmployeeRoleModel> employeeRoles = null;
        public PanEmployeeTypes()
        {
            InitializeComponent();
            if (DataAccess.instance != null)
            {
                GetEmployeeRoles();
                GetEmployeeTypes();
            }

            
        }
            private void GetEmployeeTypes()
            {
                employeeTypes = DataAccess.instance.GetEmployeeTypes();
                cbx_empTypes.DataSource = employeeTypes;
            }

            private void GetEmployeeRoles()
            {
                employeeRoles = DataAccess.instance.GetEmployeeRoles();
                chk_lstbx_Roles.DataSource = employeeRoles;
            }

        private void cbx_empTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++)
            {
                chk_lstbx_Roles.SetItemChecked(i, ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Any(x => x.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID));
            }
            txt_typeName.Text = cbx_empTypes.SelectedItem.ToString();
        }

        private void chk_lstbx_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_roleDescription.Text = ((EmployeeRoleModel)chk_lstbx_Roles.SelectedItem).RoleDescription;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bool x = false;
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++)
            {
                x = ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Any(y => y.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID);
                if(x != chk_lstbx_Roles.GetItemChecked(i))
                {
                    if(x)
                    {
                        ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.RemoveAll(y => y.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID);
                    }
                    else
                    {
                        ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Add((EmployeeRoleModel)chk_lstbx_Roles.Items[i]);
                    }
                }
            }
            DataAccess.instance.UpdateEmployeeType((EmployeeTypeModel)cbx_empTypes.SelectedItem);
            empRefresh();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_typeName.Clear();
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++)
            {
                chk_lstbx_Roles.SetItemCheckState(i, CheckState.Unchecked);
            }
            txt_typeName.Focus();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EmployeeTypeModel emp = new EmployeeTypeModel();
            emp.TypeName = txt_typeName.Text;

            
                for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++)
                {
                    
                    if ( chk_lstbx_Roles.GetItemChecked(i))
                    {
                            emp.Roles.Add((EmployeeRoleModel)chk_lstbx_Roles.Items[i]);
                    }

                }
            DataAccess.instance.InsertEmployeeType(emp);
            empRefresh();
        }

        public void empRefresh()
        {
            GetEmployeeRoles();
            GetEmployeeTypes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_emp_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_typeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
