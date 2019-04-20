using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace XdFood_Student
{
    /// <summary>
    /// WdMain.xaml 的交互逻辑
    /// </summary>
    public partial class WdMain : Window
    {
        List<Grid> grids;
        public WdMain()
        {
            InitializeComponent();
            grids = new List<Grid>() { GdBigMap, GdMiniMap, GdShop, GdDish, GdRecommand };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SelectVisibileGrid(GdShop);
            SetDgShop("黄焖鸡米饭");
            SetGdRecommand();
        }
        #region 右上角按钮
        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnMax_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                BtnMax.Content = "\xE922";
                WindowState = WindowState.Normal;
            }
            else
            {
                BtnMax.Content = "\xE923";
                WindowState = WindowState.Maximized;
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion
        #region 顶部按钮
        private void BtnMap_Click(object sender, RoutedEventArgs e)
        {
            SelectVisibileGrid(GdBigMap);
        }

        private void BtnDish_Click(object sender, RoutedEventArgs e)
        {
            SelectVisibileGrid(GdDish);
        }

        private void BtnRecommand_Click(object sender, RoutedEventArgs e)
        {
            SelectVisibileGrid(GdRecommand);

        }
        #endregion

        private void SelectVisibileGrid(Grid g)
        {
            foreach (var grid in grids)
            {
                if (grid == g)
                {
                    grid.Visibility = Visibility.Visible;
                }
                else
                {
                    grid.Visibility = Visibility.Collapsed;
                }
            }
        }
        private void SetDgShop(string shopName)
        {
            foreach (var shop in Model.Shops)
            {
                if (shop.Name == shopName)
                {
                    DgShop.ItemsSource = shop.Dishes;
                    DgShopComments.ItemsSource = shop.Comments;
                }
            }
        }
        private void SetGdRecommand()
        {
            List<DgDish> dishes = new List<DgDish>();
            foreach (var shop in Model.Shops)
            {
                foreach (var dish in shop.Dishes)
                {
                    dishes.Add(new DgDish()
                    {
                        Name = dish.Name,
                        Price = dish.Price,
                        IsPungent = dish.IsPungent,
                        Comment = dish.Comments.OrderByDescending(s => s.StarNum).FirstOrDefault().Content,
                        Introduction = dish.Introduction,
                        ShopName = shop.Name
                    });
                }
            }
            Console.WriteLine();
            DgRecommand.ItemsSource = dishes;
        }
        public class DgDish
        {
            public string ShopName  { get; set; } = "";
            public string Name { get; set; } = "";
            public double Price { get; set; } = 0;
            /// <summary>
            /// 辣不辣
            /// </summary>
            public bool IsPungent { get; set; } = false;
            public string Comment { get; set; }
            /// <summary>
            /// 介绍
            /// </summary>
            public string Introduction { get; set; }
        }
    }
}
