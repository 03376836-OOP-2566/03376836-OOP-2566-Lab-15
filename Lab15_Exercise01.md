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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/03fb86ff-c763-4570-a08a-7ce1c5de500c)


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/3382d9aa-db96-4f6b-b4cb-62adef67bf37)


7.อธิบายสิ่งที่พบในการทดลอง

ประโยค public delegate void MyDelegate(string message) ประกาศ Delegate ชื่อ MyDelegate
Delegate นี้สามารถอ้างอิงถึง method ที่
ไม่ return ค่า (void)
รับ parameter เพียงตัวเดียว เป็น string ชื่อ message

กำหนด method ให้กับ Delegate
MyDelegate myDel1 = new MyDelegate(MyMethod); สร้าง Delegate instance ชื่อ myDel1 และกำหนด method MyMethod ให้กับ Delegate ตัวนี้
MyDelegate myDel2 = MyMethod; เป็นการกำหนด method MyMethod ให้กับ Delegate myDel2 โดยตรง โดยใช้ syntax ย่อ
myDel1("Hello World"); เรียกใช้งาน method MyMethod ผ่าน Delegate myDel1 ส่ง "Hello World" ไปเป็น parameter
myDel1.Invoke("Hello Mars"); เป็นการเรียกใช้งาน Delegate อีกวิธี โดยใช้ method Invoke
myDel2("Hello Saturn"); เรียกใช้งาน method MyMethod ผ่าน Delegate myDel2
static void MyMethod(string message) { System.Console.WriteLine(message); } เป็น method จริงที่ถูก Delegate อ้างอิง
Method นี้ทำหน้าที่พิมพ์ข้อความที่รับมาบน console

Delegate ทำหน้าที่เหมือนตัวอ้างอิง method ช่วยให้ method ทำงานเหมือน object
เราสามารถสร้าง Delegate instance หลายตัว อ้างอิงถึง method เดียวกัน
การเรียกใช้งาน Delegate คล้ายกับการเรียกใช้งาน method ทั่วไป
Delegate ช่วยเพิ่มความยืดหยุ่นในการเรียกใช้งาน method และจัดการ event


