
namespace Delegates_and_Events__ICE_Task_4_
{
    partial class frmMain
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
            this.txtNumDonuts = new System.Windows.Forms.TextBox();
            this.txtNumCoffee = new System.Windows.Forms.TextBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.grpTakeAway = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.grpTakeAway.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumDonuts
            // 
            this.txtNumDonuts.Location = new System.Drawing.Point(55, 130);
            this.txtNumDonuts.Name = "txtNumDonuts";
            this.txtNumDonuts.PlaceholderText = "How many donuts would you like?";
            this.txtNumDonuts.Size = new System.Drawing.Size(207, 23);
            this.txtNumDonuts.TabIndex = 1;
            // 
            // txtNumCoffee
            // 
            this.txtNumCoffee.Location = new System.Drawing.Point(55, 193);
            this.txtNumCoffee.Name = "txtNumCoffee";
            this.txtNumCoffee.PlaceholderText = "How many cups of coffee?";
            this.txtNumCoffee.Size = new System.Drawing.Size(207, 23);
            this.txtNumCoffee.TabIndex = 2;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(106, 358);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(103, 23);
            this.btnSubmitOrder.TabIndex = 4;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // grpTakeAway
            // 
            this.grpTakeAway.Controls.Add(this.rdbNo);
            this.grpTakeAway.Controls.Add(this.rdbYes);
            this.grpTakeAway.Location = new System.Drawing.Point(55, 256);
            this.grpTakeAway.Name = "grpTakeAway";
            this.grpTakeAway.Size = new System.Drawing.Size(207, 62);
            this.grpTakeAway.TabIndex = 3;
            this.grpTakeAway.TabStop = false;
            this.grpTakeAway.Text = "Take-away?";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(113, 23);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(41, 19);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Checked = true;
            this.rdbYes.Location = new System.Drawing.Point(15, 23);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(42, 19);
            this.rdbYes.TabIndex = 0;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(55, 67);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PlaceholderText = "Customer Name";
            this.txtCustomerName.Size = new System.Drawing.Size(207, 23);
            this.txtCustomerName.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.grpTakeAway);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.txtNumCoffee);
            this.Controls.Add(this.txtNumDonuts);
            this.Name = "frmMain";
            this.Text = "The Coffee Shop";
            this.grpTakeAway.ResumeLayout(false);
            this.grpTakeAway.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumDonuts;
        private System.Windows.Forms.TextBox txtNumCoffee;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.GroupBox grpTakeAway;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}

