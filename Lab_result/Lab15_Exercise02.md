## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![2](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/94eeff5d-f6e9-4fa9-a426-6dff33c900c3)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![2](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/184d4443-e4cd-424b-821d-fb9146001052)

## อธิบายสิ่งที่พบในการทดลอง
 โค้ดนี้เป็นการใช้งาน Delegate กับเมธอดทั้งแบบ Instance และ Static 
 ในคลาส InstanceMethod มีเมธอดชื่อ MethodA ที่รับพารามิเตอร์เป็น string
 ในคลาส StaticMethod มีเมธอดชื่อ MethodB ที่รับพารามิเตอร์เป็น string
 `MyDelegate del = im.MethodA;` สร้าง instance ของ Delegate ชื่อ del และผูกไว้กับเมธอด MethodA ของ im
`del = StaticMethod.MethodB;` เปลี่ยน Delegate del ไปอ้างอิงยังเมธอดแบบ static MethodB ของคลาส StaticMethod
