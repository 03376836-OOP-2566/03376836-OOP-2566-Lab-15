# Lab 15 Exercise 10

## Func

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex10
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Func
Func<int, int, int> add = Add;
int a = 5, b= 9;
int c = add(a,b);
System.Console.WriteLine($"Add({a}, {b}) return {c}");

Func <string, string> convertToUpper = s => s.ToUpper();
string before = "all Lowercase characters";
System.Console.WriteLine($"Before = \"{before}\", after = \"{convertToUpper(before)}\"");

static int Add(int a, int b)
{
    return a + b;
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex10
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/0d5aae52-af9f-4f2f-9cb4-a44dfdc2108d)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/221e85c5-19a4-462f-8d33-415dd1d5d53f)

7.อธิบายสิ่งที่พบในการทดลอง

โค้ดนี้ใช้ delegate Func เก็บ method ไว้เรียกใช้งาน
method Add คำนวณผลรวม 2 ตัวเลข
แสดงผลลัพธ์จาก Add(5, 9)
method anonymous แปลง string เป็นตัวพิมพ์ใหญ่
แสดงผลลัพธ์จาก convertToUpper("all lowercase characters")
delegate Func เก็บ method/anonymous method
method/anonymous method รับ parameter
method/anonymous method ส่ง return value
ตัวอย่างแสดง 2 method
Add คำนวณ
convertToUpper แปลง string
delegate Func เพิ่มความยืดหยุ่นในการเขียนโปรแกรม
