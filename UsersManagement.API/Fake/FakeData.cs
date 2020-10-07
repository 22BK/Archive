using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersManagement.API.Models;

namespace UsersManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUser(int number)
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                                .RuleFor(x => x.Id, z => z.IndexFaker+1)
                                .RuleFor(x => x.FirstName, z => z.Name.FirstName())
                                .RuleFor(x => x.LastName, z => z.Name.LastName())
                                .RuleFor(x => x.Address, z => z.Address.FullAddress())
                                .Generate(number);
            }
            
            return _users;
        }
    }
}
