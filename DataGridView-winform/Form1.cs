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
                table.Columns.Add("Gender", typeof(string));
                table.Columns.Add("Married", typeof(int));
                table.Columns.Add("Birthday", typeof(DateTime));

                // Add rows.
                table.Rows.Add("Allen", "1", 0, DateTime.Now);
                table.Rows.Add("Kevin", "1", 1, DateTime.Now);
                table.Rows.Add("Dean", "1", 0, DateTime.Today);
                table.Rows.Add("Jenny", "0", 1, DateTime.Today);
                return table;
            }
        }

        public DataTable dt;
        public List<ComboData> cbData = new List<ComboData>() {
                new ComboData("Male", "1"),
                new ComboData("Female", "0")
            };
        public Form1() {
            InitializeComponent();
            cbGender.DataSource = cbData;
            cbGender.DisplayMember = "Display";
            cbGender.ValueMember = "Value";

            dt = dt ?? sampleData();
            gvInit();
        }

        private void gvInit() {
            gvGender.Items.Clear();

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

        private void button1_Click(object sender, EventArgs e) {
            DataRow dr = dt.NewRow();
            dr["Name"] = txtName.Text.Trim();
            dr["Gender"] = cbGender.SelectedValue;
            dr["Married"] = ckMarried.Checked ? 1 : 0;
            dr["Birthday"] = dtpBirthday.Value;
            dt.Rows.Add(dr);
        }
    }

    /// <summary>
    /// comboBox Items
    /// </summary>
    public class ComboData {
        public ComboData(string text, string value) {
            Display = text;
            Value = value;
        }
        public string Display { get; set; }
        public string Value { get; set; }
    }
}
