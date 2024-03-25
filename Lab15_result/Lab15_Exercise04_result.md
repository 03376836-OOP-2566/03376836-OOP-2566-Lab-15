### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="445" alt="image" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/7c0f716a-8ccb-4f0e-9c21-2b6b4799145e">
เรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="446" alt="image" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-15/assets/144195555/3ba404f9-5a48-4be9-aab5-56c038f8c4f8">
แสดงข้อความ "You are calling instance MethodA() with message Hello world", "You are calling static MethodB() with message Hello world", "You are calling anonymous method with message Hello world" และ "You are calling static MethodB() with message Hello world" ตามลำดับ โดยผลลัพธ์นี้เป็นการเรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมแสดง

imdel + smdel

You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world

imdel + smdel + amdel You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world You are calling anonymous method with message Hello world

del -= imdel

You are calling static MethodB() with message Hello world

You are calling anonymous method with message Hello world


