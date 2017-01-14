using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Tests.Common.Objects.ResponseObjects.ValidatorResponses
{
    [TestFixture]
    public class GenericValidatorResponseTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new GenericValidatorResponse());
            }

            [Test]
            public void Passed_Returns_True_When_Passed_True()
            {
                GenericValidatorResponse target = new GenericValidatorResponse(true);
                Assert.IsTrue(target.Passed);
            }

            [Test]
            public void Passed_Returns_False_When_Passed_False()
            {
                GenericValidatorResponse target = new GenericValidatorResponse(false);
                Assert.IsFalse(target.Passed);
            }

            [Test]
            public void Passed_Single_Message_Added_To_Messages()
            {
                string testMessage = "testMessage";
                GenericValidatorResponse target = new GenericValidatorResponse(true, testMessage);
                Assert.IsTrue(target.Messages.ToList()[0] == testMessage);
            }

            [Test]
            public void Passed_Message_IEnumerable_Sets_Messages()
            {
                string testMessage = "testMessage";
                string testMessage2 = "testMessage2";
                List<string> testMessages = new List<string>(){testMessage, testMessage2};
                GenericValidatorResponse target = new GenericValidatorResponse(true, testMessages);
                Assert.IsTrue(target.Messages.ToList()[0] == testMessage && target.Messages.ToList()[1] == testMessage2);
            }

            [Test]
            public void Passed_Null_Message_Returns_Empty_List()
            {
                GenericValidatorResponse target = new GenericValidatorResponse(true, (string) null);
                Assert.IsTrue(!target.Messages.Any());
            }
        }

        [TestFixture]
        public class SystemFailure
        {
            [Test]
            public void Returns_False()
            {
                Assert.IsFalse(new GenericValidatorResponse().SystemFailure);
            }
        }
    }
}