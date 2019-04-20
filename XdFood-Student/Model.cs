using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
namespace XdFood_Student
{
    public class Model
    {
        public static List<Shop> Shops = new List<Shop>() {
            new Shop(){
                Name="华莱士",
                Dishes=new List<Dish>(){ new Dish() {Name="汉堡",Introduction="好吃的", Price=10.2,IsPungent=false,Comments=new List<Comment>() { new Comment() { Content="好",User="真香"} } }, new Dish() { Name = "鸡翅", Introduction = "好吃的", Price = 20.2, IsPungent = false, Comments = new List<Comment>() { new Comment() { Content = "好", User = "真香" } } }
                }
            },
            new Shop(){
                Name="韩国烤肉",
                Dishes=new List<Dish>(){ new Dish() {Name="石锅拌饭",Introduction="好吃的", Price=10.2,IsPungent=false,Comments=new List<Comment>() { new Comment() { Content="好",User="真香"} } }, new Dish() { Name = "烤肉", Introduction = "好吃的", Price = 20.2, IsPungent = false, Comments = new List<Comment>() { new Comment() { Content = "好", User = "真香" } } }
                }
            },
        };
    }
}
