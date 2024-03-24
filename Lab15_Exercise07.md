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
<img width="445" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 11 37" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/4f401e70-ea50-443a-8c9a-5ae8dca26bfb">
### คำนวณค่ากำลังสองของตัวเลข 9 ซึ่งเป็นผลลัพธ์ของ Lambda Expression ที่เรากำหนดไว้ในตัวแปร getSquare ซึ่งใช้ในการคำนวณสำหรับตัวแปร num
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="454" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 11 53" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/b944bc01-d11c-40f1-8b3b-7a8e03f670d1">
### คำนวณค่ากำลังสองของตัวเลข 9 ซึ่งเป็นผลลัพธ์ของ Lambda Expression ที่เรากำหนดไว้ในตัวแปร getSquare ซึ่งใช้ในการคำนวณสำหรับตัวแปร num
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Square value of 9 is 81
