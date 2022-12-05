namespace user_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("state ={0} ,name {1}", ucstate1.SelectedState.ID, ucstate1.SelectedState.Name), "message", MessageBoxButtons.OK);
        }
    }
}