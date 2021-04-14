using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBookOnline.Models;

namespace WebAppBookOnline.Interface
{
    public interface IRepository
    {
        public HashSet<book> Books { get; set; }
        public book Get(int id);
        public bool Delete(int id);
    }
}