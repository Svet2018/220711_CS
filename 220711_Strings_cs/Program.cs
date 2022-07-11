// Contains

string name = "asdfghjgfd";

bool containsA = name.Contains('A'); //Содержит ли литерал А
bool containsa = name.Contains('a');

System.Console.WriteLine(containsA); //False
System.Console.WriteLine(containsa); //True

bool endwith = name.EndsWith("fd"); //  Оканчивается ли на подстроку fb
System.Console.WriteLine(endwith); //True

bool startwith = name.StartsWith("asd"); //  Начинается ли на подстроку asd
System.Console.WriteLine(endwith); // True

int indexOfG = name.IndexOf('g'); // Нахождение индекса первого символа в строке
System.Console.WriteLine(indexOfG);

int indexOfg = name.IndexOf('g', 5); // Нахождение индекса символа в строке, начиная с 5 индекса
System.Console.WriteLine(indexOfg);

int indexOfd = name.LastIndexOf('d'); // Нахождение последнего индеска символа
System.Console.WriteLine(indexOfd);

System.Console.WriteLine(name.Length); // Вывод в консоль длины строки

string substr = name.Substring(4); // Взятие подстроки с 4 индекса
System.Console.WriteLine(substr);

string substri = name.Substring(0, 3); // Взятие подстроки щт 0 до 3 индекса
System.Console.WriteLine(substri);
