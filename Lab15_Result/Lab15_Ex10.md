# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/889cde29-4fa4-4fc8-8a95-e7f15617c002)



# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/c6ec3b94-d824-4ff8-a796-5a2f96ebe284)

## อธิบายสิ่งที่พบในการทดลอง
- `Func<int, int, int> add = Add;` สร้าง delegate Func(สำหรับเมธอดที่มีการส่งค่าคืนกลับ)
- `int c = add(a,b);` เรียกใช้ตัวแปร Func โดยส่งพารามิเตอร์ตามที่กำหนดไว้ใน delegate และรับค่าที่ส่งคืนกลับมา
- `Func<string, string> convertToUpper = s => s.ToUpper();` ใช้ Lambda Expression เพื่อระบุเมธอดในรูปแบบที่ไม่ต้องประกาศเมธอดแยกไว้ โดยใช้รูปแบบ (พารามิเตอร์) => { คำสั่ง; }


