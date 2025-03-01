//  1-	For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.
int sum =0;

Console.WriteLine("ENTER A NUMBER");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = number; i > 0; i /= 10)
{
    sum += i % 10;
}
Console.WriteLine("SUMMATION OF DIGITS OF THE NUMBER ENTERED: " + sum);

//2-	while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)

Console.WriteLine("PLEASE ENTER A NUMBER BETWEEN 10 TO 100");
int number = Convert.ToInt32(Console.ReadLine());

while ( number<10 || number>100)
{
    Console.WriteLine("PLEASE TRY AGAIN ");
    break;
}

//3-	foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)

List<int> ages = new List<int>{ 8, 15 , 22 ,46 ,78 };

foreach(int age in ages)
{
    if( age<=0 && age <=12)
    {
        Console.WriteLine("YOU'RE CHILD");
    }
    else if (age <= 13 && age <= 19)
    {
        Console.WriteLine("YOU'RE YOUNG");
    }
    else if (age <= 20 && age <= 64)
    {
        Console.WriteLine("YOU'RE ADULT");
    }
    else if (age>=65)
    {
        Console.WriteLine("YOU'RE OLD");
    }
    else
    {
        Console.WriteLine("PLEASE ENTER VALİD AGE");
    }

}
//4-	Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.

int[] array = { 1, 2, 3, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 10 };
Console.WriteLine("REPEATING NUMBERS: ");
for(int i = 0; i < array.Length; i++)
{
    bool alreadyProcessed = false;
    
    for(int j = 0; j < i; j++)
    {
        if (array[j] == array[i])
        {
            alreadyProcessed = true;
            break;
        }
    }
    if (alreadyProcessed)
        continue;
    int count = 0;
    
    for(int k=0; k < array.Length; k++)
    {
        if (array[k] == array[i])
            count++;
    }
    if (count > 1)
    {
        Console.WriteLine(array[i]);
    }
}
//5-	Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.
string[] array = { "pembe", "sarı", "lacivert", "mavi", "mor", "siyah", "kahverengi" };

string shortest = array[0];
string longest = array[0];

foreach (string word in array)
{
    if (word.Length < shortest.Length)
        shortest = word;
    if (word.Length > longest.Length)
        longest = word;
}
Console.WriteLine("Shortest word: " + shortest);
Console.WriteLine("Longest word: " + longest);
//6-	Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.
Console.WriteLine("PLEASE ENTER A SENTENCE:");
string sentence = Console.ReadLine();

string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Array.Sort(words, StringComparer.OrdinalIgnoreCase);

Console.WriteLine("\nSorted words alphabetically:");
foreach (string word in words)
{
    Console.WriteLine(word);
}
//7-	Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.
string[] words = new string[0];
int count = 0;

while (true)
{
    Console.Write("Enter a word (or type 'exit' to stop): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    Array.Resize(ref words, count + 1);
    words[count] = input;
    count++;
}

Console.WriteLine("\nWords stored in the array:");
foreach (string word in words)
{
    Console.WriteLine(word);
}
//8-	Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız
List<string> words = new List<string>();

while (true)
{
    Console.Write("ENTER A WORD (OR TYPE 'exit' TO STOP): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    words.Add(input);
}

Console.WriteLine("\nWords with reversed characters:");
foreach (string word in words)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    Console.WriteLine(new string(charArray));
}
//9-	Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.
List<int> numbers = new List<int>();
Console.WriteLine("ENTER NUMBERS (type 'done' to finish):");

while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "done")
        break;

    if (int.TryParse(input, out int number))
        numbers.Add(number);
    else
        Console.WriteLine("Invalid input. Please enter a valid number.");
}

if (numbers.Count > 0)
{
    double average = numbers.Average();
    numbers.Sort();
    Console.WriteLine("\nSorted Numbers:");
    Console.WriteLine(string.Join(", ", numbers));
    Console.WriteLine($"Average: {average:F2}");
}
else
{
    Console.WriteLine("No numbers were entered.");
}
//10-	Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.
List<int> numbers = new List<int> { 5, 12, 8, 20, 3, 15, 7, 25, 30, 2 };

numbers.RemoveAll(n => n < 10);

if (numbers.Count > 0)
{
    double average = numbers.Average();
    numbers.Sort();
    Console.WriteLine("\nSorted Numbers:");
    Console.WriteLine(string.Join(", ", numbers));
    Console.WriteLine($"Average: {average:F2}");
}
else
{
    Console.WriteLine("No numbers remaining after removing values less than 10.");
}
//11-	Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.
List<int> studentGrades = new List<int> { 45, 78, 32, 90, 56, 49, 80, 37, 92, 50 };

for (int i = 0; i < studentGrades.Count; i++)
{
    if (studentGrades[i] < 50)
    {
        studentGrades[i] = 50;
    }
}

Console.WriteLine("\nUpdated Student Grades:");
Console.WriteLine(string.Join(", ", studentGrades));
    
12- Metot (Fonksiyon) nedir?
Metot (veya fonksiyon), belirli bir işi yapmak için yazılan kod parçacığıdır. Bir metodu yazarsak, onu tekrar tekrar kullanabiliriz.
  
13- Metotları neden kullanırız?
Kod tekrarını önler: Aynı kodu her yerde tekrar yazmak yerine bir metot oluşturup çağırabiliriz.
Kod daha anlaşılır olur: Küçük parçalara bölmek, kodu okumayı kolaylaştırır.
Hata yapmayı azaltır: Tek bir yerde değişiklik yaparak tüm kullanımları güncelleyebiliriz

14- Geriye değer döndüren metot ile void metot arasındaki fark nedir?
void metotlar sadece bir işlem yapar, sonuç döndürmez.
return kullanan metotlar bir sonuç döndürür, böylece onu başka yerlerde kullanabiliriz

15- Metotların parametreleri nasıl çalışır?
Metotların parametreleri, metotlara dışarıdan veri göndermemizi sağlar.
Normal parametreler: Metot içine veri gönderilir ama dışarıdaki değişken değişmez.
ref parametreler: Metot, değişkeni değiştirir ve dışarıdaki değeri de etkiler.
out parametreler: Metot, parametreyi içeride hesaplayıp değer atar.
Varsayılan parametreler: Kullanıcı değer vermezse, önceden belirlenen bir değer kullanılır.
