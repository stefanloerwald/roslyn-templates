using Tests_MyTemplate.Helpers;
using Xunit;

namespace Tests_MyTemplate
{
    public partial class MyTemplateGeneratorTests
    {
        [Fact]
        public void Empty()
        {
            var userSource = @"";
            RunGenerator(userSource, out var generatorDiagnostics, out var generated);
            generatorDiagnostics.Verify();
            Assert.Single(generated);
            generated.ContainsFileWithContent("foo.cs", @"
namespace MyTemplate
{
    public class Foo
    {
    }
}");
        }
    }
}
