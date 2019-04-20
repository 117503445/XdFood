using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XdFood_Server
{
    public class Dish
    {
        public string Name { get; set; } = "";
        public double Price { get; set; } = 0;
        /// <summary>
        /// 辣不辣
        /// </summary>
        public bool IsPungent { get; set; } = false;
        public List<Comment> Comments { get; set; }
        /// <summary>
        /// 介绍
        /// </summary>
        public string Introduction { get; set; }
    }
}
