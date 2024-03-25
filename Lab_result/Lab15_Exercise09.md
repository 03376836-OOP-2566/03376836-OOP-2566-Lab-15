## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![9](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/b57f7b66-c9ae-47ab-b0cc-8428b79854fd)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![9](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/4e5c5957-cad6-44a0-91d2-8c24ca1682a7)



## อธิบายสิ่งที่พบในการทดลอง
### โค้ดดังกล่าวเป็นการใช้งาน Action Delegate 
```
Action<int, int> sum = (a, b) =>
{
    var x = a + b;
    System.Console.WriteLine("result = " + x);
};
sum(8, 2);
```
### ทำการสร้าง Action sum ที่รับพารามิเตอร์ทั้งหมด 2 ตัวและกำหนดให้ชี้ไปยัง Lambda Expression ซึ่งมีการคำนวณผลรวมของตัวแปร a และ b  และแสดงผล
