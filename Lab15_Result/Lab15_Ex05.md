# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/3eb33794-260a-4bc6-ac9a-5ca6fb4399aa)



# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/33efa335-1bb4-47ee-8153-f7fdb39637fd)

## อธิบายสิ่งที่พบในการทดลอง
- `public delegate T Add<T>(T param1, T param2);` เป็นการประกาศ Generic Delegate ที่มีชื่อว่า Add
- `Add<int> sum = NumericSum;`/`Add<string> con = StringConcat;` สร้าง instance ของ Delegate ชื่อ sum/con โดยกำหนดให้ T เป็น int/string
- เมื่อเรียกใช้งาน จะแสดงผลจากการเรียกใช้งานเมธอด NumericSum และ StringConcat ตามลำดับ
