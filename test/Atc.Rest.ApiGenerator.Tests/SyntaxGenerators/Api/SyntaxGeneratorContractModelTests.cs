using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atc.Rest.ApiGenerator.Models;
using Atc.Rest.ApiGenerator.SyntaxGenerators;
using Atc.Rest.ApiGenerator.SyntaxGenerators.Api;
using Atc.Rest.ApiGenerator.Tests.XUnitTestTypes.CodeGenerator;
using VerifyXunit;
using Xunit;

namespace Atc.Rest.ApiGenerator.Tests.SyntaxGenerators.Api
{
    [UsesVerify]
    public class SyntaxGeneratorContractModelTests : SyntaxGeneratorTestBase
    {
        public static IEnumerable<object[]> YamlFiles { get; } = AllFiles
            .Where(x => x.FilePath.Contains("ContractModel", System.StringComparison.Ordinal))
            .Select(x => new object[] { x });

        protected override ISyntaxCodeGenerator CreateApiGenerator(ApiProjectOptions apiProject)
        {
            // Verify spec file supported for unit test
            Assert.Single(apiProject.Document.Components.Schemas);
            var schema = apiProject.Document.Components.Schemas.First().Value;

            // Construct SUT
            return new SyntaxGeneratorContractModel(apiProject, string.Empty, schema, FocusOnSegment);
        }

        [Theory(DisplayName = "Api Contract Model")]
        [MemberData(nameof(YamlFiles))]
        public Task ExecuteGeneratorTest(YamlSpecFile specFile)
        {
            Assert.NotNull(specFile.FilePath);
            return ExecuteTest(specFile);
        }
    }
}