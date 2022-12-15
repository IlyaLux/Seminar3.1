using static System.Console;
Clear();
WriteLine("Введите трехначное число");
int a = int.Parse(ReadLine());
if (a > 99 && a < 1000){
a = a % 10;
WriteLine(a);
}
else {
    WriteLine("Неверное число");
}
