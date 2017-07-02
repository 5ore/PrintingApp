using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingStatus
{
    public partial class ChangePrices : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudBA4;
        private NumericUpDown nudBA3;
        private NumericUpDown nudCA4;
        private NumericUpDown nudCA3;
        private Label label7;
        private Label label8;
        private TextBox tbName;
        private TextBox tbPass;
        private Panel LoginPanel;
        private Label label9;
        private Button btnLogin;
        private PrintersDataSetTableAdapters.PrintLogTableAdapter printLogTableAdapter1;
        private Label ValidationMessages;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnEdit;
    
        public ChangePrices()
        {
            InitializeComponent();
            nudBA4.Value = (decimal)SavePrices.BA4;
            nudBA3.Value = (decimal)SavePrices.BA3;
            nudCA4.Value = (decimal)SavePrices.CA4;
            nudCA3.Value = (decimal)SavePrices.CA3;
            Admin.AdminLoged = false;
        }

        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudBA4 = new System.Windows.Forms.NumericUpDown();
            this.nudBA3 = new System.Windows.Forms.NumericUpDown();
            this.nudCA4 = new System.Windows.Forms.NumericUpDown();
            this.nudCA3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.printLogTableAdapter1 = new PrintingStatus.PrintersDataSetTableAdapters.PrintLogTableAdapter();
            this.ValidationMessages = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBA4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCA4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCA3)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(197, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Black";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "A4: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "A3: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "A3: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "A4: ";
            // 
            // nudBA4
            // 
            this.nudBA4.DecimalPlaces = 2;
            this.nudBA4.Enabled = false;
            this.nudBA4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBA4.Location = new System.Drawing.Point(51, 117);
            this.nudBA4.Name = "nudBA4";
            this.nudBA4.Size = new System.Drawing.Size(82, 20);
            this.nudBA4.TabIndex = 7;
            this.nudBA4.ValueChanged += new System.EventHandler(this.nudBA4_ValueChanged);
            // 
            // nudBA3
            // 
            this.nudBA3.DecimalPlaces = 2;
            this.nudBA3.Enabled = false;
            this.nudBA3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBA3.Location = new System.Drawing.Point(186, 117);
            this.nudBA3.Name = "nudBA3";
            this.nudBA3.Size = new System.Drawing.Size(86, 20);
            this.nudBA3.TabIndex = 8;
            this.nudBA3.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudCA4
            // 
            this.nudCA4.DecimalPlaces = 2;
            this.nudCA4.Enabled = false;
            this.nudCA4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCA4.Location = new System.Drawing.Point(51, 210);
            this.nudCA4.Name = "nudCA4";
            this.nudCA4.Size = new System.Drawing.Size(82, 20);
            this.nudCA4.TabIndex = 9;
            this.nudCA4.ValueChanged += new System.EventHandler(this.nudCA4_ValueChanged);
            // 
            // nudCA3
            // 
            this.nudCA3.DecimalPlaces = 2;
            this.nudCA3.Enabled = false;
            this.nudCA3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCA3.Location = new System.Drawing.Point(186, 210);
            this.nudCA3.Name = "nudCA3";
            this.nudCA3.Size = new System.Drawing.Size(86, 20);
            this.nudCA3.TabIndex = 10;
            this.nudCA3.ValueChanged += new System.EventHandler(this.nudCA3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pass:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(48, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 13;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(48, 27);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 14;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.ValidationMessages);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.label7);
            this.LoginPanel.Controls.Add(this.tbPass);
            this.LoginPanel.Controls.Add(this.label8);
            this.LoginPanel.Controls.Add(this.tbName);
            this.LoginPanel.Location = new System.Drawing.Point(12, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(260, 53);
            this.LoginPanel.TabIndex = 15;
            this.LoginPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Click button to edit prices.";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(185, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Submit";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // printLogTableAdapter1
            // 
            this.printLogTableAdapter1.ClearBeforeFill = true;
            // 
            // ValidationMessages
            // 
            this.ValidationMessages.AutoSize = true;
            this.ValidationMessages.ForeColor = System.Drawing.Color.Red;
            this.ValidationMessages.Location = new System.Drawing.Point(163, 34);
            this.ValidationMessages.Name = "ValidationMessages";
            this.ValidationMessages.Size = new System.Drawing.Size(0, 13);
            this.ValidationMessages.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(101, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(240, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "$";
            // 
            // ChangePrices
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.nudCA3);
            this.Controls.Add(this.nudCA4);
            this.Controls.Add(this.nudBA3);
            this.Controls.Add(this.nudBA4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePrices";
            this.Leave += new System.EventHandler(this.ChangePrices_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.nudBA4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCA4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCA3)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //EDIT DUGME, DINAMICKI SISTEM LOGOVANJA
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Admin.AdminLoged)
            {
                if (nudBA4.Enabled)
                {
                    label9.Text = "Loged as " + Admin.AdminName;
                    btnEdit.Text = "Edit";
                    nudBA3.Enabled = false;
                    nudBA4.Enabled = false;
                    nudCA3.Enabled = false;
                    nudCA4.Enabled = false;
                }
                else
                {
                    btnEdit.Text = "Save";
                    nudBA3.Enabled = true;
                    nudBA4.Enabled = true;
                    nudCA3.Enabled = true;
                    nudCA4.Enabled = true;
                }
                

            }
            else
            {
                label9.Visible = false;
                LoginPanel.Visible = true;
            }

        }
        //DUGME ZA LOGOVANJE, VALIDACIJA
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Admin.AdminLoged)
            {
                SavePrices.SaveData(SavePrices.selectedPrinter);
            }
            if (tbName.Text != "" && tbName.Text == Admin.AdminName)
            {
                if (tbPass.Text != "" && tbPass.Text == Admin.AdminPass)
                {
                    LoginPanel.Visible = false;
                    label9.Text = "Loged as " + Admin.AdminName;
                    label9.Visible = true;
                    Admin.AdminLoged = true;
                    btnEdit.Text = "Save";

                    nudBA3.Enabled = true;
                    nudBA4.Enabled = true;
                    nudCA3.Enabled = true;
                    nudCA4.Enabled = true;

                }
                else
                {
                    ValidationMessages.Text = "Not valid password!";
                }

            }
            else
            {
                ValidationMessages.Text = "Not valid name!";
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)//nudBA3
        {
            SavePrices.BA3 = (float)nudBA3.Value;
            
        }

        private void nudBA4_ValueChanged(object sender, EventArgs e)
        {
            SavePrices.BA4 = (float)nudBA4.Value;
           
        }

        private void nudCA4_ValueChanged(object sender, EventArgs e)
        {
            SavePrices.CA4 = (float)nudCA4.Value;
           
        }

        private void nudCA3_ValueChanged(object sender, EventArgs e)
        {
            SavePrices.CA3 = (float)nudCA3.Value;
           
        }

        private void ChangePrices_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
