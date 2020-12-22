namespace OktatasNyilvantarto
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.partList = new System.Windows.Forms.ListBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.participantLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.Location = new System.Drawing.Point(12, 83);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(224, 394);
            this.nameList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // partList
            // 
            this.partList.FormattingEnabled = true;
            this.partList.Location = new System.Drawing.Point(326, 83);
            this.partList.Name = "partList";
            this.partList.Size = new System.Drawing.Size(224, 394);
            this.partList.TabIndex = 3;
            this.partList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.partList_MouseDoubleClick);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 52);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(83, 13);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Dolgozói névsor";
            // 
            // participantLbl
            // 
            this.participantLbl.AutoSize = true;
            this.participantLbl.Location = new System.Drawing.Point(323, 52);
            this.participantLbl.Name = "participantLbl";
            this.participantLbl.Size = new System.Drawing.Size(117, 13);
            this.participantLbl.TabIndex = 5;
            this.participantLbl.Text = "Oktatásban résztvevők";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.participantLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.partList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameList);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox partList;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label participantLbl;
        private System.Windows.Forms.Button button2;
    }
}