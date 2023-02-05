using static System.Console;

Clear();

Write("Введите число: ");
int.TryParse(ReadLine(),out int number);
int[] array = { -1, -2, 0, 2, 1, 3, 4 };


//bool result = ArrayLookUp(array,number);
WriteLine(ArrayLookUp(array,number)?"да":"нет");




bool ArrayLookUp(int[] InArray,int num)
{
    int result=0;
    foreach (var a in array)
    {
        if(num==a) return true;
    }
    return false;
}



