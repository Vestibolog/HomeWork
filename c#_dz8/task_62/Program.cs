/*
Задача 62: Заполните спирально массив 4 на 4
*/
int m = 4;
int n = 4;
int[,] mass = new int[m, n];
mass[0, 0] = 1;

int massLineNumber = 0;
int massColumnNumber = 0;
int vectorX = 0;
int vectorY = 1;

try
{
    for (int i = 2; i <= m * n; i++)
    {
        if (CanDoShag(massLineNumber + vectorX, massColumnNumber + vectorY))
        {
            massLineNumber += vectorX;
            massColumnNumber += vectorY;
        }
        else
        {
            if ((massColumnNumber + 1 < mass.GetLength(1)) && (mass[massLineNumber, massColumnNumber + 1] == 0))
            {
                vectorX = 0;
                vectorY = 1;
            }
            else if ((massLineNumber + 1 < mass.GetLength(0)) && (mass[massLineNumber + 1, massColumnNumber] == 0))
            {
                vectorX = 1;
                vectorY = 0;
            }
            else if ((massColumnNumber - 1 >= 0) && (mass[massLineNumber, massColumnNumber - 1] == 0))
            {
                vectorX = 0;
                vectorY = -1;
            }
            else if ((massLineNumber - 1 >= 0) && (mass[massLineNumber - 1, massColumnNumber] == 0))
            {
                vectorX = -1;
                vectorY = 0;
            }
            massLineNumber += vectorX;
            massColumnNumber += vectorY;
        }

        //Console.WriteLine($"{massLineNumber}   {massColumnNumber}");
        mass[massLineNumber, massColumnNumber] = i;
    }
}
catch (System.Exception)
{
    throw;
}

bool CanDoShag(int lineNumber, int columnNumber)
{
    bool flag = false;
    if ((lineNumber >= 0) && (lineNumber < mass.GetLength(0)))
    {
        if ((columnNumber >= 0) && (columnNumber < mass.GetLength(1)))
        {
            if (mass[lineNumber, columnNumber] == 0)
            {
                flag = true;
            }
        }
    }
    return flag;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i, j] <10 ){ Console.Write($" {array[i, j]} "); }
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(mass);