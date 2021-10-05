namespace GenericQueue
{
    partial class FormRij
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
            this.tbInOut = new System.Windows.Forms.TextBox();
            this.btIn = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btStringOut = new System.Windows.Forms.Button();
            this.btStringIn = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btTestOut = new System.Windows.Forms.Button();
            this.btTestIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInOut
            // 
            this.tbInOut.Location = new System.Drawing.Point(12, 47);
            this.tbInOut.Name = "tbInOut";
            this.tbInOut.Size = new System.Drawing.Size(260, 31);
            this.tbInOut.TabIndex = 0;
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(12, 147);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(112, 34);
            this.btIn.TabIndex = 1;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btOut
            // 
            this.btOut.Location = new System.Drawing.Point(12, 196);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(112, 34);
            this.btOut.TabIndex = 2;
            this.btOut.Text = "Out";
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(33, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Integers";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(181, 96);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(66, 25);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Strings";
            // 
            // btStringOut
            // 
            this.btStringOut.Location = new System.Drawing.Point(160, 196);
            this.btStringOut.Name = "btStringOut";
            this.btStringOut.Size = new System.Drawing.Size(112, 34);
            this.btStringOut.TabIndex = 5;
            this.btStringOut.Text = "Out";
            this.btStringOut.UseVisualStyleBackColor = true;
            this.btStringOut.Click += new System.EventHandler(this.btStringOut_Click);
            // 
            // btStringIn
            // 
            this.btStringIn.Location = new System.Drawing.Point(160, 147);
            this.btStringIn.Name = "btStringIn";
            this.btStringIn.Size = new System.Drawing.Size(112, 34);
            this.btStringIn.TabIndex = 4;
            this.btStringIn.Text = "In";
            this.btStringIn.UseVisualStyleBackColor = true;
            this.btStringIn.Click += new System.EventHandler(this.btStringIn_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(313, 96);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(99, 25);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "TestClasses";
            // 
            // btTestOut
            // 
            this.btTestOut.Location = new System.Drawing.Point(313, 196);
            this.btTestOut.Name = "btTestOut";
            this.btTestOut.Size = new System.Drawing.Size(112, 34);
            this.btTestOut.TabIndex = 8;
            this.btTestOut.Text = "Out";
            this.btTestOut.UseVisualStyleBackColor = true;
            this.btTestOut.Click += new System.EventHandler(this.btTestOut_Click);
            // 
            // btTestIn
            // 
            this.btTestIn.Location = new System.Drawing.Point(313, 147);
            this.btTestIn.Name = "btTestIn";
            this.btTestIn.Size = new System.Drawing.Size(112, 34);
            this.btTestIn.TabIndex = 7;
            this.btTestIn.Text = "In";
            this.btTestIn.UseVisualStyleBackColor = true;
            this.btTestIn.Click += new System.EventHandler(this.btTestClassIn_Click);
            // 
            // FormRij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 274);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.btTestOut);
            this.Controls.Add(this.btTestIn);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btStringOut);
            this.Controls.Add(this.btStringIn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.tbInOut);
            this.Name = "FormRij";
            this.Text = "Rij";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInOut;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btStringOut;
        private System.Windows.Forms.Button btStringIn;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button btTestOut;
        private System.Windows.Forms.Button btTestIn;
    }
}