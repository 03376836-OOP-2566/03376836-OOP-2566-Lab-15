## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![1](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/cb0f47c6-9876-4644-8156-ed99b069d650)


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![1](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-15/assets/144196695/1d38d841-66e4-415d-a2f3-7a2e99dfd892)

## อธิบายสิ่งที่พบในการทดลอง
### `public delegate void MyDelegate(string message);` ประกาศ Delegate ชื่อ MyDelegate ซึ่งค่าเป็น string
```
// 2. add target method to delegate
MyDelegate myDel1 = new MyDelegate(MyMethod);
MyDelegate myDel2 = MyMethod;
```
### เป็นการสร้างอ็อบเจกต์ของ MyDelegate และกำหนดให้ชี้ไปที่ MyMethod ได้โดยตรง หรือใช้ชื่อเมธอดโดยไม่ต้องใส่ new MyDelegate()
```
// 3. Invoke delegate
myDel1("Hello World");        // เรียกใช้ MyMethod ผ่าน myDel1
myDel1.Invoke("Hello Mars");  // เรียกใช้ MyMethod ผ่าน myDel1
myDel2("Hello Saturn");       // เรียกใช้ MyMethod ผ่าน myDel2
```
