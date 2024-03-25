## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![5](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/32d180ab-1375-4254-a03b-8ed6035a566e)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![5](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/d795c721-e9cb-4eb0-a9f8-b60fd7067a2f)

## อธิบายสิ่งที่พบในการทดลอง

public delegate T Add<T>(T param1, T param2); เป็นการประกาศ Generic Delegate ที่มีชื่อว่า Add
Add<int> sum = NumericSum;/Add<string> con = StringConcat; สร้าง instance ของ Delegate ชื่อ sum/con โดยกำหนดให้ T เป็น int/string
เมื่อเรียกใช้งาน จะแสดงผลจากการเรียกใช้งานเมธอด NumericSum และ StringConcat ตามลำดับ
