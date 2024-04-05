# Lab 15 Exercise 5

## Generic delegate

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex05
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// generic delegate

Add<int> sum = NumericSum;
int a = 30, b = 50;
System.Console.WriteLine($"Numeric sum of {a} and {b} is {sum(a, b)}");

Add<string> con = StringConcat;
string h = "hello", w = "World";
System.Console.WriteLine($"String concatenate of '{h}' and '{w}' is \"{con(h, w)}\"");


static int NumericSum(int val1, int val2)
{
    return val1 + val2;
}

static string StringConcat(string str1, string str2)
{
    return str1 + " " + str2;
}

public delegate T Add<T>(T param1, T param2); // generic delegate
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/368e6fc8-0d59-407b-9a07-e015258e9e19)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/86b38097-4ee1-4185-a830-e670e3967968)

7.อธิบายสิ่งที่พบในการทดลอง

ทดลองใช้ delegate กับ generic type T
กำหนด delegate Add 2 ตัว
Add<int> สำหรับ integer
Add<string> สำหรับ string
กำหนด method NumericSum
รับ parameter int 2 ตัว
คืนค่า int (ผลรวม)
กำหนด method StringConcat
รับ parameter string 2 ตัว
คืนค่า string (การต่อ string)
เรียกใช้งาน delegate sum
ส่ง parameter int 2 ตัว
แสดงผลลัพธ์ (sum ของ int)
เรียกใช้งาน delegate con
ส่ง parameter string 2 ตัว
แสดงผลลัพธ์ (string ที่ต่อกัน)
