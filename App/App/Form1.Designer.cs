namespace App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.activity = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.caloriesbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.activity);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.weight);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(338, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 314);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(182, 155);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 4;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(117, 155);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // activity
            // 
            this.activity.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.activity.Location = new System.Drawing.Point(117, 189);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(181, 24);
            this.activity.TabIndex = 3;
            this.activity.Text = "Select level";
            this.activity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(117, 108);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(181, 22);
            this.age.TabIndex = 2;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Activity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age:";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(117, 75);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(181, 22);
            this.weight.TabIndex = 2;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight:";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(117, 44);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(181, 22);
            this.height.TabIndex = 2;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resetbtn);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.caloriesbox);
            this.panel2.Location = new System.Drawing.Point(368, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 155);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Calories:";
            // 
            // caloriesbox
            // 
            this.caloriesbox.Enabled = false;
            this.caloriesbox.Location = new System.Drawing.Point(91, 63);
            this.caloriesbox.Name = "caloriesbox";
            this.caloriesbox.Size = new System.Drawing.Size(102, 22);
            this.caloriesbox.TabIndex = 2;
            this.caloriesbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caloriesbox.TextChanged += new System.EventHandler(this.calories_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(509, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 77);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Calories Finder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Years";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(199, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "kilocalorie";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(91, 107);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(102, 30);
            this.resetbtn.TabIndex = 6;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(123, 232);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(166, 13);
            this.error.TabIndex = 6;
            this.error.Text = "Please, enter valid inputs in fields.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 527);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calories Finder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox activity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton female;
        public System.Windows.Forms.RadioButton male;
        public System.Windows.Forms.TextBox age;
        public System.Windows.Forms.TextBox weight;
        public System.Windows.Forms.TextBox height;
        public System.Windows.Forms.TextBox caloriesbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label error;
    }
}

