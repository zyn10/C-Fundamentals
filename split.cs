string unilist = "FAST, Comsats, Bahria, ITU";

// Universties separated by comma

string[] unis = unilist.Split(", ");

int len = unis.Length;

for (int i = 0; i < len; i++)

{

    Console.WriteLine(unis[i]);

}
