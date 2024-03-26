# Lab 15 Exercise 7

## Lambda expression

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex07
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Lambda expression
Square getSquare = x=> x*x ; // 2. define lambda expression

int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");

delegate int Square(int num);  // 1. declare delegate
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="411" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-15/assets/144195963/d95ceab8-1064-42da-8b2b-5b52670ffd08">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="461" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-15/assets/144195963/7aee7b52-ddf5-4354-bdc5-11d1ca9bb5dc">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Square value of 9 is 81
