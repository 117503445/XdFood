using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
namespace XdFood_Student
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static string ID { get; set; } = "";

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //string s=JsonConvert.SerializeObject(Model.Shops);
            //Model.Shops = JsonConvert.DeserializeObject<List<Shop>>(s);
        }
    }
}
