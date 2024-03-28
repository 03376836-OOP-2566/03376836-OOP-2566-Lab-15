# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/f3a9dd0e-8a6e-46f1-a417-54f0eb95aae7)



# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/73e9aaf1-b2e0-4f3c-a5f6-0e1b48c681e2)

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
