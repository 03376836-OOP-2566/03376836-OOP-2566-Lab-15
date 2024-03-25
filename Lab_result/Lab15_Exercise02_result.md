## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-3.png)

สามารถ Build ได้ เพราะ สร้างคลาส InstanceMethod และ StaticMethod ที่ประกอบด้วยเมธอดที่เราต้องการให้ delegate ไปเรียกใช้กำหนด delegate ชื่อ MyDelegate ซึ่งระบุลักษณะของเมธอดที่จะถูกเรียกผ่าน delegate นี้ ในที่นี้คือเมธอดที่รับพารามิเตอร์ชนิด string 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-4.png)

สามารถ Run ได้ เรียกใช้เมธอดที่ delegate ชี้ไป โดยส่งพารามิเตอร์เข้าไป เราสามารถใช้ delegate นั้นๆ โดยไม่ต้องระบุชื่อเมธอดโดยตรง 

## อธิบายสิ่งที่พบในการทดลอง

- You are calling instance MethodA() with message Hello World
- You are calling static MethodB() with message Hello Moon