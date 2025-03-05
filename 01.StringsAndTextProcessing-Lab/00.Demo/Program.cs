using System.Text;

string name = "Pesho";
Console.WriteLine(name);

// вземане на дължината на текст
int length = name.Length;

// достъпване на първия символ в тескста
char firstSymbol = name[0];

// достъпване на последния символ в тескста
char lastSymbol = name[name.Length - 1];

//name[0] = 'G'; -> Compile time eror - type string is Read Only!!!

//подаване на няколко параметъра на string.Join
string fullName = string.Join(" ", "Diyаn", "Petrov", "Apostolov");

Console.WriteLine(fullName); //Diyаn Petrov Apostolov

//текст представен като масив от char 
char[] charArray = name.ToCharArray();

//промяна на някой от елементите на масива с друг
charArray[0] = 'G';

Console.WriteLine(string.Join("", charArray)); //Gesho

// Unicode symbols

string unicodeText = "你好";

Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine(unicodeText);

// построяване на нов string като подадем char и колко пъти да се повтори
string text = new string('*', 5); 

Console.WriteLine(text); // "*****"

//StringBuilder

StringBuilder sb = new StringBuilder();

sb.Append("Diyan, ");
sb.Append("Apostolov");

Console.WriteLine(sb);  //Diyan, Apostolov

//метода Append добавя елементите на един и същи ред
//метода AppendLine добавя елементите на отделни редове

//обръщане на StringBuilder в тип string
string str = sb.ToString();






