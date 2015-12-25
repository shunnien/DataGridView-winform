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

        /// <summary>
        /// DataGridView the initialize.
        /// </summary>
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
            gvGender.DataSource = cbData.Select(q => q).ToList();
            gvGender.DisplayMember = "Display";
            gvGender.ValueMember = "Value";
            gvSample.DataSource = dt;
            gvSample.EditMode = DataGridViewEditMode.EditOnEnter;
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
                    listDes.Add(new ComboData("Select...", 0));
                    listDes.Add(new ComboData("Handsome", 1));
                    listDes.Add(new ComboData("Nuttiness", 2));
                    listDes.Add(new ComboData("Polite", 3));
                    listDes.Add(new ComboData("Burly", 4));
                    break;
                case "Female":
                    listDes.Add(new ComboData("Select...", 0));
                    listDes.Add(new ComboData("Beautiful", 1));
                    listDes.Add(new ComboData("Sexy", 2));
                    listDes.Add(new ComboData("Cute", 3));
                    break;
                default:
                    listDes.Add(new ComboData("Select...", 0));
                    listDes.Add(new ComboData("Handsome", 1));
                    listDes.Add(new ComboData("Nuttiness", 2));
                    listDes.Add(new ComboData("Polite", 3));
                    listDes.Add(new ComboData("Burly", 4));
                    listDes.Add(new ComboData("Beautiful", 5));
                    listDes.Add(new ComboData("Sexy", 6));
                    listDes.Add(new ComboData("Cute", 7));
                    break;
            }
            if (sender.GetType().Name == "DataGridViewComboBoxCell") {
                var cb = (DataGridViewComboBoxCell)sender;
                if (!listDes.Any(q => q.Value == (int)cb.Value)) {
                    cb.Value = 0;
                }
            }
            sender.DataSource = listDes;
        }

        private void button1_Click(object sender, EventArgs e) {
            DataRow dr = dt.NewRow();
            dr["Name"] = txtName.Text.Trim();
            dr["Gender"] = cbGender.SelectedValue;
            dr["Married"] = ckMarried.Checked ? 1 : 0;
            dr["Birthday"] = dtpBirthday.Value;
            dr["Des"] = cbDes.SelectedValue;
            dt.Rows.Add(dr);
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e) {
            cbDesBind(cbDes, (sender as ComboBox).Text);
        }

        private void gvSample_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            // 判斷觸發事件的欄位是 Gender 才進行以下動作
            if (((DataGridView)sender).Columns[((DataGridView)sender).CurrentCell.ColumnIndex].Name == "gvGender") {
                ComboBox cb = e.Control as ComboBox;
                if (cb != null) {
                    // 增加事件
                    cb.SelectionChangeCommitted += new EventHandler(cb_SelectedIndexChanged);
                }
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e) {
            // 取得現在欄位索引
            int columnIndex = gvSample.CurrentCell.ColumnIndex;
            // 將控制項轉給 ComboBox
            ComboBox cbx = sender as ComboBox;
            // 判斷現在選取的 Column 是 Gender
            if (gvSample.Columns[columnIndex].Name == "gvGender") {
                string selTxt = cbx.Text,
                selVal = cbx.SelectedValue.ToString();
                // 當選取項目值和顯示文字任一為空，就不進行動作
                if (string.IsNullOrEmpty(selTxt) || string.IsNullOrEmpty(selVal)) return;
                // 將此列資料的 Des Cell　取出
                // 其 DataType 為 DataGridViewCell 
                // 將其強制轉換為 DataGridViewComboBoxCell
                var targetCbx = gvSample.CurrentRow.Cells["gvDes"] as DataGridViewComboBoxCell;
                // 綁定資料
                cbDesBind(targetCbx, selTxt);
            }
        }

        private void gvSample_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            // DataGridViewComboBoxCell gvDes dynamic databinding
            var dgv = sender as DataGridView;
            if (dgv.Rows.Count > 0 && dgv.Columns.Count > 5) {
                foreach (var dgvr in dgv.Rows) {
                    var targetCell = ((DataGridViewRow)dgvr).Cells["gvDes"] as DataGridViewComboBoxCell;
                    var genderCell = ((DataGridViewRow)dgvr).Cells["gvGender"] as DataGridViewComboBoxCell;
                    if (targetCell == null) continue;
                    cbDesBind(targetCell, genderCell.FormattedValue.ToString());
                }
            }
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
