using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logisticsDataSet.Logistics' table. You can move, or remove it, as needed.
            this.logisticsTableAdapter.Fill(this.logisticsDataSet.Logistics);

        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void LoadDB()
        {
            LogisticsContextDB context = new LogisticsContextDB();
            List<Logistic> list = context.Logistics.ToList();
            dgvLogistics.DataSource = list;

            txtId.Text = "";
            txtSendAddress.Text = "";
            txtRecAddress.Text = "";
            txtWeight.Text = "";
            txtWidth.Text = "";
            txtLength.Text = "";
            txtHeight.Text = "";
            txtSender.Text = "";
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            txtId.Enabled = true;
        }

        private bool isChecked()
        {
            String id = txtId.Text.Trim();
            String sendAddr = txtSendAddress.Text.Trim();
            String recAddr = txtRecAddress.Text.Trim();
            String weight = txtWeight.Text.Trim();

            if(String.IsNullOrEmpty(id)|| String.IsNullOrEmpty(sendAddr) || String.IsNullOrEmpty(recAddr) || String.IsNullOrEmpty(weight))
            {
                lblId.ForeColor = Color.Red;
                lblRecAddress.ForeColor = Color.Red;
                lblSendAddress.ForeColor = Color.Red;
                lblWeight.ForeColor = Color.Red;
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết (đã được highlight)!");
                return false;
            }
            else return true;
        }

        private void EntryHandle(TextBox textBox, int textLimit)
        {
            String entryText = textBox.Text.Trim();
            if (entryText.Length > textLimit)
            {
                MessageBox.Show("Nhập quá số lượng kí tự cho phép"+" ("+textLimit+")"+"! Vui lòng nhập lại");
                textBox.Text = "";
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            EntryHandle(txtId, 20);
        }

        private void txtSender_TextChanged(object sender, EventArgs e)
        {
            EntryHandle(txtSender, 50);
        }

        private void txtSendAddress_TextChanged(object sender, EventArgs e)
        {
            EntryHandle((TextBox)sender, 160);
        }

        private void dgvLogistics_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgvLogistics.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSender.Text = dgvLogistics.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSendAddress.Text = dgvLogistics.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRecAddress.Text = dgvLogistics.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtWeight.Text = dgvLogistics.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtLength.Text = dgvLogistics.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtWidth.Text = dgvLogistics.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtHeight.Text = dgvLogistics.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtId.Enabled = false;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            LogisticsContextDB context = new LogisticsContextDB();
            Logistic logistic = new Logistic();

            if (isChecked())
            {
                var item = context.Logistics.Find(txtId.Text.Trim());

                if (item == null)
                {
                    logistic.Id = txtId.Text.Trim();
                    logistic.Sender = !String.IsNullOrEmpty(txtLength.Text.Trim()) ? txtSender.Text.Trim():"Ẩn danh";
                    logistic.SendAddress = txtSendAddress.Text.Trim();
                    logistic.RecAddress = txtRecAddress.Text.Trim();
                    logistic.Weight = Convert.ToDouble(txtWeight.Text.Trim());
                    logistic.Length = !String.IsNullOrEmpty(txtLength.Text.Trim()) ? Convert.ToInt32(txtLength.Text.Trim()):0;
                    logistic.Width = !String.IsNullOrEmpty(txtWidth.Text.Trim()) ? Convert.ToInt32(txtWidth.Text.Trim()):0;
                    logistic.Height = !String.IsNullOrEmpty(txtHeight.Text.Trim()) ? Convert.ToInt32(txtHeight.Text.Trim()):0;
                    context.Logistics.Add(logistic);
                    context.SaveChanges();
                    LoadDB();
                }
                else
                {
                    MessageBox.Show("Mã vận đơn đã tồn tại! Vui lòng nhập lại!");
                    txtId.Text = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LogisticsContextDB contextDB = new LogisticsContextDB();
            String id = txtId.Text.Trim();
            if (String.IsNullOrEmpty(id))
                MessageBox.Show("Vui lòng nhập mã vận đơn hoặc chọn đơn vận chuyển trong Data Grid View");
            else
            {
                var item = contextDB.Logistics.Find(id);

                if (item != null)
                {
                    Logistic logistic = (Logistic)item;
                    contextDB.Logistics.Remove(logistic);
                    contextDB.SaveChanges();
                    LoadDB();
                }
                else
                {
                    MessageBox.Show("Mã vận đơn SAI! Vui lòng nhập lại!");
                    txtId.Text = "";
                }
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LogisticsContextDB contextDB = new LogisticsContextDB();
            String id = txtId.Text.Trim();
            if (String.IsNullOrEmpty(id))
                MessageBox.Show("Vui lòng nhập mã vận đơn và nhấn Enter để tìm kiếm hoặc chọn đơn vận chuyển trong Data Grid View");
            else
            {
                var item = contextDB.Logistics.Find(id);

                if (item != null)
                {
                    item.Sender = txtSender.Text.Trim();
                    item.SendAddress = txtSendAddress.Text.Trim();
                    item.RecAddress = txtRecAddress.Text.Trim();
                    item.Weight = Convert.ToDouble(txtWeight.Text.Trim());
                    item.Length = Convert.ToInt32(txtLength.Text.Trim());
                    item.Width = Convert.ToInt32(txtWidth.Text.Trim());
                    item.Height = Convert.ToInt32(txtHeight.Text.Trim());
                    contextDB.SaveChanges();
                    LoadDB();
                }

            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            LogisticsContextDB contextDB = new LogisticsContextDB();
            Logistic logistic = new Logistic();
            logistic.Id = txtId.Text.Trim();
            if(e.KeyCode == Keys.Enter)
            {
                var item = contextDB.Logistics.Find(logistic.Id);
               
                if(item != null)
                {
                    logistic = (Logistic)item;
                    txtSender.Text = logistic.Sender;
                    txtSendAddress.Text = logistic.SendAddress;
                    txtRecAddress.Text = logistic.RecAddress;
                    txtWeight.Text = logistic.Weight.ToString();
                    txtLength.Text = logistic.Length.ToString();
                    txtWidth.Text = logistic.Width.ToString();
                    txtHeight.Text = logistic.Height.ToString();
                    txtId.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnInsert.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã vận đơn SAI! Vui lòng nhập lại!");
                    txtId.Text = "";
                }
            }
        }
    }
}
