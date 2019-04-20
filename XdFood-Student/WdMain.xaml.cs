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
            SelectVisibileGrid(GdBigMap);
            SetDgShop("黄焖鸡米饭");
            SetGdRecommand();
            SetGdDishes();
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
        private void SetGdDishes()
        {
            List<DgDish> dishes = new List<DgDish>();
            foreach (var shop in Model.Shops)
            {
                foreach (var dish in shop.Dishes)
                {
                    if (TbSearch.Text == "" || dish.Name.Contains(TbSearch.Text) || shop.Name.Contains(TbSearch.Text))
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
            }
            Console.WriteLine();
            DgDishes.ItemsSource = dishes;
        }
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
            public string ShopName { get; set; } = "";
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

        private void ImgBigMap_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var i = Mouse.GetPosition(ImgBigMap);
            var x = i.X / ImgBigMap.ActualWidth;
            var y = i.Y / ImgBigMap.ActualHeight;
            if (x >= 0.4 && x <= 0.48 && y >= 0.03 && y <= 0.38)
            {
                Console.WriteLine("新综");
            }
            else if (x >= 0.55 && x <= 0.60 && y >= 0.02 && y <= 0.36)
            {
                Console.WriteLine("老综");
            }
            else if (x >= 0.16 && x <= 0.28 && y >= 0.08 && y <= 0.23)
            {
                Console.WriteLine("海棠");
            }
            else if (x >= 0.2 && x <= 0.4 && y >= 0.42 && y <= 0.66)
            {
                Console.WriteLine("图书馆");
            }
            else if (x >= 0.07 && x <= 0.16 && y >= 0.62 && y <= 0.79)
            {
                Console.WriteLine("丁香");
            }
            else if (x >= 0.7 && x <= 0.89 && y >= 0.09 && y <= 0.35)
            {
                Console.WriteLine("竹园");
            }
            else if (x >= 0.47 && x <= 0.64 && y >= 0.47 && y <= 0.66)
            {
                Console.WriteLine("E楼");
            }
            SelectVisibileGrid(GdMiniMap);
            Cursor = Cursors.Arrow;
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            SetGdDishes();
        }

        private void ImgBigMap_MouseMove(object sender, MouseEventArgs e)
        {
            var i = Mouse.GetPosition(ImgBigMap);
            var x = i.X / ImgBigMap.ActualWidth;
            var y = i.Y / ImgBigMap.ActualHeight;
            bool b = false;
            if (x >= 0.4 && x <= 0.48 && y >= 0.03 && y <= 0.38)
            {
                b = true;
            }
            else if (x >= 0.55 && x <= 0.60 && y >= 0.02 && y <= 0.36)
            {
                b = true;
            }
            else if (x >= 0.16 && x <= 0.28 && y >= 0.08 && y <= 0.23)
            {
                b = true;
            }
            else if (x >= 0.2 && x <= 0.4 && y >= 0.42 && y <= 0.66)
            {
                b = true;
            }
            else if (x >= 0.07 && x <= 0.16 && y >= 0.62 && y <= 0.79)
            {
                b = true;
            }
            else if (x >= 0.7 && x <= 0.89 && y >= 0.09 && y <= 0.35)
            {
                b = true;
            }
            else if (x >= 0.47 && x <= 0.64 && y >= 0.47 && y <= 0.66)
            {
                b = true;
            }
            Cursor = b ? Cursors.Hand : Cursors.Arrow;
        }

        private void ImgMiniMap_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var i = Mouse.GetPosition(ImgMiniMap);
            var x = i.X / ImgMiniMap.ActualWidth;
            var y = i.Y / ImgMiniMap.ActualHeight;
            Console.WriteLine(x); Console.WriteLine(y);
            bool b = false;
            if (x >= 0.35 && x <= 0.65 && y >= 0.68 && y <= 0.81)
            {
                b = true;
            }
            else if (x >= 0.26 && x <= 0.35 && y >= 0.37 && y <= 0.7)
            {
                b = true;
            }
            else if (x >= 0.64 && x <= 0.71 && x >= 0.51 && x <= 0.6)
            {
                b = true;
            }
            if (b)
            {
                SelectVisibileGrid(GdShop);
                Cursor = Cursors.Arrow;
            }
        }

        private void ImgMiniMap_MouseMove(object sender, MouseEventArgs e)
        {
            var i = Mouse.GetPosition(ImgMiniMap);
            var x = i.X / ImgMiniMap.ActualWidth;
            var y = i.Y / ImgMiniMap.ActualHeight;
            bool b = false;
            if (x >= 0.35 && x <= 0.65 && y >= 0.68 && y <= 0.81)
            {
                b = true;
            }
            else if (x >= 0.26 && x <= 0.35 && y >= 0.37 && y <= 0.7)
            {
                b = true;
            }
            else if (x >= 0.64 && x <= 0.71 && x >= 0.51 && x <= 0.6)
            {
                b = true;
            }
            Cursor = b ? Cursors.Hand : Cursors.Arrow;
        }
    }
}
