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

// Console.Write("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(b);

// if(a>b)
// {
//     Console.WriteLine($"Число {a} больше чем число {b}");
// }
// else if (a<b)
// {
//     Console.WriteLine($"Число {a} меньше чем число {b}");
// }


// Console.Write("Введите своё имя:");
// string? name = Console.ReadLine();
// if (name == "Alex")
// {
//     Console.WriteLine("Вас зовут Alex");
// }
// else if (name == "Bob")
// {
//     Console.WriteLine("Вас зовут Bob");
// }
// else if (name == "Ilya")
// {
//     Console.WriteLine("Вас зовут Илья");
// }
// else if (name == "Milya")
// {
//     Console.WriteLine("Вас зовут Milya");
// }
// else
// {
//     Console.WriteLine("ЭТО КАКАЯ-ТО ХУЙНЯ!");
// }



// Console.Write("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1==num2)
// {
//     Console.WriteLine($"Число {num1} равно {num2}.");
// }

// else if (num1>num2)
// {
//     Console.WriteLine($"Число {num1} больше чем {num2}.");
// }

// else if (num1<num2)
// {
//     Console.WriteLine($"Число {num1} меньше {num2}.");
// }

// else
// {
//     Console.WriteLine("Ты как это вызвал?");
// }


// Console.Write("Введите число в диапазоне от 6 до 9:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (5<num1 && num1<10)
// {
//     Console.WriteLine("Число больше 5 и меньше 10");
// }
// else if (num1<5)
// {
//     Console.WriteLine($"Число {num1} меньше 5");
// }
// else
// {
//     Console.WriteLine("Неизвестное число");
// }

// Console.Write("Введите число 5 или число 10:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 == 5 | num1 == 10)
// {
//     Console.WriteLine($"Число  либо равно 5, либо равно 10");
// }
// else if (num1<5)
// {
//     Console.WriteLine($"Число меньше 5");
// }
// else if (num1>10)
// {
//     Console.WriteLine($"Число больше 10");
// }

// for(int i = 1; i<5; i++)
// {
//     Console.WriteLine(i);
// }
// for(int i = 2,j = 3; i<100;i++,j++)
// {
//     Console.WriteLine($"{i*j}");
// }   

// var i = 4;
// var p = 3;
// for (Console.WriteLine("Начало выполнения цикла"); i<100;Console.WriteLine($"i={i*p}"))
// {
//     i++;
// }


int i = 6;
do
{
    Console.WriteLine(i*5);
    i++;
}
while(i<100);