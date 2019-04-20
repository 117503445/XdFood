using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XdFood_Student
{
    public class Shop
    {
        /// <summary>
        /// 店名
        /// </summary>
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
