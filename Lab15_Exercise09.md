# Lab 15 Exercise 9

## Action

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex09
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Action
Action a = Print;
a();

Action<int, int, int> s = PrintSum;
s(4, 5, 6);

Action<int, int> sum = (a, b) =>
{
    var x = a + b;
    System.Console.WriteLine("result = " + x);
};
sum(8, 2);


static void Print()
{
    System.Console.WriteLine("Hello World");
}
static void PrintSum(int a, int b, int c)
{
    System.Console.WriteLine($"sum = {a + b + c}");
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/7cd93877-494b-4303-a1d8-bd52eb50852e)


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-15/assets/144197034/f9c703eb-2b16-431f-a393-3d1c3876cb2b)


7.อธิบายสิ่งที่พบในการทดลอง

ทดลองใช้ delegate Action
กำหนด delegate a
เก็บ method Print
เรียกใช้ delegate a
พิมพ์ "Hello World"
กำหนด delegate s
เก็บ method PrintSum
ส่ง parameter 3 ตัว
กำหนด delegate sum
เก็บ anonymous method
บวก parameter 2 ตัว
พิมพ์ "Hello World"
พิมพ์ "sum = 15"
พิมพ์ "result = 10"
แสดงผลลัพธ์จาก method อื่น (ไม่ระบุ)
แสดงผลลัพธ์จาก method อื่น (ไม่ระบุ)
