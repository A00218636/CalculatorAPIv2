﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using SharedCalculator;
namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {

        private IWebDriver _webDriver;

        [TestInitialize]
       public void Startup()
        {
            DriverManager manager = new DriverManager();
            manager.SetUpDriver(new ChromeConfig());

        }

        //[TestMethod]
        //https://github.com/A000917542/WebApiTestSkeleton
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(1, 2, 3)]
        [DataRow(3, 1, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 4, 7)]
        [DataRow(3, 5, 8)]
        [DataRow(3, 6, 9)]
        [DataRow(3, 7, 10)]
        [DataRow(3, 8, 11)]
        public void CalculatorAddMethodMustAdd(double left, double right, double expected)
        {
            double result;
            result = SharedCalculator.Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
            
        }
        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 2, -1)]
        [DataRow(3, 1, 2)]
        [DataRow(3, 3, 0)]
        [DataRow(2, 1, 1)]
        [DataRow(3, 4, -1)]
        [DataRow(5, 1, 4)]
        [DataRow(6, 1, 5)]
        [DataRow(7, 1, 6)]
        [DataRow(8, 1, 7)]
        public void CalculatorAddMethodMustSubtract(double left, double right, double expected)
        {
            double result;
            result = SharedCalculator.Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(1, 2, .5)]
        [DataRow(3, 1, 3)]
        [DataRow(3, 3, 1)]
        [DataRow(2, 1, 2)]
        [DataRow(2, 4, .5)]
        [DataRow(4, 2, 2)]
        [DataRow(6, 2, 3)]
        [DataRow(8, 2, 4)]
        [DataRow(10, 2, 5)]
        public void CalculatorAddMethodMustDivide(double left, double right, double expected)
        {
            double result;
            result = SharedCalculator.Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(1, 2, 2)]
        [DataRow(3, 1, 3)]
        [DataRow(3, 3, 9)]
        [DataRow(2, 1, 2)]
        [DataRow(5, 2, 10)]
        [DataRow(6, 3, 18)]
        [DataRow(7, 4, 28)]
        [DataRow(8, 5, 40)]
        [DataRow(3, 4, 12)]
        public void CalculatorAddMethodMustMultiply(double left, double right, double expected)
        {
            double result;
            result = SharedCalculator.Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);

        }

      
    }
}
