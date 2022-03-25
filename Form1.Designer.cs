namespace PatientEnroll
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSecurityNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSymptom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSym = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSecurityNum = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblSym = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSecurityNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPhone,
            this.chSecurityNum,
            this.chAddress,
            this.chSymptom});
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(41, 39);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(564, 150);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 50;
            // 
            // chPhone
            // 
            this.chPhone.DisplayIndex = 2;
            this.chPhone.Text = "전화번호";
            this.chPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPhone.Width = 100;
            // 
            // chSecurityNum
            // 
            this.chSecurityNum.DisplayIndex = 1;
            this.chSecurityNum.Text = "주민번호";
            this.chSecurityNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSecurityNum.Width = 110;
            // 
            // chAddress
            // 
            this.chAddress.Text = "주소";
            this.chAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAddress.Width = 200;
            // 
            // chSymptom
            // 
            this.chSymptom.Text = "증상";
            this.chSymptom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSymptom.Width = 80;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(437, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 79);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSym
            // 
            this.txtSym.Location = new System.Drawing.Point(129, 404);
            this.txtSym.Name = "txtSym";
            this.txtSym.Size = new System.Drawing.Size(236, 21);
            this.txtSym.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 249);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "환자명";
            // 
            // lblSecurityNum
            // 
            this.lblSecurityNum.AutoSize = true;
            this.lblSecurityNum.Location = new System.Drawing.Point(61, 289);
            this.lblSecurityNum.Name = "lblSecurityNum";
            this.lblSecurityNum.Size = new System.Drawing.Size(53, 12);
            this.lblSecurityNum.TabIndex = 4;
            this.lblSecurityNum.Text = "주민번호";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(61, 329);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "전화번호";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(61, 368);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(29, 12);
            this.lblAdress.TabIndex = 6;
            this.lblAdress.Text = "주소";
            // 
            // lblSym
            // 
            this.lblSym.AutoSize = true;
            this.lblSym.Location = new System.Drawing.Point(61, 409);
            this.lblSym.Name = "lblSym";
            this.lblSym.Size = new System.Drawing.Size(29, 12);
            this.lblSym.TabIndex = 7;
            this.lblSym.Text = "증상";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(129, 363);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 21);
            this.txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(129, 323);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 21);
            this.txtPhone.TabIndex = 10;
            // 
            // txtSecurityNum
            // 
            this.txtSecurityNum.Location = new System.Drawing.Point(129, 283);
            this.txtSecurityNum.Name = "txtSecurityNum";
            this.txtSecurityNum.Size = new System.Drawing.Size(236, 21);
            this.txtSecurityNum.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 242);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 21);
            this.txtName.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 454);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSecurityNum);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSym);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSecurityNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSym);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ListView);
            this.Name = "Form1";
            this.Text = "환자접수";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chSecurityNum;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chSymptom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSym;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSecurityNum;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblSym;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSecurityNum;
        private System.Windows.Forms.TextBox txtName;
    }
}
