# Exercise 3.1
![Ex3 1](https://github.com/65030179179Pattarapon/03376836-OOP-2566-Lab-15/assets/144198506/501a5d39-07d1-46f1-b766-7a50f5ff1d0b)

# Exercise 3.2
![Ex3 2](https://github.com/65030179179Pattarapon/03376836-OOP-2566-Lab-15/assets/144198506/5ef02a12-2c08-4e4a-af1b-508793582346)

##
- สร้างคลาส InstanceMethod ที่มีเมธอดชื่อ MethodA ซึ่งรับพารามิเตอร์เป็น string เพื่อแสดงข้อความ "You are calling instance MethodA() with message {message}" ในหน้าจอ.
- สร้างคลาส StaticMethod ที่มีเมธอดชื่อ MethodB ซึ่งรับพารามิเตอร์เป็น string เพื่อแสดงข้อความ "You are calling static MethodB() with message {message}" ในหน้าจอ.
ประกาศ Delegate ชื่อ MyDelegate ที่รับพารามิเตอร์เป็น string และไม่มีการส่งคืนค่า.
- ในฟังก์ชัน Main():

-- สร้าง Instance ของ InstanceMethod และกำหนดเมธอด MethodA ให้กับตัวแปร Delegate del.

-- เรียกใช้เมธอด InvokeDelegate() เพื่อเรียกใช้งาน Delegate โดยส่ง Delegate del ไปเป็นพารามิเตอร์.

-- เปลี่ยนค่าของ Delegate del ใหม่เป็น Static Method MethodB ของคลาส StaticMethod และเรียกใช้งาน InvokeDelegate() อีกครั้ง.

-- กำหนด Delegate เป็น Anonymous Method และเรียกใช้งาน InvokeDelegate() อีกครั้ง.

- ในฟังก์ชัน InvokeDelegate():

-- เรียกใช้งาน Delegate ที่รับเข้ามาโดยส่งข้อความ "Hello World" ไปเป็นพารามิเตอร์
