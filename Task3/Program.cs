using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine());

int b = - a;

while (b <= a) {
    WriteLine(b);
    b = b + 1;
}