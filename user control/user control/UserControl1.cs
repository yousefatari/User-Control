using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_control
{
    public partial class ucstate : UserControl
    {
        public ucstate()
        {
            InitializeComponent();
        }

        public states SelectedState

        {
            get
            {
                return(states)cbxstate.SelectedItem;
            }
        }




        private void ucstate_Load(object sender, EventArgs e)
        {
            List<states> list = new List<states>();

            list.Add(new states() { ID = 1, Name = "Delhi" });
            list.Add(new states() { ID = 2, Name = "Amman" });
            list.Add(new states() { ID = 3, Name = "New york" });
            list.Add(new states() { ID = 4, Name = "dubai" });
            
            cbxstate.DataSource = list;
            cbxstate.ValueMember = "ID";
            cbxstate.DisplayMember = "Name";





        }

        private void btngetstate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
