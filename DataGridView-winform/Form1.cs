using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_winform {
    public partial class Form1 : Form {

        private DataTable sampleData() {
            using (DataTable table = new DataTable()) {
                // Add columns.
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Gender", typeof(int));
                table.Columns.Add("Married", typeof(int));
                table.Columns.Add("Birthday", typeof(DateTime));
                table.Columns.Add("Des", typeof(int));

                // Add rows.
                table.Rows.Add("Allen", 1, 0, DateTime.Now, 1);
                table.Rows.Add("Kevin", 1, 1, DateTime.Now, 2);
                table.Rows.Add("Dean", 1, 0, DateTime.Today, 3);
                table.Rows.Add("Jenny", 0, 1, DateTime.Today, 1);
                return table;
            }
        }

        public DataTable dt;
        public List<ComboData> cbData = new List<ComboData>() {
                new ComboData("Male", 1),
                new ComboData("Female", 0)
            };
        public Form1() {
            InitializeComponent();
            cbGender.DataSource = cbData;
            cbGender.DisplayMember = "Display";
            cbGender.ValueMember = "Value";
            cbDes.DisplayMember = "Display";
            cbDes.ValueMember = "Value";
            cbDesBind(cbDes, "Male");
            dt = dt ?? sampleData();
            gvInit();
        }

        private void gvInit() {
            gvGender.Items.Clear();
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn() {
                Name = "gvDes",
                DataPropertyName = "Des",
                HeaderText = "Des",
                DisplayMember = "Display",
                ValueMember = "Value"
            };
            cbDesBind(cb, "");
            gvSample.Columns.Add(cb);
            gvGender.DataSource = cbData;
            gvGender.DisplayMember = "Display";
            gvGender.ValueMember = "Value";
            gvSample.DataSource = dt;
        }

        private void gvSample_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            // 指定第 0 列，刪除按鈕的所在列
            if (e.ColumnIndex == 0) {
                (sender as DataGridView).Rows.RemoveAt(e.RowIndex);
            }
        }

        /// <summary>
        /// comboBox cbDesc datasource bind.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="selVal">The sel value.</param>
        private void cbDesBind(dynamic sender, string selVal) {
            List<ComboData> listDes = new List<ComboData>();
            switch (selVal.Trim()) {
                case "Male":
                    listDes.Add(new ComboData("Handsome", 1));
                    listDes.Add(new ComboData("Nuttiness", 2));
                    listDes.Add(new ComboData("Polite", 3));
                    listDes.Add(new ComboData("Burly", 4));
                    break;
                case "Female":
                    listDes.Add(new ComboData("Beautiful", 1));
                    listDes.Add(new ComboData("Sexy", 2));
                    listDes.Add(new ComboData("Cute", 3));
                    break;
                default:
                    listDes.Add(new ComboData("Handsome", 1));
                    listDes.Add(new ComboData("Nuttiness", 2));
                    listDes.Add(new ComboData("Polite", 3));
                    listDes.Add(new ComboData("Burly", 4));
                    listDes.Add(new ComboData("Beautiful", 5));
                    listDes.Add(new ComboData("Sexy", 6));
                    listDes.Add(new ComboData("Cute", 7));
                    break;
            }
            sender.DataSource = listDes;
        }

        private void button1_Click(object sender, EventArgs e) {
            DataRow dr = dt.NewRow();
            dr["Name"] = txtName.Text.Trim();
            dr["Gender"] = cbGender.SelectedValue;
            dr["Married"] = ckMarried.Checked ? 1 : 0;
            dr["Birthday"] = dtpBirthday.Value;
            dt.Rows.Add(dr);
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e) {
            cbDesBind(cbDes, (sender as ComboBox).Text);
        }
    }

    /// <summary>
    /// comboBox Items
    /// </summary>
    public class ComboData {
        public ComboData(string text, int value) {
            Display = text;
            Value = value;
        }
        public string Display { get; set; }
        public int Value { get; set; }
    }
}
