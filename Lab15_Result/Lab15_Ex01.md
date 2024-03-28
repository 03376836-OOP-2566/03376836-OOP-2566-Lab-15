# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/c7e58760-4a5f-4b26-90b0-9dce84d38639)


# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-15/assets/144195683/40a6979a-a7f1-463e-9f08-a2e6da0861ad)

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
