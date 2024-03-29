### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

เรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

แสดงข้อความ "You are calling instance MethodA() with message Hello world", "You are calling static MethodB() with message Hello world", "You are calling anonymous method with message Hello world" และ "You are calling static MethodB() with message Hello world" ตามลำดับ โดยผลลัพธ์นี้เป็นการเรียกใช้งาน delegate และเมทอดต่างๆ ที่เรากำหนดให้กับตัวแปร delegate และสร้างการเชื่อมต่อระหว่างเมทอดได้อย่างสมบูรณ์

### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมแสดง

imdel + smdel

You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world

imdel + smdel + amdel You are calling instance MethodA() with message Hello world You are calling static MethodB() with message Hello world You are calling anonymous method with message Hello world

del -= imdel

You are calling static MethodB() with message Hello world

You are calling anonymous method with message Hello world
