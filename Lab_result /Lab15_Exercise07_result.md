## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/c564cf80-ba1e-4686-95e2-c7c8ebe66141)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/20ffa311-13ed-41cd-8182-cef8564f9788)


## อธิบายสิ่งที่พบในการทดลอง
- `delegate int Square(int num);` กำหนด Delegate ชื่อ Square
- `Square getSquare = x => x * x;` กำหนด Lambda Expression เพื่อสร้างเมธอดเป็น Square โดยใช้คีย์เวิร์ด =>
```
int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");
```
 ใช้ตัวแปร getSquare ในการเรียกใช้งาน โดยส่งค่าที่ต้องการคำนวณกำลังสองเข้าไป
