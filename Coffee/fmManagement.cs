﻿using DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Coffee
{
    public partial class fmManagement : Form
    {
        BindingSource listBill = new BindingSource();
        BindingSource listCategory = new BindingSource();
        BindingSource listFood = new BindingSource();
        BindingSource listTable = new BindingSource();

        public fmManagement()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0: Tab0(); break;
                case 1: Tab1(); break;
                case 2: Tab2(); break;
              
                case 4: Tab4(); break;
            }
            try { AddBindingData(); } catch (Exception) { }
        }

        #region Methods
        

        

        private void AddBindingData()
        {
            dtgvCategory.DataSource = CategoryDAO.Instance.LoadCategory();
            dtgvFood.DataSource = FoodDAO.Instance.LoadFood();

            txbCateID.DataBindings.Clear();
            txbCateName.DataBindings.Clear();

            txbCateID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCateName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Tên", true, DataSourceUpdateMode.Never));

            txbFoodID.DataBindings.Clear();
            txbFoodName.DataBindings.Clear();
            cbbFoodCate.DataBindings.Clear();
            nbuFoodPrice.DataBindings.Clear();

            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            cbbFoodCate.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Danh mục", true, DataSourceUpdateMode.Never));
            nbuFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Giá", true, DataSourceUpdateMode.Never));

            dtgvCategory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCategory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtgvFood.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvFood.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvFood.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvFood.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

        #region Events
      

      

        //Báo cáo
     
     
        //Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvFood.DataSource = FoodDAO.Instance.SearchFoodByName(txbSearch.Text);
        }
        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtgvFood.DataSource = FoodDAO.Instance.SearchFoodByName(txbSearch.Text);

            txbFoodID.DataBindings.Clear();
            txbFoodName.DataBindings.Clear();
            cbbFoodCate.DataBindings.Clear();
            nbuFoodPrice.DataBindings.Clear();

            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            cbbFoodCate.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Danh mục", true, DataSourceUpdateMode.Never));
            nbuFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Giá", true, DataSourceUpdateMode.Never));
        }
        

        //Disable textbox
        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCateID.Enabled = false;
            txbCateName.Enabled = false;
        }
        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbFoodID.Enabled = false;
            txbFoodName.Enabled = false;
            cbbFoodCate.Enabled = false;
            nbuFoodPrice.Enabled = false;
        }
        #endregion

        //Category
        private void btnCateAdd_Click(object sender, EventArgs e)
        {
            if (txbCateID.Enabled == false && txbCateName.Enabled == false)
            {
                txbCateName.Enabled = true;
                return;
            }
            else
            {
                CategoryDAO.Instance.AddCategory(txbCateName.Text);
                txbCateID.Enabled = false;
                txbCateName.Enabled = false;
                MessageBox.Show("Thêm thành công !", "Thông báo !");
                Tab1();
            }
        }
        private void btnCateEdit_Click(object sender, EventArgs e)
        {
            if (txbCateID.Enabled == false && txbCateName.Enabled == false)
            {
                txbCateName.Enabled = true;
                return;
            }
            else
            {
                CategoryDAO.Instance.EditCategory(Convert.ToInt32(txbCateID.Text), txbCateName.Text);
                txbCateID.Enabled = false;
                txbCateName.Enabled = false;
                MessageBox.Show("Sửa thành công !", "Thông báo !");
                Tab1();
            }
        }
        private void btnCateDel_Click(object sender, EventArgs e)
        {
            if (txbCateID.Enabled == false && txbCateName.Enabled == false)
                if (MessageBox.Show("Bạn có chắc xóa danh mục " + txbCateName.Text, "Xác nhận xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        CategoryDAO.Instance.DeleteCategory(Convert.ToInt32(txbCateID.Text));
                        txbCateID.Enabled = false;
                        txbCateName.Enabled = false;
                        MessageBox.Show("Xóa thành công !", "Thông báo !");
                        Tab1();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa danh mục này. \nLý do: Còn tồn tại thức ăn thuộc danh mục này.", "Lỗi");
                    }
                }
        }
        //Food
        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            if (txbFoodID.Enabled == false && txbFoodName.Enabled == false && cbbFoodCate.Enabled == false && nbuFoodPrice.Enabled == false)
            {
                txbFoodName.Enabled = true;
                nbuFoodPrice.Enabled = true;

                cbbFoodCate.Enabled = true;
                cbbFoodCate.DataSource = CategoryDAO.Instance.GetListCategory();
                cbbFoodCate.DisplayMember = "name";
                return;
            }
            else
            {
                FoodDAO.Instance.InsertFood(txbFoodName.Text, cbbFoodCate.Text, Convert.ToInt32(nbuFoodPrice.Text));
                txbFoodID.Enabled = false;
                txbFoodName.Enabled = false;
                cbbFoodCate.Enabled = false;
                nbuFoodPrice.Enabled = false;
                MessageBox.Show("Thêm thành công !", "Thông báo !");
                Tab1();
            }
        }
        private void btnFoodEdit_Click(object sender, EventArgs e)
        {
            if (txbFoodID.Enabled == false && txbFoodName.Enabled == false && cbbFoodCate.Enabled == false && nbuFoodPrice.Enabled == false)
            {
                txbFoodName.Enabled = true;
                nbuFoodPrice.Enabled = true;

                cbbFoodCate.Enabled = true;
                cbbFoodCate.DataSource = CategoryDAO.Instance.GetListCategory();
                cbbFoodCate.DisplayMember = "name";
                return;
            }
            else
            {
                FoodDAO.Instance.UpdateFood(txbFoodName.Text, cbbFoodCate.Text, Convert.ToInt32(nbuFoodPrice.Text), Convert.ToInt32(txbFoodID.Text));
                txbFoodID.Enabled = false;
                txbFoodName.Enabled = false;
                cbbFoodCate.Enabled = false;
                nbuFoodPrice.Enabled = false;
                MessageBox.Show("Sửa thành công !", "Thông báo !");
                Tab1();
            }
        }
        private void btnFoodDel_Click(object sender, EventArgs e)
        {
            if (txbFoodID.Enabled == false && txbFoodName.Enabled == false && cbbFoodCate.Enabled == false && nbuFoodPrice.Enabled == false)
                if (MessageBox.Show("Bạn có chắc xóa món " + txbFoodName.Text, "Xác nhận xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        FoodDAO.Instance.DeleteFood(Convert.ToInt32(txbFoodID.Text));
                        txbFoodID.Enabled = false;
                        txbFoodName.Enabled = false;
                        cbbFoodCate.Enabled = false;
                        nbuFoodPrice.Enabled = false;
                        MessageBox.Show("Xóa thành công !", "Thông báo !");
                        Tab1();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra !", "Lỗi");
                    }
                }
        }

        //Table
        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            if (txbTableID.Enabled == false && txbTableName.Enabled == false && txbTableStatus.Enabled == false)
            {
                txbTableName.Enabled = true;
                txbTableStatus.Enabled = true;
            }
            else
            {
                TableDAO.Instance.AddTable(txbTableName.Text, txbTableStatus.Text);
                txbTableName.Enabled = false;
                txbTableStatus.Enabled = false;
                Tab2();
            }
        }
        private void btnTableEdit_Click(object sender, EventArgs e)
        {
            if (txbTableID.Enabled == false && txbTableName.Enabled == false && txbTableStatus.Enabled == false)
            {
                txbTableName.Enabled = true;
                txbTableStatus.Enabled = true;
            }
            else
            {
                try {
                    TableDAO.Instance.UpdateTable(Convert.ToInt32(txbTableID.Text), txbTableName.Text, txbTableStatus.Text);
                    txbTableName.Enabled = false;
                    txbTableStatus.Enabled = false;
                    Tab2();
                    MessageBox.Show("Sửa bàn thành công !!! ", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Tên bàn bị trùng", "Lỗi");
                }

            }
        }
        private void btnTableDel_Click(object sender, EventArgs e)
        {
            if (txbTableID.Enabled == false && txbTableName.Enabled == false && txbTableStatus.Enabled == false)
                if (MessageBox.Show("Bạn có chắc xóa bàn " + txbTableName.Text, "Xác nhận xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        TableDAO.Instance.DeleteTable(Convert.ToInt32(txbTableID.Text));
                        txbTableName.Enabled = false;
                        txbTableStatus.Enabled = false;
                        MessageBox.Show("Xóa thành công !", "Thông báo !");
                        Tab2();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra !", "Lỗi");
                    }
                }
        }

        #region Tab Controls
        void Tab0() { }
        void Tab1()
        {
            dtgvCategory.DataSource = CategoryDAO.Instance.LoadCategory();
            dtgvFood.DataSource = FoodDAO.Instance.LoadFood();
            AddBindingData();
        }
        void Tab2()
        {
            try
            {
                dtgvTable.DataSource = TableDAO.Instance.LoadTable();
                dtgvTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgvTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgvTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                txbTableID.DataBindings.Clear();
                txbTableName.DataBindings.Clear();
                txbTableStatus.DataBindings.Clear();

                txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
                txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Tên bàn", true, DataSourceUpdateMode.Never));
                txbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
      
        void Tab4() { }
        #endregion

     

        private void lsvFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}