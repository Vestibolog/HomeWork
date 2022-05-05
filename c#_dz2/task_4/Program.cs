int dayNumber = new Random().Next(-1,9);
Console.WriteLine(dayNumber);

if ( (dayNumber < 0) | (dayNumber > 7) )
{
    Console.WriteLine("некорерктное число");
} else
if ( dayNumber <= 5 )
{
    Console.WriteLine("Это рабочий день");
} else
{
   Console.WriteLine("Это Выходной"); 
}