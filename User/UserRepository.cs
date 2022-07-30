using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class UserRepository
    {
        private List<ClassUser> _users = new List<ClassUser>();
        public void Save(ClassUser user)
        {
            bool counter = false;
            for(int i = 0; i < _users.Count; i++)
            {
                if(_users[i].Id == user.Id)
                {
                    counter = true;
                    break;
                }
            }
            if (!counter)
            {
                user.Id = _users.Count;
                _users.Add(user);
            }
            else
            {
                Console.WriteLine("Пользователь с таким Id уже существует");
            }
        }
        public ClassUser Get(int id)
        {
            int counter = 0;
            bool flag = false;
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == id)
                {
                    counter = i;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                throw new Exception();
            }
            else
            {
                var user = new ClassUser()
                {
                    Id = _users[counter].Id,
                    Username = _users[counter].Username,
                    Password = _users[counter].Password
                };
                return user;
            }
        }
        public List<ClassUser> GetAll()
        {
            var list = new List<ClassUser>();
            for(int i = 0; i < (_users.Count); i++)
            {
                list.Add(_users[i]);
            }
            return list;
        }
        public void Delete(int id)
        {
            int counter = 0;
            bool flag = false;
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == id)
                {
                    counter = i;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                throw new Exception();
            }
            else
            {
                _users.RemoveAt(counter);
            }
        }
    }
}
