
SortedDictionary<string, double> fruits = new SortedDictionary<string, double>();

// добавяне на елементи в речника (KeyValuePair)
fruits["banana"] = 2.20;
fruits["apple"] = 1.90;

fruits.Add("kiwi", 3.20);
fruits.Add("grape", 4.20);

// премахване на KeyValuePair от речника по ключ
fruits.Remove("apple");

// добавяне на нов KeyValuePair
fruits.Add("mango", 5.20); // този kvp влиза на мястото на изтрития "apple"
fruits.Add("golden apple", 7.60);

foreach (var kvp in fruits)
{
    Console.WriteLine($"Fruit: {kvp.Key} - Price: {kvp.Value:F2}");
}


// филтриране на колекцията само с числа по-големи от 5
List<int> numbers = new () { 1, 2, 13, 4, -5, 6 };

List<int> numbersBiggerThanFive = numbers.Where(n => n > 5).ToList();

Console.WriteLine(string.Join(", ", numbers));               // 1, 2, 13, 4, -5, 6
Console.WriteLine(string.Join(", ", numbersBiggerThanFive)); // 13, 6












