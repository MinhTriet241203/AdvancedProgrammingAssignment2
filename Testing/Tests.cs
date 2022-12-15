using System;
using AdvancedProgrammingAssignment2.Controller;
using MongoDB.Bson;
using Xunit;

namespace Testing
{
    public class Tests
    {

        [Fact]
        public void TestAddCategory()
        {
            CategoryManage.AddCategory("Children's Book");
        }

        [Fact]
        public void TestDelCategory()
        {
            //remember to change this ObjectId before testing
            var x = "639ac5010f5915be849563da";
            CategoryManage.DeleteCategory(x);
        }

        [Fact]
        public void TestUpdateCategory()
        {
            //remember to change this ObjectId before testing
            var x = "639ac5010f5915be849563da";
            CategoryManage.UpdateCategory(x, "changedName");
        }

        [Fact]
        public void TestAddAdmin()
        {
            AccountManage.AddAdmin("admin@mail.com", "admin1", "123");
        }

        [Fact]
        public void TestAddLibra()
        {
            AccountManage.AddLibrarian("librarian@mail.com", "librarian1", "123");
        }

        [Fact]
        public void TestAddUser()
        {
            AccountManage.AddUser("user@mail.com", "user1", "123");
        }

        [Fact]
        public void TestDelAccount()
        {
            //remember to change this ObjectId before testing
            var x = "639aca59482cd43757be2343";
            AccountManage.RemoveAccount(x);
        }
        
    }
}