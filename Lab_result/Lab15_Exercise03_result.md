## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-5.png)

สามารถ Build ได้ เพราะ เกิดขึ้อผิดพลาด ไม่พบตัวระบุค่ากับ ;

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-6.png)

สามารถ Run ได้ เกิดขึ้อผิดพลาด ไม่พบตัวระบุค่ากับ ;

## อธิบายสิ่งที่พบในการทดลอง

- You are calling instance MethodA() with message Hello World
- You are calling static MethodB() with message Hello World
- You are calling anonymous method with message Hello World

## หลังแก้ไขโปรแกรม

![pic](/Pictures/pic-9.png)

![pic](/Pictures/pic-7.png)

![pic](/Pictures/pic-8.png)

เรียกใช้งานเมธอดหรือฟังก์ชันที่กำหนดไว้ผ่านตัวแปร delegate โดยไม่ต้องระบุชื่อเมธอดโดยตรง ในกรณีนี้เราสามารถใช้ passing delegate as parameter ได้

delegate เป็นพารามิเตอร์ให้กับเมธอด InvokeDelegate โดยที่ delegate นั้นมีลักษณะเป็นเมธอดที่รับพารามิเตอร์ชนิด string  ซึ่งจะทำให้เมธอด InvokeDelegate สามารถเรียกใช้ delegate ที่ส่งเข้ามาโดยส่งค่า "Hello World" เข้าไปในเมธอดที่ delegate ชี้ไปได้ทุกครั้งที่เรียกใช้งาน