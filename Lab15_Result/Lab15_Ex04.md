# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/655928c7-1acb-4cf2-98ce-2313f6df581b)


# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/18642c30-ed49-4e4d-be61-70c23a21535f)

## อธิบายสิ่งที่พบในการทดลอง
 โค้ดเกี่ยวกับ Passing delegate as parameter
- `MyDelegate del = imdel + smdel;` รวม imdel กับ smdel เข้าด้วยกันใน del ทำให้เมื่อเรียก del("Hello world"); จะเรียกทั้ง MethodA และ MethodB
- `del += amdel;` เพิ่ม Anonymous Method เข้าไปด้วย ทำให้ del เรียก 3 เมธอดพร้อมกัน
- vdel -= imdel;` ลบ imdel ออกจาก del ทำให้เมื่อเรียก del("Hello world"); จะเหลือแค่ MethodB และ Anonymous Method
