namespace VMWareSetter
{
    partial class App
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
            this.findButton = new System.Windows.Forms.Button();
            this.machinesList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.machinesPath = new System.Windows.Forms.TextBox();
            this.outp = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.propValueInp = new System.Windows.Forms.TextBox();
            this.propertiesList = new System.Windows.Forms.ListView();
            this.col0 = new System.Windows.Forms.ColumnHeader();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.findButton.Location = new System.Drawing.Point(458, 35);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(94, 29);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.OnFindPressed);
            // 
            // machinesList
            // 
            this.machinesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machinesList.FormattingEnabled = true;
            this.machinesList.Location = new System.Drawing.Point(244, 35);
            this.machinesList.Name = "machinesList";
            this.machinesList.Size = new System.Drawing.Size(193, 28);
            this.machinesList.TabIndex = 0;
            this.machinesList.SelectedIndexChanged += new System.EventHandler(this.OnMachineIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.machinesPath);
            this.groupBox1.Controls.Add(this.machinesList);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "virtual machines";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "path to virtual machines folder";
            // 
            // machinesPath
            // 
            this.machinesPath.Location = new System.Drawing.Point(16, 36);
            this.machinesPath.Name = "machinesPath";
            this.machinesPath.Size = new System.Drawing.Size(222, 27);
            this.machinesPath.TabIndex = 1;
            // 
            // outp
            // 
            this.outp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.outp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outp.ForeColor = System.Drawing.Color.Silver;
            this.outp.Location = new System.Drawing.Point(12, 495);
            this.outp.Name = "outp";
            this.outp.Size = new System.Drawing.Size(576, 79);
            this.outp.TabIndex = 3;
            this.outp.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.propValueInp);
            this.groupBox2.Controls.Add(this.propertiesList);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 314);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(16, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "property value";
            // 
            // propValueInp
            // 
            this.propValueInp.Location = new System.Drawing.Point(16, 253);
            this.propValueInp.Name = "propValueInp";
            this.propValueInp.Size = new System.Drawing.Size(222, 27);
            this.propValueInp.TabIndex = 3;
            this.propValueInp.TextChanged += new System.EventHandler(this.OnPropValueChanged);
            // 
            // propertiesList
            // 
            this.propertiesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col0,
            this.col1});
            this.propertiesList.FullRowSelect = true;
            this.propertiesList.Location = new System.Drawing.Point(16, 23);
            this.propertiesList.MultiSelect = false;
            this.propertiesList.Name = "propertiesList";
            this.propertiesList.Size = new System.Drawing.Size(542, 218);
            this.propertiesList.TabIndex = 0;
            this.propertiesList.UseCompatibleStateImageBehavior = false;
            this.propertiesList.View = System.Windows.Forms.View.Details;
            this.propertiesList.SelectedIndexChanged += new System.EventHandler(this.OnPropertySelectedChanged);
            // 
            // col0
            // 
            this.col0.Text = "Property";
            this.col0.Width = 260;
            // 
            // col1
            // 
            this.col1.Text = "Value";
            this.col1.Width = 260;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.outp);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "App";
            this.Text = "VMWare Setter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button findButton;
        private ComboBox machinesList;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox machinesPath;
        private RichTextBox outp;
        private GroupBox groupBox2;
        private ListView propertiesList;
        private ColumnHeader col0;
        private ColumnHeader col1;
        private Label label2;
        private TextBox propValueInp;
    }
}