using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace TestCal
{
    [TestFixture]
    class TestCal
    {
        //AdditonTests
        //AdditionTest1
        [Test]
        public void DoAddition_Input1and1point1_Returns1point1()
        {
            //Arrange 
            double num1 = 1;
            double num2 = 1.1;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }


        //AdditionTest2
        [Test]
        public void DoAddition_Input9point9and0point1_Returns10point0()
        {
            //Arrange 
            double num1 = 9.9;
            double num2 = 10.0;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        
        
        //AdditionTest3
        [Test]
        public void DoAddition_Input0and0point1_Returns0point1()
        {
            //Arrange 
            double num1 = 0;
            double num2 = 0.1;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //SubtractionTests
        //SubtractionTest1
        [Test]
        public void DoSubtraction_Input0and1_Returns_minus1()
        {
            //Arrange 
            double num1 = 0;
            double num2 = 1;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }


        //SubtractionTest2
        [Test]
        public void DoSubtraction_Input2point0and2point0_Returns_0()
        {
            //Arrange 
            double num1 = 2.0;
            double num2 = 2.0;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        
        
        //SubtractionTest3
        [Test]
        public void DoSubtraction_Input232point0and200_Returns_32point0()
        {
            //Arrange 
            double num1 = 232.0;
            double num2 = 200;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }


        //DivisionTests
        //DivisionTest1
        [Test]
        public void DoDivison_Input2and2_Returns_1()
        {
            //Arrange 
            double num1 = 2;
            double num2 = 2;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }


        //DivisionTest2
        [Test]
        public void DoDivison_Input_minus56and7_Returns_minus_8()
        {
            //Arrange 
            double num1 = -56;
            double num2 = 7;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }


        //DivisionTest3
        [Test]
        public void DoDivison_Input2point0and2_Returns_1()
        {
            //Arrange 
            double num1 = 2.0;
            double num2 = 2;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //MultiplicationTests
        //MultiplicationTest1
        [Test]
        public void DoMultiplication_Input0and0_Returns_0()
        {
            //Arrange 
            double num1 = 0;
            double num2 = 0;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        
        
        //MultiplicationTest2
        [Test]
        public void DoMultiplication_Input_minus_1_and_minus_1_Returns_1()
        {
            //Arrange 
            double num1 = -1;
            double num2 = -1;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        
        
        //MultiplicationTest3
        [Test]
        public void DoMultiplication_Input_3point6and2point3Returns_8point28()
        {
            //Arrange 
            double num1 = 3.6;
            double num2 = 2.3;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }


        //GetFirstNumberTests
        //GetFirstNumberTest1
        [Test]
        public void DoGetFirstNumber_Inpu1and41_Returns_minus1()
        {
            //Arrange 
            double fnum = -1;
            double snum = 41;
            double ResultExpected = fnum;
            Calc testCalulation = new Calc(fnum, snum);
            //Act
            double aResult = testCalulation.GetFirstNumber();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //GetFirstNumberTests
        //GetFirstNumberTest2
        [Test]
        public void DoGetFirstNumber_Inpu45and41_Returns_45()
        {
            //Arrange 
            double fnum = 45;
            double snum = 41;
            double ResultExpected = fnum;
            Calc testCalulation = new Calc(fnum, snum);
            //Act
            double aResult = testCalulation.GetFirstNumber();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //GetFirstNumberTests
        //GetFirstNumberTest3
        [Test]
        public void DoGetFirstNumber_Inpu341and410_Returns_341()
        {
            //Arrange 
            double fnum = 341;
            double snum = 410;
            double ResultExpected = fnum;
            Calc testCalulation = new Calc(fnum, snum);
            //Act
            double aResult = testCalulation.GetFirstNumber();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //GetSecondNumberTests
        //GetSecondNumberTest1
        [Test]
        public void DoGetSecondNumber_Inpu3and10_Returns_10()
        {
            //Arrange 
            double fnum = 3;
            double snum = 10;
            double ResultExpected = snum;
            Calc testCalulation = new Calc(fnum, snum);
            //Act
            double actualResult = testCalulation.GetSecondNumber();
            //Assert
            Assert.AreEqual(ResultExpected, actualResult);
        }


        //GetSecondNumberTest2
        [Test]
        public void DoGetSecondNumber_Inpu130and110_Returns_110()
        {
            //Arrange 
            double fnum = 130;
            double snum = 110;
            double ResultExpected = snum;
            Calc testCalulation = new Calc(fnum, snum);
            //Act
            double actualResult = testCalulation.GetSecondNumber();
            //Assert
            Assert.AreEqual(ResultExpected, actualResult);
        }
        //GetSecondNumberTest3
        [Test]
        public void DoGetSecondNumber_Inpu13and10_Returns_1()
        {
            //Arrange 
            double fnum = 13;
            double snum = 10;
            double ResultExpected = snum;
            Calc testCalulation = new Calc(fnum, snum);
            //Act
            double actualResult = testCalulation.GetSecondNumber();
            //Assert
            Assert.AreEqual(ResultExpected, actualResult);
        }
    }
}
