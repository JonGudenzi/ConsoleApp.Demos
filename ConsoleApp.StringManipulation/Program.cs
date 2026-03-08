using System.Security.AccessControl;

Console.WriteLine("-------- String manipulation ---------");

//Initialize with a regular string literal.
string s1 = "This is a literal string.";  //preferred way to initialize a string
String s2 = "This is also a literal string.";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

//Declare without Initializing. (Possible null exeption)
string s3;

//Initialize to null (possible null exeption)
string? s4 = null;
Console.WriteLine($"{nameof(s4)}: {s4}"); // Output: s4:

//Initialize as an empty string
string s5 = string.Empty; //preferred way to initialize an empty string
string s6 = "";
Console.WriteLine($"{nameof(s5)}: {s5}"); // Output: s5:
Console.WriteLine($"{nameof(s6)}: {s6}"); // Output: s6:

//Escape sequences and character 
string sentence = "She said, \"I have your money\" /r/n This is the next line ";
Console.WriteLine($"{nameof(sentence)}: {sentence}");


//Verbatim string literal (ignores escape characters)
string path = "C:\\program files\\programfolder";
string newPath = @"C:\program files\programfolder";
Console.WriteLine($"{nameof(path)}: {path}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// Raw string literal 
string rawLiteral = """
    This is a raw string literal.
    It can span multiple lines and include "quotes" without needing to escape them.
    """;  // If there are multiple lines, the closing """ must be on a new line and indented to the same level as the opening """.

// Review contatenation and interpolation
s1 += s2;
string newString = $"{s1} {s2} Some random text"; // string interpolation    
string newString1 = s1 + $"{s1} {s2} Some random text"; // string concatenation with interpolation
string newString2 = String.Format("Literal string {0} {1}", s1, s1);

/* String manupulation methods and properties. Somtimes it is just assessments */

//Null or empty check
// find the length of a string
Console.WriteLine($"Length of {nameof(s1)} has a length of {s1.Length}");


// Substring


// Null or empty check

//Splitting strings

// Replace

// Convert to string

// Changing Formatting

// String comparison