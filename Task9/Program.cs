using static System.Console;
Clear();
int number = new Random().Next(10, 100);
WriteLine(number);
WriteLine(number%2==0?"Четное":"Нечетное");
WriteLine(number/10>number%10?number / 10:number % 10); //Тернарный оператор 1 число после ? при выполнении условия число после : при невыполнении

// if(number/10>number%10)
// {
//     WriteLine(a1);
// }
// else
// {
//     WriteLine(a2);
// }