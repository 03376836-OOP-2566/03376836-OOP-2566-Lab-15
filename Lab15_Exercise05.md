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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/9bee28d8-d028-4ce4-b00c-50732c58a789)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/ad6bb778-092d-45aa-a689-984f7cc6e72a)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ generic delegate Add<T> เพื่อเรียกใช้งานเมทอดที่รับพารามิเตอร์ในรูปแบบที่แตกต่างกัน
### ในโค้ด
- สร้าง delegate sum ไปยังเมทอด NumericSum ที่รับพารามิเตอร์สองตัวที่มีประเภท int และส่งคืนผลลัพธ์ในรูปแบบ int
- เรียกใช้ delegate sum เพื่อคำนวณผลรวมของเลข a และ b และแสดงผลลัพธ์
- สร้าง delegate con และให้มันชี้ไปยังเมทอด StringConcat ที่รับพารามิเตอร์สองตัวที่มีประเภท string และส่งคืนผลลัพธ์ในรูปแบบ string
- เรียกใช้ delegate con เพื่อเชื่อมต่อสตริง h และ w และแสดงผลลัพธ์
