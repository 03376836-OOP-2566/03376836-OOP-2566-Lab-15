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

![6](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/fe59ceda-6c13-4922-9def-b249ea2266f7)

คำนวณค่ากำลังสองของตัวเลข 9 ซึ่งเป็นผลลัพธ์ของ anonymous method ที่เรากำหนดไว้ในตัวแปร getSquare ซึ่งใช้ในการคำนวณสำหรับตัวแปร num

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![6 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/e88a43b8-eb2b-4e15-921a-ce73973c9680)

7.อธิบายสิ่งที่พบในการทดลอง

คำนวณค่ากำลังสองของตัวเลข 9 ซึ่งเป็นผลลัพธ์ของ anonymous method ที่เรากำหนดไว้ในตัวแปร getSquare ซึ่งใช้ในการคำนวณสำหรับตัวแปร num

โปรแกรมแสดง

Square value of 9 is 81
