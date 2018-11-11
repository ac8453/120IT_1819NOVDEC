namespace CodePortfolioStreamWriterReader
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
            this.tbTest = new System.Windows.Forms.TextBox();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.lbRetrieved = new System.Windows.Forms.Label();
            this.btStore = new System.Windows.Forms.Button();
            this.btRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(15, 25);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(699, 20);
            this.tbTest.TabIndex = 0;
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Location = new System.Drawing.Point(12, 9);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(702, 13);
            this.lbInstructions.TabIndex = 1;
            this.lbInstructions.Text = "Enter text into the box below and press \"Store\", on restarting the application pr" +
    "ess \"Retrieve\" - this will set the label (\"lbRetrieved\") to the stored text";
            // 
            // lbRetrieved
            // 
            this.lbRetrieved.AutoSize = true;
            this.lbRetrieved.Location = new System.Drawing.Point(12, 92);
            this.lbRetrieved.Name = "lbRetrieved";
            this.lbRetrieved.Size = new System.Drawing.Size(35, 13);
            this.lbRetrieved.TabIndex = 2;
            this.lbRetrieved.Text = "label2";
            // 
            // btStore
            // 
            this.btStore.Location = new System.Drawing.Point(15, 51);
            this.btStore.Name = "btStore";
            this.btStore.Size = new System.Drawing.Size(353, 23);
            this.btStore.TabIndex = 3;
            this.btStore.Text = "Store";
            this.btStore.UseVisualStyleBackColor = true;
            // 
            // btRetrieve
            // 
            this.btRetrieve.Location = new System.Drawing.Point(374, 51);
            this.btRetrieve.Name = "btRetrieve";
            this.btRetrieve.Size = new System.Drawing.Size(340, 23);
            this.btRetrieve.TabIndex = 4;
            this.btRetrieve.Text = "Retrieve";
            this.btRetrieve.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 125);
            this.Controls.Add(this.btRetrieve);
            this.Controls.Add(this.btStore);
            this.Controls.Add(this.lbRetrieved);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.tbTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Label lbRetrieved;
        private System.Windows.Forms.Button btStore;
        private System.Windows.Forms.Button btRetrieve;
    }
}

