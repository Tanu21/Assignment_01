using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_01;
using NUnit.Framework;

namespace Assignment_01_Tests
{
    [TestFixture]
    class Assignment_01_Tests
    {
        [Test]

        public void Getlength_input9_Expectedoutput9()
        {
            //Arrange
            int Actual_length = 9;
            int width = 4;

            Rectangle testrectangle = new Rectangle(Actual_length, width);
            //Act
            int ExpectedLength = testrectangle.Getlength();
            //Assert
            Assert.AreEqual(ExpectedLength, Actual_length);
        }
        [Test]
        public void Set_length_input17_Expectedoutput17()
        {
            //Arrange
            int Actual_Set_length = 17;
            int width = 4;

            Rectangle testrectangle = new Rectangle(Actual_Set_length, width);
            //Act
            int ExpectedLength = testrectangle.Setlength(Actual_Set_length);
            //Assert
            Assert.AreEqual(ExpectedLength, Actual_Set_length);
        }
        [Test]
        public void GetWidth_input15_Expectedoutput15()
        {
            //Arrange
            int Actual_length = 9;
            int Actualwidth = 15;

            Rectangle testrectangle = new Rectangle(Actual_length, Actualwidth);
            //Act
            int ExpectedWidth = testrectangle.GetWidth();
            //Assert
            Assert.AreEqual(ExpectedWidth, Actualwidth);
        }
        [Test]
        public void SetWidth_input6_Expectedoutput6()
        {
            //Arrange
            int Actual_length = 9;
            int Expected_width = 6;

            Rectangle testrectangle = new Rectangle(Actual_length, Expected_width);
            //Act
            int Actual_Set_width = testrectangle.SetWidth(Expected_width);
            //Assert
            Assert.AreEqual(Actual_Set_width, Expected_width);
        }

        [Test]
        public void Get_Perimeter_inputlength5_inputwidth5_Expectedoutput20()
        {
            //Arrange
            int Actual_length = 5;
            int Actual_width = 5;
            int Expected_Perimeter = 20;

            Rectangle testrectangle = new Rectangle(Actual_length, Actual_width);
            //Act
            int Actual_Perimeter = testrectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(Actual_Perimeter, Expected_Perimeter);
        }
        [Test]
        public void Get_Area_inputlength9_inputwidth9_Expectedoutput81()
        {
            //Arrange
            int Actual_length = 9;
            int Actual_width = 9;
            int Expected_Area = 81;

            Rectangle testrectangle = new Rectangle(Actual_length, Actual_width);
            //Act
            int Actual_Area = testrectangle.GetArea();
            //Assert
            Assert.AreEqual(Actual_Area, Expected_Area);
        }

    }
}
