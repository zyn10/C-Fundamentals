// String with characters

string someString = ".....My city isFaisalabad****";

char[] charsToTrim = { '*', '.' };

string cleanString = someString.Trim(charsToTrim);

Console.WriteLine(cleanString);
