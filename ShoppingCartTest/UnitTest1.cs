namespace ShoppingCartTest;

using ShoppingCartModels;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class ProductTests
{
    [TestMethod]
    public void Product_WithValidFields_ShouldBeValid()
    {
        // Arrange
        var product = new Product
        {
            Id = 0,
            Name = "Test",
            Price = 7.67M,
            Description = "Test"
        };

        var validationContext = new ValidationContext(product);
        var validationResults = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateObject(product, validationContext, validationResults, true);

        // Assert
        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void Product_WithNegativePrice_ShouldBeInvalid()
    {
        // Arrange
        var product = new Product
        {
            Id = 1,
            Name = "Test",
            Price = -3M, // Invalid price
            Description = "Test"
        };

        var validationContext = new ValidationContext(product);
        var validationResults = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateObject(product, validationContext, validationResults, true);

        // Assert
        Assert.IsFalse(isValid);
        Assert.IsTrue(validationResults.Exists(vr => vr.MemberNames.Contains("Price")));
    }
}