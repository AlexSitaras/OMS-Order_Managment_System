
namespace ORMANSYS
{
    partial class addorderform
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
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label timolLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addorderform));
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.sxedioTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.timolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.paytextBox = new System.Windows.Forms.TextBox();
            this.ordbt = new System.Windows.Forms.Button();
            this.photobt = new System.Windows.Forms.Button();
            this.sxedbt = new System.Windows.Forms.Button();
            this.timolbt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new ORMANSYS.customersDataSet();
            this.custinfoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ORMANSYS.customersDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new ORMANSYS.customersDataSetTableAdapters.TableAdapterManager();
            this.custinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet1 = new ORMANSYS.customersDataSet();
            this.custinfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cust_infoTableAdapter = new ORMANSYS.customersDataSetTableAdapters.cust_infoTableAdapter();
            this.custinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.custinfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cust_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet2 = new ORMANSYS.customersDataSet();
            this.custinfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.custinfoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            photoLabel = new System.Windows.Forms.Label();
            timolLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            photoLabel.Location = new System.Drawing.Point(39, 523);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(160, 25);
            photoLabel.TabIndex = 13;
            photoLabel.Text = "ΦΟΤΟΓΡΑΦΙΑ :";
            photoLabel.Click += new System.EventHandler(this.photoLabel_Click);
            // 
            // timolLabel
            // 
            timolLabel.AutoSize = true;
            timolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            timolLabel.Location = new System.Drawing.Point(676, 523);
            timolLabel.Name = "timolLabel";
            timolLabel.Size = new System.Drawing.Size(137, 25);
            timolLabel.TabIndex = 15;
            timolLabel.Text = "ΤΙΜΟΛΟΓΙΟ :";
            timolLabel.Click += new System.EventHandler(this.timolLabel_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label6.Location = new System.Drawing.Point(63, 604);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 25);
            label6.TabIndex = 26;
            label6.Text = "ΣΧΟΛΙΑ ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label7.Location = new System.Drawing.Point(63, 629);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(136, 25);
            label7.TabIndex = 27;
            label7.Text = "ΠΛΗΡΩΜΗΣ :";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "date", true));
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTextBox.Location = new System.Drawing.Point(569, 166);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(397, 35);
            this.dateTextBox.TabIndex = 8;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            // 
            // orderTextBox
            // 
            this.orderTextBox.AllowDrop = true;
            this.orderTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order", true));
            this.orderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.orderTextBox.Location = new System.Drawing.Point(217, 392);
            this.orderTextBox.Multiline = true;
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.ReadOnly = true;
            this.orderTextBox.Size = new System.Drawing.Size(388, 39);
            this.orderTextBox.TabIndex = 10;
            this.orderTextBox.TextChanged += new System.EventHandler(this.orderTextBox_TextChanged);
            this.orderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.orderTextBox_DragDrop);
            this.orderTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.orderTextBox_DragEnter);
            // 
            // sxedioTextBox
            // 
            this.sxedioTextBox.AllowDrop = true;
            this.sxedioTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sxedioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "sxedio", true));
            this.sxedioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxedioTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sxedioTextBox.Location = new System.Drawing.Point(828, 392);
            this.sxedioTextBox.Multiline = true;
            this.sxedioTextBox.Name = "sxedioTextBox";
            this.sxedioTextBox.ReadOnly = true;
            this.sxedioTextBox.Size = new System.Drawing.Size(413, 39);
            this.sxedioTextBox.TabIndex = 12;
            this.sxedioTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.sxedioTextBox_DragDrop);
            this.sxedioTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.sxedioTextBox_DragEnter);
            // 
            // photoTextBox
            // 
            this.photoTextBox.AllowDrop = true;
            this.photoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "photo", true));
            this.photoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.photoTextBox.Location = new System.Drawing.Point(217, 517);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(388, 39);
            this.photoTextBox.TabIndex = 14;
            this.photoTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.photoTextBox_DragDrop);
            this.photoTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.photoTextBox_DragEnter);
            // 
            // timolTextBox
            // 
            this.timolTextBox.AllowDrop = true;
            this.timolTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "timol", true));
            this.timolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timolTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.timolTextBox.Location = new System.Drawing.Point(828, 517);
            this.timolTextBox.Multiline = true;
            this.timolTextBox.Name = "timolTextBox";
            this.timolTextBox.ReadOnly = true;
            this.timolTextBox.Size = new System.Drawing.Size(413, 39);
            this.timolTextBox.TabIndex = 16;
            this.timolTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.timolTextBox_DragDrop);
            this.timolTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.timolTextBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(365, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ΗΜΕΡΟΜΗΝΙΑ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(51, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "ΠΑΡΑΓΓΕΛΙΑ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(716, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "ΣΧΕΔΙΟ :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(244, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(869, 55);
            this.label4.TabIndex = 22;
            this.label4.Text = "ΚΑΤΑΧΩΡΗΣΗ ΝΕΑΣ ΠΑΡΑΓΓΕΛΙΑΣ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(254, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "ΠΕΛΑΤΗΣ :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.custinfoBindingSource6, "name", true));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(391, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(712, 37);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(532, 778);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Αποθήκευση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paytextBox
            // 
            this.paytextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paytextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "timol", true));
            this.paytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.paytextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.paytextBox.Location = new System.Drawing.Point(217, 623);
            this.paytextBox.Multiline = true;
            this.paytextBox.Name = "paytextBox";
            this.paytextBox.Size = new System.Drawing.Size(1089, 80);
            this.paytextBox.TabIndex = 28;
            // 
            // ordbt
            // 
            this.ordbt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ordbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ordbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ordbt.ForeColor = System.Drawing.Color.White;
            this.ordbt.Location = new System.Drawing.Point(615, 392);
            this.ordbt.Name = "ordbt";
            this.ordbt.Size = new System.Drawing.Size(50, 39);
            this.ordbt.TabIndex = 29;
            this.ordbt.Text = "...";
            this.ordbt.UseVisualStyleBackColor = false;
            this.ordbt.Click += new System.EventHandler(this.ordbt_Click);
            // 
            // photobt
            // 
            this.photobt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.photobt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.photobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photobt.ForeColor = System.Drawing.Color.White;
            this.photobt.Location = new System.Drawing.Point(615, 516);
            this.photobt.Name = "photobt";
            this.photobt.Size = new System.Drawing.Size(50, 39);
            this.photobt.TabIndex = 30;
            this.photobt.Text = "...";
            this.photobt.UseVisualStyleBackColor = false;
            this.photobt.Click += new System.EventHandler(this.photobt_Click);
            // 
            // sxedbt
            // 
            this.sxedbt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sxedbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sxedbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxedbt.Location = new System.Drawing.Point(1256, 392);
            this.sxedbt.Name = "sxedbt";
            this.sxedbt.Size = new System.Drawing.Size(50, 39);
            this.sxedbt.TabIndex = 31;
            this.sxedbt.Text = "...";
            this.sxedbt.UseVisualStyleBackColor = false;
            this.sxedbt.Click += new System.EventHandler(this.sxedbt_Click);
            // 
            // timolbt
            // 
            this.timolbt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timolbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timolbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timolbt.Location = new System.Drawing.Point(1256, 516);
            this.timolbt.Name = "timolbt";
            this.timolbt.Size = new System.Drawing.Size(50, 39);
            this.timolbt.TabIndex = 32;
            this.timolbt.Text = "...";
            this.timolbt.UseVisualStyleBackColor = false;
            this.timolbt.Click += new System.EventHandler(this.timolbt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(1283, 839);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "label8";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "customersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custinfoBindingSource6
            // 
            this.custinfoBindingSource6.DataMember = "cust_info";
            this.custinfoBindingSource6.DataSource = this.customersDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cust_infoTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = ORMANSYS.customersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // custinfoBindingSource
            // 
            this.custinfoBindingSource.DataMember = "cust_info";
            this.custinfoBindingSource.DataSource = this.customersDataSet1;
            // 
            // customersDataSet1
            // 
            this.customersDataSet1.DataSetName = "customersDataSet";
            this.customersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custinfoBindingSource2
            // 
            this.custinfoBindingSource2.DataMember = "cust_info";
            this.custinfoBindingSource2.DataSource = this.customersDataSet1;
            // 
            // cust_infoTableAdapter
            // 
            this.cust_infoTableAdapter.ClearBeforeFill = true;
            // 
            // custinfoBindingSource1
            // 
            this.custinfoBindingSource1.DataMember = "cust_info";
            this.custinfoBindingSource1.DataSource = this.customersDataSet1;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.customersDataSet1;
            // 
            // custinfoBindingSource3
            // 
            this.custinfoBindingSource3.DataMember = "cust_info";
            this.custinfoBindingSource3.DataSource = this.customersDataSet1;
            // 
            // cust_infoBindingSource
            // 
            this.cust_infoBindingSource.DataMember = "cust_info";
            this.cust_infoBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet2
            // 
            this.customersDataSet2.DataSetName = "customersDataSet";
            this.customersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custinfoBindingSource4
            // 
            this.custinfoBindingSource4.DataMember = "cust_info";
            this.custinfoBindingSource4.DataSource = this.customersDataSet2;
            // 
            // custinfoBindingSource5
            // 
            this.custinfoBindingSource5.DataMember = "cust_info";
            this.custinfoBindingSource5.DataSource = this.customersDataSet2;
            // 
            // addorderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1346, 853);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timolbt);
            this.Controls.Add(this.sxedbt);
            this.Controls.Add(this.photobt);
            this.Controls.Add(this.ordbt);
            this.Controls.Add(this.paytextBox);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.sxedioTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(timolLabel);
            this.Controls.Add(this.timolTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addorderform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Καταχώρηση νέας παραγγελίας";
            this.Load += new System.EventHandler(this.addorderform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private customersDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private customersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.TextBox sxedioTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox timolTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private customersDataSet customersDataSet1;
        private System.Windows.Forms.BindingSource custinfoBindingSource;
        private customersDataSetTableAdapters.cust_infoTableAdapter cust_infoTableAdapter;
        private System.Windows.Forms.BindingSource custinfoBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.BindingSource custinfoBindingSource2;
        private System.Windows.Forms.BindingSource custinfoBindingSource3;
        private System.Windows.Forms.BindingSource cust_infoBindingSource;
        private System.Windows.Forms.Label label5;
        private customersDataSet customersDataSet2;
        private System.Windows.Forms.BindingSource custinfoBindingSource4;
        private System.Windows.Forms.BindingSource custinfoBindingSource5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource custinfoBindingSource6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox paytextBox;
        private System.Windows.Forms.Button ordbt;
        private System.Windows.Forms.Button photobt;
        private System.Windows.Forms.Button sxedbt;
        private System.Windows.Forms.Button timolbt;
        private System.Windows.Forms.Label label8;
    }
}