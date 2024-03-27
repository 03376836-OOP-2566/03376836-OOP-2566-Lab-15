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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/9d25cfdc-5350-4e1b-bdb6-2baba43419f9)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab15_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-15/assets/144195708/91d289b4-1e3a-45f7-8140-347ddaf1870b)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองพบว่า

- การใช้งาน Delegate Action ในการกำหนดลักษณะการทำงานของเมทอดหรือการกระทำโดยไม่ต้องกำหนดชื่อเมทอดเป็นชื่อตัวแปร

- การใช้ Lambda Expression ในการสร้างฟังก์ชันที่ไม่ต้องมีชื่ออย่างสะดวก

- การใช้งาน Action ในลักษณะของเรียกใช้งานเมทอดหรือการกระทำแบบทันทีโดยไม่ต้องกำหนดชื่อเมทอดไว้ก่อน
- 
- ความสามารถในการส่งพารามิเตอร์ต่างๆ เข้าไปใน Action ได้ ไม่ว่าจะเป็น Action ที่ไม่รับพารามิเตอร์ หรือ Action ที่รับพารามิเตอร์แบบหลายตัว
