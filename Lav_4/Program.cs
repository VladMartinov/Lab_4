using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
Console.WriteLine("Введите номер задания(1-7 Обычные задания, 8-11 Индивидуальные задания");
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
            Console.WriteLine("\nЧерез Массив:");
            for (int i = 1; i <= Line.Length - 1; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (arr2[i] == arr2[j])
                    {
                        arr2[i] = ' ';
                    }
                }
            }
            foreach (char v in arr2)
            {
                if (v == ' ')
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(v + " ");
                }
            }
            break;
        }
    case 2:
        {
            Console.WriteLine("Введите строку");
            string Line = Console.ReadLine();
            Line = Line.Trim();
            char[] Massiv = Line.ToCharArray();
            int Num = 0;
            int i = 0;
            Console.WriteLine("Через массив:");
            foreach (char H in Massiv)
            {
                if (H == ' ')
                {
                    if (Massiv[i - 1] != '-' && Massiv[i - 1] != ',')
                    {
                        Num++;
                        Console.Write($"({Num})" + H);
                    }
                    else
                    {
                        Console.Write(H);
                    }
                }
                else
                {
                    Console.Write(H);
                }
                i++;
            }
            Console.WriteLine();
            string[] Line2 = Line.Split(' ');
            string separators = "- _ / ? | . , ";
            string[] separators2 = separators.Split(' ');
            int Num2 = 1;
            for (int j=0; j<Line2.Length; j++)
            {
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
                }
                Num2++;
            }
            break;
        }
    case 3:
        {
            string Line = Console.ReadLine();
            Console.WriteLine("2-й метод:");
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
            Regex regex = new Regex(@"[^0-50-9:0-50-9]");
            for (int i = 0; i < 10; i++)
            {
                string Line = Console.ReadLine();
                Line = Line.Trim();
               
                    LineNorm[i]= Line;
                Line = regex.Replace(Line, "");
                Line = Regex.Replace(Line, ":", " ");
                string[] Line0 = Line.Split(' '); 
                foreach(string f in Line0)
                
                min[i] = int.Parse(Line0[0]);
                sec[i] = int.Parse(Line0[1]);
            }
            int AllTime=0;
            for(int i=0;i<10;i++)
            {
                sec[i] = (sec[i] + (60 * min[i]));
                AllTime += sec[i];
                Console.WriteLine(sec[i]);
            }           
            int MIN = sec.Min();
            int MAX = sec.Max();
            Console.WriteLine($"Минимальное время звучания:[{MIN/60} мин : {MIN%60} сек]");
            Console.WriteLine($"Максимальное время звучания:[{MAX / 60} мин : {MAX % 60} сек]");
            Console.WriteLine($"Все время звучания: [{AllTime/60} мин : {AllTime%60} сек]");
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
            Console.WriteLine($"Минимальная разница звучания: [{(MinDifference(sec)[1]-MinDifference(sec)[0])/60} мин: {(MinDifference(sec)[1] - MinDifference(sec)[0]) % 60} сек]");
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
            Console.WriteLine("Трек 1: "+LineNorm[cord1[0]]);
            Console.WriteLine("Трек 2: " + LineNorm[cord1[1]]);


            break;
        }
    case 8:
        {/*
            Console.WriteLine("Шифр простой одинарной перестановки:");
            string Line = Console.ReadLine();
            char[] Massiv = Line.ToCharArray();
            char[] Shifr = new char[Massiv.Length];
            int[] Num= new int [Massiv.Length];
            Random rnd = new Random();
            for (int i=0;i<Massiv.Length;i++)
            {
                if (i + 1 == Massiv.Length)
                {
                    Shifr[i] = Massiv[i];
                    Num[i] = i;
                }
                else
                if (i % 2 == 0)
                {
                    Shifr[i] = Massiv[i + 1];
                    Num[i] = i + 1;
                }
                else
                {
                    Shifr[i] = Massiv[i - 1];
                    Num[i] = i - 1;
                }

            }
            Console.WriteLine("Зашифрованный:");
            foreach (char F in Shifr)
            {
                Console.Write(F);
            }
            for (int i = 1; i < Massiv.Length; i++)
            {
                if(i-1==0)
                {
                    Shifr[i-1] = Shifr[Num[i-1]];
                }
                if (i + 1 == Massiv.Length)
                {
                    Shifr[i] = Shifr[Num[i]];
                }
                else
                if (i % 2 == 0)
                {
                    Shifr[i] = Massiv[Num[i+1]];
                }
                else
                {
                    Shifr[i] = Massiv[Num[i - 1]];
                }
            }
            Console.WriteLine("\nКод шифратора:");
            foreach (int G in Num)
            {
                Console.Write(G);
            }
            Console.WriteLine("\nДешифровка:");
            foreach (char F in Shifr)
            {
                Console.Write(F);
            }
            Console.WriteLine("\nКнижный шифр");
            char[] Mass1 = Line.ToCharArray();
            int num = 0;
            foreach(char F in Mass1)
            {
                if (F == ' ')
                {
                    num++;
                }
                for(int i=0; i<Mass1.Length;i++)
                {

                }
            }
            */
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
            Console.WriteLine("Введите строку:");
            string Line = Console.ReadLine();
            char[] Array = new char[Line.Length];
            Array = Line.ToCharArray();
            Console.WriteLine("\nШифр простой одинарной перестановки:");
            Console.WriteLine("");
            Console.Write("Зашифрованный : ");
            char[] Code1 = new char[Code(Array).Length];
            int Num = 0;
            foreach (char Read in Code(Array))
            {
                Console.Write(Read);
                Code1[Num] = Read;
                Num++;
            }
            Console.WriteLine();
            Console.Write("Расшифрованный : ");
            foreach (char Read in Decode(Array))
            {
                Console.Write(Read);
            }
            Console.WriteLine("");
            Console.WriteLine("\nКнижный шифр:\n");
            string[] Verse = new string[8];
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
            Line = Regex.Replace(Line, @"\bAND\b", "&");
            Line = Regex.Replace(Line, @"\bOR\b", "|");
            Console.WriteLine(Line);
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
}
