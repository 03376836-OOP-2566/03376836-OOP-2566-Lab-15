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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/394f110a-a708-48b3-8c04-d03e8d585dc3)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/5470adb9-ce31-4b30-aa9c-5f308a027f57)
 ## โคค้ดมีข้อผิดพลาด แก้ไข
 - แก้ไขในบรรทัดที่ 19 ลบ A ออก สามารถรันโปรแกรมได้
   ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/cee9ee87-229f-4723-882a-d855e9a5f775)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ delegate MyDelegate ในการส่งผ่านเป็นพารามิเตอร์ไปยังเมทอด InvokeDelegate 
- เปลี่ยนค่าของ delegate ก่อนเรียกใช้ InvokeDelegate ในแต่ละครั้งเมื่อเรียกใช้ InvokeDelegate โดยส่ง delegate เข้าไป เมทอดนั้นจะเรียกใช้ delegate นั้นๆ และส่งค่า "Hello World" ไปให้

