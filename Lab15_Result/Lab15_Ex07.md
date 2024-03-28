# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/5c2c3464-7fe7-467f-a22c-25a1a9c46db4)



# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/78182b78-1715-4125-a6d2-b555584a5651)


## อธิบายสิ่งที่พบในการทดลอง
- `delegate int Square(int num);` กำหนด Delegate ชื่อ Square
- `Square getSquare = x => x * x;` กำหนด Lambda Expression เพื่อสร้างเมธอดเป็น Square โดยใช้คีย์เวิร์ด =>
```
int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");
```
 ใช้ตัวแปร getSquare ในการเรียกใช้งาน โดยส่งค่าที่ต้องการคำนวณกำลังสองเข้าไป
