# Lab 15 Exercise 6

## Anonymous method

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex06
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Anonymous method
Square getSquare = delegate (int x)  // 2. define lambda expression
{
    return x * x;
};
int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");

delegate int Square(int num);  // 1. declare delegate
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/0a343e37-cee3-4858-9d7c-44e45fbd0c03)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/530d26db-81de-4d94-88df-145a34a2ceb8)

7.อธิบายสิ่งที่พบในการทดลอง

จากากรทดลองพบว่า การทดลองนี้เป็นการใช้งาน Anonymous Method หรือ Lambda Expression ผ่านการใช้งาน Delegate ในภาษา C# เพื่อสร้างฟังก์ชันที่ไม่ต้องมีชื่อ
