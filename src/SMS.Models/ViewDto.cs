using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class ViewDto<T>
    {
        public List<object> Columns { get; set; }
        public T Data { get; set; }
        //public T SearchData { get; set; }
        public List<T> ListData { get; set; }
    }
}
