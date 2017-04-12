using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class UserRepository<T> : IUserRepository<T> where T : User
    {
        public UserRepository()
        {

        }
        public IEnumerable<T> GetAllUsers()
        {
            return Enumerable.Range(0, 1000).Select(_ => ReflectionUtils.ObjectInitializer<T>(u => {
                u.FirstName = "".GenerateRandomString();
                u.LastName = "".GenerateRandomString();
            }));
        }
    }

    public interface IUserRepository<T> : IRepository<T>
    {
        IEnumerable<T> GetAllUsers();
    }

    public interface IRepository<T>
    {

    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public sealed class ReflectionUtils
    {
        public static T ObjectInitializer<T>(Action<T> initializer)
        {
            var result = Activator.CreateInstance<T>();
            initializer(result);
            return result;
        }
    }

    public static class CommonUtils
    {
        static Random random = new Random();
        public static string GenerateRandomString(this string source)
        {
            const string initialString = "ABCSADASD@!#!@#ASD)_)31231231AJDASDQ";

            return new string(Enumerable
                                .Repeat(initialString, initialString.Length)
                                .Select(_ => _[random.Next(0, initialString.Length)]).ToArray()
                                );
        }
    }
}
