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

![9](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/6cea3355-937a-4cea-8e6b-24a0d2ce59ca)

การแสดงข้อความ "Hello World" จากการเรียกใช้งาน Action a
การแสดงผลรวมของตัวเลข 4, 5, และ 6 จากการเรียกใช้งาน Action s
การแสดงผลรวมของตัวเลข 8 และ 2 จากการเรียกใช้งาน Action sum โดยใช้ Lambda Expression

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![9 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/ba534daf-93ec-4115-aa3e-a1bb67580c83)

7.อธิบายสิ่งที่พบในการทดลอง

การแสดงข้อความ "Hello World" จากการเรียกใช้งาน Action a
การแสดงผลรวมของตัวเลข 4, 5, และ 6 จากการเรียกใช้งาน Action s
การแสดงผลรวมของตัวเลข 8 และ 2 จากการเรียกใช้งาน Action sum โดยใช้ Lambda Expression

โปรแกรมแสดง

Hello World

sum = 15

result = 10
