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

System.Console.WriteLine("Проверка на пустоту");
string empty = "";
string nullstring = null;
bool isnulempty = string.IsNullOrEmpty(empty);
bool isnulempty1 = string.IsNullOrEmpty(nullstring);
System.Console.WriteLine(isnulempty);
System.Console.WriteLine(isnulempty1);

System.Console.WriteLine("Проверка на пустоту");
string backsp = " ";
bool isnulempty2 = string.IsNullOrWhiteSpace(backsp);
System.Console.WriteLine(isnulempty2);


//Объединение строк

string str = string.Concat("My ", "name ", "is ", "John.");
System.Console.WriteLine(str);

string str1 = string.Join(" ", "My", "name", "is", "John.");
System.Console.WriteLine(str1);

str1 = str1.Insert(0, "By the way, "); //Вставляет подстроку начиная с 0 индекса
System.Console.WriteLine(str1);

str1 = str1.Remove(0, 3); //Удаляет символы с 0 по 3 индекс подстроки 
System.Console.WriteLine(str1);

string str2 = str.Replace('n', 'k'); //Заменяет все символы n на k
System.Console.WriteLine(str2);

string data = "1;2;3;4;5;6;7;8;9";
string[] splitdata = data.Split(';');
string first = splitdata[3];
System.Console.WriteLine(first);



