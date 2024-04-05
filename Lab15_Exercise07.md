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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/d0c730a5-6d87-46ab-8276-06fdf0c2bb82)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/1fcca7e8-1862-4e53-8631-ccce3349a11e)

7.อธิบายสิ่งที่พบในการทดลอง

กำหนด delegate Square
รับ parameter int 1 ตัว
คืนค่า int
กำหนด lambda expression
เก็บในตัวแปร getSquare
รับ parameter int 1 ตัว
คืนค่า int (ผลคูณของ x กับ x)
กำหนดตัวแปร num เก็บค่า 9
เรียกใช้งาน delegate getSquare
ส่ง parameter num
เก็บผลลัพธ์ในตัวแปร sqr
แสดงผลลัพธ์ sqr


ทำคล้ายกับการทดลองก่อนหน้านี้ แต่ตัวโค้ดในExercise นี้ จะสั้นกว่า เข้าใจง่ายกว่า
