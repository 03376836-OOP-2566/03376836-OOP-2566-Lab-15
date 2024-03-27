# Lab 15 Exercise 8

## Lambda expression

1.สร้าง console application project

```cmd
dotnet new console --name Lab15_Ex08
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int oddNumbers = numbers.Count(n => n % 2 == 1);
Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab15_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/e50b694c-4d29-4b96-b0d0-6b9a8fd15c75)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/3faedfc4-daf3-4e19-9ef9-2412d93e5ad1)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองพบว่า
- Lambda Expression ที่ใช้ใน Count() Method ช่วยให้สามารถกรองและนับข้อมูลในลิสต์หรืออาร์เรย์ได้อย่างสะดวก
  
- ผลลัพธ์ของ Lambda Expression (n => n % 2 == 1) จะคืนค่า true สำหรับตัวเลขที่เป็นเลขคี่ (หารด้วย 2 มีเศษเป็น 1) และ false สำหรับตัวเลขที่ไม่ใช่เลขคี่ (หารด้วย 2 มีเศษเป็น 0)

- การใช้ string.Join(" ", numbers) ช่วยในการเชื่อมต่อสมาชิกในอาร์เรย์ numbers เข้าด้วยกันเป็น string สำหรับการแสดงผล
