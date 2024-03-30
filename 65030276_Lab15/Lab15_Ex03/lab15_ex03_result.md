# 3.1
<img width="639" alt="Screenshot 2024-03-31 055042" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-15/assets/144866059/aa77a90c-1d1e-4409-b788-656b8ab734ce">

# 3.2
<img width="639" alt="Screenshot 2024-03-31 055055" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-15/assets/144866059/dc748a76-ed51-4dbd-8eb0-9c873b3b1fcf">

###
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
