# Lab 15 Exercise 7

## Lambda expression

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex07
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Lambda expression
Square getSquare = x=> x*x ; // 2. define lambda expression

int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");

delegate int Square(int num);  // 1. declare delegate
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/c0e34688-2dc9-4e5f-87ac-4b21f4f55ccd)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/1c20073a-88a7-4ae1-97ef-56d2a83a21d8)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลอง พบว่าการทดลองดังกล่าวเป็นการใช้ Lambda Expression ผ่านการใช้งาน Delegate ในภาษา C# เพื่อสร้างฟังก์ชันที่ไม่ต้องมีชื่อ 
