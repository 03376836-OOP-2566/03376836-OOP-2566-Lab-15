## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![10](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/7ed3baa9-360f-41b7-9dbd-e6f9f8079a31)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5


![10](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/cd606298-e19c-4027-938d-18beee22a0ce)

## อธิบายสิ่งที่พบในการทดลอง
 `Func<int, int, int> add = Add;` สร้าง delegate Func(สำหรับเมธอดที่มีการส่งค่าคืนกลับ)
 `int c = add(a,b);` เรียกใช้ตัวแปร Func โดยส่งพารามิเตอร์ตามที่กำหนดไว้ใน delegate และรับค่าที่ส่งคืนกลับมา
`Func<string, string> convertToUpper = s => s.ToUpper();` ใช้ Lambda Expression เพื่อระบุเมธอดในรูปแบบที่ไม่ต้องประกาศเมธอดแยกไว้ โดยใช้รูปแบบ (พารามิเตอร์) => { คำสั่ง; }
