using CRUD_NETCore_TDD.Infra.Models;
using CRUD_NETCore_TDD.Infra.Repositories;
using CRUD_NETCore_TDD.Infra.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CRUD_NETCore_TDD.Test.Tests
{
    public class PostUserTest:BaseTest
    {
        #region THEORY
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        //[InlineData("John")]
        //public void Theory_PostUser_Name_NoValidation(string name)
        //{
        //    var user = new User
        //    {
        //        Name = name
        //    };

        //    var val = new PostUserValidator().Validate(user);
        //    Assert.False(val.IsValid);
        //}

        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //[InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        //[InlineData("John")]
        //public void Theory_PostUser_Name_Validation(string name)
        //{
        //    var user = new User
        //    {
        //        Name = name
        //    };

        //    var val = new PostUserValidator().Validate(user);
        //    Assert.False(val.IsValid);
        //}

        [Theory]
        [InlineData(null,100)]
        [InlineData("",100)]
        [InlineData("John Doe",100)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ",101)]
        [InlineData("John Doe",101)]
        public void Theory_PostUser_Name(string name, int errorCode)
        {
            var user = new User
            {
                Name = name
            };

            CheckError(new PostUserValidator(), errorCode, user);  
            //var val = new PostUserValidator().Validate(user);
            //Assert.False(val.IsValid);

            //if (!val.IsValid)
            //{
            //    bool hasError = val.Errors.Any(a => a.ErrorCode.Equals(errorCode.ToString()));
            //    Assert.True(hasError);
            //}
        }
        #endregion
        #region FACT
        //[Fact]
        //public void Fact_PostUser_NoModelNoRepository()
        //{
        //    //EXAMPLE
        //    var user = new User("John", 50, true);

        //    //REPOSITORY
        //    ctx.User.Add(user);
        //    ctx.SaveChanges();

        //    //ASSERT
        //    Assert.Equal(1,user.Id);
        //}

        //[Fact]
        //public void Fact_PostUser_NoRepository()
        //{
        //    //EXAMPLE
        //    var user = new User(0,"John", 50, true);

        //    //REPOSITORY
        //    ctx.User.Add(user);
        //    ctx.SaveChanges();

        //    //ASSERT
        //    Assert.Equal(1, user.Id);
        //}

        [Fact]
        public void Fact_PostUser()
        {
            //EXAMPLE
            var user = new User(0, "John", 50, true);

            //REPOSITORY
            user = new UserRepository(ctx).Post(user);

            //ASSERT
            Assert.Equal(1, user.Id);
        }
        #endregion
    }
}
