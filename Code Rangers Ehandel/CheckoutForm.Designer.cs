
namespace Code_Rangers_Ehandel
{
    partial class CheckoutForm
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
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnSwish = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreditCard.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnCreditCard.ForeColor = System.Drawing.Color.Honeydew;
            this.btnCreditCard.Location = new System.Drawing.Point(91, 168);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(81, 30);
            this.btnCreditCard.TabIndex = 31;
            this.btnCreditCard.Text = "Credit card";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnSwish
            // 
            this.btnSwish.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSwish.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnSwish.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSwish.Location = new System.Drawing.Point(91, 242);
            this.btnSwish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSwish.Name = "btnSwish";
            this.btnSwish.Size = new System.Drawing.Size(81, 30);
            this.btnSwish.TabIndex = 32;
            this.btnSwish.Text = "Swish";
            this.btnSwish.UseVisualStyleBackColor = false;
            this.btnSwish.Click += new System.EventHandler(this.btnSwish_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInvoice.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnInvoice.ForeColor = System.Drawing.Color.Honeydew;
            this.btnInvoice.Location = new System.Drawing.Point(91, 316);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(81, 30);
            this.btnInvoice.TabIndex = 33;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "How do you want to pay?";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(265, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnSwish);
            this.Controls.Add(this.btnCreditCard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnSwish;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label label1;
    }
}