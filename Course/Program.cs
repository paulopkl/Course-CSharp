using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //sbyte x = 100;
            //Console.WriteLine(x);

            //SByte y = 102;
            //Console.WriteLine(y);

            //byte n1 = 255; 
            ////n1++;
            //Console.WriteLine(n1);

            //int n2 = 1000;
            //Console.WriteLine(n2);

            //int n3 = 2147483647;
            //Console.WriteLine(n3);

            //long n4 = 2147483648L;
            //Console.WriteLine(n4);

            //bool complete = false;
            //Console.WriteLine(complete);

            //char gender = 'm';
            //Console.WriteLine(gender);

            //char letter = '\u0041';
            //Console.WriteLine(letter);

            //float n5 = 4.5f;
            //n5 = 283.44f;
            //Console.WriteLine(n5);

            //double n6 = 4.5;
            //n6 = 283.44;
            //Console.WriteLine(n6);

            //string name = "Paulo Ricardo";
            //name = "batata";
            //Console.WriteLine(name);

            //object obj1 = "other string";
            //object obj2 = 4.5f;

            //int n1 = int.MinValue;
            //Console.WriteLine(n1);

            //int n2 = int.MaxValue;
            //Console.WriteLine(n2);

            //sbyte n3 = sbyte.MinValue;
            //Console.WriteLine(n3);

            //decimal n4 = decimal.MaxValue; // Max Value possible in CSharp
            //Console.WriteLine(n4);

            //Console.Write("Good Morning!");
            //Console.WriteLine("Good Morning!");

            //char gender = 'F';
            //int age = 32;
            //double balance = 10.35784;
            //string str = "Paulo";

            //age += 18;

            //age *= 3;
            //age /= 5;

            ////Console.WriteLine(balance.ToString("F2"));
            ////Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));

            ////Console.WriteLine("{0} have {1} years old and balance equal to $ {2:F2} dolars", str, age, balance);

            //Console.WriteLine($"{str} have {age} years old and balance equal to $ {balance:F2} dollars!");

            //Console.WriteLine(
            //    str + " have " + age + " years old and balance equal to $ " + balance.ToString("F2") + " dollars!"
            //);

            //string s = "ABC";
            //s += "BEF";
            //Console.WriteLine(s);

            //double a;
            //float b;

            //a = 5.1;
            //b = (float)a; // Float = double // Casting!

            //Console.WriteLine(b);

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a; // Float = double // Casting!

            //Console.WriteLine(b);

            //int a = 55;
            //int b = 22;

            //double result = (double) a / b;

            //Console.WriteLine(result);

            //int n1 = 3 + 4 * 2;
            //int n2 = (3 + 4) * 2;
            //double n3 = 17 % 3;
            //double n4 = 10.0 / 8.0;

            //Console.WriteLine($"{n1}, {n2}, {n3}, {n4}");

            //double a = 1.0, b = -3.0, c = -4.0;

            //double delta = Math.Pow(b, 2.0) - 4 * a * c;

            //double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Console.WriteLine($"{x1}, {x2}");

            //string phrase = Console.ReadLine();
            //string[] arr = phrase.Split(" ");

            //for (int i = 0; i < arr.Length; i++) {
            //    Console.WriteLine(arr[i]);
            //}

            //Console.Write("Write your age: ");
            //int n1 = int.Parse(Console.ReadLine());

            //char ch = char.Parse(Console.ReadLine());

            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(" ");
            //string name = vet[0];
            //char gender = char.Parse(vet[1]);
            //int age = int.Parse(vet[2]);
            //double height = double.Parse(vet[3]);

            //Console.WriteLine(age);
            //Console.WriteLine(gender);
            //Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine($"{name} {gender} {age} {height.ToString("F2", CultureInfo.InvariantCulture)}");

            //int a = 10;
            //bool c1 = a < 10;

            //Console.WriteLine(c1);

            //bool bool2 = !(2 > 3) && 4 != 5;
            //Console.WriteLine(bool2);

            //double price = double.Parse(Console.ReadLine());

            //if (price > 0) {
            //    double discount = price * 0.1;
            //}

            //Console.WriteLine(discount);

            //Console.WriteLine(returnsNumbers(1, 10, 3));

            //Console.WriteLine("Write three numbers!");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(returnsNumbers(n1, n2, n3));

            //while (true) {
            //    Console.WriteLine("Type a number:");
            //    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    if (a < 0) {
            //        Console.WriteLine("Negative Number!");
            //        break;
            //    }

            //    a = Math.Sqrt(a);

            //    Console.WriteLine(a.ToString("F3", CultureInfo.InvariantCulture));
            //}

            //int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //for (int i = 1; i <= N; i++) {
            //    if (
            //        i % 2 != 0 &&
            //        i % 3 != 0 &&
            //        i % 5 != 0 &&
            //        i % 7 != 0 &&
            //        i % 11 != 0 &&
            //        i % Math.Sqrt(i) != 0 &&
            //        i % i == 0
            //    ) {
            //        Console.WriteLine(i);
            //    }

            //    continue;
            //}

            ////////////////////

            //Triangle x = new Triangle();

            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ////x.generatePerimeter();
            //x.generateArea();

            ////////////////////

            //Product p = new Product();

            //p.Name = Console.ReadLine();
            //p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //p.Quantity = int.Parse(Console.ReadLine());

            //p.TotalStockValue();

            //Console.WriteLine(p);

            ////////////////////

            //Console.Write("Write the Radius: ");
            //double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calculator calc = new Calculator();

            //Console.WriteLine($"Circumference {calc.circumference(radius).ToString("F3")}");
            //Console.WriteLine($"Volume {calc.Volume(radius).ToString("F3")}");

            /////////////////// Static

            //Console.Write("Write the Radius: ");
            //double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"Circumference {Calculator.circumference(radius).ToString("F3")}");
            //Console.WriteLine($"Volume {Calculator.Volume(radius).ToString("F3")}");

            ////////////////// Constructor

            //string name = Console.ReadLine();
            //double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //int quantity = int.Parse(Console.ReadLine());

            //Product p = new Product(name, price, quantity);

            //p.TotalStockValue();

            //p.Name = ";";

            //Console.WriteLine(p);

            //////////////////

            //Constructor_less cons = new Constructor_less
            //{
            //    name = "Paulo",
            //    age = 19,
            //    gender = 'M'
            //};

            //cons.returnData();

            //////////////////

            //Console.Write("Enter the account number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter the account holder: ");
            //string holder = Console.ReadLine();
            //Console.Write("There will be initial deposit (s/n)?");
            //char willBe = char.Parse(Console.ReadLine());

            //AccountBank AB;

            //if (willBe == 's' || willBe == 'S')
            //{
            //    Console.WriteLine("Enter The value of initial Deposit: ");
            //    double initialDesposit = double.Parse(Console.ReadLine());
            //    AB = new AccountBank(num, holder, initialDesposit);
            //} else
            //{
            //    AB = new AccountBank(num, holder);
            //}

            //Console.WriteLine("Account Data: ");
            //Console.Write(AB); // ToString();

            //////////////

            //Point p;
            //Point p2;

            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);
            //p = new Point();
            //Console.WriteLine(p);
            //p.X = 5;
            //p.Y = 15;
            //Console.WriteLine(p);
            //p = new Point();
            //Console.WriteLine(p);
            //p.X = 91;
            //p.Y = 89;
            //p2 = p;
            //Console.WriteLine(p2);

            //////////////

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("x is null!");

            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("y is null!");

            //double a = x ?? 5.0;
            //double b = y ?? 5.0;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //////////////

            //Vectors v = new Vectors(Console.ReadLine());

            //int n = int.Parse(Console.ReadLine());

            //Vectors2[] vect = new Vectors2[n];

            //double averangePrice = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Write an Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Write an Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    Console.WriteLine("==============================");

            //    //vect[i] = new Vectors2(name, price);
            //    vect[i] = new Vectors2 { Name = name, Price = price };
            //}

            //foreach (var item in vect)
            //{
            //    averangePrice += item.Price;
            //    Console.WriteLine($"The Name of the {item.Name} and the value is {item.Price}");
            //}

            //Console.WriteLine($"Averange price of products is {averangePrice}");

            //////////////////////

            //int s1 = Calculator.Sum(1, 5, 10, 15, 20, 25, 30, 17);

            //Console.WriteLine(s1);

            /////////////////////

            //int a = 10;
            //int tripleA;
            ////Calculator.Triple(ref a);
            //Calculator.TripleOut(a, out tripleA);
            //Console.WriteLine(a);

            //string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //ListTest listTest = new ListTest();

            //ExercisesLists exercisesLists = new ExercisesLists();

            //MatrizTest mat = new MatrizTest();

            //SwitchCase switchCase = new SwitchCase();

            //ConditionTernary conditionTernary = new ConditionTernary();

            //StringsFunctions stringsFunctions = new StringsFunctions();

            DateTimeTest dateTimeTest = new DateTimeTest();
        }

        //static double returnsNumbers(int a, int b, int c) {
        //    double m;
        //    if (a > b && a > c) {
        //        m = a;
        //    } else if (b > a && b > c) {
        //        m = b;
        //    } else {
        //        m = c;
        //    }

        //    return m;
        //}
    }
}

