﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    public partial class CheckoutForm : Form
    {
        private PaymentContext paymentContext;
        public CheckoutForm()
        {
            InitializeComponent();
            paymentContext = new PaymentContext();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            paymentContext.Pay(new CreditCard());
        }

        private void btnSwish_Click(object sender, EventArgs e)
        {
            paymentContext.Pay(new Swish());
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            paymentContext.Pay(new Invoice());

        }
    }
}
