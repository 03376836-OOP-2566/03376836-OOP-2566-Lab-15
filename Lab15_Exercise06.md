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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/fd4067bc-d872-4b64-92b5-02eef8344da7)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/458ced09-a919-4df0-a5ec-e44f00868937)

7.อธิบายสิ่งที่พบในการทดลอง

ทดลองใช้ anonymous method กับ delegate
กำหนด delegate Square
รับ parameter int 1 ตัว
คืนค่า int
กำหนด anonymous method
รับ parameter int 1 ตัว
คืนค่า int (ผลคูณของ x กับ x)
กำหนดตัวแปร getSquare
เก็บ anonymous method
เรียกใช้งาน delegate getSquare
ส่ง parameter int 1 ตัว
เก็บผลลัพธ์ในตัวแปร sqr
แสดงผลลัพธ์ sqr
