namespace Prog4
{
    partial class Prog4
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
            this.originLabel = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.toULBtn = new System.Windows.Forms.Button();
            this.fromULBtn = new System.Windows.Forms.Button();
            this.packageLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(2, 28);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(83, 13);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Zip Code:";
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(123, 25);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(100, 20);
            this.originTextBox.TabIndex = 1;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(2, 58);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(109, 13);
            this.destinationLabel.TabIndex = 2;
            this.destinationLabel.Text = "Destination Zip Code:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(123, 55);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationTextBox.TabIndex = 3;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(2, 87);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(88, 13);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length in inches:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(123, 84);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 5;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(2, 114);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(83, 13);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width in inches:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(123, 111);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 7;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(2, 140);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(86, 13);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height in inches:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(123, 137);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(2, 168);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(93, 13);
            this.weightLabel.TabIndex = 10;
            this.weightLabel.Text = "Weight in pounds:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(123, 165);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(69, 197);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(257, 36);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(119, 134);
            this.packageListBox.TabIndex = 13;
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(382, 39);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(75, 23);
            this.detailsBtn.TabIndex = 14;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // toULBtn
            // 
            this.toULBtn.Location = new System.Drawing.Point(382, 90);
            this.toULBtn.Name = "toULBtn";
            this.toULBtn.Size = new System.Drawing.Size(75, 23);
            this.toULBtn.TabIndex = 15;
            this.toULBtn.Text = "To UofL";
            this.toULBtn.UseVisualStyleBackColor = true;
            this.toULBtn.Click += new System.EventHandler(this.toULBtn_Click);
            // 
            // fromULBtn
            // 
            this.fromULBtn.Location = new System.Drawing.Point(382, 144);
            this.fromULBtn.Name = "fromULBtn";
            this.fromULBtn.Size = new System.Drawing.Size(75, 23);
            this.fromULBtn.TabIndex = 16;
            this.fromULBtn.Text = "From UofL";
            this.fromULBtn.UseVisualStyleBackColor = true;
            this.fromULBtn.Click += new System.EventHandler(this.fromULBtn_Click);
            // 
            // packageLabel
            // 
            this.packageLabel.AutoSize = true;
            this.packageLabel.Location = new System.Drawing.Point(254, 13);
            this.packageLabel.Name = "packageLabel";
            this.packageLabel.Size = new System.Drawing.Size(127, 13);
            this.packageLabel.TabIndex = 17;
            this.packageLabel.Text = "Please Select a Package";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(66, 9);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(104, 13);
            this.detailLabel.TabIndex = 18;
            this.detailLabel.Text = "Enter Package Data";
            // 
            // Prog4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 226);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.packageLabel);
            this.Controls.Add(this.fromULBtn);
            this.Controls.Add(this.toULBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.originLabel);
            this.Name = "Prog4";
            this.Text = "Prog 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button toULBtn;
        private System.Windows.Forms.Button fromULBtn;
        private System.Windows.Forms.Label packageLabel;
        private System.Windows.Forms.Label detailLabel;
    }
}

