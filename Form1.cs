using System.Text.Json;

namespace _10._1_Serialization
{
    public partial class Form1 : Form
    {
        Customer customer;
        string json = @"C:\MSSA\20483\Files\10-1json.txt";
        string xml = @"C:\MSSA\20483\Files\10-1xml.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.Id = int.Parse(txtId.Text);
            customer.FirstName = txtFname.Text;
            customer.LastName = txtLname.Text;
            customer.Membership = txtMembership.Text;
            MessageBox.Show("Employee object created.");
        }

        private void btnJSONSerialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(json))
            {
                File.Delete(json);
            }
            FileStream jsonStream = new FileStream(json, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonStream, customer);
            MessageBox.Show("Object serialized.");
            jsonStream.Close();
        }

        private void btnJSONDeserialize_Click(object sender, EventArgs e)
        {
            FileStream jsonStream = new FileStream(json, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<Customer>(jsonStream);
            MessageBox.Show($"Customer Info: First Name: {obj?.FirstName}, LastName: {obj?.LastName}, Membership: {obj?.Membership}");
            jsonStream.Close();
        }
    }
}
