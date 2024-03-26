# Lab 15 Exercise 9

## Action

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex09
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Action
Action a = Print;
a();

Action<int, int, int> s = PrintSum;
s(4, 5, 6);

Action<int, int> sum = (a, b) =>
{
    var x = a + b;
    System.Console.WriteLine("result = " + x);
};
sum(8, 2);


static void Print()
{
    System.Console.WriteLine("Hello World");
}
static void PrintSum(int a, int b, int c)
{
    System.Console.WriteLine($"sum = {a + b + c}");
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="472" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-15/assets/144195963/2b362481-dab0-4b6e-a860-0bd9c211ad5d">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="441" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-15/assets/144195963/2202ed0d-8638-4613-a455-7f7ebcf5fc93">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Hello World

sum = 15

result = 10
