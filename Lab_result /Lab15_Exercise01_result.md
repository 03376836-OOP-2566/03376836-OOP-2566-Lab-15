# บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/3336b58f-03bd-4d83-80ea-470ac1feb17a)


# บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-15/assets/144197367/d00c1ac5-4ccb-4120-bb9f-a244abd1ecfa)


## อธิบายสิ่งที่พบในการทดลอง
 `public delegate void MyDelegate(string message);` ประกาศ Delegate ชื่อ MyDelegate ซึ่งค่าเป็น string
```
// 2. add target method to delegate
MyDelegate myDel1 = new MyDelegate(MyMethod);
MyDelegate myDel2 = MyMethod;
```
 เป็นการสร้างอ็อบเจกต์ของ MyDelegate และกำหนดให้ชี้ไปที่ MyMethod ได้โดยตรง หรือใช้ชื่อเมธอดโดยไม่ต้องใส่ new MyDelegate()
```
// 3. Invoke delegate
myDel1("Hello World");        // เรียกใช้ MyMethod ผ่าน myDel1
myDel1.Invoke("Hello Mars");  // เรียกใช้ MyMethod ผ่าน myDel1
myDel2("Hello Saturn");       // เรียกใช้ MyMethod ผ่าน myDel2
```
