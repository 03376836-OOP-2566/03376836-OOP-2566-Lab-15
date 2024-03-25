## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/f3c938bc-6c66-40dd-b22d-6e1442a1ac80)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/f5ed45f2-254a-48ba-af75-6dbb04825e49)


## อธิบายสิ่งที่พบในการทดลอง
- `Func<int, int, int> add = Add;` สร้าง delegate Func(สำหรับเมธอดที่มีการส่งค่าคืนกลับ)
- `int c = add(a,b);` เรียกใช้ตัวแปร Func โดยส่งพารามิเตอร์ตามที่กำหนดไว้ใน delegate และรับค่าที่ส่งคืนกลับมา
- `Func<string, string> convertToUpper = s => s.ToUpper();` ใช้ Lambda Expression เพื่อระบุเมธอดในรูปแบบที่ไม่ต้องประกาศเมธอดแยกไว้ โดยใช้รูปแบบ (พารามิเตอร์) => { คำสั่ง; }
