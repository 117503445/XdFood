using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
namespace XdFood_Server
{
    public class Model
    {
        public static List<Shop> Shops = new List<Shop>() {
            new Shop(){
                Name="华莱士",
                Dishes=new List<Dish>(){ new Dish() {Name="汉堡",Introduction="好吃的", Price=10.2,IsPungent=false,Comments=new List<Comment>() { new Comment() { Content="好",UserName="真香"} } }, new Dish() { Name = "鸡翅", Introduction = "好吃的", Price = 20.2, IsPungent = false, Comments = new List<Comment>() { new Comment() { Content = "好", UserName = "真香" } } }
                }
            },
            new Shop(){
                Name="韩国烤肉",
                Dishes=new List<Dish>(){ new Dish() {Name="石锅拌饭",Introduction="好吃的", Price=10.2,IsPungent=false,Comments=new List<Comment>() { new Comment() { Content="好",UserName="真香"} } }, new Dish() { Name = "烤肉", Introduction = "好吃的", Price = 20.2, IsPungent = false, Comments = new List<Comment>() { new Comment() { Content = "好", UserName = "真香" } } }
                }
            },
            new Shop(){
                Name="黄焖鸡米饭",
                Dishes=new List<Dish>(){ new Dish() {Name="小米饭",Introduction="小米做的饭", Price=10.2,IsPungent=false,Comments=new List<Comment>() { new Comment() { Content="好",UserName="真香"} } }, new Dish() { Name = "烤肉", Introduction = "好吃的", Price = 20.2, IsPungent = false, Comments = new List<Comment>() { new Comment() { Content = "好", UserName = "真香" } } }
                },
                Comments=new List<Comment>(){
                   new Comment(){  Content = "好", UserName = "小王"}
                }
            },
            new Shop(){
                Name="港式叉烧饭",
                Dishes=new List<Dish>(){ new Dish() {Name="五花肉叉烧饭",Introduction="叉烧甜滋滋", Price=14,IsPungent=false,Comments=new List<Comment>() { new Comment() { Content="美味！！！",UserName="齐浩天"} } }, new Dish() { Name = "白切鸡", Introduction = "鸡肉是白的", Price = 12, IsPungent =true , Comments = new List<Comment>() { new Comment() { Content = "的确很好吃", UserName = "罗肖怡" }, new Comment() { Content = "和我家乡的一样", UserName = "李二蛋" } } }
                },
                Comments=new List<Comment>(){
                   new Comment(){  Content = "这家店还行", UserName = "小明"},
                   new Comment(){  Content = "有点贵", UserName = "老徐"}
                }
            },
            new Shop(){
                Name="蒙古烤肉饭",
                Dishes=new List<Dish>(){ new Dish() {Name="三菜加烤肉",Introduction="烤肉很独特",Price=14,IsPungent= false,Comments=new List<Comment>() { new Comment() {Content="饭太少了",UserName="小璇"} } },new Dish() {Name = "三菜加鸡排", Introduction = "有鸡排",Price = 8,IsPungent = false,Comments = new List<Comment>() { new Comment() {Content = "菜不好吃", UserName = "小丽" }, new Comment() { Content ="很暖胃", UserName = "小周" } } }
                },
                Comments=new List<Comment>(){
                   new Comment(){  Content = "很暖胃", UserName = "小周"},
                   new Comment(){  Content = "很便宜", UserName = "张老师"}
                }
            },
            new Shop(){
                Name="吉品轩",
                Dishes=new List<Dish>(){ new Dish() {Name="水饺",Introduction="皮薄馅大,一咬流汁", Price=15.00,IsPungent=true,Comments=new List<Comment>() { new Comment() { Content="物超所值,人间美味",UserName="猪猪和蛛蛛"} } }, new Dish() { Name = "平泉羊汤", Introduction = "御用上品,鲜美馋人", Price = 20, IsPungent = false, Comments = new List<Comment>() { new Comment() { Content = "膻的很,不爱喝", UserName = "天天吃羊灰太狼" }, new Comment() { Content = "地道,这是家乡的味道,强烈推荐大家来尝一尝", UserName = "打灰太狼的喜羊羊" } } }
                },
                Comments=new List<Comment>(){
                   new Comment(){  Content = "物美价廉,老板和蔼漂亮,来的人超级多,吃饭可热闹哩", UserName = "吃饭睡觉打豆豆"},
                   new Comment(){  Content = "味道不错,卫生也很好,就是吃饭排队,人太多,尤其热的时候,粘乎乎的恶心死", UserName = "能下蛋大公鸡"}
                }
            },
            new Shop(){
                Name="风味快餐",
                Dishes=new List<Dish>(){ new Dish() {Name="三菜加鸡排",Introduction="有鸡排", Price=8,IsPungent= true,Comments=new List<Comment>() { new Comment() {Content="菜不好吃",UserName="小丽"} } }, new Dish() {Name = "紫薯粥", Introduction = "喝粥很健康", Price = 5,IsPungent = false,Comments = new List<Comment>() { new Comment() {Content = "很暖胃", UserName = "小周" }, new Comment() { Content ="很便宜", UserName = "张老师" } } }
               },
                Comments=new List<Comment>(){
                   new Comment(){  Content = "很暖胃", UserName = "小周"},
                   new Comment(){  Content = "菜品丰富", UserName = "王老师"}
                 }
        },
    };
    }
}