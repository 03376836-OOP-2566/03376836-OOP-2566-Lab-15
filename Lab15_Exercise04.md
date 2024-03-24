# Lab 15 Exercise 4

## Passing delegate as parameter

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex04
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// passing delegate as parameter


var im = new InstanceMethod();
MyDelegate imdel = im.MethodA;
MyDelegate smdel = StaticMethod.MethodB;
MyDelegate amdel = (string message) => System.Console.WriteLine($"You are calling anonymous method with message {message}");
System.Console.WriteLine("------------------");
System.Console.WriteLine("imdel + smdel");
MyDelegate del = imdel + smdel  ;
del("Hello world");
System.Console.WriteLine("------------------");
System.Console.WriteLine("imdel + smdel + amdel");
del  += amdel  ;
del("Hello world");

System.Console.WriteLine("------------------");
System.Console.WriteLine("del -= imdel ");
del -= imdel;
del("Hello world");

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
dotnet build  Lab15_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="445" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 57 19" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/99a01fd9-d4f8-46e0-8be4-3453468ff4ec">
### เรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="446" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 57 33" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/2ca49fc6-1107-4729-a80b-b953541e2953">
### แสดงข้อความ "You are calling instance MethodA() with message Hello world", "You are calling static MethodB() with message Hello world", "You are calling anonymous method with message Hello world" และ "You are calling static MethodB() with message Hello world" ตามลำดับ โดยผลลัพธ์นี้เป็นการเรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### imdel + smdel
You are calling instance MethodA() with message Hello world
You are calling static MethodB() with message Hello world
------------------
imdel + smdel + amdel
You are calling instance MethodA() with message Hello world
You are calling static MethodB() with message Hello world
You are calling anonymous method with message Hello world
------------------
### del -= imdel 
### You are calling static MethodB() with message Hello world
### You are calling anonymous method with message Hello world 
