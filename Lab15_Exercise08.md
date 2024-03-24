# Lab 15 Exercise 8

## Lambda expression

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex08
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int oddNumbers = numbers.Count(n => n % 2 == 1);
Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="446" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 17 59" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/a65ab92e-dce4-4896-976a-df5afe95590e">
### แสดงผลลัพธ์ที่บอกจำนวนของตัวเลขคี่ทั้งหมดที่พบในอาร์เรย์ numbers และรายการของตัวเลขในอาร์เรย์ด้วยคำสั่ง Console.WriteLine
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="447" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 18 14" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/3dbb91a3-4bdb-49d8-bb1f-32b30025a184">
### แสดงผลลัพธ์ที่บอกจำนวนของตัวเลขคี่ทั้งหมดที่พบในอาร์เรย์ numbers และรายการของตัวเลขในอาร์เรย์ด้วยคำสั่ง Console.WriteLine
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### There are 5 odd numbers in 5 4 1 3 9 8 6 7 2 0
