using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PatientEnroll
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Ptnt clsPtnt = new Ptnt();
            clsPtnt.PtntNM = "";
            clsPtnt.PtntSN = "";
            clsPtnt.PtntNO = "";
            clsPtnt.PtntAds ="";
            clsPtnt.PtntSYM = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //환자 정보 수정 
            if (ListView.SelectedIndices.Count > 0)
            {
                ListView.SelectedItems[0].SubItems[0].Text = txtName.Text;
                ListView.SelectedItems[0].SubItems[1].Text = txtPhone.Text;
                ListView.SelectedItems[0].SubItems[2].Text = txtSecurityNum.Text;
                ListView.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
                ListView.SelectedItems[0].SubItems[4].Text = txtSym.Text;
                this.txtName.Clear();
                this.txtPhone.Clear();
                this.txtSecurityNum.Clear();
                this.txtAddress.Clear();
                this.txtSym.Clear();
            }

            //환자 정보 등록
            else
            {
                var strArray = new String[] { this.txtName.Text, this.txtPhone.Text, this.txtSecurityNum.Text, this.txtAddress.Text, this.txtSym.Text };
                var lvt = new ListViewItem(strArray);
                this.ListView.Items.Add(lvt);
                this.txtName.Clear();
                this.txtPhone.Clear();
                this.txtSecurityNum.Clear();
                this.txtAddress.Clear();
                this.txtSym.Clear();

            }
            
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(ListView.SelectedItems.Count > 0)
            {
                txtName.Text = ListView.SelectedItems[0].SubItems[0].Text;
                txtPhone.Text = ListView.SelectedItems[0].SubItems[1].Text;
                txtSecurityNum.Text = ListView.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = ListView.SelectedItems[0].SubItems[3].Text;
                txtSym.Text = ListView.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
    class Ptnt
    {
        string sPtntNM = string.Empty; //환자명
        string sPtntSN = string.Empty; //주민번호
        string sPtntNO = string.Empty; //전화번호
        string sPtntAds = string.Empty; //주소
        string sPtntSYM = string.Empty; //증상
        public string PtntNM
        {
            get { return sPtntNM; }
            set { sPtntNM = value; }
        }
        public string PtntSN
        {
            get { return sPtntSN; }
            set { sPtntSN = value; }
        }
        public string PtntNO
        {
            get { return sPtntNO; }
            set { sPtntNO = value; }
        }
        public string PtntAds
        {
            get { return sPtntAds; }
            set { sPtntAds = value; }
        }
        public string PtntSYM
        {
            get { return sPtntSYM; }
            set { sPtntSYM = value; }
        }
    }
}