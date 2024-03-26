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

![8](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/21e57bbf-e913-45c1-bba6-fa61c031a1c3)

แสดงผลลัพธ์ที่บอกจำนวนของตัวเลขคี่ทั้งหมดที่พบในอาร์เรย์ numbers และรายการของตัวเลขในอาร์เรย์ด้วยคำสั่ง Console.WriteLine

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![8 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/d225ef31-5b60-4fc9-aca4-bb1fff0e8ef7)

7.อธิบายสิ่งที่พบในการทดลอง

แสดงผลลัพธ์ที่บอกจำนวนของตัวเลขคี่ทั้งหมดที่พบในอาร์เรย์ numbers และรายการของตัวเลขในอาร์เรย์ด้วยคำสั่ง Console.WriteLine

โปรแกรมแสดง

There are 5 odd numbers in 5 4 1 3 9 8 6 7 2 0
