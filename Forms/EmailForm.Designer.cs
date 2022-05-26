namespace SendEmail_Project
{
    partial class EmailForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFromPassword = new System.Windows.Forms.TextBox();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.listViewToEmail = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.To.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFromPassword);
            this.groupBox1.Controls.Add(this.txtFromEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // txtFromPassword
            // 
            this.txtFromPassword.Location = new System.Drawing.Point(6, 99);
            this.txtFromPassword.Name = "txtFromPassword";
            this.txtFromPassword.Size = new System.Drawing.Size(241, 27);
            this.txtFromPassword.TabIndex = 2;
            this.txtFromPassword.UseSystemPasswordChar = true;
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Location = new System.Drawing.Point(6, 46);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(241, 27);
            this.txtFromEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // To
            // 
            this.To.Controls.Add(this.btnAdd);
            this.To.Controls.Add(this.label4);
            this.To.Controls.Add(this.label3);
            this.To.Controls.Add(this.txtAddEmail);
            this.To.Controls.Add(this.listViewToEmail);
            this.To.Location = new System.Drawing.Point(12, 155);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(356, 310);
            this.To.TabIndex = 1;
            this.To.TabStop = false;
            this.To.Text = "To";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(6, 46);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(241, 27);
            this.txtAddEmail.TabIndex = 3;
            // 
            // listViewToEmail
            // 
            this.listViewToEmail.Location = new System.Drawing.Point(6, 99);
            this.listViewToEmail.Name = "listViewToEmail";
            this.listViewToEmail.Size = new System.Drawing.Size(344, 205);
            this.listViewToEmail.TabIndex = 2;
            this.listViewToEmail.UseCompatibleStateImageBehavior = false;
            this.listViewToEmail.View = System.Windows.Forms.View.SmallIcon;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.txtBody);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSubject);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 453);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Content";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(279, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 29);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(6, 193);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(370, 254);
            this.txtBody.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Body";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(6, 87);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(370, 80);
            this.txtSubject.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subject";
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.To);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.To.ResumeLayout(false);
            this.To.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFromEmail;
        private Label label2;
        private Label label1;
        private TextBox txtFromPassword;
        private GroupBox To;
        private Button btnAdd;
        private Label label4;
        private Label label3;
        private TextBox txtAddEmail;
        private ListView listViewToEmail;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtSubject;
        private Label label5;
        private TextBox txtBody;
        private Button btnSend;
    }
}