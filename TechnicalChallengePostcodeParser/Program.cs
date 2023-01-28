using TechnicalChallengePostcodeParser;

List<String> postCodes = new List<String>
{
    "M28 7JP",
    "WC2H7DE",
    "CT21 4LR",
    "N33DP"
};

foreach(string postcode in postCodes)
{
    Postcode parsedPostcode = Postcode.FromString(postcode);

    Console.WriteLine($"# POSTCODE: {postcode}");
    Console.WriteLine($"\tOUTWARD CODE: {parsedPostcode.OutwardCode}");
    Console.WriteLine($"\t\tOUTWARD LETTER: {parsedPostcode.OutwardLetter}");
    Console.WriteLine($"\t\tOUTWARD NUMBER: {parsedPostcode.OutwardNumber}");
    Console.WriteLine($"\tINWARD CODE: {parsedPostcode.InwardCode}");
    Console.WriteLine();
    Console.WriteLine();
}