using AdvancedProgrammingAssignment2.Controller;
using AdvancedProgrammingAssignment2.Model;
using MongoDB.Bson;
using Xunit;
using Xunit.Abstractions;

namespace Testing
{
    public class Tests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

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
            User test = new User("testDeleteAccount@mail.com", "user", "123");
            var x = "testDeleteAccount@@mail.com";
            AccountManage.RemoveAccount(x);
        }

        [Fact]
        public void GetAllAccountsTest()
        {
            var accounts = AccountManage.GetAllAccounts();
            foreach (Account account in accounts) _testOutputHelper.WriteLine(account.ToJson());
        }

        [Fact]
        public void LoginTest()
        {
            var email = "user@mail.com";
            var password = "123";
            Assert.True(AccountManage.Login(email, password).Equals("success"));
            _testOutputHelper.WriteLine(AccountManage.Login(email, password));
        }
    }
}