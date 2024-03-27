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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/326a944b-853a-4294-ad38-88981d26bca0)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/fe5a0be4-1a9a-47c9-8386-aab37ae0c87e)

7.อธิบายสิ่งที่พบในการทดลอง

จากาการทดลองมีการใช้งาน Delegate ใน C# เพื่อแสดงการทำงานของการบวกและลบ Delegate กันภายในกันเอง

และการใช้งาน Delegate ที่เป็น Anonymous Method โดยใช้งานแบบเพิ่มและลบ Delegate จากกัน

 
