## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/a731acde-1c40-44a3-a362-5e3a916da21f)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/7b0e0191-c5e4-43f4-942e-534c45afc818)


## อธิบายสิ่งที่พบในการทดลอง
 โค้ดเกี่ยวกับ Passing delegate as parameter
- `MyDelegate del = imdel + smdel;` รวม imdel กับ smdel เข้าด้วยกันใน del ทำให้เมื่อเรียก del("Hello world"); จะเรียกทั้ง MethodA และ MethodB
- `del += amdel;` เพิ่ม Anonymous Method เข้าไปด้วย ทำให้ del เรียก 3 เมธอดพร้อมกัน
- vdel -= imdel;` ลบ imdel ออกจาก del ทำให้เมื่อเรียก del("Hello world"); จะเหลือแค่ MethodB และ Anonymous Method
