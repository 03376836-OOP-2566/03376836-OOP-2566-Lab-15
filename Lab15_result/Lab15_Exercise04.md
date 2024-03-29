### ผลที่ได้จากการรันคำสั่งในข้อ 3

![Screenshot 2024-03-29 212502](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-15/assets/144195697/2f20ed28-72ca-4c38-8998-efd07e439284)

โปรแกรม Build เพราะโค้ดเกี่ยวกับ Passing delegate as parameter MyDelegate del = imdel + smdel; รวม imdel กับ smdel เข้าด้วยกันใน del ทำให้เมื่อเรียก del("Hello world"); จะเรียกทั้ง MethodA และ MethodB

### ผลที่ได้จากการรันคำสั่งในข้อ 5

![Screenshot 2024-03-29 212509](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-15/assets/144195697/97981e62-1d9c-4ee7-a81e-8b7627a147d2)

โปรแกรม Run ได้เพราะ delegate ด้วยกันโดยใช้ตัวดำเนินการบวก + และลด delegate ด้วยการใช้ตัวดำเนินการลบ -= ตามลำดับ และเรียก delegate โดยส่งพารามิเตอร์ไปยัง delegate นั้นๆ

### สิ่งที่พบในการทดลอง
- ผลลัพท์ที่ได้ คือ
  
------------------
imdel + smdel
You are calling instance MethodA() with message Hello world
You are calling static MethodB() with message Hello world
------------------
imdel + smdel + amdel
You are calling instance MethodA() with message Hello world
You are calling static MethodB() with message Hello world
You are calling anonymous method with message Hello world
------------------
del -= imdel
You are calling static MethodB() with message Hello world
You are calling anonymous method with message Hello world


