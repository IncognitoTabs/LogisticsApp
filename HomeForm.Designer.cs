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
            this.dgvLogistics = new System.Windows.Forms.DataGridView();
            this.lab = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSendAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogistics
            // 
            this.dgvLogistics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLogistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLogistics.Location = new System.Drawing.Point(10, 351);
            this.dgvLogistics.Name = "dgvLogistics";
            this.dgvLogistics.ReadOnly = true;
            this.dgvLogistics.Size = new System.Drawing.Size(864, 200);
            this.dgvLogistics.TabIndex = 0;
            // 
            // lab
            // 
            this.lab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(70, 44);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(80, 17);
            this.lab.TabIndex = 1;
            this.lab.Text = "Mã Vận đơn";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(187, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 25);
            this.txtId.TabIndex = 2;
            // 
            // txtSendAddress
            // 
            this.txtSendAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSendAddress.Location = new System.Drawing.Point(187, 106);
            this.txtSendAddress.Name = "txtSendAddress";
            this.txtSendAddress.Size = new System.Drawing.Size(200, 25);
            this.txtSendAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Địa chỉ gửi";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(187, 172);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(200, 25);
            this.txtWeight.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trọng lượng";
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidth.Location = new System.Drawing.Point(187, 235);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(200, 25);
            this.txtWidth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chiều rộng";
            // 
            // txtSender
            // 
            this.txtSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSender.Location = new System.Drawing.Point(563, 44);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(200, 25);
            this.txtSender.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên người gửi";
            // 
            // txtRecAddress
            // 
            this.txtRecAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecAddress.Location = new System.Drawing.Point(563, 106);
            this.txtRecAddress.Name = "txtRecAddress";
            this.txtRecAddress.Size = new System.Drawing.Size(200, 25);
            this.txtRecAddress.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ nhận";
            // 
            // txtLength
            // 
            this.txtLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLength.Location = new System.Drawing.Point(563, 172);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(200, 25);
            this.txtLength.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chiều dài";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Location = new System.Drawing.Point(563, 235);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(200, 25);
            this.txtHeight.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chiều cao";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(187, 286);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(382, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSendAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.dgvLogistics);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogistics;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSendAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

