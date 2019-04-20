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
    /// WdLogin.xaml 的交互逻辑
    /// </summary>
    public partial class WdLogin : Window
    {
        public WdLogin()
        {
            InitializeComponent();
#if false
            Button_Click(null, null);
#endif
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var jwt = TestNetwork.Login(Tbun.Text, Pb.Password);
            if (jwt == "")
            {
                MessageBox.Show("登陆失败");
            }
            else
            {
                App.ID = jwt;
                WdMain wdMain = new WdMain();
                wdMain.Show();
                Close();
            }
        }
    }
}
