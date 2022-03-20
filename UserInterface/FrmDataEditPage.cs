using Bussiness.Concrete;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmDataEditPage : Form
    {
        BraceletManager braceletManager;
        int id;

        public FrmDataEditPage()
        {
            InitializeComponent();
            braceletManager = BraceletManager.GetInstance();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void FrmDataEditPage_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }
        void DataDisplay()
        {
            DtgList.DataSource = braceletManager.GetList();
            DtgList.Columns["Id"].Visible = false;
            DtgList.Columns["BraceletNo"].HeaderText = "BRACELET";
            DtgList.Columns["BigDiameter"].HeaderText = "BİG DIAMETER";
            DtgList.Columns["SmallDiameter"].HeaderText = "SMAL DIAMETER";
            LblTop.Text = DtgList.RowCount.ToString();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtgList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgList.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle bir kayıt seçiniz.");
                return;
            }
            id = DtgList.CurrentRow.Cells["Id"].Value.ConInt();
            TxtBraceletSize.Text = DtgList.CurrentRow.Cells["BraceletNo"].Value.ToString();
            TxtBigDiameter.Text = DtgList.CurrentRow.Cells["BigDiameter"].Value.ToString();
            TxtSmallDiameter.Text = DtgList.CurrentRow.Cells["SmallDiameter"].Value.ToString();
        }

        private void TxtBraceletSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtBigDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtSmallDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle()
        {
            TxtBraceletSize.Clear(); TxtBigDiameter.Clear(); TxtSmallDiameter.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string control = Control();
            if (control!="OK")
            {
                MessageBox.Show(control, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Bilgileri kaydetmek istediğinize emin misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Bracelet bracelet = new Bracelet(TxtBraceletSize.Text.ConInt(), TxtBigDiameter.Text.ConInt(), TxtSmallDiameter.Text.ConInt());
                
                string message = braceletManager.Add(bracelet);
                if (message!="OK")
                {
                    MessageBox.Show(message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla kaydedilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Temizle();
                DataDisplay();
            }
        }
        string Control()
        {
            Bracelet bracelet = braceletManager.Get(TxtBraceletSize.Text.ConInt());

            if (bracelet!=null)
            {
                if (bracelet.BraceletNo == TxtBraceletSize.Text.ConInt())
                {
                    return "Bu Bracelet No ile zaten bir kayıt var. Lütfen Clear Butonunu kullanarak ekranı temizleyip, farklı bir kayıt ekleyiniz.";
                }
            }
            return "OK";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string message = braceletManager.Delete(id);
                if (message != "OK")
                {
                    MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Kayıt başarıyla silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                Temizle();
                DataDisplay();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (id==0)
            {
                MessageBox.Show("Lütfen öncelikle geçerli bir kayıt seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Kaydı güncellemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Bracelet bracelet = new Bracelet(id, TxtBraceletSize.Text.ConInt(), TxtBigDiameter.Text.ConInt(), TxtSmallDiameter.Text.ConInt());

                string message = braceletManager.Update(bracelet);
                if (message != "OK")
                {
                    MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Kayıt başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                Temizle();
                DataDisplay();
            }
        }
    }
}
