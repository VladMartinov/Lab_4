using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
static char[] Code(char[] Array)
{
    char[] Massiv = new char[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (i + 1 == Massiv.Length)
        {
            Massiv[i] = Array[i];
        }
        else
        if (i % 2 == 0)
        {
            Massiv[i] = Array[i + 1];
        }
        else
        {
            Massiv[i] = Array[i - 1];
        }
    }
    return Massiv;
}
static char[] Decode(char[] Code1)
{
    char[] DeMassiv = new char[Code1.Length];
    /*foreach(char G in Code1)
    {
        Console.Write(G);
    }*/
    DeMassiv = Code1;
    /* for (int i = 0; i < Code1.Length; i++)
     {
         if (i == 0)
         {
             DeMassiv[i] = Code1[i+1];
             Console.Write(DeMassiv[i]);
         }
         else
         if (i + 1 == Code1.Length)
         {
             DeMassiv[i] = Code1[i];
             Console.Write(DeMassiv[i]);
         }
         else
         if (i % 2 == 0)
         {
             DeMassiv[i] = Code1[i+1];
             Console.Write(DeMassiv[i]);
         }
         else
         {
             DeMassiv[i] = Code1[i-1];
             Console.Write(DeMassiv[i]);
         }
     }*/
    return DeMassiv;
}
static int[] MinDifference(int[] sec)
{
    int[] A = sec;
    int[] SortedSecsArray = sec.OrderBy(x => x).ToArray();
    int[] Diff = new int[SortedSecsArray.Length - 1];
    for (int i = 1; i < SortedSecsArray.Length; i++)
    {
        Diff[i - 1] = SortedSecsArray[i] - SortedSecsArray[i - 1];

    }
    int cord = Array.IndexOf(Diff, Diff.Min());
    int[] Index = { SortedSecsArray[cord], SortedSecsArray[cord + 1] };

    return Index;
}
Console.WriteLine("Добро пожаловать в Лабораторную работу 4!");
int Cvest = int.Parse(Console.ReadLine());
switch (Cvest)
{
    case 1:
        {
            Console.WriteLine("Задание 1");
            string Line = Console.ReadLine();
            Line = Line.ToLower();
            char[] Massiv = Line.ToCharArray();
            char[] arr = new char[Line.Length];
            char[] arr2 = Line.ToCharArray();
            Console.WriteLine("Через Метод:");
            for (int i = 0; i < Line.Length; i++)
            {
                if (arr.Contains(Line[i]))
                {
                    Massiv[i] = ' ';
                }
                arr[i] = Massiv[i];
            }
            foreach (char x in Massiv)
            {
                if (x == ' ')
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine("\nЧерез Стринг:");
            string LineString ="";
            int Numeration = 0;
            for (int i = 0; i < Line.Length ; ++i)
            {

                if (LineString.Contains(Line[i]))
                {
                }
                else
                {
                    LineString += Line[i];
                    LineString += ' ';
                }
            }         
            Console.WriteLine(LineString);           
            break;
        }
    case 2:
        {
            Console.WriteLine("Введите строку");
            string Line = Console.ReadLine();
            Line = Line.Trim();
            char[] Massiv = Line.ToCharArray();
            int Num = 0;
            int Numeration = 0;
            int i = 0;
            Console.WriteLine("Через массив:");
            char[] separatorsChar = { '-', ',', '–', '!', '.' };

            foreach (char H in Massiv)
            {
                if (i+1==Massiv.Length)
                {
                    if (H == '.' || H == '!' || H == '?' || H ==' ')
                    {
                        Num++;
                        Console.Write($"({Num})" + H);
                    }  
                    else
                    {
                        Num++;
                        Console.Write(H+$"({Num})" );
                        Console.Write(".");
                    }
                }
                else
                if (H == ' ')
                {
                    for (int k = 0; k < separatorsChar.Length; k++)
                    {
                        if (Massiv[i-1]==separatorsChar[k])
                        {
                            Numeration++;
                        }
                    }
                    if(Numeration>0)
                    {
                        Console.Write(H);                       
                    }
                    else
                    {
                        Num++;
                        Console.Write($"({Num})" + H);
                    }
                    Numeration = 0;
                }
                else
                {
                    Console.Write(H);
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Через метод:");
            string[] Line2 = Line.Split(' ');
            string separators = "- _ / ? | . , : !";
            string[] separators2 = separators.Split(' ');
            int Num2 = 1;
            for (int j=0; j<Line2.Length; j++)
            {
                if (j+1== Line2.Length)
                {
                    if (separators2.Contains(Line2[j]))
                    {
                        Console.Write(Line2[j]);
                    }
                    else
                    {
                        Line2[j] = Line2[j].Insert(Line2[j].Length - 1,$"({Num2})") ;
                        Console.Write(Line2[j]);
                        Num2++;
                    }
                }
                else
                if (Line2[j].Length == 1)
                {
                    if (separators2.Contains(Line2[j]))
                    {
                        Console.Write(Line2[j] + " ");
                    }
                }
                else
                {
                    Console.Write(Line2[j] + $"({Num2}) ");
                    Num2++;
                }              
            }
            break;
        }
    case 3:
        {          
            string Line = Console.ReadLine();
            Console.WriteLine("1-й метод:");
            Console.WriteLine("\n2-й метод:");
            string [] Line2 = Line.Split(' ');
            for (int i=Line2.Length-1;i>=0;i--)
            {
                Console.Write(Line2[i]+" ");
            }
            Console.WriteLine("\n3-й метод:");
            StringBuilder builder = new StringBuilder(Line);
            string Line0 = builder.ToString();
            string[] Line3 = Line0.Split(' ');
            for (int i = Line3.Length - 1; i >= 0; i--)
            {
                Console.Write(Line3[i] + " ");
            }
            break;
        }
    case 4:
        {
            string[] Massiv=new string[7];
            char[] Massiv2;
            string[] sg = { ".com" };
            int Num=0;
            int[] Space = new int[7];
            for (int i=0;i<7;i++)
            {
                string Line = Console.ReadLine();
                Massiv[i] = Line;
                Massiv2 = Line.ToCharArray();
                if (Line.Contains(".com"))
                {
                    Console.WriteLine($"Строка под номером {i + 1} содержит .com");
                    Console.WriteLine(Massiv2);
                }
                foreach(char Z in Massiv2)
                {
                    if (Z==' ')
                    {
                        Num++;
                    }
                }
                Space[i] = Num;
                Num = 0;
            }
            int Min = Space.Min();
            Console.Write("\nСтрока по номером:");
            for (int i = 0; i < 7; i++)
            {
                if (Space[i] == Min)
                {
                    Console.Write($"{i + 1},");
                }
            }
            Console.WriteLine(" содержит наименьшее кол-во пробелов.");
            Console.WriteLine("2-й Метод:");
            for (int i =0;i<7;i++)
            {
                if(Massiv[i].Contains(".com"))
                {
                    Console.WriteLine($"Строка под номером {i+1} содержит .com");
                    Console.WriteLine(Massiv[i]);
                }
            }
            int[] Space1 = new int[7];
            for (int i= 0;i<7;i++)
            {
                Space1[i]= (Massiv[i].Split(' ').Length)-1;
            }
            int Min1 = Space1.Min();
            Console.Write("\nСтрока по номером:");
            for (int i=0;i<7;i++)
            {
                if (Space1[i]== Min1)
                {
                    Console.Write($"{i+1},");
                }
            }
            Console.WriteLine(" содержит наименьшее кол-во пробелов.");
            break;
        }
    case 5:
        {
            string Line = Console.ReadLine();
            char[] Mass = Line.ToCharArray();
            string[] Mas = Line.Split(' ');
            Regex regex = new Regex("(^[A-Z]).*([0-9]{2}$)") ;
            foreach (string L in Mas)
            {
                if (regex.IsMatch(L))
                {
                    Console.Write(L + " ");
                }
            }
            /*for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].IsUpper(Mas[i], 0))
                {

                }
            }*/
            break;
        }
    case 6:
        {
            string Line = Console.ReadLine();
            Line = Regex.Replace(Line, @"[\s]", "");
            Line = Regex.Replace(Line, "-", " -");
            Line = Regex.Replace(Line, "[+]", " ");
            Line = Regex.Replace(Line, "=", " ");
            string [] Line0 = Line.Split(' ');
            int[] Num = new int [Line0.Length];
            for (int i=0;i<Line0.Length;i++)
            {
             Num [i]= int.Parse(Line0[i]);
            }
            foreach(int K in Num)
            {
                Console.WriteLine(K);
            }
            break;
        }
    case 7:
        {
            int[] min = new int[10];
            int[] sec = new int[10];
            string[] LineNorm = new string[10];
            LineNorm[0] = "1. Gentle Giant – Free Hand[6:15]";
            LineNorm[1] = "2. Supertramp – Child Of Vision [07:27]";
            LineNorm[2] = "3. Camel – Lawrence [10:46]";
            LineNorm[3] = "4. Yes – Don’t Kill The Whale [3:55]";
            LineNorm[4] = "5. 10CC – Notell Hotel [04:58]";
            LineNorm[5] = "6. Nektar – King Of Twilight [4:16]";
            LineNorm[6] = "7. The Flower Kings – Monsters & Men [21:19]";
            LineNorm[7] = "8. Focus – Le Clochard [1:59]";
            LineNorm[8] = "9. Pendragon – Fallen Dream And Angel [5:23]";
            LineNorm[9] = "10. Kaipa – Remains Of The Day (08:02)";
            List<string> Gt1 = new List<string>();
            Regex regex = new Regex(@"([0-5]{0,1})(\d):([0-5]{0,1}\d)");  //@"([0-5]{0,1})(\d):([0-5]{0,1}\d)"
            for (int i = 0; i < 10; i++)
            {
              //  string Line = Console.ReadLine();
               // Line = Line.Trim();
               
              //      LineNorm[i]= Line;
                MatchCollection matches = regex.Matches(LineNorm[i]);
                if (matches.Count > 0)
                {
                    foreach (Match m in matches)
                    {
                        Gt1.Add(m.Value);

                    }
                }
                /* Line = regex.Replace(Line, "");
                 Line = Regex.Replace(Line, ":", " ");
                 string[] Line0 = Line.Split(' '); */
                /* foreach(string f in Line0)

                 min[i] = int.Parse(Line0[0]);
                 sec[i] = int.Parse(Line0[1]);*/

            }
            int Gt4 = 0;
            foreach(string G in Gt1)
            {
                string[] TmpArray = G.Split(':');
                min[Gt4] = int.Parse(TmpArray[0]);
                sec[Gt4] = int.Parse(TmpArray[1]); ;
                Gt4++;
            }
            int AllTime = 0;
            for (int i = 0; i < 10; i++)
            {
                sec[i] = (sec[i] + (60 * min[i]));
                AllTime += sec[i];
            }
            int MIN = sec.Min();
            int MAX = sec.Max();
            Console.WriteLine($"Минимальное время звучания:[{MIN / 60} мин : {MIN % 60} сек]");
            Console.WriteLine($"Максимальное время звучания:[{MAX / 60} мин : {MAX % 60} сек]");
            Console.WriteLine($"Все время звучания: [{AllTime / 3600} ч : {(AllTime/60)%60} мин : {AllTime % 60} сек]");
            
            Console.WriteLine($"Минимальная разница звучания: [{(MinDifference(sec)[1] - MinDifference(sec)[0]) / 60} мин: {(MinDifference(sec)[1] - MinDifference(sec)[0]) % 60} сек]");
            int[] cord1 = new int[2];
            int V = 0;
            foreach (int L in sec)
            {
                if (L == MinDifference(sec)[0])
                {
                    cord1[V] = Array.IndexOf(sec, L);
                    V++;
                }
                else
                if (L == MinDifference(sec)[1])
                {
                    cord1[V] = Array.IndexOf(sec, L);
                    V++;
                }
            }
            Console.WriteLine("Треки с минимальной разницой во времени:");
            Console.WriteLine("Трек 1: " + LineNorm[cord1[0]]);
            Console.WriteLine("Трек 2: " + LineNorm[cord1[1]]);


            break;
        }
    case 8:
        {           
            Console.WriteLine("Введите строку:");
            string Line = Console.ReadLine();
            char[] Array = new char[Line.Length];
            Array = Line.ToCharArray();
            Console.WriteLine("\nШифр простой одинарной перестановки:");
            char[] Code1 = new char[Code(Array).Length];
            int Num = 0;
            char[,] Array2;
            Array2 = new char[(Line.Length / 2) + (Line.Length % 2), (Line.Length / (Line.Length / 2))];
            char[] CodedLine = new char[Line.Length];
            char[,] CodedArray = new char[(Line.Length / (Line.Length / 2)), (Line.Length / 2) + (Line.Length % 2)];
            for (int i = 0; i < (Line.Length / 2) + (Line.Length % 2); i++)
            {
                for (int l = 0; l < Line.Length / (Line.Length / 2); l++)
                {
                    if (Num == Line.Length)
                    {
                        break;
                    }
                    Array2[i, l] = Array[Num];

                    Num++;
                }
            }
            Num = 0;
            //for (int i = (Line.Length / 2)  -2 ; i >= 0; i--)
            for (int i = 0; i < Line.Length / (Line.Length / 2); i++)
            {
                for (int l = 0; l < (Line.Length / 2) + (Line.Length % 2); l++)
                {
                    if (Num == CodedLine.Length)
                    {
                        break;
                    }
                    CodedLine[Num] = Array2[l, i];
                    CodedArray[i, l] = Array2[l, i];
                    Num++;
                }
            }
            Console.Write("Зашифрованный: ");
            foreach (char G in CodedLine)
            {
                Console.Write(G);
            }
            Num = 0;
            char[] DeCodedLine = new char[CodedLine.Length];
            for (int i = 0; i < (CodedLine.Length / 2) + (CodedLine.Length % 2); i++)
            {
                for (int l = 0; l < CodedLine.Length / (CodedLine.Length / 2); l++)
                {
                    if (Num == CodedLine.Length)
                    {
                        break;
                    }
                    DeCodedLine[Num] = CodedArray[l, i];
                    Num++;
                }
            }
            Console.Write("\nРасшифрованный: ");
            foreach (char G in DeCodedLine)
            {
                Console.Write(G);
            }
            Console.WriteLine("\nКнижный шифр:\n");
            Console.WriteLine("Введите кол-во строк стиха:");
            int Num00 = int.Parse(Console.ReadLine());
            string[] Verse = new string[Num00];
            char[] CharVerse = new char[Verse.Length];
            for (int i = 0; i < Verse.Length; i++)
            {
                Verse[i] = Console.ReadLine();
            }
            string[] CodeBook = new string[Array.Length];
            int j = 0;
            int z = 0;
            char[] Mass1;
            for (int k = 0; k < Array.Length; k++)
            {
                for (int i = 0; i < 8; i++)
                {
                    Mass1 = Verse[i].ToCharArray();
                    for (int j2 = 0; j2 < Mass1.Length; j2++)
                    {
                        if (Array[k] == Mass1[j2])
                        {
                            CodeBook[k] = i + "/" + j2;
                            j++;
                            break;
                        }

                    }
                    if (j > 0)
                    {
                        j = 0;
                        z = 0;
                        break;
                    }
                    if (i + 1 == 8)
                    {
                        CodeBook[k] = 0 + "/" +0;
                    }
                }
            }
            Console.Write("\nЗашифрованный : ");
            foreach (string G in CodeBook)
            {
                    Console.Write(G + " ");
            }
            int[] DeCode;
            for (int i = 0;i<CodeBook.Length;i++)
            {
                if (CodeBook[i] == "")
                {
                }
                else
                {
                    CodeBook[i] = Regex.Replace(CodeBook[i], "/", " ");
                }
            }
            string[] Length;
            char[] DeCode3=new char [Line.Length+1];
            int Num3 = 0;
            for (int k = 0; k < Array.Length; k++)
            {
                for (int i = 0; i < 8; i++)
                {
                    Length = CodeBook[k].Split(' ');
                    DeCode = new int[Length.Length];
                    DeCode[0] = int.Parse(Length[0]);
                    DeCode[1] = int.Parse(Length[1]);
                    Mass1 = Verse[i].ToCharArray();
                    if (DeCode[0] == i)
                    {
                        for (int j1 = 0; j1 < Mass1.Length; j1++)
                        {    
                           
                            if (DeCode[1] == j1)
                            {
                                DeCode3[Num3] = Mass1[j1];
                                Num3++;
                            }

                        }
                    }
                }
            }
            
            Console.Write("\nРасшифрованный : ");
            foreach (char c in DeCode3)
            {
                Console.Write(c);
            }
            Console.Write("\nШифр Виженера : ");

            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789 .,!?;‏؟‏‎(.―[],(){}⟨⟩)„“«»“”‘’‹›:";
            string text = Line;
            string StartText = text;
            Console.WriteLine("\nВведите ключ: ");
            string key = Console.ReadLine();
            int Num1 = 0;
            for (int i = 0; i < key.Length - 1; i++)
            {
                if (i + 1 > text.Length)
                {
                    text = text + text[Num1];
                    Num1++;
                }
            }
            StringBuilder codedText = new StringBuilder();
            StringBuilder DecodedText = new StringBuilder();
            int[] keyIndex = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                keyIndex[i] = alphabet.IndexOf(key[i]);
            }
            for (int i = 0; i < text.Length; i++)
            {
                codedText.Append(alphabet[
                    (alphabet.IndexOf(text[i]) + keyIndex[i % key.Length]) % alphabet.Length]);
            }
            Console.WriteLine($"Зашифрованны: {codedText}");
            for (int i = 0; i < codedText.Length; i++)
            {
                DecodedText.Append(alphabet[
                    (((alphabet.IndexOf(codedText[i]) + alphabet.Length) - keyIndex[i % key.Length]) % alphabet.Length)]);
            }
            Console.WriteLine($"Расшифрованны: {DecodedText}");
            break;
        }
    case 9:
        {
            string Line = Console.ReadLine();
            /* Line = Regex.Replace(Line, @"\bAND\b", "&");
             Line = Regex.Replace(Line, @"\bOR\b", "|");
             Console.WriteLine(Line);*/
            char[] Array = Line.ToCharArray();
            if (Line.Contains("AND"))
            {
                Line = Line.Replace("AND", "&");
            }
            if (Line.Contains("OR"))
            {

                Line = Line.Replace("OR", "|");

            }
            Console.WriteLine(Line);
            for (int i = 0; i < Array.Length; i++)
            {
                if(Array[i] == 'A' && i+2<Array.Length)
                {
                    if(Array[i+1]=='N')
                    {
                        if (Array[i + 2] == 'D')
                        {
                            Array[i] = '&';
                            Array[i + 1] = ' ' ;
                            Array[i + 2] = ' ';
                        }
                    }
                }
                if (Array[i] == 'O' && i + 1 < Array.Length)
                {
                    if (Array[i + 1] == 'R')
                    {
                        Array[i] = '|';
                        Array[i + 1] = ' ';
                    }
                }
                    
            }
            Console.WriteLine();
            foreach(char B in Array)
            {
                Console.Write(B);
            }
            break;
        }
    case 10:
        {
            string Line = Console.ReadLine();
            Regex regex = new Regex(@"\b[a-zA-Zа-яА-Я0-9]*[:int|:short|:byte][0-9]*\b");
            //Line = Regex.Replace(Line, @"\b[a-zA-Zа-яА-Я0-9]*[:int|:short|:byte][0-9]*\b", "1");
            string[] Mas = Line.Split(' ');
            foreach(string G in Mas)
            {
                if (regex.IsMatch(G))
                {
                    Console.WriteLine(G);
                }
            }
                
            break;
        }
    case 11:  //Тестовый
        {
            string Line = Console.ReadLine();
            char[] Array = Line.ToCharArray();
            char[,] Array2;
            Array2 = new char[(Line.Length / 2) + (Line.Length % 2), (Line.Length / (Line.Length / 2))];         
            char[] CodedLine = new char [Line.Length];
            char[,] CodedArray= new char[(Line.Length / (Line.Length / 2)), (Line.Length / 2) + (Line.Length % 2)];
            int Num = 0;
            for (int i = 0; i < (Line.Length / 2)+(Line.Length%2); i++)
            {
                for (int j = 0; j < Line.Length / (Line.Length / 2); j++)
                {
                    if (Num == Line.Length)
                    {
                        break;
                    }
                    Console.WriteLine(i + " Мас " + j);
                    Array2[i, j] = Array[Num];
                   
                    Num++;
                }
            }
            Num = 0;
            //for (int i = (Line.Length / 2)  -2 ; i >= 0; i--)
            for (int i = 0; i < Line.Length / (Line.Length / 2); i++)
            {
                for (int j = 0; j < (Line.Length / 2) + (Line.Length % 2); j++)
                {
                    if (Num == CodedLine.Length)
                    {
                        break;
                    }
                    CodedLine[Num] = Array2[j, i];
                    CodedArray[i, j] = Array2[j, i];
                    Num++;
                }
            }
            Console.Write("Зашифрованный: ");
            foreach (char G in CodedLine)
            {
                Console.Write(G);
            }
            Num = 0;
            char[] DeCodedLine = new char[CodedLine.Length];
            for (int i = 0; i < (CodedLine.Length / 2) + (CodedLine.Length % 2); i++)
            {
                for (int j = 0; j < CodedLine.Length / (CodedLine.Length / 2); j++)
                {
                    if (Num == CodedLine.Length)
                    {
                        break;
                    }
                    DeCodedLine[Num] = CodedArray[j, i];
                    Num++;
                }
            }
            Console.Write("\nРасшифрованный: ");
            foreach (char G in DeCodedLine)
            {
                Console.Write(G);
            }
            break;
        }
}
