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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/5e728c93-6423-49f1-bcff-5289f1528f1e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/c51586f8-dd46-4e94-9b2a-f89910daffae)

7.อธิบายสิ่งที่พบในการทดลอง

ทดสอบ chaining delegate ผ่าน method MethodA, MethodB และ anonymous method
พยายาม chaining delegate โดยใช้ + ผลลัพธ์คือ error CS0236 เพราะ delegate chaining ไม่รองรับ
ลบ delegate ออกจาก chain โดยใช้ -= ผลลัพธ์คือ error CS0236 เช่นเดียวกัน
เรียกใช้งาน delegate chain ผลลัพธ์คือ ไม่เกิดอะไรขึ้น (เพราะ error)
การ chaining delegate ทำได้โดยวิธีอื่น เช่น สร้าง delegate ใหม่
โค้ดนี้ไม่สามารถรันได้ ต้องแก้ไข error ก่อน 

