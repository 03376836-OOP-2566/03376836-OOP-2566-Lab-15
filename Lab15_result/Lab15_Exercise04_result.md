### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="453" alt="15-4 run1" src="https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-15/assets/144196048/8d49a8ff-7d3f-4bfa-baa0-05045e22c1ec">

เรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="450" alt="15-4 run2" src="https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-15/assets/144196048/3e8ca57b-919a-4a27-bde1-509d13f9e7ab">

แสดงข้อความ "You are calling instance MethodA() with message Hello world", "You are calling static MethodB() with message Hello world", "You are calling anonymous method with message Hello world" และ "You are calling static MethodB() with message Hello world" ตามลำดับ โดยผลลัพธ์นี้เป็นการเรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมแสดง

imdel + smdel

You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world

imdel + smdel + amdel You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world You are calling anonymous method with message Hello world

del -= imdel

You are calling static MethodB() with message Hello world

You are calling anonymous method with message Hello world
