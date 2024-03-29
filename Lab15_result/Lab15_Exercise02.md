### ผลที่ได้จากการรันคำสั่งในข้อ 3

![Screenshot 2024-03-29 211320](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-15/assets/144195697/e12c6c4a-0205-4acd-8223-e6a291378981)

โปรแกรม Build เพราะโค้ดนี้เป็นการใช้งาน Delegate กับเมธอดทั้งแบบ Instance และ Staticในคลาส InstanceMethod มีเมธอดชื่อ MethodA ที่รับพารามิเตอร์เป็น string

### ผลที่ได้จากการรันคำสั่งในข้อ 5

![Screenshot 2024-03-29 211326](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-15/assets/144195697/0a24350e-52d8-46fe-ac29-46ba252a8111)

โปรแกรม Runได้เพราะเรียกใช้เมธอดที่ delegate ชี้ไป โดยส่งพารามิเตอร์เข้าไป เราสามารถใช้ delegate นั้นๆ โดยไม่ต้องระบุชื่อเมธอดโดยตรง

### สิ่งที่พบในการทดลอง
- โปรแกรม Build เพราะโค้ดนี้เป็นการใช้งาน Delegate กับเมธอดทั้งแบบ Instance และ Staticในคลาส InstanceMethod มีเมธอดชื่อ MethodA ที่รับพารามิเตอร์เป็น string
- โปรแกรม Runได้เพราะเรียกใช้เมธอดที่ delegate ชี้ไป โดยส่งพารามิเตอร์เข้าไป เราสามารถใช้ delegate นั้นๆ โดยไม่ต้องระบุชื่อเมธอดโดยตรง
- ผลลัพท์ที่ได้ คือ
  - You are calling instance MethodA() with message Hello World
  - You are calling static MethodB() with message Hello Moon
