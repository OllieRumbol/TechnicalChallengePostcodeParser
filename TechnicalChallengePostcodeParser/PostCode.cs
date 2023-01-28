using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalChallengePostcodeParser;

public class PostCode
{
    public string OutwardCode { get; init; }

    public string OutwardLetter { get; init; }

    public string OutwardNumber { get; set; }

    public string InwardCode { get; init; }

    private PostCode(string outwardCode, string outwardLetter, string outwardNumber, string inwardCode)
    {
        OutwardCode = outwardCode;
        OutwardLetter = outwardLetter;
        OutwardNumber = outwardNumber;
        InwardCode = inwardCode;
    } 

    public static PostCode FromString (string postCode)
    {
        postCode = postCode.Replace(" ", "").ToUpper();

        if (postCode.Length < 5 || postCode.Length > 7)
        {
            throw new ArgumentException("Invalid post code, need to between 5 and 7 characters");
        }
        
        string outwardCode = postCode.Substring(0, postCode.Length - 3);
        string inwardCode = postCode.Substring(postCode.Length - 3, 3);

        string outwardLetter = "";
        string outwardNumber = "";

        return new PostCode(outwardCode, outwardLetter, outwardNumber, inwardCode);
    }
}
