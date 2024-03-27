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
# แก้ไข

![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/9f62615d-084f-40a5-a4a2-6a2b3b8d1ff4)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/d71b7b73-18c7-46e3-a2c5-3036d4ad827e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/92b00592-30dd-4af4-85d8-136703c0a50a)

7.อธิบายสิ่งที่พบในการทดลอง

จากโค้ดพบว่าการทดลองนี้เป็นการใช้งาน Delegate ใน C# โดยเรียกใช้งานเมทอดผ่าน Delegate และการใช้งาน Anonymous Method ผ่าน Delegate ด้วย Lambda Expression

โดยมีการสร้าง Instance Method และ Static Method , การสร้าง Delegate และใช้งาน , การเปลี่ยน Delegate เป็น Static Method , การใช้งาน Anonymous Method ผ่าน Lambda Expression

ทำให้เห็นว่าการใช้งาน Delegate ในการเรียกใช้งานเมทอด MethodA ของ InstanceMethod และ MethodB ของ StaticMethod รวมถึงการใช้งาน Anonymous Method 

ผ่าน Lambda Expression ผ่าน Delegate ซึ่งเป็นวิธีการที่มีความยืดหยุ่นและสะดวกในการใช้งาน
