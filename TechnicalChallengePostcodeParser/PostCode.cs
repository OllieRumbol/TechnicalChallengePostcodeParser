using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalChallengePostcodeParser;

public class Postcode
{
    public string OutwardCode { get; init; }

    public string OutwardLetter { get; init; }

    public string OutwardNumber { get; set; }

    public string InwardCode { get; init; }

    private Postcode(string outwardCode, string outwardLetter, string outwardNumber, string inwardCode)
    {
        OutwardCode = outwardCode;
        OutwardLetter = outwardLetter;
        OutwardNumber = outwardNumber;
        InwardCode = inwardCode;
    } 

    public static Postcode FromString (string postcode)
    {
        postcode = postcode.Replace(" ", "").ToUpper();

        if (postcode.Length < 5 || postcode.Length > 7)
        {
            throw new ArgumentException("Invalid postcode, need to between 5 and 7 characters");
        }

        if (postcode.All(Char.IsLetterOrDigit) == false)
        {
            throw new ArgumentException("Invalid postcode, needs to only contain letters and numbers");
        }
        
        string outwardCode = postcode.Substring(0, postcode.Length - 3);
        string inwardCode = postcode.Substring(postcode.Length - 3, 3);

        if(Char.IsLetter(outwardCode.First()) == false)
        {
            throw new ArgumentException("Postcode is invalid, outward code must start with a letter");
        }

        if (Char.IsNumber(inwardCode.First()) == false)
        {
            throw new ArgumentException("Postcode is invalid, inward code must start with a number");
        }

        string outwardLetter;
        string outwardNumber;
        if (outwardCode.Length is 2)
        {
            outwardLetter = outwardCode.First().ToString();
            outwardNumber = outwardCode.Last().ToString();
        }
        else if (outwardCode.Length is 3)
        {
            outwardLetter = outwardCode.First().ToString();
            outwardNumber = outwardCode.Substring(1, 2);
        }
        else
        {
            outwardLetter = outwardCode.Substring(0, 2);
            outwardNumber = outwardCode.Substring(2, 2);
        }

        return new Postcode(outwardCode, outwardLetter, outwardNumber, inwardCode);
    }
}
