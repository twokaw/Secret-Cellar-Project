using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;

namespace SecretCellar.Settings_Panels
{
    public partial class PanEmployeeTypes : ManagedPanel
    {
        private List<EmployeeTypeModel> employeeTypes = null;
        private List<EmployeeRoleModel> employeeRoles = null;
        
        
        public PanEmployeeTypes() {
            InitializeComponent();

			dataGridView_employeeTypes.Columns["Id"].Visible = false;

			if (DataAccess.instance != null) {
                RefreshEmployeeRoles();
                RefreshEmployeeTypes();
            }
        }


		private void dataGridView_employeeTypes_SelectionChanged(object sender, EventArgs e) {
            //TODO The UInt Parse fails because the values aren't correct.
            EmployeeTypeModel selectedEmployeeTypeModel = employeeTypes.Find((empType) => empType.TypeID == uint.Parse(dataGridView_employeeTypes.SelectedRows[0].Cells[0].Value.ToString()));
            if (selectedEmployeeTypeModel == null) return;

			for (int i=0; i<chk_lstbx_Roles.Items.Count; i++) {
				chk_lstbx_Roles.SetItemChecked(i, selectedEmployeeTypeModel.Roles.Any(x => x.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID));
			}

		}


		private void cbx_empTypes_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                chk_lstbx_Roles.SetItemChecked(i, ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Any(x => x.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID));
            }

            txt_typeName.Text = cbx_empTypes.SelectedItem.ToString();
        }


        private void chk_lstbx_Roles_SelectedIndexChanged(object sender, EventArgs e) {
            txt_roleDescription.Text = ((EmployeeRoleModel)chk_lstbx_Roles.SelectedItem).RoleDescription;
        }


        private void btn_update_Click(object sender, EventArgs e) {
            bool x = false;
            
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                x = ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Any(y => y.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID);
                if (x != chk_lstbx_Roles.GetItemChecked(i)) {
                    if (x) {
                        ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.RemoveAll(y => y.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID);
                    }
                    else {
                        ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Add((EmployeeRoleModel)chk_lstbx_Roles.Items[i]);
                    }
                }
            }
            DataAccess.instance.UpdateEmployeeType((EmployeeTypeModel)cbx_empTypes.SelectedItem);
            RefreshLists();
        }


        private void btn_clear_Click(object sender, EventArgs e) {
            txt_typeName.Clear();

            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                chk_lstbx_Roles.SetItemCheckState(i, CheckState.Unchecked);
            }
            txt_typeName.Focus();
        }


        private void btn_new_Click(object sender, EventArgs e) {
            EmployeeTypeModel emp = new EmployeeTypeModel();
            emp.TypeName = txt_typeName.Text;

            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                if (chk_lstbx_Roles.GetItemChecked(i)) {
                    emp.Roles.Add((EmployeeRoleModel)chk_lstbx_Roles.Items[i]);
                }
            }

            DataAccess.instance.InsertEmployeeType(emp);
            RefreshLists();
        }

        
		/// <summary>
		/// Refreshes the Employee Types.
		/// </summary>
		private void RefreshEmployeeTypes() {
			employeeTypes = DataAccess.instance.GetEmployeeTypes();
			cbx_empTypes.DataSource = employeeTypes;
			dataGridView_employeeTypes.DataSource = employeeTypes.Select((emp) => new {
				Id = emp.TypeID,
				Type = emp.TypeName
			}).ToList();
		}


		/// <summary>
		/// Refreshes the Employee Roles.
		/// </summary>
		private void RefreshEmployeeRoles() {
            employeeRoles = DataAccess.instance.GetEmployeeRoles();
            chk_lstbx_Roles.Items.Clear();
            chk_lstbx_Roles.Items.AddRange(employeeRoles.ToArray());
        }


		/// <summary>
		/// Refreshes both the employee roles and the employee types.
		/// </summary>
		public void RefreshLists() {
			RefreshEmployeeRoles();
			RefreshEmployeeTypes();
		}
	}
}
