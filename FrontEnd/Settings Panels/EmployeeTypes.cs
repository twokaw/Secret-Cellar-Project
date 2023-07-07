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
        private EmployeeTypeModel _selectedEmployeeTypes = null;
        
        
        public PanEmployeeTypes() {
            InitializeComponent();

			dataGridView_employeeTypes.Columns["Id"].Visible = false;

			if (DataAccess.instance != null) RefreshLists();
		}

        private void GetEmployeeRoles()
        {
            employeeRoles = DataAccess.instance.GetEmployeeRoles();
            try
            {
                chk_lstbx_Roles.DataSource = employeeRoles;
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message );
            }
        }


        private void cbx_empTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++)
                chk_lstbx_Roles.SetItemChecked(i, ((EmployeeTypeModel)cbx_empTypes.SelectedItem).Roles.Any(x => x.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID));

            txt_typeName.Text = cbx_empTypes.SelectedItem.ToString();
        }


        /// <summary>
        /// Update the role checkboxes on employee type select.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void dataGridView_employeeTypes_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView_employeeTypes.SelectedRows.Count == 0 || dataGridView_employeeTypes.SelectedRows[0].Cells.Count == 0) return;

            string selectedId = dataGridView_employeeTypes.SelectedRows[0].Cells["Id"].Value.ToString();
			_selectedEmployeeTypes = employeeTypes.Find((empType) => empType.TypeID == uint.Parse(selectedId));
			if (_selectedEmployeeTypes == null) return;

			for (int i=0; i<chk_lstbx_Roles.Items.Count; i++) {
				chk_lstbx_Roles.SetItemChecked(i, _selectedEmployeeTypes.Roles.Any(x => x.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID));
			}

			txt_typeName.Text = _selectedEmployeeTypes.TypeName;
		}


        /// <summary>
        /// Update the role description on checkbox select.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_lstbx_Roles_SelectedIndexChanged(object sender, EventArgs e) {
            txt_roleDescription.Text = ((EmployeeRoleModel)chk_lstbx_Roles.SelectedItem).RoleDescription;
        }


        /// <summary>
        /// Update the selected employee type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e) {
            if (_selectedEmployeeTypes == null) return;
            if (txt_typeName.Text == "") { MessageBox.Show("Cannot have an empty name.", "Error"); return; }

            bool x = false;
            
            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                x = _selectedEmployeeTypes.Roles.Any(y => y.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID);
                if (x != chk_lstbx_Roles.GetItemChecked(i)) {
                    if (x) {
                        _selectedEmployeeTypes.Roles.RemoveAll(y => y.RoleID == ((EmployeeRoleModel)chk_lstbx_Roles.Items[i]).RoleID);
                    }
                    else {
                        _selectedEmployeeTypes.Roles.Add((EmployeeRoleModel)chk_lstbx_Roles.Items[i]);
                    }
                }
            }

            _selectedEmployeeTypes.TypeName = txt_typeName.Text;

			DataAccess.instance.UpdateEmployeeType(_selectedEmployeeTypes);
            RefreshLists();
        }


        /// <summary>
        /// Clear the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e) {
            txt_typeName.Clear();

            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                chk_lstbx_Roles.SetItemCheckState(i, CheckState.Unchecked);
            }
            txt_typeName.Focus();
        }


        /// <summary>
        /// Create a new employee type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_new_Click(object sender, EventArgs e) {
			if (txt_typeName.Text == "") { MessageBox.Show("Cannot have an empty name.", "Error"); return; }

			EmployeeTypeModel emp = new EmployeeTypeModel() {
                TypeName = txt_typeName.Text
            };

            for (int i = 0; i < chk_lstbx_Roles.Items.Count; i++) {
                if (chk_lstbx_Roles.GetItemChecked(i)) {
                    emp.Roles.Add((EmployeeRoleModel)chk_lstbx_Roles.Items[i]);
                }
            }

            DataAccess.instance.InsertEmployeeType(emp);
            RefreshLists();
        }


        /// <summary>
        /// Delete the selected employee type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button_delete_Click(object sender, EventArgs e) {
			string selectedId = dataGridView_employeeTypes.SelectedRows[0].Cells["Id"].Value.ToString();
			EmployeeTypeModel selectedEmployeeTypeModel = employeeTypes.Find((empType) => empType.TypeID == uint.Parse(selectedId));
            if (selectedEmployeeTypeModel == null) return;

            DataAccess.instance.DeleteEmployeeType(selectedEmployeeTypeModel.TypeID);
            RefreshEmployeeTypes();
		}


		/// <summary>
		/// Refreshes the Employee Types.
		/// </summary>
		private void RefreshEmployeeTypes() {
			employeeTypes = DataAccess.instance.GetEmployeeTypes();
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
