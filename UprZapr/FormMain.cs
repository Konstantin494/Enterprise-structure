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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //проверка есть ли потомки, поиск по списках объекта в предприятии и удаление
            }
        }

        private void enterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                MessageBox.Show("Предприятие может быть только одно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormFillStruct formDialog = new FormFillStruct("Введите наименование предприятия");
            if (formDialog.ShowDialog() == DialogResult.OK)
            {
                string name = formDialog.getValue();
                Enterprise enterprise = new Enterprise(name);
                TreeNode node = treeView1.Nodes.Add(name);
                node.Tag = enterprise;
            }
        }

        private void departToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is Enterprise)
            {
                FormFillStruct formDialog = new FormFillStruct("Введите наименование цеха/отдела");
                if (formDialog.ShowDialog() == DialogResult.OK)
                {
                    string name = formDialog.getValue();
                    if (treeView1.Nodes.ContainsKey(name))
                    {
                        MessageBox.Show("Цех/отдел с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Departament departament = new Departament(name);
                    ((Enterprise)treeView1.SelectedNode.Tag).Departaments.Add(departament);
                    TreeNode node = treeView1.SelectedNode.Nodes.Add(name);
                    node.Tag = departament;
                }
            }
            else
            {
                MessageBox.Show("Выберите предприятие к которому добавляете", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is Departament)
            {
                FormFillStruct formStruct = new FormFillStruct("Введите наименование участка/бюро");
                if (formStruct.ShowDialog() == DialogResult.OK)
                {
                    string name = formStruct.getValue();
                    if (treeView1.Nodes.ContainsKey(name))
                    {
                        MessageBox.Show("Участок/бюро с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Sector sector = new Sector(name);
                    ((Departament)treeView1.SelectedNode.Tag).Sectors.Add(sector);
                    TreeNode node = treeView1.SelectedNode.Nodes.Add(name);
                    node.Tag = sector;
                }
            }
            else
            {
                MessageBox.Show("Выберите цех/отдел к которому добавляете", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sotrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                FormFillUser formUser = new FormFillUser();
                if (formUser.ShowDialog() == DialogResult.OK)
                {
                    Employee sotr = formUser.getUser();
                    if (treeView1.Nodes.ContainsKey(sotr.Id.ToString()))
                    {
                        MessageBox.Show("Сотрудник с таким идентификатором уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (treeView1.SelectedNode.Tag is Enterprise)
                    {
                        Enterprise enterprise = treeView1.SelectedNode.Tag as Enterprise;
                        enterprise.Employees.Add(sotr);
                    }
                    if (treeView1.SelectedNode.Tag is Departament)
                    {
                        Departament departament = treeView1.SelectedNode.Tag as Departament;
                        departament.Employees.Add(sotr);
                    }
                    if (treeView1.SelectedNode.Tag is Sector)
                    {
                        Sector sector = treeView1.SelectedNode.Tag as Sector;
                        sector.Employees.Add(sotr); ;
                    }
                    TreeNode node = treeView1.SelectedNode.Nodes.Add(sotr.Id.ToString(), sotr.GetSurnameAndFirstLettersOfNameAndPatronymic());
                    node.Tag = sotr;
                }
            }
            else
            {
                MessageBox.Show("Выберите подразделение к которому добавляете", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
