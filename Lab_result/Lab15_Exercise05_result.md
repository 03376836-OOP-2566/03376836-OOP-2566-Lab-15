## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-12.png)

สามารถ Build ได้ เพราะ delegate ที่รับพารามิเตอร์แบบ generic และ return ค่าที่มีประเภทข้อมูลเดียวกันกับพารามิเตอร์ที่รับเข้า คือ  generic delegate Add< int > สำหรับฟังก์ชัน NumericSum และ Add< string > สำหรับฟังก์ชัน StringConcat 
 
## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-13.png)

สามารถ Run ได้ เพราะ Add< int > แทน delegate ที่รับพารามิเตอร์แบบ int และ return ค่าที่เป็น int และ Add< string > แทน delegate ที่รับพารามิเตอร์แบบ string และ return ค่าที่เป็น string

## อธิบายสิ่งที่พบในการทดลอง

- Numeric sum of 30 and 50 is 80
- String concatenate of 'hello' and 'World' is "hello World"