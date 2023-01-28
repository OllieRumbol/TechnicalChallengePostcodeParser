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
    PostCode parsedPostCode = PostCode.FromString(postcode);

    Console.WriteLine($"# POSTCODE: {postcode}");
    Console.WriteLine($"\tOUTWARD CODE: {parsedPostCode.OutwardCode}");
    Console.WriteLine($"\t\tOUTWARD LETTER: {""}");
    Console.WriteLine($"\t\tOUTWARD NUMBER: {""}");
    Console.WriteLine($"\tINWARD CODE: {parsedPostCode.InwardCode}");
    Console.WriteLine();
    Console.WriteLine();
}