# Lab 15 Exercise 6

## Anonymous method

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex06
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Anonymous method
Square getSquare = delegate (int x)  // 2. define lambda expression
{
    return x * x;
};
int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");

delegate int Square(int num);  // 1. declare delegate
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="531" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-15/assets/144195963/c229fbfa-2494-4a92-8166-88cb6d9af6e7">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="425" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-15/assets/144195963/f05e6fa4-298b-4b89-a36e-083b921028f0">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Square value of 9 is 81
