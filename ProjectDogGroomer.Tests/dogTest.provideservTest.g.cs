using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDogGroomer;
// <copyright file="dogTest.provideservTest.g.cs">Copyright ©  2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ProjectDogGroomer.Tests
{
    public partial class dogTest
    {

[TestMethod]
[PexGeneratedBy(typeof(dogTest))]
public void provideservTest886()
{
    dog dog;
    dog = new dog((string)null);
    this.provideservTest(dog, Dogservices.fullgroom);
    Assert.IsNotNull((object)dog);
}
    }
}
