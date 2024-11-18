namespace _10._1_Serialization
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
            btnJSONSerialize = new Button();
            lblId = new Label();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            lblFname = new Label();
            lblLname = new Label();
            lblMembership = new Label();
            txtMembership = new TextBox();
            btnJSONDeserialize = new Button();
            btnXMLDeserialize = new Button();
            btnXMLSerialize = new Button();
            btnCreate = new Button();
            btnAddtoList = new Button();
            SuspendLayout();
            // 
            // btnJSONSerialize
            // 
            btnJSONSerialize.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnJSONSerialize.Location = new Point(124, 317);
            btnJSONSerialize.Name = "btnJSONSerialize";
            btnJSONSerialize.Size = new Size(110, 23);
            btnJSONSerialize.TabIndex = 0;
            btnJSONSerialize.Text = "JSON Serialize";
            btnJSONSerialize.UseVisualStyleBackColor = true;
            btnJSONSerialize.Click += btnJSONSerialize_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(153, 57);
            lblId.Name = "lblId";
            lblId.Size = new Size(75, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Customer Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(295, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(295, 117);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(100, 23);
            txtFname.TabIndex = 3;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(295, 168);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(100, 23);
            txtLname.TabIndex = 4;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFname.Location = new Point(167, 117);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(67, 15);
            lblFname.TabIndex = 5;
            lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLname.Location = new Point(153, 171);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(65, 15);
            lblLname.TabIndex = 6;
            lblLname.Text = "Last Name";
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMembership.Location = new Point(153, 220);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(77, 15);
            lblMembership.TabIndex = 8;
            lblMembership.Text = "Membership";
            // 
            // txtMembership
            // 
            txtMembership.Location = new Point(295, 217);
            txtMembership.Name = "txtMembership";
            txtMembership.Size = new Size(100, 23);
            txtMembership.TabIndex = 7;
            // 
            // btnJSONDeserialize
            // 
            btnJSONDeserialize.BackColor = SystemColors.ControlLight;
            btnJSONDeserialize.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnJSONDeserialize.Location = new Point(124, 373);
            btnJSONDeserialize.Name = "btnJSONDeserialize";
            btnJSONDeserialize.Size = new Size(110, 23);
            btnJSONDeserialize.TabIndex = 9;
            btnJSONDeserialize.Text = "JSON Deserialize";
            btnJSONDeserialize.UseVisualStyleBackColor = false;
            btnJSONDeserialize.Click += btnJSONDeserialize_Click;
            // 
            // btnXMLDeserialize
            // 
            btnXMLDeserialize.BackColor = SystemColors.ControlLight;
            btnXMLDeserialize.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXMLDeserialize.Location = new Point(291, 373);
            btnXMLDeserialize.Name = "btnXMLDeserialize";
            btnXMLDeserialize.Size = new Size(110, 23);
            btnXMLDeserialize.TabIndex = 11;
            btnXMLDeserialize.Text = "XML Deserialize";
            btnXMLDeserialize.UseVisualStyleBackColor = false;
            btnXMLDeserialize.Click += btnXMLDeserialize_Click;
            // 
            // btnXMLSerialize
            // 
            btnXMLSerialize.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXMLSerialize.Location = new Point(291, 317);
            btnXMLSerialize.Name = "btnXMLSerialize";
            btnXMLSerialize.Size = new Size(110, 23);
            btnXMLSerialize.TabIndex = 10;
            btnXMLSerialize.Text = "XML Serialize";
            btnXMLSerialize.UseVisualStyleBackColor = true;
            btnXMLSerialize.Click += btnXMLSerialize_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(239, 260);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnAddtoList
            // 
            btnAddtoList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoList.Location = new Point(365, 260);
            btnAddtoList.Name = "btnAddtoList";
            btnAddtoList.Size = new Size(75, 23);
            btnAddtoList.TabIndex = 13;
            btnAddtoList.Text = "Add";
            btnAddtoList.UseVisualStyleBackColor = true;
            btnAddtoList.Click += btnAddtoList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddtoList);
            Controls.Add(btnCreate);
            Controls.Add(btnXMLDeserialize);
            Controls.Add(btnXMLSerialize);
            Controls.Add(btnJSONDeserialize);
            Controls.Add(lblMembership);
            Controls.Add(txtMembership);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnJSONSerialize);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJSONSerialize;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private Label lblFname;
        private Label lblLname;
        private Label lblMembership;
        private TextBox txtMembership;
        private Button btnJSONDeserialize;
        private Button btnXMLDeserialize;
        private Button btnXMLSerialize;
        private Button btnCreate;
        private Button btnAddtoList;
    }
}
