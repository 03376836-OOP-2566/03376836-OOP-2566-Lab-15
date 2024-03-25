## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![4](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/8ee58005-264f-4049-a5e4-c6ab708afd34)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/99f7b34f-41d7-42e1-8751-59ca5976498f)

## อธิบายสิ่งที่พบในการทดลอง
โค้ดเกี่ยวกับ Passing delegate as parameter
`MyDelegate del = imdel + smdel;` รวม imdel กับ smdel เข้าด้วยกันใน del ทำให้เมื่อเรียก del("Hello world"); จะเรียกทั้ง MethodA และ MethodB
 `del += amdel;` เพิ่ม Anonymous Method เข้าไปด้วย ทำให้ del เรียก 3 เมธอดพร้อมกัน
vdel -= imdel;` ลบ imdel ออกจาก del ทำให้เมื่อเรียก del("Hello world"); จะเหลือแค่ MethodB และ Anonymous Method
