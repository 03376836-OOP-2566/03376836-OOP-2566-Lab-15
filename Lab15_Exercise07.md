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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/14570832-d010-4148-907a-ae1f6211cb6c)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/0e2e2124-6c17-4a39-a13d-b8c8d1ea89ad)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ lambda expression เพื่อสร้างฟังก์ชันที่มีลักษณะเหมือนกับเมทอด Square ที่รับพารามิเตอร์ชนิด int และส่งคืนผลลัพธ์เป็น int
- ใช้ getSquare(num) เราได้รับผลลัพธ์ของการคำนวณและแสดงผลลัพธ์ลงคอนโซล
