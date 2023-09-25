
namespace ORMANSYS
{
    partial class addordform
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label timolLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addordform));
            this.photobt = new System.Windows.Forms.Button();
            this.ordbt = new System.Windows.Forms.Button();
            this.paytextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.sxedioTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.timolTextBox = new System.Windows.Forms.TextBox();
            this.timolbt = new System.Windows.Forms.Button();
            this.sxedbt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            timolLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label7.Location = new System.Drawing.Point(56, 594);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(136, 25);
            label7.TabIndex = 44;
            label7.Text = "ΠΛΗΡΩΜΗΣ :";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            photoLabel.Location = new System.Drawing.Point(32, 488);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(160, 25);
            photoLabel.TabIndex = 34;
            photoLabel.Text = "ΦΟΤΟΓΡΑΦΙΑ :";
            // 
            // timolLabel
            // 
            timolLabel.AutoSize = true;
            timolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            timolLabel.Location = new System.Drawing.Point(669, 488);
            timolLabel.Name = "timolLabel";
            timolLabel.Size = new System.Drawing.Size(137, 25);
            timolLabel.TabIndex = 36;
            timolLabel.Text = "ΤΙΜΟΛΟΓΙΟ :";
            // 
            // photobt
            // 
            this.photobt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.photobt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.photobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photobt.ForeColor = System.Drawing.Color.White;
            this.photobt.Location = new System.Drawing.Point(608, 481);
            this.photobt.Name = "photobt";
            this.photobt.Size = new System.Drawing.Size(50, 39);
            this.photobt.TabIndex = 47;
            this.photobt.Text = "...";
            this.photobt.UseVisualStyleBackColor = false;
            this.photobt.Click += new System.EventHandler(this.photobt_Click);
            // 
            // ordbt
            // 
            this.ordbt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ordbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ordbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ordbt.ForeColor = System.Drawing.Color.White;
            this.ordbt.Location = new System.Drawing.Point(608, 357);
            this.ordbt.Name = "ordbt";
            this.ordbt.Size = new System.Drawing.Size(50, 39);
            this.ordbt.TabIndex = 46;
            this.ordbt.Text = "...";
            this.ordbt.UseVisualStyleBackColor = false;
            this.ordbt.Click += new System.EventHandler(this.ordbt_Click);
            // 
            // paytextBox
            // 
            this.paytextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.paytextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.paytextBox.Location = new System.Drawing.Point(210, 588);
            this.paytextBox.Multiline = true;
            this.paytextBox.Name = "paytextBox";
            this.paytextBox.Size = new System.Drawing.Size(1089, 80);
            this.paytextBox.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(712, 37);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(247, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "ΠΕΛΑΤΗΣ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(242, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(869, 55);
            this.label4.TabIndex = 41;
            this.label4.Text = "ΚΑΤΑΧΩΡΗΣΗ ΝΕΑΣ ΠΑΡΑΓΓΕΛΙΑΣ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(709, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "ΣΧΕΔΙΟ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(44, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "ΠΑΡΑΓΓΕΛΙΑ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(358, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "ΗΜΕΡΟΜΗΝΙΑ :";
            // 
            // orderTextBox
            // 
            this.orderTextBox.AllowDrop = true;
            this.orderTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.orderTextBox.Location = new System.Drawing.Point(210, 357);
            this.orderTextBox.Multiline = true;
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.ReadOnly = true;
            this.orderTextBox.Size = new System.Drawing.Size(388, 39);
            this.orderTextBox.TabIndex = 32;
            this.orderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.orderTextBox_DragDrop);
            this.orderTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.orderTextBox_DragEnter);
            // 
            // sxedioTextBox
            // 
            this.sxedioTextBox.AllowDrop = true;
            this.sxedioTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sxedioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxedioTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sxedioTextBox.Location = new System.Drawing.Point(821, 357);
            this.sxedioTextBox.Multiline = true;
            this.sxedioTextBox.Name = "sxedioTextBox";
            this.sxedioTextBox.ReadOnly = true;
            this.sxedioTextBox.Size = new System.Drawing.Size(413, 39);
            this.sxedioTextBox.TabIndex = 33;
            this.sxedioTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.sxedioTextBox_DragDrop);
            this.sxedioTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.sxedioTextBox_DragEnter);
            // 
            // photoTextBox
            // 
            this.photoTextBox.AllowDrop = true;
            this.photoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.photoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.photoTextBox.Location = new System.Drawing.Point(210, 482);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(388, 39);
            this.photoTextBox.TabIndex = 35;
            this.photoTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.photoTextBox_DragDrop);
            this.photoTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.photoTextBox_DragEnter);
            // 
            // timolTextBox
            // 
            this.timolTextBox.AllowDrop = true;
            this.timolTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timolTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.timolTextBox.Location = new System.Drawing.Point(821, 482);
            this.timolTextBox.Multiline = true;
            this.timolTextBox.Name = "timolTextBox";
            this.timolTextBox.ReadOnly = true;
            this.timolTextBox.Size = new System.Drawing.Size(413, 39);
            this.timolTextBox.TabIndex = 37;
            this.timolTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.timolTextBox_DragDrop);
            this.timolTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.timolTextBox_DragEnter);
            // 
            // timolbt
            // 
            this.timolbt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timolbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timolbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timolbt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timolbt.Location = new System.Drawing.Point(1249, 481);
            this.timolbt.Name = "timolbt";
            this.timolbt.Size = new System.Drawing.Size(50, 39);
            this.timolbt.TabIndex = 49;
            this.timolbt.Text = "...";
            this.timolbt.UseVisualStyleBackColor = false;
            this.timolbt.Click += new System.EventHandler(this.timolbt_Click);
            // 
            // sxedbt
            // 
            this.sxedbt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sxedbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sxedbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxedbt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sxedbt.Location = new System.Drawing.Point(1249, 357);
            this.sxedbt.Name = "sxedbt";
            this.sxedbt.Size = new System.Drawing.Size(50, 39);
            this.sxedbt.TabIndex = 48;
            this.sxedbt.Text = "...";
            this.sxedbt.UseVisualStyleBackColor = false;
            this.sxedbt.Click += new System.EventHandler(this.sxedbt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(508, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 46);
            this.button1.TabIndex = 50;
            this.button1.Text = "Αποθήκευση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(1284, 797);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "label6";
            this.label6.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker1.Location = new System.Drawing.Point(567, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(457, 35);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // addordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1347, 826);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timolbt);
            this.Controls.Add(this.sxedbt);
            this.Controls.Add(this.photobt);
            this.Controls.Add(this.ordbt);
            this.Controls.Add(this.paytextBox);
            this.Controls.Add(label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.sxedioTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(timolLabel);
            this.Controls.Add(this.timolTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addordform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addordform";
            this.Load += new System.EventHandler(this.addordform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button photobt;
        private System.Windows.Forms.Button ordbt;
        private System.Windows.Forms.TextBox paytextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.TextBox sxedioTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox timolTextBox;
        private System.Windows.Forms.Button timolbt;
        private System.Windows.Forms.Button sxedbt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}