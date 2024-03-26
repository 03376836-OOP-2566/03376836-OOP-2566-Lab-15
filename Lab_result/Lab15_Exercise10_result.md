## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-22.png)

สามารถ Build ได้ เพราะ ใช้ Func delegate เพื่อเรียกใช้ Method และ anonymous function อีกทั้ง Func delegate ช่วยให้สร้างตัวแปรที่เก็บการเรียกใช้ Method หรือ anonymous function ได้ โดยระบุประเภทของพารามิเตอร์และประเภทของค่าที่คืนกลับมา 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-23.png)

สามารถ Run ได้ เพราะ static int Add(int a, int b) เป็นฟังก์ชันที่ถูกสร้างขึ้นเพื่อทำการบวกตัวเลขสองตัว และถูกเรียกใช้ผ่าน Delegate add Func<int, int, int> และ System.Console.WriteLine($"Before = \"{before}\", after = \"{convertToUpper(before)}\""); ทำการเรียกใช้ convertToUpper เพื่อเปลี่ยน string before เป็นตัวพิมพ์ใหญ่ทั้งหมด จาก Func <string, string>


## อธิบายสิ่งที่พบในการทดลอง

- Add(5, 9) return 14
- Before = "all Lowercase characters", after = "ALL LOWERCASE CHARACTERS"