# Lab 15 Exercise 2

## Delegate on instance and static method

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex02
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var im = new InstanceMethod();
MyDelegate del = im.MethodA;
del("Hello World");
del = StaticMethod.MethodB;
del("Hello Moon");

class InstanceMethod
{
     public void MethodA(string message)
     {
        System.Console.WriteLine($"You are calling instance MethodA() with message {message}");
     }
}
static class StaticMethod
{
     public static void MethodB(string message)
     {
        System.Console.WriteLine($"You are calling static MethodB() with message {message}");
     }
}

public delegate void MyDelegate(string message);
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="451" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 34 31" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/d3e53684-9d0b-4263-9148-7d0dff1cc30b">
### สามารถ build ได้แสดงข้อความ "You are calling instance MethodA() with message Hello World" และ "You are calling static MethodB() with message Hello Moon" ตามลำดับ ซึ่งเป็นผลลัพธ์จากการเรียกใช้งาน delegate ที่ถูกกำหนดเมทอดเป้าหมายต่างกัน
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="448" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 34 44" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/318d78f7-3be0-421d-b7e4-94cac8f1e333">
### สามารถ run ได้แสดงข้อความ "You are calling instance MethodA() with message Hello World" และ "You are calling static MethodB() with message Hello Moon" ตามลำดับ ซึ่งเป็นผลลัพธ์จากการเรียกใช้งาน delegate ที่ถูกกำหนดเมทอดเป้าหมายต่างกัน
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### You are calling instance MethodA() with message Hello World
### You are calling static MethodB() with message Hello Moon
