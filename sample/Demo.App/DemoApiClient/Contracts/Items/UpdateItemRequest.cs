﻿using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.33.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.App.Contracts.Items
{
    /// <summary>
    /// UpdateItemRequest.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.1.33.0")]
    public class UpdateItemRequest
    {
        /// <summary>
        /// Item.
        /// </summary>
        [Required]
        public Item Item { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Item)}: ({Item})";
        }
    }
}