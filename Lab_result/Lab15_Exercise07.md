## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![7](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/16e61038-b6e3-4ff6-98af-530ed7163926)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![7](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/34c6989a-1209-472e-82e1-fafffbf68569)

## อธิบายสิ่งที่พบในการทดลอง
`delegate int Square(int num);` กำหนด Delegate ชื่อ Square
 `Square getSquare = x => x * x;` กำหนด Lambda Expression เพื่อสร้างเมธอดเป็น Square โดยใช้คีย์เวิร์ด =>
```
int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");
```
 ใช้ตัวแปร getSquare ในการเรียกใช้งาน โดยส่งค่าที่ต้องการคำนวณกำลังสองเข้าไป
