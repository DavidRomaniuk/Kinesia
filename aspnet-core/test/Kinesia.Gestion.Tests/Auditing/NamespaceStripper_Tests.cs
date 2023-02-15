using Kinesia.Gestion.Auditing;
using Kinesia.Gestion.Test.Base;
using Shouldly;
using Xunit;

namespace Kinesia.Gestion.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Kinesia.Gestion.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Kinesia.Gestion.Auditing.GenericEntityService`1[[Kinesia.Gestion.Storage.BinaryObject, Kinesia.Gestion.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Kinesia.Gestion.Auditing.XEntityService`1[Kinesia.Gestion.Auditing.AService`5[[Kinesia.Gestion.Storage.BinaryObject, Kinesia.Gestion.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Kinesia.Gestion.Storage.TestObject, Kinesia.Gestion.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
