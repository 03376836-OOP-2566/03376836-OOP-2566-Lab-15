## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/b63c151f-6b9d-4ebf-8df8-32b15899e3e4)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/7a933cd5-50aa-416f-bccb-e548a2c81104)


## อธิบายสิ่งที่พบในการทดลอง
 โค้ดดังกล่าวเป็นการใช้งาน Action Delegate 
```
Action<int, int> sum = (a, b) =>
{
    var x = a + b;
    System.Console.WriteLine("result = " + x);
};
sum(8, 2);
```
- ทำการสร้าง Action sum ที่รับพารามิเตอร์ทั้งหมด 2 ตัวและกำหนดให้ชี้ไปยัง Lambda Expression ซึ่งมีการคำนวณผลรวมของตัวแปร a และ b  และแสดงผล
