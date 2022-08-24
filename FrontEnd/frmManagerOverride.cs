using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace SecretCellar {
    public partial class frmManagerOverride : Form {
        public frmManagerOverride() { InitializeComponent(); }
        

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
            Console.WriteLine(label_ManagerPassword.Text);



        }
    }
}
