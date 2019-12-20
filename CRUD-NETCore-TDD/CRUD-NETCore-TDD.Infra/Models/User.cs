using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_NETCore_TDD.Infra.Models
{
    public class User
    {
        public User()
        {

        }
        public User(int id, string name, int age, bool isActive)
        {
            Id = id;
            Name = name;
            Age = age;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}
