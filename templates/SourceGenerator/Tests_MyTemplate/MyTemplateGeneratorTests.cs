using MyTemplate;
using Tests_MyTemplate.Helpers;
using Xunit.Abstractions;

namespace Tests_MyTemplate
{
    public partial class MyTemplateGeneratorTests : TestBase<MyTemplateGenerator>
    {
        public MyTemplateGeneratorTests(ITestOutputHelper output_helper) : base(output_helper)
        {
        }
        // for the actual test cases, see folder "MyTemplateGenerator"
    }
}
