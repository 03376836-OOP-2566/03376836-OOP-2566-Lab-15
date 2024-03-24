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
<img width="458" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 28 20" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/8b31bad3-8996-4e0f-9669-d5ea7c654cf4">
### การแสดงผลลัพธ์ของการเรียกใช้งาน Func add เพื่อทำการบวกเลข 5 กับ 9 และแสดงผลลัพธ์
### การแสดงผลลัพธ์ของการเรียกใช้งาน Func convertToUpper เพื่อแปลงตัวอักษรทั้งหมดในสตริง before ให้เป็นตัวพิมพ์ใหญ่และแสดงผลลัพธ์
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="451" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 28 37" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/fe38aca7-a6ac-4e01-baa6-5e90bda3a3ae">
### การแสดงผลลัพธ์ของการเรียกใช้งาน Func add เพื่อทำการบวกเลข 5 กับ 9 และแสดงผลลัพธ์
### การแสดงผลลัพธ์ของการเรียกใช้งาน Func convertToUpper เพื่อแปลงตัวอักษรทั้งหมดในสตริง before ให้เป็นตัวพิมพ์ใหญ่และแสดงผลลัพธ์
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Add(5, 9) return 14
### Before = "all Lowercase characters", after = "ALL LOWERCASE CHARACTERS"
