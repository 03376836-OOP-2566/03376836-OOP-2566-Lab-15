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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/3abda9c9-8074-469f-b4ba-272197136f74)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/9f391d33-2a0e-4713-baee-a363c89f37a4)

7.อธิบายสิ่งที่พบในการทดลอง

โค้ดนี้แสดงการใช้งาน Delegate กับ method ทั้งแบบ instance และ static
Delegate MyDelegate อ้างอิง method ที่รับ string parameter และไม่ return ค่า
var im = new InstanceMethod(); สร้าง instance ของ InstanceMethod
MyDelegate del = im.MethodA; กำหนด method MethodA ของ instance im ให้กับ del
del("Hello World!"); เรียกใช้งาน MethodA ผ่าน del ส่ง "Hello World!" ไป
del = StaticMethod.MethodB; เปลี่ยน del ให้ อ้างอิง method MethodB ของ class StaticMethod
del("Hello Moon!"); เรียกใช้งาน MethodB ผ่าน del ส่ง "Hello Moon!" ไป
Delegate ช่วยให้ method ทำงานเหมือน object
Delegate เพิ่มความยืดหยุ่นในการเรียกใช้งาน method
โค้ดนี้แสดงวิธีใช้ Delegate กับ method 2 ประเภท
