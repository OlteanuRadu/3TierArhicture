using DataAccesLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class UsersBLL<T> where T : User
    {
        public UsersBLL()
        {

        }
        [Dependency]
        public UserRepository<T> UserRepository { get; set; }
        public IEnumerable<T> SomeBLMethod()
        {
           return this.UserRepository.GetAllUsers().Take(10);
        }
    }
}
