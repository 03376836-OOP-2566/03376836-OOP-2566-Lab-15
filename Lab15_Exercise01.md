# Lab 15 Exercise 1

## Delegate

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex01
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// 2. add target method to delegate
MyDelegate myDel1 = new MyDelegate(MyMethod);
MyDelegate myDel2 = MyMethod;

// 3. Invoke delegate
myDel1("Hello World");
myDel1.Invoke("Hello Mars");
myDel2("Hello Saturn");

static  void  MyMethod(string message)
{
    System.Console.WriteLine(message);
}

// 1. declare delegate
public delegate void MyDelegate(string message);
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="443" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 21 40" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/134a6866-07e4-4c1e-997f-7635eb5d4b9e">
### สามารถ build ได้ แสดงข้อความ "Hello World", "Hello Mars" และ "Hello Saturn" ที่แตกต่างกันตามการเรียกใช้งาน Delegate ผ่านตัวแปร myDel1 และ myDel2 ตามลำดับ
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="449" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 22 34" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/c7f7f0bf-5407-489c-b573-18c703fb24c3">
### สามารถ run ได้ แสดงข้อความ "Hello World", "Hello Mars" และ "Hello Saturn" ที่แตกต่างกันตามการเรียกใช้งาน Delegate ผ่านตัวแปร myDel1 และ myDel2 ตามลำดับ
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Hello World
### Hello Mars
### Hello Saturn
