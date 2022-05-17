using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class Person_Viewer : Form
    {
        private IContainer components;
        private DataGridView dataGridView1;
        private ShopEasy_DBDataSet ShopEasy_DBDataSet;
        private BindingSource personBindingSource;
        private DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rewardPointsDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isTeacherDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isSeniorDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isVeteranDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private ShopEasy_DBDataSetTableAdapters.PersonTableAdapter personTableAdapter;

        public Person_Viewer()
        {
            InitializeComponent();
        }

        private void Person_Viewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.ShopEasy_DBDataSet.Person);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTeacherDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSeniorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isVeteranDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopEasy_DBDataSet = new ShopEasy.ShopEasy_DBDataSet();
            this.personTableAdapter = new ShopEasy.ShopEasy_DBDataSetTableAdapters.PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.rewardPointsDataGridViewTextBoxColumn,
            this.isTeacherDataGridViewCheckBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn,
            this.isSeniorDataGridViewCheckBoxColumn,
            this.isVeteranDataGridViewCheckBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // rewardPointsDataGridViewTextBoxColumn
            // 
            this.rewardPointsDataGridViewTextBoxColumn.DataPropertyName = "Reward Points";
            this.rewardPointsDataGridViewTextBoxColumn.HeaderText = "Reward Points";
            this.rewardPointsDataGridViewTextBoxColumn.Name = "rewardPointsDataGridViewTextBoxColumn";
            // 
            // isTeacherDataGridViewCheckBoxColumn
            // 
            this.isTeacherDataGridViewCheckBoxColumn.DataPropertyName = "Is_Teacher";
            this.isTeacherDataGridViewCheckBoxColumn.HeaderText = "Is_Teacher";
            this.isTeacherDataGridViewCheckBoxColumn.Name = "isTeacherDataGridViewCheckBoxColumn";
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "Is_Admin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "Is_Admin";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            // 
            // isSeniorDataGridViewCheckBoxColumn
            // 
            this.isSeniorDataGridViewCheckBoxColumn.DataPropertyName = "Is_Senior";
            this.isSeniorDataGridViewCheckBoxColumn.HeaderText = "Is_Senior";
            this.isSeniorDataGridViewCheckBoxColumn.Name = "isSeniorDataGridViewCheckBoxColumn";
            // 
            // isVeteranDataGridViewCheckBoxColumn
            // 
            this.isVeteranDataGridViewCheckBoxColumn.DataPropertyName = "Is_Veteran";
            this.isVeteranDataGridViewCheckBoxColumn.HeaderText = "Is_Veteran";
            this.isVeteranDataGridViewCheckBoxColumn.Name = "isVeteranDataGridViewCheckBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.ShopEasy_DBDataSet;
            // 
            // ShopEasy_DBDataSet
            // 
            this.ShopEasy_DBDataSet.DataSetName = "ShopEasy_DBDataSet";
            this.ShopEasy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Person_Viewer
            // 
            this.ClientSize = new System.Drawing.Size(1173, 516);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Person_Viewer";
            this.Load += new System.EventHandler(this.Person_Viewer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private void Person_Viewer_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.ShopEasy_DBDataSet.Person);
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet1.Person' table. You can move, or remove it, as needed.
          //  this.personTableAdapter.Fill(this.ShopEasy_DBDataSet1.Person);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
