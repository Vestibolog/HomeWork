int number = new Random().Next(100,1000);

Console.WriteLine( $"{number}");  

int number1 = number / 100;
int number3 = number % 10;

Console.WriteLine( $"{number1} и {number3}  будет  {number1*10+number3}");
 