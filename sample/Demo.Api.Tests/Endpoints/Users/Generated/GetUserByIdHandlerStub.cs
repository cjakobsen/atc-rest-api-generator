﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Demo.Api.Generated.Contracts;
using Demo.Api.Generated.Contracts.Users;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.15.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Users.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.15.0")]
    public class GetUserByIdHandlerStub : IGetUserByIdHandler
    {
        public Task<GetUserByIdResult> ExecuteAsync(GetUserByIdParameters parameters, CancellationToken cancellationToken = default)
        {
            var data = new User
            {
                Id = Guid.Parse("77a33260-0000-441f-ba60-b0a833803fab"),
                Gender = GenderType.Female,
                FirstName = "Hallo1",
                LastName = "Hallo2",
                Email = "john.doe@example.com",
                Homepage = new Uri("http://www.dr.dk"),
                Color = ColorType.Red,
                HomeAddress = new Address
                {
                    StreetName = "Hallo",
                    StreetNumber = "Hallo1",
                    PostalCode = "Hallo2",
                    CityName = "Hallo3",
                    MyCountry = new Country
                    {
                        Name = "Hallo1",
                        Alpha2Code = "Ha",
                        Alpha3Code = "Hal",
                    },
                },
                CompanyAddress = new Address
                {
                    StreetName = "Hallo",
                    StreetNumber = "Hallo1",
                    PostalCode = "Hallo2",
                    CityName = "Hallo3",
                    MyCountry = new Country
                    {
                        Name = "Hallo1",
                        Alpha2Code = "Ha",
                        Alpha3Code = "Hal",
                    },
                },
            };

            return Task.FromResult(GetUserByIdResult.Ok(data));
        }
    }
}