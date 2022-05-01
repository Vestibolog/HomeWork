int number = 5;
int i=0;

number= number - number % 2;

while ( i <= number)
{
    if ( i % 2 == 0 )
    {
        if ( i == number )
        {
            Console.Write( $"{i}.");    
        } else
        {
            Console.Write( $"{i}, ");
        }      
    }
    i++;
}
