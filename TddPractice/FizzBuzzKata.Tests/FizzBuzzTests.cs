using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Should_Return_Fizz_For_Input_Of_Three()
        {
            //Given
            var input = 3;
            var fizzBuzz = CreateFizzBuzz();
            //When
            var result = fizzBuzz.CheckForFizz(input);
            //Then
            Assert.AreEqual("Fizz", result);
        }


        [Test]
        public void Should_Return_Fizz_For_Input_Of_9()
        {
            //Given
            var input = 9;
            var fizzBuzz = CreateFizzBuzz();
            //When
            var result = fizzBuzz.CheckForFizz(input);
            //Then
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void Should_Return_2_For_Input_Of_2_When_Checking_FizzBuzz()
        {
            //Given
            var input = 2;
            var fizzBuzz = CreateFizzBuzz();
            //When
            var result = fizzBuzz.CheckForFizz(input);
            //Then
            Assert.AreEqual("2", result);
        }

        [Test]
        public void Should_Return_8_For_Input_Of_8_When_Checking_FizzBuzz()
        {
            //Given
            var input = 8;
            var fizzBuzz = CreateFizzBuzz();
            //When
            var result = fizzBuzz.CheckForFizz(input);
            //Then
            Assert.AreEqual("8", result);
        }


        [Test]
        public void Should_Return_Buzz_Given_5_When_Checking_FizzBuzz()
        {
            //Given
            var input = 5;
            var fizzBuzz = CreateFizzBuzz();
            //When
            var result = fizzBuzz.CheckForBuzz(input);
            //Then
            Assert.AreEqual("Buzz", result);
        }
        
        
        [Test]
        public void Should_Return_1_Given_1_When_Checking_FizzBuzz()
        {
            //Given
            var input = 1;
            var fizzBuzz = CreateFizzBuzz();
            //When
            var result = fizzBuzz.CheckForBuzz(input);
            //Then
            Assert.AreEqual("1", result);
        }

        private static FizzBuzz CreateFizzBuzz()
        {
            return new FizzBuzz();
        }
    }
}
