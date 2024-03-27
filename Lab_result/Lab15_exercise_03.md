4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/394f110a-a708-48b3-8c04-d03e8d585dc3)

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/5470adb9-ce31-4b30-aa9c-5f308a027f57)
 ## โคค้ดมีข้อผิดพลาด แก้ไข
 - แก้ไขในบรรทัดที่ 19 ลบ A ออก สามารถรันโปรแกรมได้
   ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-15/assets/144195611/cee9ee87-229f-4723-882a-d855e9a5f775)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ delegate MyDelegate ในการส่งผ่านเป็นพารามิเตอร์ไปยังเมทอด InvokeDelegate 
- เปลี่ยนค่าของ delegate ก่อนเรียกใช้ InvokeDelegate ในแต่ละครั้งเมื่อเรียกใช้ InvokeDelegate โดยส่ง delegate เข้าไป เมทอดนั้นจะเรียกใช้ delegate นั้นๆ และส่งค่า "Hello World" ไปให้
