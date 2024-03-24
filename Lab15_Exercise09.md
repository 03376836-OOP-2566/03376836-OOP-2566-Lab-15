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
<img width="459" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 20 34" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/6dbd465f-be0e-499e-9798-d8f8e2a71093">
### การแสดงข้อความ "Hello World" จากการเรียกใช้งาน Action a
### การแสดงผลรวมของตัวเลข 4, 5, และ 6 จากการเรียกใช้งาน Action s
### การแสดงผลรวมของตัวเลข 8 และ 2 จากการเรียกใช้งาน Action sum โดยใช้ Lambda Expression
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="447" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 20 49" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/489e2d2a-aef9-4751-9fe0-e9e02dc1dc9d">
### การแสดงข้อความ "Hello World" จากการเรียกใช้งาน Action a
### การแสดงผลรวมของตัวเลข 4, 5, และ 6 จากการเรียกใช้งาน Action s
### การแสดงผลรวมของตัวเลข 8 และ 2 จากการเรียกใช้งาน Action sum โดยใช้ Lambda Expression
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Hello World
### sum = 15
### result = 10
