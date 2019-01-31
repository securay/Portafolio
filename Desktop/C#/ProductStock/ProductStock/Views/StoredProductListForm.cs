﻿using DataAccess;
using Entity;
using ProductStock.CustomControls;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductStock.Views
{
    public partial class StoredProductListForm : ListForm
    {
        private Context Context;
        private StoreRepository StoreRepository;
        private ProductRepository ProductRepository;
        private StoredProductRepository StoredProductRepository;

        public StoredProductListForm(Context Context)
        {
            InitializeComponent();

            this.Context = Context;

            Init();
        }

        private void Init()
        {
            StoreRepository = new StoreRepository(Context);
            ProductRepository = new ProductRepository(Context);
            StoredProductRepository = new StoredProductRepository(Context);

            StoreComboBox.Visible = true;
            StoreComboBox.ComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            LoadStores(StoreRepository);

            AddButton.Click += AddButton_Click;

            LoadStoredProducts();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(new StoredProductForm(Context).ShowDialog() == DialogResult.OK)
            {
                LoadStoredProducts();
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStoredProducts();
        }

        private void LoadStoredProducts()
        {
            if (StoreComboBox.ComboBox.SelectedItem != null)
            {
                Grid.DataSource = StoredProductRepository.GetByStoreAndName(StoreComboBox.ComboBox.SelectedItem as Store, "").ToList();

                HideAuditColumns();
            }
        }
    }
}
