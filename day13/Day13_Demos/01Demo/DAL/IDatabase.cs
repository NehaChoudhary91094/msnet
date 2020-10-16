using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Demo.POCO;

namespace _01Demo.DAL
{
   public interface IDatabase
    {
        List<Emp> Select();
        int Insert(Emp emp);
        int Update(Emp emp);
        int Delete(Emp emp);

    }
}
