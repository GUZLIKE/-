// {
//     Console.WriteLine("Hello World!");
//     {
//         Console.WriteLine("Howdy!");
//     }
// }

// {
//     int number;
//     {
//         number = 4561234;
//     }
//     {
//         Console.WriteLine($"{number}");
//     }
//     string my_name;
//     {
//         my_name = "Bob";
//     }
//     {
//         Console.WriteLine($"{my_name}");
//     }
//     const string NAME = "Tom";
//     {
//         Console.WriteLine($"{NAME}");
//     }
//     {
//         Console.WriteLine($"{my_name}"+","+$"{NAME}");
//     }
// }


// {
// Console.WriteLine(true);
// Console.WriteLine(false);
// }

// {
//     Console.WriteLine(0b100011010011001); 
//     Console.WriteLine(0xF1);
// }

// {
//     string name;
//     {
//         name = "Bob";
//     }
//     {
//         Console.WriteLine($"{name}");
//     }
//     string name_2;
//     {
//         name_2 = "Tom";
//     }
//     {
//         Console.WriteLine($"{name}\n{name_2}");
//     }
//     {
//         Console.WriteLine('\x23');
//     }
//     {
//         Console.WriteLine("Компания \"Чук И КОК\"");
//     }
// }


// {
//     char a;
//     {
//         a = 'A';
//     }
//     {
//         Console.WriteLine($"{a}");
//     }
//     char b;
//     {
//         b = '\x5A';
//     }
//     {
//         Console.WriteLine($"{b}");
//     }
// }


// string name = "Tom";
// int age = 33;
// bool isEmplooyed = false;
// double weight = 78.31;


// {
//     Console.WriteLine($"Имя:{name}");
//     Console.WriteLine($"Возраст:{age}");
//     Console.WriteLine($"Работает:{isEmplooyed}");
//     Console.WriteLine($"Вес:{weight}");
// }

// string name = "Mike";
// int age = 33;
// double height = 1.7;
// Console.WriteLine($"Имя: {name}, Возраст: {age}, Рост: {height}м.");

// Console.Write("Введите своё имя:");
// string? name = Console.ReadLine();
// Console.Write("Введите свой возраст:");
// string? age = Console.ReadLine();
// Console.Write("Введите ваш рост:");
// string? height = Console.ReadLine();
// Console.WriteLine("Введите ваш вес:");
// string? weight = Console.ReadLine();
// Console.WriteLine($"Привет {name}!");
// Console.WriteLine($"Твой возраст:{age}");
// Console.WriteLine($"Твой рост: {height} метров");
// Console.WriteLine($"Твой вес: {weight} кг");

// Console.Write("Введите имя: ");
// string? name = Console.ReadLine();



// Console.Write("Введите возраст: ");
// int age = Convert.ToInt32(Console.ReadLine());



// Console.Write("Введите рост: ");
// double height = Convert.ToDouble(Console.ReadLine());



// Console.Write("Введите размер зарплаты: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine());


// Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м Зарплата: {salary}$");

// int a = 10;
// int b = 5 + a;
// int a = 25;
// int b = a / 5;
// int a = 25;
// int b = 5;
// int c = a / b;

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// int a = 10; 
// int b = 5;
// int c = 10;
// bool z = a>b;
// bool d = c<=a;
// Console.WriteLine(z);
// Console.WriteLine(d);

// int a = 10;
// int b = 10;
// if(a>b)
// {
//     Console.WriteLine($"Число {a} больше чем {b}");
// }
// else
// {
//     Console.WriteLine($"Число {b} больше чем {a}");
// }

Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int z;
while(!int.TryParse(Console.ReadLine(), out z))
Console.WriteLine("Веденное значение не число, повторите ввод");
Console.WriteLine(z);
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(b);



if(a>b)
{
    Console.WriteLine($"Число {a} больше чем число {b}");
}
else if (a<b)
{
    Console.WriteLine($"Число {a} меньше чем число {b}");
}



// finally
// {
//     if(a>b)
// {
//     Console.WriteLine($"Число {a} больше чем число {b}");
// }
// else if (a<b)
// {
//     Console.WriteLine($"Число {a} меньше чем число {b}");
// }
// }



