using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestProject.AtcTest.Contracts.Test
{
    /// <summary>
    /// Domain Interface for RequestHandler.
    /// Description: Get all users.
    /// Operation: GetUsers.
    /// Area: Test.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public interface IGetUsersHandler
    {
        /// <summary>
        /// Execute method.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        Task<GetUsersResult> ExecuteAsync(CancellationToken cancellationToken = default);
    }
}