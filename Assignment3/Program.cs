using Assignment3;
using Assignment3.Presentation;

// ReverseArray reverseArray = new ReverseArray();
//
// int[] numbers = reverseArray.generateNumbers();
// Console.WriteLine($"Original Array:");
// foreach (var n in numbers)
// {
//     Console.Write(n+ " ");
// }
// Console.WriteLine();
// reverseArray.reverse(numbers);
// Console.WriteLine("Reversed Array: ");
// reverseArray.printNumbers(numbers);
//
// Fibanocci fib = new Fibanocci();
// Console.WriteLine("Enter value for fibanocci series: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int seriesValue = fib.series(number);
// Console.WriteLine(seriesValue);

// ManagePerson mp = new ManagePerson();
// mp.AddStudent();
// mp.PrintAllCustomers();


Color redColor = new Color(255, 0, 0);
Color greenColor = new Color(0, 255, 0);
Color blueColor = new Color(0, 0, 255);

Ball ball1 = new Ball(6, redColor);
Ball ball2 = new Ball(12, greenColor);
Ball ball3 = new Ball(15, blueColor);

ball1.Throw();
ball3.Throw();
ball1.Pop();
ball1.Throw();
ball2.Throw();
ball3.Throw();

ball2.Throw();
ball2.Throw();
ball1.Throw();

ball2.Pop();
ball3.Throw();
ball1.Throw();

Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times.");
Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times.");
Console.WriteLine($"Ball 1 has been thrown {ball3.GetThrowCount()} times (after popping).");
