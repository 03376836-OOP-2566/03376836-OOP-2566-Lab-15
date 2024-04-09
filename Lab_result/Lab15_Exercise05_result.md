## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/14bb0b80-c6eb-46aa-9c1b-b458f5783c84)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/c19d6fda-8c89-4f1d-a83e-9fada2e724e2)


## อธิบายสิ่งที่พบในการทดลอง
- `public delegate T Add<T>(T param1, T param2);` เป็นการประกาศ Generic Delegate ที่มีชื่อว่า Add
- `Add<int> sum = NumericSum;`/`Add<string> con = StringConcat;` สร้าง instance ของ Delegate ชื่อ sum/con โดยกำหนดให้ T เป็น int/string
- เมื่อเรียกใช้งาน จะแสดงผลจากการเรียกใช้งานเมธอด NumericSum และ StringConcat ตามลำดับ
