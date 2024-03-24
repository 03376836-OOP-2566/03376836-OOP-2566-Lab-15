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
<img width="452" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 41 16" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/579324a8-898b-4e9d-a4cb-cfe5a665035f">
### แก้ไขแล้ว ไม่สามารถ build ได้ เนื่องจากมีข้อผิดพลาดใน class InstanceMethod
5.Run project โดยการใช้คำสั่ง 

```cmd
dotnet run --project Lab15_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="447" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 41 45" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/7315174a-cb41-4b9b-b86d-bc73cf76e2b3">
### แก้ไขแล้ว แสดงข้อความ "You are calling instance MethodA() with message Hello World" และ "You are calling static MethodB() with message Hello Moon" ตามลำดับ และ "You are calling anonymous method with message Hello World" ซึ่งเป็นผลลัพธ์จากการเรียกใช้งาน delegate ที่ถูกกำหนดเมทอดเป้าหมายต่างกันและ anonymous method
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### You are calling instance MethodA() with message Hello World
### You are calling static MethodB() with message Hello World
### You are calling anonymous method with message Hello World
