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

![7](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/e9f0d287-aa65-4fab-a1a1-9d996630c308)

คำนวณค่ากำลังสองของตัวเลข 9 ซึ่งเป็นผลลัพธ์ของ Lambda Expression ที่เรากำหนดไว้ในตัวแปร getSquare ซึ่งใช้ในการคำนวณสำหรับตัวแปร num

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![7 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/fa59e29a-1e49-47c7-b673-fb33dcc8e09f)

7.อธิบายสิ่งที่พบในการทดลอง

คำนวณค่ากำลังสองของตัวเลข 9 ซึ่งเป็นผลลัพธ์ของ Lambda Expression ที่เรากำหนดไว้ในตัวแปร getSquare ซึ่งใช้ในการคำนวณสำหรับตัวแปร num

โปรแกรมแสดง

Square value of 9 is 81
