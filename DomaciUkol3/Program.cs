using Microsoft.VisualBasic;
using System.Text;

string[] morseovyZnaky = { ".-", "-...", "-.-.","-.-.", "-..", "-..", ".", "..-.", "--.", "....", "..", "..",".---", "-.-", ".-..",
    "--", "-.", "-.", "---", "---", ".--.", "--.-", ".-.",".-.", "...","...","-", "-", "..-","..-","..-", "...-", ".--", "-..-", "-.--", "-.--", "--..", ",","?", "!", "\"" };

char[] alpha = "ABCČDĎEFGHIÍJKLMNŇOÓPQRŘSŠTŤUŮÚVWXYÝZ,?!\"".ToCharArray();

//kontrola, jestli to sedí
//for (int i= 0; i < morseovyZnaky.Length; i++)
//{
//    Console.WriteLine("Morseovka " + morseovyZnaky[i] + " a abeceda " + alpha[i]);
//}

Console.WriteLine("Zadej text: ");
string text = Console.ReadLine().ToUpper();
char[] poleZnaku = new char[text.Length];
string[] poleZnakuMorse = new string [text.Length];

for (int i = 0; i < poleZnaku.Length; i++)
{
    poleZnaku[i] = text[i];
    int index = Array.IndexOf(alpha, poleZnaku[i]);
    poleZnakuMorse[i] = morseovyZnaky[index];
 }

string vysledek = string.Join('|', poleZnakuMorse);

Console.WriteLine(vysledek + "||");
Console.ReadLine();