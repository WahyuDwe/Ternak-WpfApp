﻿using System.Collections.Generic;
using System.Windows.Controls;
using Final_Project_Pemrograman_Lanjut.controller;
using Final_Project_Pemrograman_Lanjut.model;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class ChickenPage : Page
    {
        private ProdukControllerChicken _controller;
        public ChickenPage()
        {
            _controller = new ProdukControllerChicken(this);
            InitializeComponent();
            var product = GetProduct();
            if (product.Count > 0)
            {
                ListViewProducts.ItemsSource = product;
            }
        }

        private List<DataProduct> GetProduct()
        {
            return _controller.ShowProductChicken();
        }
    }
}