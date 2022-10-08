using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.CodeDom;

namespace CrudApiWinForm
{
    public partial class UserCrudFrm : Form
    {
        public UserCrudFrm()
        {
            InitializeComponent();
        }

        private async void GetAllData_Click(object sender, EventArgs e)
        {
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://localhost:7043/");
            HttpResponseMessage response = clint.GetAsync("api/user").Result;
            var emp = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
            dataGridView1.DataSource = emp;
        }

        private void SearchById_Click(object sender, EventArgs e)
        {
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://localhost:7043/");
            HttpResponseMessage response = clint.GetAsync("api/user/"+txtId.Text).Result;
            Employee emp = response.Content.ReadAsAsync<Employee>().Result;
            List<Employee> empList = new List<Employee>();
            empList.Add(emp);               
            dataGridView1.DataSource = empList;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee() { Ad = txtName.Text, Soyad = txtSurname.Text };
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://localhost:7043/");
            HttpResponseMessage response = clint.PostAsJsonAsync("api/user/" ,emp).Result;
            MessageBox.Show("Eklendi");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://localhost:7043/");
            HttpResponseMessage response = clint.DeleteAsync("api/user/" + txtId.Text).Result;
            MessageBox.Show("Silindi");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee() { Id = Convert.ToInt32(txtId.Text), Ad = txtName.Text, Soyad = txtSurname.Text };
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://localhost:7043/");
            HttpResponseMessage response = clint.PutAsJsonAsync("api/user" , emp).Result;
            MessageBox.Show("Güncellendi");
        }
    }
}
