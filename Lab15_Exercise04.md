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

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/1a930732-92b9-4c38-adc4-739d5e1e06be)

เรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-15/assets/144195995/50efce1a-f5ca-4d65-b45e-b03cd7b68488)

7.อธิบายสิ่งที่พบในการทดลอง
แสดงข้อความ "You are calling instance MethodA() with message Hello world", "You are calling static MethodB() with message Hello world", "You are calling anonymous method with message Hello world" และ "You are calling static MethodB() with message Hello world" ตามลำดับ โดยผลลัพธ์นี้เป็นการเรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

โปรแกรมแสดง

imdel + smdel

You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world
imdel + smdel + amdel You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world You are 
calling anonymous method with message Hello world

del -= imdel

You are calling static MethodB() with message Hello world

You are calling anonymous method with message Hello world
