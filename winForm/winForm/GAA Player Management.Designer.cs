namespace Assignment8
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newID = new System.Windows.Forms.TextBox();
            this.newName = new System.Windows.Forms.TextBox();
            this.newAge = new System.Windows.Forms.TextBox();
            this.newHeight = new System.Windows.Forms.TextBox();
            this.newDist = new System.Windows.Forms.TextBox();
            this.newSpd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.updateSpd = new System.Windows.Forms.TextBox();
            this.updateDist = new System.Windows.Forms.TextBox();
            this.updateHeight = new System.Windows.Forms.TextBox();
            this.updateAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.nameNew = new System.Windows.Forms.TextBox();
            this.idUpdate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.delConfirm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.delID = new System.Windows.Forms.TextBox();
            this.maxSpd = new System.Windows.Forms.TextBox();
            this.avgDist = new System.Windows.Forms.TextBox();
            this.minSpd = new System.Windows.Forms.TextBox();
            this.avgSpd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maxDist = new System.Windows.Forms.TextBox();
            this.minDist = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 174);
            this.dataGridView1.TabIndex = 2;
            // 
            // newID
            // 
            this.newID.Location = new System.Drawing.Point(19, 55);
            this.newID.Name = "newID";
            this.newID.Size = new System.Drawing.Size(38, 20);
            this.newID.TabIndex = 3;
            this.newID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(63, 55);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(100, 20);
            this.newName.TabIndex = 4;
            // 
            // newAge
            // 
            this.newAge.Location = new System.Drawing.Point(170, 55);
            this.newAge.Name = "newAge";
            this.newAge.Size = new System.Drawing.Size(35, 20);
            this.newAge.TabIndex = 5;
            this.newAge.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // newHeight
            // 
            this.newHeight.Location = new System.Drawing.Point(211, 55);
            this.newHeight.Name = "newHeight";
            this.newHeight.Size = new System.Drawing.Size(52, 20);
            this.newHeight.TabIndex = 6;
            // 
            // newDist
            // 
            this.newDist.Location = new System.Drawing.Point(269, 55);
            this.newDist.Name = "newDist";
            this.newDist.Size = new System.Drawing.Size(73, 20);
            this.newDist.TabIndex = 7;
            // 
            // newSpd
            // 
            this.newSpd.Location = new System.Drawing.Point(348, 55);
            this.newSpd.Name = "newSpd";
            this.newSpd.Size = new System.Drawing.Size(78, 20);
            this.newSpd.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.newID);
            this.groupBox1.Controls.Add(this.newSpd);
            this.groupBox1.Controls.Add(this.newName);
            this.groupBox1.Controls.Add(this.newDist);
            this.groupBox1.Controls.Add(this.newAge);
            this.groupBox1.Controls.Add(this.newHeight);
            this.groupBox1.Location = new System.Drawing.Point(448, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Player";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(351, 81);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.Age);
            this.groupBox2.Controls.Add(this.updateSpd);
            this.groupBox2.Controls.Add(this.updateDist);
            this.groupBox2.Controls.Add(this.updateHeight);
            this.groupBox2.Controls.Add(this.updateAge);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.updateBtn);
            this.groupBox2.Controls.Add(this.nameNew);
            this.groupBox2.Controls.Add(this.idUpdate);
            this.groupBox2.Location = new System.Drawing.Point(448, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 107);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Player ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(348, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(266, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Distance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Height";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(170, 32);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 11;
            this.Age.Text = "Age";
            // 
            // updateSpd
            // 
            this.updateSpd.Location = new System.Drawing.Point(349, 52);
            this.updateSpd.Name = "updateSpd";
            this.updateSpd.Size = new System.Drawing.Size(77, 20);
            this.updateSpd.TabIndex = 10;
            // 
            // updateDist
            // 
            this.updateDist.Location = new System.Drawing.Point(269, 52);
            this.updateDist.Name = "updateDist";
            this.updateDist.Size = new System.Drawing.Size(73, 20);
            this.updateDist.TabIndex = 9;
            // 
            // updateHeight
            // 
            this.updateHeight.Location = new System.Drawing.Point(211, 51);
            this.updateHeight.Name = "updateHeight";
            this.updateHeight.Size = new System.Drawing.Size(52, 20);
            this.updateHeight.TabIndex = 8;
            // 
            // updateAge
            // 
            this.updateAge.Location = new System.Drawing.Point(170, 51);
            this.updateAge.Name = "updateAge";
            this.updateAge.Size = new System.Drawing.Size(35, 20);
            this.updateAge.TabIndex = 7;
            this.updateAge.TextChanged += new System.EventHandler(this.updateAge_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(351, 78);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // nameNew
            // 
            this.nameNew.Location = new System.Drawing.Point(63, 50);
            this.nameNew.Name = "nameNew";
            this.nameNew.Size = new System.Drawing.Size(100, 20);
            this.nameNew.TabIndex = 2;
            // 
            // idUpdate
            // 
            this.idUpdate.Location = new System.Drawing.Point(19, 50);
            this.idUpdate.Name = "idUpdate";
            this.idUpdate.Size = new System.Drawing.Size(38, 20);
            this.idUpdate.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.delConfirm);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.deleteBtn);
            this.groupBox3.Controls.Add(this.delID);
            this.groupBox3.Location = new System.Drawing.Point(448, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 93);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Player";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Type \'DELETE\' to confirm";
            // 
            // delConfirm
            // 
            this.delConfirm.Location = new System.Drawing.Point(110, 55);
            this.delConfirm.Name = "delConfirm";
            this.delConfirm.Size = new System.Drawing.Size(100, 20);
            this.delConfirm.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(357, 55);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // delID
            // 
            this.delID.Location = new System.Drawing.Point(15, 55);
            this.delID.Name = "delID";
            this.delID.Size = new System.Drawing.Size(42, 20);
            this.delID.TabIndex = 0;
            this.delID.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // maxSpd
            // 
            this.maxSpd.Location = new System.Drawing.Point(300, 100);
            this.maxSpd.Name = "maxSpd";
            this.maxSpd.Size = new System.Drawing.Size(100, 20);
            this.maxSpd.TabIndex = 12;
            // 
            // avgDist
            // 
            this.avgDist.Location = new System.Drawing.Point(106, 19);
            this.avgDist.Name = "avgDist";
            this.avgDist.Size = new System.Drawing.Size(100, 20);
            this.avgDist.TabIndex = 13;
            // 
            // minSpd
            // 
            this.minSpd.Location = new System.Drawing.Point(300, 59);
            this.minSpd.Name = "minSpd";
            this.minSpd.Size = new System.Drawing.Size(100, 20);
            this.minSpd.TabIndex = 14;
            // 
            // avgSpd
            // 
            this.avgSpd.Location = new System.Drawing.Point(300, 19);
            this.avgSpd.Name = "avgSpd";
            this.avgSpd.Size = new System.Drawing.Size(100, 20);
            this.avgSpd.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.maxDist);
            this.groupBox4.Controls.Add(this.minDist);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.maxSpd);
            this.groupBox4.Controls.Add(this.minSpd);
            this.groupBox4.Controls.Add(this.avgSpd);
            this.groupBox4.Controls.Add(this.avgDist);
            this.groupBox4.Location = new System.Drawing.Point(23, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 176);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Minimum Distance";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Average Distance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Maximum Distance";
            // 
            // maxDist
            // 
            this.maxDist.Location = new System.Drawing.Point(106, 100);
            this.maxDist.Name = "maxDist";
            this.maxDist.Size = new System.Drawing.Size(100, 20);
            this.maxDist.TabIndex = 20;
            // 
            // minDist
            // 
            this.minDist.Location = new System.Drawing.Point(106, 62);
            this.minDist.Name = "minDist";
            this.minDist.Size = new System.Drawing.Size(100, 20);
            this.minDist.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Maximum Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Minimum Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Average Speed";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 412);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox newID;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newAge;
        private System.Windows.Forms.TextBox newHeight;
        private System.Windows.Forms.TextBox newDist;
        private System.Windows.Forms.TextBox newSpd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox nameNew;
        private System.Windows.Forms.TextBox idUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox delID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox delConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maxSpd;
        private System.Windows.Forms.TextBox avgDist;
        private System.Windows.Forms.TextBox minSpd;
        private System.Windows.Forms.TextBox avgSpd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox maxDist;
        private System.Windows.Forms.TextBox minDist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox updateSpd;
        private System.Windows.Forms.TextBox updateDist;
        private System.Windows.Forms.TextBox updateHeight;
        private System.Windows.Forms.TextBox updateAge;

    }
}

