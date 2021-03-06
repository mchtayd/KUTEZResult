using Bussiness.Concrete;
using DataAccess.Concrete;
using DataAccess.Shared;
using Entity;
using Newtonsoft.Json;
using RestSharp;
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
    public partial class FrmAccessScreen : Form
    {
        BraceletManager braceletManager;
        double conclusion = 0, pi = 3.14;
        double bigDiameterPow, smallDiameterPow;


        public FrmAccessScreen()
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
        private void FrmAccessScreen_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamanızı kapatmak istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void FrmAccessScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BtnDataEdit_Click(object sender, EventArgs e)
        {
            FrmDataEditPage frmDataEditPage = new FrmDataEditPage();
            frmDataEditPage.ShowDialog();
        }

        private void TxtBraceletSize_TextChanged(object sender, EventArgs e)
        {
            if (TxtBraceletSize.Text == "")
            {
                LblBigDiameter.Text = "00";
                LblSmallDiameter.Text = "00";
                LblPerimeterResult.Text = "00"; ;
            }

        }

        private void TxtBraceletSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDataType.Text== "API")
            {
                BtnDataEdit.Visible = false;
                TxtBraceletSize.Clear();
                return;
            }
            if (CmbDataType.Text == "MSSQL")
            {
                BtnDataEdit.Visible = true;
                TxtBraceletSize.Clear();
                return;
            }
        }

        private async void BtnSentServer_Click(object sender, EventArgs e)
        {
            if (TxtBraceletSize.Text == "")
            {
                MessageBox.Show("Lütfen öncelikle Bracelet Size değerini giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbDataType.Text == "API")
            {
                if (TxtBraceletSize.Text == "1")
                {
                    LblBigDiameter.Text = (90).ToString();
                    LblSmallDiameter.Text = (65).ToString();
                }
                else if (TxtBraceletSize.Text == "2")
                {
                    LblBigDiameter.Text = (80).ToString();
                    LblSmallDiameter.Text = (60).ToString();
                }
                else if(TxtBraceletSize.Text == "3")
                {
                    LblBigDiameter.Text = (70).ToString();
                    LblSmallDiameter.Text = (55).ToString();
                }
                else if(TxtBraceletSize.Text == "4")
                {
                    LblBigDiameter.Text = (60).ToString();
                    LblSmallDiameter.Text = (50).ToString();
                }
                else if (TxtBraceletSize.Text == "5")
                {
                    LblBigDiameter.Text = (50).ToString();
                    LblSmallDiameter.Text = (45).ToString();
                }
                else
                {
                    MessageBox.Show("Girilen değer aralığında bir ölçüt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


                /*string response = await ClientProcess.ClientExecuteAsync("https://kutez.com/testapi/get_diameter.php?size=" + TxtBraceletSize.Text, Method.GET, null);

                Conclusion classInstance = JsonConvert.DeserializeObject<Conclusion>(response);

                if (classInstance==null)
                {
                    MessageBox.Show("İnternet bağlantınızı kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LblBigDiameter.Text = classInstance.BigDiameter.ToString();
                LblSmallDiameter.Text = classInstance.SmallDiameter.ToString();*/
            }

            else if (CmbDataType.Text == "MSSQL")
            {
                Bracelet bracelet = braceletManager.Get(TxtBraceletSize.Text.ConInt());

                if (bracelet == null)
                {
                    MessageBox.Show(TxtBraceletSize.Text + " Numaralı Kayıta Ait Bir Veri Bulunamamıştır!\nEğer eklemek isterseniz Data Edit butonunu kullanabilirsiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LblBigDiameter.Text = bracelet.BigDiameter.ToString();
                LblSmallDiameter.Text = bracelet.SmallDiameter.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Data Type Şeçeneklerinden birini seçiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (LblBigDiameter.Text == "00" || LblSmallDiameter.Text == "00")
            {
                MessageBox.Show("Lütfen öncelikle geçerli bir Bracelet Size değeri girerek Sent To Server Butonuna basınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bigDiameterPow = Math.Pow(LblBigDiameter.Text.ConDouble(), 2);
            smallDiameterPow = Math.Pow(LblSmallDiameter.Text.ConDouble(), 2);
            double sayi = (bigDiameterPow + smallDiameterPow) / 2;
            sayi = Math.Sqrt(sayi);

            conclusion = pi * sayi;

            LblPerimeterResult.Text = Math.Round(conclusion, 2).ToString();
        }
    }
}
