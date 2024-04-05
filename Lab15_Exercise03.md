# Lab 15 Exercise 3

## Passing delegate as parameter

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex03
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// passing delegate as parameter


var im = new InstanceMethod();
MyDelegate del = im.MethodA;
InvokeDelegate(del);
del = StaticMethod.MethodB;
InvokeDelegate(del);
del = (string message) => System.Console.WriteLine($"You are calling anonymous method with message {message}");
InvokeDelegate(del);

static void InvokeDelegate(MyDelegate myDel)
{
    myDel("Hello World");
}
class InstanceMethod
{
     public void MethodA(string message)
     {A
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
dotnet build  Lab15_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/228eb531-77c8-4b4a-ae52-465f98904842)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/c0ee7fe8-c304-413b-b535-6435dbab97b0)

7.อธิบายสิ่งที่พบในการทดลอง

โค้ดนี้แสดงการใช้งาน Delegate กับ method 3 ประเภท: instance, static และ anonymous
Delegate MyDelegate อ้างอิง method ที่รับ string parameter และไม่ return ค่า
var im = new InstanceMethod(); สร้าง instance ของ InstanceMethod
MyDelegate del = im.MethodA; กำหนด method MethodA ของ instance im ให้กับ del
InvokeDelegate(del); เรียกใช้งาน MethodA ผ่าน del ส่ง "Hello World" ไป
del = StaticMethod.MethodB; เปลี่ยน del ให้ อ้างอิง method MethodB ของ class StaticMethod
InvokeDelegate(del); เรียกใช้งาน MethodB ผ่าน del ส่ง "Hello World" ไป
del = (string message) => System.Console.WriteLine($"You are calling anonymous method with message {message}"); กำหนด anonymous method ให้กับ del
InvokeDelegate(del); เรียกใช้งาน anonymous method ผ่าน del ส่ง "Hello World" ไป
Delegate ช่วยให้ method ทำงานเหมือน object
Delegate เพิ่มความยืดหยุ่นในการเรียกใช้งาน method
โค้ดนี้แสดงวิธีใช้ Delegate กับ method 2 ประเภท
โค้ดนี้ยังแสดงวิธีใช้ Delegate กับ anonymous method
Anonymous method ช่วยให้เขียน method สั้น ๆ ได้โดยไม่ต้องสร้าง class
Delegate ช่วยให้ code ยืดหยุ่นและสามารถปรับเปลี่ยนได้ง่าย

แต่เนื่องจากเกิดข้อผิดพลาดบางอย่างทำให้ แสดงผลไม่ได้
