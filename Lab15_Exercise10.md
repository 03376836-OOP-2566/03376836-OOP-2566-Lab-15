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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/363729e1-f852-42f7-92d9-de08502be681)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/77cdadb0-8628-42c8-aea3-4d5f69aa66b3)

7.อธิบายสิ่งที่พบในการทดลอง
 - ใช้ delegate Func ในการกำหนดฟังก์ชันแบบ generic ที่สามารถรับพารามิเตอร์และส่งคืนค่าได้ 
- Func<int, int, int>ฟังก์ชันที่รับอาร์กิวเมนต์สองตัวและส่งค่ากลับเป็นชนิดข้อมูลประเภทint
- Func<string, string>ก์ชันที่รับอาร์กิวเมนต์เป็น string และส่งค่ากลับเป็น string
- ผลลัพธ์ของโค้ดคือการเรียกใช้ฟังก์ชัน Add เพื่อทำการบวกเลข และการแปลงตัวอักษรในรูปแบบตัวพิมพ์ใหญ่ทั้งหมด ตามลำดับ

