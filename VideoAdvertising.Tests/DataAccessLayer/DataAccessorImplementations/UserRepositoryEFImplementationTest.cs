using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.DataAccessLayer.DataAccessorImplementations;
using VideoAdvertising.DataAccessLayer.DbContexts;
using VideoAdvertising.DataAccessLayer.Models;

namespace VideoAdvertising.Tests.DataAccessLayer.DataAccessorImplementations
{
    [TestFixture]
    public class UserRepositoryEFImplementationTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);

                Assert.IsNotNull(new UserRepositoryEFImplementation(mockUserDbContext.Object));
            }
        }

        [TestFixture]
        public class GetAll
        {
            private UserRepositoryEFImplementation Target;

            [SetUp]
            public void Before_Each_Test()
            {
                IQueryable<DbUser> users = new List<DbUser>()
                {
                    new DbUser {Email = "abc@abc.com", Id = "1", Username = "abc"},
                    new DbUser {Email = "xyz@abc.com", Id = "2", Username = "xyz"},
                    new DbUser {Email = "123@abc.com", Id = "3", Username = "123"}
                }.AsQueryable();

                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                mockDbSet.As<IQueryable<DbUser>>().Setup(a => a.GetEnumerator()).Returns(users.GetEnumerator());

                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);

                Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);
            }

            [Test]
            public void Is_Not_Null()
            {
               Assert.IsNotNull(Target.GetAll());
            }

            [Test]
            public void Returns_All_Items()
            {
                Assert.IsNotNull(Target.GetAll().Count() == 3);
            }
        }

        [TestFixture]
        public class GetById
        {
            private UserRepositoryEFImplementation Target;

            [SetUp]
            public void Before_Each_Test()
            {
                IQueryable<DbUser> users = new List<DbUser>()
                {
                    new DbUser {Email = "abc@abc.com", Id = "1", Username = "abc"},
                    new DbUser {Email = "xyz@abc.com", Id = "2", Username = "xyz"},
                    new DbUser {Email = "123@abc.com", Id = "3", Username = "123"}
                }.AsQueryable();

                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Provider).Returns(users.Provider);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.ElementType).Returns(users.ElementType);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Expression).Returns(users.Expression);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());
                
                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);

                Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);
            }

            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(Target.GetById(string.Empty));
            }

            [TestCase("1", "abc")]
            [TestCase("2", "xyz")]
            [TestCase("3", "123")]
            public void Returns_Expected_User(string id, string username)
            {
                Assert.IsTrue(Target.GetById(id).Username == username);
            }
        }

        [TestFixture]
        public class GetUserByEmail
        {
            private UserRepositoryEFImplementation Target;

            [SetUp]
            public void Before_Each_Test()
            {
                IQueryable<DbUser> users = new List<DbUser>()
                {
                    new DbUser {Email = "abc@abc.com", Id = "1", Username = "abc"},
                    new DbUser {Email = "xyz@abc.com", Id = "2", Username = "xyz"},
                    new DbUser {Email = "123@abc.com", Id = "3", Username = "123"}
                }.AsQueryable();

                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Provider).Returns(users.Provider);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.ElementType).Returns(users.ElementType);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Expression).Returns(users.Expression);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());

                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);

                Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);
            }

            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(Target.GetUserByEmail(string.Empty));
            }

            [TestCase("abc@abc.com", "1")]
            [TestCase("xyz@abc.com", "2")]
            [TestCase("123@abc.com", "3")]
            public void Returns_Expected_User(string email, string id)
            {
                Assert.IsTrue(Target.GetUserByEmail(email).Id == id);
            }
        }

        [TestFixture]
        public class GetUserByUserName
        {
            private UserRepositoryEFImplementation Target;

            [SetUp]
            public void Before_Each_Test()
            {
                IQueryable<DbUser> users = new List<DbUser>()
                {
                    new DbUser {Email = "abc@abc.com", Id = "1", Username = "abc"},
                    new DbUser {Email = "xyz@abc.com", Id = "2", Username = "xyz"},
                    new DbUser {Email = "123@abc.com", Id = "3", Username = "123"}
                }.AsQueryable();

                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Provider).Returns(users.Provider);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.ElementType).Returns(users.ElementType);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Expression).Returns(users.Expression);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());

                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);

                Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);
            }

            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(Target.GetUserByUserName(string.Empty));
            }

            [TestCase("abc", "1")]
            [TestCase("xyz", "2")]
            [TestCase("123", "3")]
            public void Returns_Expected_User(string username, string id)
            {
                Assert.IsTrue(Target.GetUserByUserName(username).Id == id);
            }
        }

        public class Store
        {
            [Test]
            public void Is_Not_Null()
            {
                int callbackCount = 0;
                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                mockDbSet.Setup(a => a.Add(It.IsAny<DbUser>())).Returns(new DbUser());
                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);
                mockUserDbContext.Setup(a => a.SaveChanges()).Callback(() => callbackCount++);
                UserRepositoryEFImplementation Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);

                Assert.IsNotNull(Target.Store(new DbUser()));
                Assert.IsTrue(callbackCount == 1);
            }

            [Test]
            public void Null_Db_Return_Is_Not_Returned_Null()
            {
                int callbackCount = 0;
                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();
                mockDbSet.Setup(a => a.Add(It.IsAny<DbUser>())).Returns((DbUser)null);
                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.Users).Returns(mockDbSet.Object);
                mockUserDbContext.Setup(a => a.SaveChanges()).Callback(() => callbackCount++);
                UserRepositoryEFImplementation Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);

                Assert.IsNotNull(Target.Store(new DbUser()));
                Assert.IsTrue(callbackCount == 1);
            }
        }

        [TestFixture]
        public class Update
        {
            private UserRepositoryEFImplementation Target;
            private DbSet<DbUser> _userDbSet;
            private int _callbackCount;

            [SetUp]
            public void Before_Each_Test()
            {
                _callbackCount = 0;
                IQueryable<DbUser> users = new List<DbUser>()
                {
                    new DbUser {Email = "abc@abc.com", Id = "1", Username = "abc"},
                    new DbUser {Email = "xyz@abc.com", Id = "2", Username = "xyz"},
                    new DbUser {Email = "123@abc.com", Id = "3", Username = "123"}
                }.AsQueryable();

                Mock<DbSet<DbUser>> mockDbSet = new Mock<DbSet<DbUser>>();

                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Provider).Returns(users.Provider);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.ElementType).Returns(users.ElementType);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.Expression).Returns(users.Expression);
                mockDbSet.As<IQueryable<DbUser>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());
                mockDbSet.Setup(a => a.Find(It.IsAny<string>())).Returns(users.FirstOrDefault());


                mockDbSet.Setup(a => a.Add(It.IsAny<DbUser>())).Returns(new DbUser());
                _userDbSet = mockDbSet.Object;
                Mock<UserDbContext> mockUserDbContext = new Mock<UserDbContext>();
                mockUserDbContext.Setup(a => a.SetEntryIsModified(It.IsAny<DbUser>()));
                mockUserDbContext.Setup(a => a.SetPropertyIsModified(It.IsAny<DbUser>()));
                mockUserDbContext.Setup(a => a.Users).Returns(_userDbSet);
                mockUserDbContext.Setup(a => a.SaveChanges()).Callback(() => _callbackCount++);

                Target = new UserRepositoryEFImplementation(mockUserDbContext.Object);
            }

            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(Target.Update("1", new DbUser { Username = "def" }));
            }

            [Test]
            public void Updates_Values_Correctly()
            {
                string id = "1";
                string newUsername = "def";
                Target.Update(id, new DbUser {Username = newUsername});
                Assert.IsTrue(_callbackCount == 1);
            }
        }
    }
}
