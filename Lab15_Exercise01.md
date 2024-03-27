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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/8a9ebb01-7ae6-4a83-bae3-4ecd0c3cb528)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/8cce5771-92ea-4ac4-b563-f0fade9f010d)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้งาน Delegateประกาศ Delegate โดยใช้คีย์เวิร์ด delegate
```
public delegate void MyDelegate(string message);
```
- และ ซึ่งระบุลักษณะของเมทอดที่ต้องการโยงตัวแทนอีกทีหนึ่งมทอดที่เราโยงกับตัวแทน Delegate และส่งพารามิเตอร์ไปให้กับเมทอดนั้น MyMethod จะถูกเรียกใช้ด้วยข้อความที่ถูกส่งเข้าไปในพารามิเตอร์ของเมทอดนั้นๆ
