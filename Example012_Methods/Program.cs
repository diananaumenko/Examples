// Вид 1
//void Method1()
//{
  //  Console.WriteLine("Автор ...");
//}
// Method1();



// Вид2
//void Method2(string msg)
//{
 //   Console.WriteLine(msg);
//}
// Method2("Текст сообщения");

// void Method21(string msg,int count)
// {
 //    int i = 0;
 //   while (i < count)
  //  {
 //       Console.WriteLine(msg);
 //       i++;
 //   }
//}
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");


// Вид3

//int Method3()
//{
//    return DateTime.Now.Year;
//}

//int year = Method3();
//Console.WriteLine(year);



// Вид4 синтаксис цикла while
// string Method4(int count, string text)
//{
  //  int i = 0;
    //string result = String.Empty;

    //while (i < count)
    //{
   //     result = result + text;
    //    i++;
    //}
    //return result;
//}

//string res = Method4(10, "asdf");
//Console.WriteLine(res);


// Вид4 синтаксис цикла for
//string Method4(int count, string text)
//{
  //  string result = String.Empty;
  //  for ( int i = 0; i < count; i++)
  //  {
  //      result = result + text;
 //   }
//    return result;
//}

//string res = Method4(10, "asdf");
//Console.WriteLine(res);

//for (int i = 2; i <= 10; i++)
//{
 //  for (int j = 0; j <= 10; j++)
 //   {
 //       Console.WriteLine($"{i} x {j} = {i*j}");
 //   }
 //   Console.WriteLine();
//}

//===== Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими буквами "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласия пруссокого короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine( );
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replase(newText, 'C', 'c');
Console.WriteLine(newText);