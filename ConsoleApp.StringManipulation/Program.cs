Console.WriteLine("-------- String manipulation ---------");

//Initialize with a regular string literal.
string s1 = "This is a literal string.";  //preferred way to initialize a string
String s2 = "This is also a literal string.";

//Declare without Initializing. (Possible null exeption)
string s3;

//Initialize to null (possible null exeption)
string? s4 = null;

//Initialize as an empty string
string s5 = string.Empty; //preferred way to initialize an empty string
string s6 = "";

//Escape sequences and character 
string sentence = "She said, \"I have your money\" /r/n This is the next line ";


//Verbatim string literal (ignores escape characters)
string path = "C:\\program files\\programfolder";
string newpPath = @"C:\program files\programfolder";