using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTests
  {
    [TestMethod]
    public void QueenConstructor_CreatesInstanceOfQueen_Queen()
    {
      Queen newQueen = new Queen(3,5);
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }
    [TestMethod]
    public void SetX_SetsValueOfX_Void()
    {
      Queen newQueen = new Queen(3,5);
      int newX = 4;
      newQueen.X = newX;
      Assert.AreEqual(newX, newQueen.X);
    }
    [TestMethod]
    public void SetY_SetsValueOfY_Void()
    {
      Queen newQueen = new Queen(3,5);
      int newY = 4;
      newQueen.Y = newY;
      Assert.AreEqual(newY, newQueen.Y);
    }
    [TestMethod]
    public void CheckLegalMove_DeterminesIfFalse_Bool()
    {
      // arrange
      Queen newQueen = new Queen(3,5);
      // act
      bool isLegal = newQueen.CheckLegalMove(1, 8);
      // assert
      Assert.AreEqual(false, isLegal);
    }
    [TestMethod]
    public void CheckLegalMove_DeterminesIfXIsFalse_Bool()
    {
      // arrange
      Queen newQueen = new Queen(3,5);
      // act
      bool isLegal = newQueen.CheckLegalMove(10, 8);
      // assert
      Assert.AreEqual(false, isLegal);
    }
     [TestMethod]
    public void CheckLegalMove_DeterminesIfYIsFalse_Bool()
    {
      // arrange
      Queen newQueen = new Queen(3,5);
      // act
      bool isLegal = newQueen.CheckLegalMove(8, 10);
      // assert
      Assert.AreEqual(false, isLegal);
    }
  }
}



//  [TestMethod]
//     public void SetSide1_SetsValueOfSide1_Void()
//     {
//       // Arrange
//       Rectangle newRectangle = new Rectangle(3, 5);
//       int newLength1 = 44;
//       // Act
//       newRectangle.Side1 = newLength1;
//       // Assert
//       Assert.AreEqual(newLength1, newRectangle.Side1);
//     }


//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()