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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/df73bd8c-8ff6-43ab-ac7d-0f098df3442f)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/f2564f74-5218-433b-a102-ac92aae9c19c)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองพบว่ามีการใช้งาน Generic Delegate ใน C# เพื่อสร้าง Delegate

ที่รับพารามิเตอร์แบบ Generic ที่สามารถใช้งานกับประเภทข้อมูลต่าง ๆ ได้
