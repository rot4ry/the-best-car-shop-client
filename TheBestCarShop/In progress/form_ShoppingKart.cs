﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestCarShop
{
    public partial class form_ShoppingKart : Form
    {
        private List<Product> _productsInKart;
        public form_ShoppingKart()
        {
            InitializeComponent();
        }
    }
}
