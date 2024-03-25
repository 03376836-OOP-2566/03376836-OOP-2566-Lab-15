## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/564d7aa7-f84c-437f-ab97-215737c422b8)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/c4227042-f678-40a1-adee-0638bfae6c10)


## อธิบายสิ่งที่พบในการทดลอง
 โค้ดนี้เป็นการใช้งาน Delegate กับเมธอดทั้งแบบ Instance และ Static 
 ในคลาส InstanceMethod มีเมธอดชื่อ MethodA ที่รับพารามิเตอร์เป็น string
 ในคลาส StaticMethod มีเมธอดชื่อ MethodB ที่รับพารามิเตอร์เป็น string
 ## `MyDelegate del = im.MethodA;` สร้าง instance ของ Delegate ชื่อ del และผูกไว้กับเมธอด MethodA ของ im
 ## `del = StaticMethod.MethodB;` เปลี่ยน Delegate del ไปอ้างอิงยังเมธอดแบบ static MethodB ของคลาส StaticMethod
