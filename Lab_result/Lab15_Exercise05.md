## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![5](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/32d180ab-1375-4254-a03b-8ed6035a566e)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![5](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/d795c721-e9cb-4eb0-a9f8-b60fd7067a2f)

## อธิบายสิ่งที่พบในการทดลอง
 โค้ดเกี่ยวกับ Passing delegate as parameter
`MyDelegate del = imdel + smdel;` รวม imdel กับ smdel เข้าด้วยกันใน del ทำให้เมื่อเรียก del("Hello world"); จะเรียกทั้ง MethodA และ MethodB
 `del += amdel;` เพิ่ม Anonymous Method เข้าไปด้วย ทำให้ del เรียก 3 เมธอดพร้อมกัน
vdel -= imdel;` ลบ imdel ออกจาก del ทำให้เมื่อเรียก del("Hello world"); จะเหลือแค่ MethodB และ Anonymous Method
