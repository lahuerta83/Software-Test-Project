// <copyright file="dogTest.cs">Copyright ©  2019</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDogGroomer;

namespace ProjectDogGroomer.Tests
{
    /// <summary>This class contains parameterized unit tests for dog</summary>
    [PexClass(typeof(dog))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class dogTest
    {
        /// <summary>Test stub for Beinggroom()</summary>
        [PexMethod]
        internal void BeinggroomTest([PexAssumeUnderTest]dog target)
        {
            target.Beinggroom();
            // TODO: add assertions to method dogTest.BeinggroomTest(dog)
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal dog ConstructorTest(string dogname)
        {
            dog target = new dog(dogname);
            return target;
            // TODO: add assertions to method dogTest.ConstructorTest(String)
        }

        /// <summary>Test stub for get_Dogname()</summary>
        [PexMethod]
        internal string DognameGetTest([PexAssumeUnderTest]dog target)
        {
            string result = target.Dogname;
            return result;
            // TODO: add assertions to method dogTest.DognameGetTest(dog)
        }

        /// <summary>Test stub for provideserv(Dogservices)</summary>
        [PexMethod]
        internal void provideservTest([PexAssumeUnderTest]dog target, Dogservices typeofgroom)
        {
            target.provideserv(typeofgroom);
            // TODO: add assertions to method dogTest.provideservTest(dog, Dogservices)
        }
    }
}
