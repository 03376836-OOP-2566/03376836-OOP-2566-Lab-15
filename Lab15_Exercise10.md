# Lab 15 Exercise 10

## Func

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex10
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Func
Func<int, int, int> add = Add;
int a = 5, b= 9;
int c = add(a,b);
System.Console.WriteLine($"Add({a}, {b}) return {c}");

Func <string, string> convertToUpper = s => s.ToUpper();
string before = "all Lowercase characters";
System.Console.WriteLine($"Before = \"{before}\", after = \"{convertToUpper(before)}\"");

static int Add(int a, int b)
{
    return a + b;
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex10
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/3c0a1be8-d058-4751-855e-0406fae59971)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/49029309-dc8c-4585-a4e6-51afcd4010ad)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองพบว่า 

- Func ใช้สำหรับเก็บ Reference ของเมทอด โดยสามารถระบุพารามิเตอร์และประเภทของค่าที่คืนได้

- ในที่นี้ Func<int, int, int> หมายถึง Func ที่รับพารามิเตอร์สองตัวและคืนค่าเป็นจำนวนเต็ม

- Func<string, string> หมายถึง Func ที่รับ string เป็นพารามิเตอร์และคืนค่าเป็น string

- การใช้ Lambda Expression ในการสร้าง Func ทำให้สามารถสร้างฟังก์ชันใหม่ได้อย่างสะดวก โดยไม่ต้องประกาศเมทอดใหม่โดยตรง

- Func ช่วยให้สามารถส่งเมทอดเข้าไปเป็นพารามิเตอร์ของเมทอดอื่น และใช้งานได้อย่างยืดหยุ่นและสะดวก
