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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/65fc4df6-3611-4618-8da1-1b22ffe6c281)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/532cd6a9-55a6-4d93-ac41-7e2a5f7d2556)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองมีการใช้งาน Delegate ใน C# ซึ่งเป็นประเภทของชนิดข้อมูลที่ใช้เก็บตัวชี้ไปยังเมทอดหรือลำดับการทำงาน 

โดย Delegate ใช้เพื่อสร้างการแบ่งแยก (decoupling) ระหว่างเมทอดหรือลำดับการทำงานกับการเรียกใช้งาน

เช่น เมื่อเราต้องการส่งการกระทำหรือลำดับการทำงานไปยังเมทอดอื่น ๆ ให้ทำงานในลักษณะเดียวกัน

โดยมีการ ประกาศ Delegate , การเพิ่ม Method , การดรรียกใช้งาน Delegate
