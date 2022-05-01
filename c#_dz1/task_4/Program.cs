int numberA = 2;
int numberB = 3;
int numberC = 7;
int max = numberA;

if ( max < numberB )
{
    max = numberB;
}
if ( max < numberC )
{
    max = numberC;
}
Console.WriteLine( $"Максимальное число рано = {max}");