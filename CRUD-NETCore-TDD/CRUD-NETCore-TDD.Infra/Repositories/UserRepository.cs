using CRUD_NETCore_TDD.Infra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_NETCore_TDD.Infra.Repositories
{
    public class UserRepository
    {
        private readonly MyContext ctx;
        public UserRepository(MyContext ctx)
        {
            this.ctx = ctx;

        }
        public User Post(User user)
        {
            ctx.Users.Add(user);
            ctx.SaveChanges();
            return user;
        }
    }
}
