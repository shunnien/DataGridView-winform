namespace DataGridView_winform {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.ckMarried = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gvSample = new System.Windows.Forms.DataGridView();
            this.gvbtnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gvMarried = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 22);
            this.txtName.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(120, 50);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(138, 20);
            this.cbGender.TabIndex = 3;
            this.cbGender.Text = "Male";
            // 
            // ckMarried
            // 
            this.ckMarried.AutoSize = true;
            this.ckMarried.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckMarried.Location = new System.Drawing.Point(120, 78);
            this.ckMarried.Name = "ckMarried";
            this.ckMarried.Size = new System.Drawing.Size(87, 24);
            this.ckMarried.TabIndex = 4;
            this.ckMarried.Text = "Married";
            this.ckMarried.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(120, 115);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(138, 22);
            this.dtpBirthday.TabIndex = 5;
            this.dtpBirthday.Value = new System.DateTime(2015, 12, 15, 17, 11, 44, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthday";
            // 
            // gvSample
            // 
            this.gvSample.AllowUserToAddRows = false;
            this.gvSample.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvSample.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvbtnDel,
            this.gvName,
            this.gvGender,
            this.gvMarried,
            this.gvBirthday});
            this.gvSample.Location = new System.Drawing.Point(12, 147);
            this.gvSample.MultiSelect = false;
            this.gvSample.Name = "gvSample";
            this.gvSample.RowTemplate.Height = 24;
            this.gvSample.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSample.Size = new System.Drawing.Size(663, 292);
            this.gvSample.TabIndex = 0;
            this.gvSample.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSample_CellContentClick);
            // 
            // gvbtnDel
            // 
            this.gvbtnDel.HeaderText = "Action";
            this.gvbtnDel.Name = "gvbtnDel";
            this.gvbtnDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvbtnDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gvbtnDel.Text = "Del";
            this.gvbtnDel.UseColumnTextForButtonValue = true;
            // 
            // gvName
            // 
            this.gvName.DataPropertyName = "Name";
            this.gvName.HeaderText = "Name";
            this.gvName.Name = "gvName";
            // 
            // gvGender
            // 
            this.gvGender.DataPropertyName = "Gender";
            this.gvGender.HeaderText = "Gender";
            this.gvGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gvGender.Name = "gvGender";
            this.gvGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gvMarried
            // 
            this.gvMarried.DataPropertyName = "Married";
            this.gvMarried.FalseValue = "0";
            this.gvMarried.HeaderText = "Married";
            this.gvMarried.IndeterminateValue = "0";
            this.gvMarried.Name = "gvMarried";
            this.gvMarried.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMarried.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gvMarried.TrueValue = "1";
            // 
            // gvBirthday
            // 
            this.gvBirthday.DataPropertyName = "Birthday";
            this.gvBirthday.HeaderText = "Birthday";
            this.gvBirthday.Name = "gvBirthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(310, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // cbDes
            // 
            this.cbDes.FormattingEnabled = true;
            this.cbDes.Location = new System.Drawing.Point(411, 115);
            this.cbDes.Name = "cbDes";
            this.cbDes.Size = new System.Drawing.Size(138, 20);
            this.cbDes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.ckMarried);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvSample);
            this.Name = "Form1";
            this.Text = "DataGridView Usage";
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSample;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.CheckBox ckMarried;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBirthday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvMarried;
        private System.Windows.Forms.DataGridViewComboBoxColumn gvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewButtonColumn gvbtnDel;
        private System.Windows.Forms.ComboBox cbDes;
        private System.Windows.Forms.Label label3;
    }
}

