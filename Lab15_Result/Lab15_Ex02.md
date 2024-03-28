# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/28cac4a3-5ce6-4f61-93d9-91089d353f7a)


# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/21900871-6f13-4f3d-9421-e33bc2e8f64a)

## อธิบายสิ่งที่พบในการทดลอง
 โค้ดนี้เป็นการใช้งาน Delegate กับเมธอดทั้งแบบ Instance และ Static 
 ในคลาส InstanceMethod มีเมธอดชื่อ MethodA ที่รับพารามิเตอร์เป็น string
 ในคลาส StaticMethod มีเมธอดชื่อ MethodB ที่รับพารามิเตอร์เป็น string
 ## `MyDelegate del = im.MethodA;` สร้าง instance ของ Delegate ชื่อ del และผูกไว้กับเมธอด MethodA ของ im
 ## `del = StaticMethod.MethodB;` เปลี่ยน Delegate del ไปอ้างอิงยังเมธอดแบบ static MethodB ของคลาส StaticMethod
