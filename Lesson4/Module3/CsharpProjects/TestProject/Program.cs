/**
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

string pangram = "The quick brown fox jumps over the lazy dog";

//Split pangram to one array per word
string[] words = pangram.Split(' ');
foreach (var word_arr in words){
    //Reverse each word array
    char[] charArray = word_arr.ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = new string(charArray);
    Console.Write(reversedWord + " ");
}
