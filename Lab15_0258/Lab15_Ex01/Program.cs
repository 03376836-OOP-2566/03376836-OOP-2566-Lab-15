MyDelegate myDel1 = new MyDelegate(MyMethod);
MyDelegate myDel2 = MyMethod;


myDel1("Hello World");
myDel1.Invoke("Hello Mars");
myDel2("Hello Saturn");

static  void  MyMethod(string message)
{
    System.Console.WriteLine(message);
}

public delegate void MyDelegate(string message);