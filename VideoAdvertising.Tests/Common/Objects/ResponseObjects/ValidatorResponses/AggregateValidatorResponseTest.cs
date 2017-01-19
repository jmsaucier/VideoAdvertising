using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Tests.Common.Objects.ResponseObjects.ValidatorResponses
{
    [TestFixture]
    public class AggregateValidatorResponseTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void Is_Not_Null()
            {
                Assert.IsNotNull(new AggregateValidatorResponse());
            }

            public void Passes_By_Default()
            {
                Assert.IsTrue(new AggregateValidatorResponse().Passed);
            }

            public void No_Messages_By_Default()
            {
                Assert.IsTrue(!new AggregateValidatorResponse().Messages.Any());
            }

            public void Not_System_Failure_By_Default()
            {
                Assert.IsFalse(new AggregateValidatorResponse().SystemFailure);
            }
        }

        [TestFixture]
        public class AddValidatorResponse
        {
            [TestFixture]
            public class Passed
            {
                [Test]
                public void Accepts_Null()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(null);
                    Assert.IsNotNull(target);
                }

                [Test]
                public void Passed_True_Returns_True()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(true));
                    Assert.IsTrue(target.Passed);
                }

                [Test]
                public void Passed_False_Returns_False()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(false));
                    Assert.IsFalse(target.Passed);
                }

                [Test]
                public void Passed_True_Plus_True_Returns_True()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(true));
                    target.AddValidatorResponse(new GenericValidatorResponse(true));
                    Assert.IsTrue(target.Passed);
                }

                [Test]
                public void Passed_True_Plus_False_Returns_False()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(true));
                    target.AddValidatorResponse(new GenericValidatorResponse(false));
                    Assert.IsFalse(target.Passed);
                }

                [Test]
                public void Passed_False_Plus_True_Returns_False()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(false));
                    target.AddValidatorResponse(new GenericValidatorResponse(true));
                    Assert.IsFalse(target.Passed);
                }

                [Test]
                public void Passed_False_Plus_False_Returns_False()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(false));
                    target.AddValidatorResponse(new GenericValidatorResponse(false));
                    Assert.IsFalse(target.Passed);
                }
            }

            [TestFixture]
            public class SystemFailure
            {
                [Test]
                public void Accepts_Null()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(null);
                    Assert.IsNotNull(target);
                }

                [Test]
                public void SystemFailure_True_Returns_True()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new SystemFailureValidatorResponse());
                    Assert.IsTrue(target.SystemFailure);
                }

                [Test]
                public void SystemFailure_False_Returns_False()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse());
                    Assert.IsFalse(target.SystemFailure);
                }

                [Test]
                public void SystemFailure_True_Plus_True_Returns_True()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new SystemFailureValidatorResponse());
                    target.AddValidatorResponse(new SystemFailureValidatorResponse());
                    Assert.IsTrue(target.SystemFailure);
                }

                [Test]
                public void SystemFailure_True_Plus_False_Returns_True()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new SystemFailureValidatorResponse());
                    target.AddValidatorResponse(new GenericValidatorResponse());
                    Assert.IsTrue(target.SystemFailure);
                }

                [Test]
                public void SystemFailure_False_Plus_True_Returns_True()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse());
                    target.AddValidatorResponse(new SystemFailureValidatorResponse());
                    Assert.IsTrue(target.SystemFailure);
                }

                [Test]
                public void SystemFailure_False_Plus_False_Returns_False()
                {
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse());
                    target.AddValidatorResponse(new GenericValidatorResponse());
                    Assert.IsFalse(target.SystemFailure);
                }
            }

            [TestFixture]
            public class Messages
            {
                [Test]
                public void Adds_Message_To_Result()
                {
                    string testMessage = "test";
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(true, testMessage));
                    Assert.IsTrue(target.Messages.ToList()[0] == testMessage);
                }

                [Test]
                public void Adds_Multiple_Messages_To_Result()
                {
                    string testMessage1 = "test";
                    string testMessage2 = "test2";

                    List<string> testMessages = new List<string>{testMessage1, testMessage2};
                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(true, testMessages));
                    Assert.IsTrue(target.Messages.ToList()[0] == testMessage1);
                }

                [Test]
                public void Adds_Multiple_Messages_Multiple_Responses_To_Result()
                {
                    string testMessage1 = "test";
                    string testMessage2 = "test2";

                    AggregateValidatorResponse target = new AggregateValidatorResponse();
                    target.AddValidatorResponse(new GenericValidatorResponse(true, testMessage1));
                    target.AddValidatorResponse(new GenericValidatorResponse(true, testMessage2));
                    Assert.IsTrue(target.Messages.ToList()[0] == testMessage1);
                }

            }

        }

    }
}
