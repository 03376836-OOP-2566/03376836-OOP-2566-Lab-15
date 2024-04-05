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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/88b6f37f-0678-468c-8c5c-6bbd7fd7bcbd)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/9f3495a7-8f68-42a4-b7b9-e5e8f80bd1bc)


7.อธิบายสิ่งที่พบในการทดลอง

ทดลองใช้ LINQ Count method กับ lambda expression
กำหนด array numbers เก็บตัวเลข 10 ตัว
ใช้ Count method กับ array numbers
กรองเฉพาะตัวเลขคี่ (n % 2 == 1)
เก็บจำนวนตัวเลขคี่ใน oddNumbers
แสดงผลจำนวนตัวเลขคี่ (oddNumbers) และ array numbers
