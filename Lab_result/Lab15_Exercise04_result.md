## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-10.png)

สามารถ Build ได้ เพราะ สร้าง instance ของ InstanceMethod กับ StaticMethod และ delegate ที่เรียก method ของทั้งสองคลาส แต่จะเตือนว่ามี ค่า Null
 
## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-11.png)

สามารถ Run ได้ เพราะ delegate ด้วยกันโดยใช้ตัวดำเนินการบวก + และลด delegate ด้วยการใช้ตัวดำเนินการลบ -= ตามลำดับ และเรียก delegate โดยส่งพารามิเตอร์ไปยัง delegate นั้นๆ 

## อธิบายสิ่งที่พบในการทดลอง

------------------
- imdel + smdel
- You are calling instance MethodA() with message Hello world
- You are calling static MethodB() with message Hello world
------------------
- imdel + smdel + amdel
- You are calling instance MethodA() with message Hello world
- You are calling static MethodB() with message Hello world
- You are calling anonymous method with message Hello world
------------------
- del -= imdel
- You are calling static MethodB() with message Hello world
- You are calling anonymous method with message Hello world

