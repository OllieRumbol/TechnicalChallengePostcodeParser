using TechnicalChallengePostcodeParser;

namespace TechnicalChallengePostcodeParserUnitTests;

[TestClass]
public class PostCodeUnitTests
{
    [TestMethod]
    public void ParsePostcodeStringToObjectSuccessfullyOutwardAndInward()
    {
        // Arrange 
        string postcode = "m28 7Jp";
        string outwardCode = "M28";
        string inwardCode = "7JP";

        // Act 
        PostCode postcodeParsed = PostCode.FromString(postcode);

        // Assert
        Assert.AreEqual(outwardCode, postcodeParsed.OutwardCode);
        Assert.AreEqual(inwardCode, postcodeParsed.InwardCode);
    }

    [TestMethod]
    public void ParsePostcodeStringToObjectSuccessfully()
    {
        // Arrange 
        string postcode = "tn23 3NG";
        string outwardLetter = "TN";
        string outwardNumber = "23";

        // Act 
        PostCode postcodeParsed = PostCode.FromString(postcode);

        //Assert
        Assert.AreEqual(outwardLetter, postcodeParsed.OutwardLetter);
        Assert.AreEqual(outwardNumber, postcodeParsed.OutwardNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ParsePostcodeStringToObjectWithInvalidLength()
    {
        // Arrange
        string postcode = "CT400078DS";

        // Act
        PostCode postcodeParsed = PostCode.FromString(postcode);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ParsePostcodeStringToObjectWithInvalidCharacters()
    {
        // Arrange
        string postcode = "NY!! &*$";

        // Act
        PostCode postcodeParsed = PostCode.FromString(postcode);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ParsePostcodeStringToObjectWithInvalidFirstCharacter()
    {
        // Arrange
        string postcode = "123 456";

        // Act
        PostCode postcodeParsed = PostCode.FromString(postcode);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ParsePostcodeStringToObjectWithInvalidFirstCharacterInwardCode()
    {
        // Arrange
        string postcode = "AB56 opn";

        // Act
        PostCode postcodeParsed = PostCode.FromString(postcode);
    }
}