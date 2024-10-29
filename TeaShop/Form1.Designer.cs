namespace TeaShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCostFrom = new System.Windows.Forms.TextBox();
            this.txtCostTo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtQuantityTo = new System.Windows.Forms.TextBox();
            this.txtQuantityFrom = new System.Windows.Forms.TextBox();
            this.txtCountries = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowCherryTea_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(932, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnShowCostRange_Click);
            // 
            // txtCostFrom
            // 
            this.txtCostFrom.Location = new System.Drawing.Point(932, 42);
            this.txtCostFrom.Multiline = true;
            this.txtCostFrom.Name = "txtCostFrom";
            this.txtCostFrom.Size = new System.Drawing.Size(99, 20);
            this.txtCostFrom.TabIndex = 3;
            // 
            // txtCostTo
            // 
            this.txtCostTo.Location = new System.Drawing.Point(1049, 42);
            this.txtCostTo.Name = "txtCostTo";
            this.txtCostTo.Size = new System.Drawing.Size(99, 20);
            this.txtCostTo.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(932, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnShowQuantityRange_Click);
            // 
            // txtQuantityTo
            // 
            this.txtQuantityTo.Location = new System.Drawing.Point(1049, 109);
            this.txtQuantityTo.Multiline = true;
            this.txtQuantityTo.Name = "txtQuantityTo";
            this.txtQuantityTo.Size = new System.Drawing.Size(99, 20);
            this.txtQuantityTo.TabIndex = 6;
            // 
            // txtQuantityFrom
            // 
            this.txtQuantityFrom.Location = new System.Drawing.Point(932, 109);
            this.txtQuantityFrom.Multiline = true;
            this.txtQuantityFrom.Name = "txtQuantityFrom";
            this.txtQuantityFrom.Size = new System.Drawing.Size(99, 20);
            this.txtQuantityFrom.TabIndex = 6;
            // 
            // txtCountries
            // 
            this.txtCountries.Location = new System.Drawing.Point(932, 168);
            this.txtCountries.Multiline = true;
            this.txtCountries.Name = "txtCountries";
            this.txtCountries.Size = new System.Drawing.Size(216, 20);
            this.txtCountries.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(932, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnShowCountries_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(760, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnShowCountryTeaCount_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(760, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnShowAverageQuantityPerCountry_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(932, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnShowTop3CheapestTeaInCountry_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(932, 223);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(216, 20);
            this.txtCountry.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(932, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnShowTop3ExpensiveTeaInCountry_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(760, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnShowTop3CheapestTeaAllCountries_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(760, 129);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnShowTop3ExpensiveTeaAllCountries_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(760, 158);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 21);
            this.button11.TabIndex = 16;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnTop3CountriesByTeaCount_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(760, 185);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(160, 21);
            this.button12.TabIndex = 17;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(760, 212);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(160, 21);
            this.button13.TabIndex = 18;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnTop3CountriesByQuantity_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(760, 266);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(160, 21);
            this.button14.TabIndex = 19;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnTop3TeaByTypeQuantity_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(760, 239);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(160, 21);
            this.button15.TabIndex = 19;
            this.button15.Text = "button14";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnTop3BlackTeaByQuantity_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(760, 424);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(160, 23);
            this.button16.TabIndex = 20;
            this.button16.Text = "Edit";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(932, 424);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(160, 23);
            this.button17.TabIndex = 21;
            this.button17.Text = "ADD";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(760, 453);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(332, 23);
            this.button18.TabIndex = 22;
            this.button18.Text = "Delite";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 630);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCountries);
            this.Controls.Add(this.txtQuantityFrom);
            this.Controls.Add(this.txtQuantityTo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCostTo);
            this.Controls.Add(this.txtCostFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCostFrom;
        private System.Windows.Forms.TextBox txtCostTo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtQuantityTo;
        private System.Windows.Forms.TextBox txtQuantityFrom;
        private System.Windows.Forms.TextBox txtCountries;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}

