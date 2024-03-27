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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/aa9e81c9-f81f-4938-882c-f61adad3e4d3)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/4af41a55-bc62-471e-9ca7-9e6a9c67bc74)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ lambda expression ในการนับจำนวนตัวเลขคี่ในอาร์เรย์ numbers
- numbers.Count() เรียกใช้วิธี Count() บนอาร์เรย์ numbersจะนับจำนวนสมาชิกในอาร์เรย์
- ในการทดลอง ขั้นตอนสุดท้ายConsole.WriteLine() นำจำนวนของตัวเลขคี่ที่นับได้มาแสดงผลบนคอนโซลด้วยข้อความที่แสดงจำนวนตัวเลขคี่ทั้งหมดในอาร์เรย์ (ตัวเลขคี่จะถูกส่งคืนจากการเรียก Count() และเก็บไว้ในตัวแปร oddNumbers)
