using System.Text.Json;
using System.Xml.Serialization;

namespace _10._1_Serialization
{
    public partial class Form1 : Form
    {
        Customer customer;
        string json = @"C:\MSSA\20483\Files\10-1json.txt";
        string xml = @"C:\MSSA\20483\Files\10-1xml.xml";
        List<Customer> customerList = new List<Customer>();
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
            JsonSerializer.Serialize(jsonStream, customerList);
            MessageBox.Show("Object serialized (JSON).");
            jsonStream.Close();
        }

        private void btnJSONDeserialize_Click(object sender, EventArgs e)
        {
            FileStream jsonStream = new FileStream(json, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<List<Customer>>(jsonStream);

            foreach (var cust in customerList)
            {
                MessageBox.Show($"Customer Info:\nFirst Name: {cust?.FirstName}\nLastName: {cust?.LastName}\nMembership: {cust?.Membership}");
            }
            jsonStream.Close();
        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(xml))
            {
                File.Delete(xml);
            }
            FileStream xmlStream = new FileStream(xml, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Customer));
            xmlSerializer.Serialize(xmlStream, customerList);
            MessageBox.Show("Object serialized (XML).");
            xmlStream.Close();
        }

        private void btnXMLDeserialize_Click(object sender, EventArgs e)
        {
            FileStream xmlStream = new FileStream(xml, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Customer));
            var obj = (Customer)xmlSerializer.Deserialize(xmlStream);
            MessageBox.Show($"Customer Info:\nFirst Name: {obj?.FirstName}\nLastName: {obj?.LastName}\nMembership: {obj?.Membership}");
            xmlStream.Close();
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.Id = int.Parse(txtId.Text);
            customer.FirstName = txtFname.Text;
            customer.LastName = txtLname.Text;
            customer.Membership = txtMembership.Text;
            customerList.Add(customer);
            MessageBox.Show("Employee object created and added to the list.");
        }
    }
}
