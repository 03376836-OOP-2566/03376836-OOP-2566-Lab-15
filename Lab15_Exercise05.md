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
<img width="445" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 00 48" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/9093763a-7423-44cf-9824-2d1a0bb5cdcc">
### การเรียกใช้งานเมทอด NumericSum และ StringConcat ผ่าน Generic Delegate sum และ con ตามลำดับ โดยผลลัพธ์นี้จะแสดงผลลัพธ์ของการบวกเลขและการต่อข้อความตามลำดับ
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="447" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 06 01 05" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/0631ddc2-d5df-4621-88d6-b1531ad99048">
### การเรียกใช้งานเมทอด NumericSum และ StringConcat ผ่าน Generic Delegate sum และ con ตามลำดับ โดยผลลัพธ์นี้จะแสดงผลลัพธ์ของการบวกเลขและการต่อข้อความตามลำดับ
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Numeric sum of 30 and 50 is 80
### String concatenate of 'hello' and 'World' is "hello World"
