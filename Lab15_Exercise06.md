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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/a811aa3a-5d6a-49cd-af5e-e980c7a1d5a7)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/aa86e009-052e-4e47-b4c1-b5a169e27b8d)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ anonymous method เพื่อสร้างฟังก์ชันที่มีลักษณะเหมือนกับเมทอด Square ที่รับพารามิเตอร์ชนิด int และส่งคืนผลลัพธ์เป็น int
