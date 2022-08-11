namespace assgmt3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtt_number = new System.Windows.Forms.TextBox();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_coast = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkav = new System.Windows.Forms.CheckBox();
            this.lbladmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "number";
            // 
            // txtt_number
            // 
            this.txtt_number.Location = new System.Drawing.Point(30, 46);
            this.txtt_number.Margin = new System.Windows.Forms.Padding(2);
            this.txtt_number.Name = "txtt_number";
            this.txtt_number.Size = new System.Drawing.Size(121, 27);
            this.txtt_number.TabIndex = 1;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(206, 46);
            this.d1.Margin = new System.Windows.Forms.Padding(2);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(241, 27);
            this.d1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(315, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(254, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "stock id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(224, 148);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 27);
            this.txt_id.TabIndex = 5;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(10, 148);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(150, 27);
            this.txt_name.TabIndex = 6;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(61, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(40, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "coast";
            // 
            // txt_coast
            // 
            this.txt_coast.Location = new System.Drawing.Point(19, 211);
            this.txt_coast.Margin = new System.Windows.Forms.Padding(2);
            this.txt_coast.Name = "txt_coast";
            this.txt_coast.Size = new System.Drawing.Size(121, 27);
            this.txt_coast.TabIndex = 9;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(224, 211);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(121, 27);
            this.txt_price.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(247, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "pricce ";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(50, 269);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 27);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "Add";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(239, 269);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 27);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Exit";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkav
            // 
            this.chkav.AutoSize = true;
            this.chkav.Location = new System.Drawing.Point(465, 211);
            this.chkav.Margin = new System.Windows.Forms.Padding(2);
            this.chkav.Name = "chkav";
            this.chkav.Size = new System.Drawing.Size(105, 24);
            this.chkav.TabIndex = 14;
            this.chkav.Text = "is available";
            this.chkav.UseVisualStyleBackColor = true;
            this.chkav.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Location = new System.Drawing.Point(596, 35);
            this.lbladmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(50, 20);
            this.lbladmin.TabIndex = 15;
            this.lbladmin.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 423);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.chkav);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_coast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.txtt_number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtt_number;
        private DateTimePicker d1;
        private Label label2;
        private Label label3;
        private TextBox txt_id;
        private TextBox txt_name;
        private Label label4;
        private Label label5;
        private TextBox txt_coast;
        private TextBox txt_price;
        private Label label6;
        private Button btn1;
        private Button btn2;
        private ErrorProvider errorProvider1;
        private DataGridView dd;
        private CheckBox chkav;
        private Label lbladmin;
    }
}