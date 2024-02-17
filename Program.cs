// Задача 1: Задайте двумерный массив символов (тип char
// // // [,]). Создать строку из символов этого массива. 
// a b c => “abcdef”
// d e f 

// string GetStringFromCharArray (char[,] array)

// {
//     string result = string.Empty; 
//     for (int i = 0; i < array.GetLength(0); i++) 
//      {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//       result += array[i, j];    
//      }

//  }
//   return result;
// }

// char [,] chars = {{'a', 'b', 'c'}, {'d', 'e', 'f'}};
// string res  = GetStringFromCharArray(chars);
// Console.WriteLine(res);



//  Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-”
// int Char (string str)

// string charString = "1H56Shfed";
// Console.WriteLine(charString.ToLower());

// / Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш”/ => Да
// “55655” => Да
     
//   bool IsPalindrome(string str)
//     {
//         char[] temp = str.ToCharArray();
//         Array.Reverse(temp);
//         string res = new string(temp);

//         if (str.Equals(res))
//         {
//             return true;
//         }
//         else
//         {
//            return false; 
//         }

//     }
//     {
//                 Console.WriteLine(IsPalindrome("шалаш").ToString());
//     }

// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”

// {
// string value = Console.ReadLine();
// string[] words = value.Split(' ');//cтрока с разделенными пробелами
// Console.WriteLine("reversed:");
// Array.Reverse(words);

// for (int i=0; i < words.Length; i++)
// {
// Console.Write(words[i]+ " " );
// }
// Console.ReadKey();//нажатый пользователем симол
// }




    

        
           
 

