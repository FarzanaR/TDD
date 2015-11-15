using System;
using AgeCalculatorKata;
using NUnit.Framework;

namespace AgeCalculator.Tests
{
    [TestFixture]
    class AgeCalculatorTests
    {

        [Test]
        public void Should_Return_26_Given_Year_19890809_and_20151112()
        {
            //Given
            var ageCalc = new AgeCalc();
            var birthDate = new DateTime(1989, 08, 09);
            var ageDate = new DateTime(2015, 11, 12);
            //When
            var result = ageCalc.CalculateAge(birthDate, ageDate);
            //Then
            Assert.AreEqual(26, result);
        }
        
        [Test]
        public void Should_Return_1_Given_Year_2014809_and_20151112()
        {
            //Given
            var ageCalc = new AgeCalc();
            var birthDate = new DateTime(2014, 08, 09);
            var ageDate = new DateTime(2015, 11, 12);
            //When
            var result = ageCalc.CalculateAge(birthDate, ageDate);
            //Then
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Should_Return_5_Given_Year_20101112_and_20151112()
        {
            //Given
            var ageCalc = new AgeCalc();
            var birthDate = new DateTime(2010, 11, 12);
            var ageDate = new DateTime(2015, 11, 12);
            //When
            var result = ageCalc.CalculateAge(birthDate, ageDate);
            //Then
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Should_Return_5_Given_Year_20101112_and_20151201()
        {
            //Given
            var ageCalc = new AgeCalc();
            var birthDate = new DateTime(2010, 11, 12);
            var ageDate = new DateTime(2015, 12, 01);
            //When
            var result = ageCalc.CalculateAge(birthDate, ageDate);
            //Then
            Assert.AreEqual(5, result);
        } 


        [Test]
        public void Should_Return_4_Given_Year_20101112_and_20151111()
        {
            //Given
            var ageCalc = new AgeCalc();
            var birthDate = new DateTime(2010, 11, 12);
            var ageDate = new DateTime(2015, 11, 11);
            //When
            var result = ageCalc.CalculateAge(birthDate, ageDate);
            //Then
            Assert.AreEqual(4, result);
        }
      
    }
}
