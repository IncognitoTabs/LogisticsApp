namespace LogisticsApp
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvLogistics = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticsDataSet = new LogisticsApp.LogisticsDataSet();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSendAddress = new System.Windows.Forms.TextBox();
            this.lblSendAddress = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecAddress = new System.Windows.Forms.TextBox();
            this.lblRecAddress = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.logisticsTableAdapter = new LogisticsApp.LogisticsDataSetTableAdapters.LogisticsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogistics
            // 
            this.dgvLogistics.AutoGenerateColumns = false;
            this.dgvLogistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogistics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLogistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.sendAddressDataGridViewTextBoxColumn,
            this.recAddressDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn});
            this.dgvLogistics.DataSource = this.logisticsBindingSource;
            this.dgvLogistics.Location = new System.Drawing.Point(0, 350);
            this.dgvLogistics.Name = "dgvLogistics";
            this.dgvLogistics.Size = new System.Drawing.Size(884, 200);
            this.dgvLogistics.TabIndex = 0;
            this.dgvLogistics.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLogistics_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // sendAddressDataGridViewTextBoxColumn
            // 
            this.sendAddressDataGridViewTextBoxColumn.DataPropertyName = "SendAddress";
            this.sendAddressDataGridViewTextBoxColumn.HeaderText = "SendAddress";
            this.sendAddressDataGridViewTextBoxColumn.Name = "sendAddressDataGridViewTextBoxColumn";
            // 
            // recAddressDataGridViewTextBoxColumn
            // 
            this.recAddressDataGridViewTextBoxColumn.DataPropertyName = "RecAddress";
            this.recAddressDataGridViewTextBoxColumn.HeaderText = "RecAddress";
            this.recAddressDataGridViewTextBoxColumn.Name = "recAddressDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // logisticsBindingSource
            // 
            this.logisticsBindingSource.DataMember = "Logistics";
            this.logisticsBindingSource.DataSource = this.logisticsDataSet;
            // 
            // logisticsDataSet
            // 
            this.logisticsDataSet.DataSetName = "LogisticsDataSet";
            this.logisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(89, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Mã Vận đơn";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(206, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 25);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtSendAddress
            // 
            this.txtSendAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSendAddress.Location = new System.Drawing.Point(206, 106);
            this.txtSendAddress.Name = "txtSendAddress";
            this.txtSendAddress.Size = new System.Drawing.Size(200, 25);
            this.txtSendAddress.TabIndex = 4;
            this.txtSendAddress.TextChanged += new System.EventHandler(this.txtSendAddress_TextChanged);
            // 
            // lblSendAddress
            // 
            this.lblSendAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSendAddress.AutoSize = true;
            this.lblSendAddress.Location = new System.Drawing.Point(89, 106);
            this.lblSendAddress.Name = "lblSendAddress";
            this.lblSendAddress.Size = new System.Drawing.Size(70, 17);
            this.lblSendAddress.TabIndex = 3;
            this.lblSendAddress.Text = "Địa chỉ gửi";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(206, 172);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(200, 25);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(89, 172);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 17);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Trọng lượng";
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidth.Location = new System.Drawing.Point(206, 235);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(200, 25);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chiều rộng";
            // 
            // txtSender
            // 
            this.txtSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSender.Location = new System.Drawing.Point(582, 44);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(200, 25);
            this.txtSender.TabIndex = 10;
            this.txtSender.TextChanged += new System.EventHandler(this.txtSender_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên người gửi";
            // 
            // txtRecAddress
            // 
            this.txtRecAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecAddress.Location = new System.Drawing.Point(582, 106);
            this.txtRecAddress.Name = "txtRecAddress";
            this.txtRecAddress.Size = new System.Drawing.Size(200, 25);
            this.txtRecAddress.TabIndex = 12;
            this.txtRecAddress.TextChanged += new System.EventHandler(this.txtSendAddress_TextChanged);
            // 
            // lblRecAddress
            // 
            this.lblRecAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecAddress.AutoSize = true;
            this.lblRecAddress.Location = new System.Drawing.Point(465, 106);
            this.lblRecAddress.Name = "lblRecAddress";
            this.lblRecAddress.Size = new System.Drawing.Size(79, 17);
            this.lblRecAddress.TabIndex = 11;
            this.lblRecAddress.Text = "Địa chỉ nhận";
            // 
            // txtLength
            // 
            this.txtLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLength.Location = new System.Drawing.Point(582, 172);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(200, 25);
            this.txtLength.TabIndex = 14;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chiều dài";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Location = new System.Drawing.Point(582, 235);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(200, 25);
            this.txtHeight.TabIndex = 16;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chiều cao";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(206, 286);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Tạo đơn";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(401, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sửa/Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(582, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa đơn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // logisticsTableAdapter
            // 
            this.logisticsTableAdapter.ClearBeforeFill = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRecAddress);
            this.Controls.Add(this.lblRecAddress);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtSendAddress);
            this.Controls.Add(this.lblSendAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvLogistics);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Form";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogistics;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSendAddress;
        private System.Windows.Forms.Label lblSendAddress;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecAddress;
        private System.Windows.Forms.Label lblRecAddress;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private LogisticsDataSet logisticsDataSet;
        private System.Windows.Forms.BindingSource logisticsBindingSource;
        private LogisticsDataSetTableAdapters.LogisticsTableAdapter logisticsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
    }
}

