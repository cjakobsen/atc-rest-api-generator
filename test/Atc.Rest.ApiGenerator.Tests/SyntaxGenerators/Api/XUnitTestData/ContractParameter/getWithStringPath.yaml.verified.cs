using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace TestProject.AtcTest.Contracts.Test
{
    /// <summary>
    /// Parameters for operation request.
    /// Description: Get user by id.
    /// Operation: GetUserById.
    /// Area: Test.
    /// </summary>
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetUserByIdParameters
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        [FromRoute(Name = "id")]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}";
        }
    }
}