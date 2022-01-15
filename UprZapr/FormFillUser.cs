using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UprZapr
{
    public partial class FormFillUser : Form
    {
        private Employee employee;
        public FormFillUser()
        {
            InitializeComponent();
        }

        public Employee getUser()
        {
            return employee;
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSurname.Text) || String.IsNullOrWhiteSpace(textBoxName.Text) || String.IsNullOrWhiteSpace(textBoxPatronymic.Text) || String.IsNullOrWhiteSpace(textBoxId.Text) || String.IsNullOrWhiteSpace(comboBoxRoles.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = 0;
            if (Int32.TryParse(textBoxId.Text, out id) && id > 0)
            {
                employee = new Employee(textBoxSurname.Text, textBoxName.Text, textBoxPatronymic.Text, dateTimeBitrh.Value, dateTimeEmp.Value, comboBoxRoles.Text, id);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите корректный идентификатор", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
