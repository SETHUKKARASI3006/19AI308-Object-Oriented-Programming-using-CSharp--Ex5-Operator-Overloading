# 19AI308-Object-Oriented-Programming-using-CSharp--Ex5-Operator-Overloading

# AIM:
To write a C# program to pass values through constructors(default and parameterized) and also overload equal operators by checking whether objects are equal using operator overloading. 

# ALGORITHM:
## Step 1:
Initialize a default and a parameterized constructor inside a class MyClass.

## Step 2:
Overload the equal to operator.

## Step 3:
Write the code in the main function to implement operator overloading.

## Step 4:
Create objects ob1,ob2 and ob3 for the class MyClass.

## Step 5:
Check the equality of the objects of the class.

# PROGRAM:
Developed by:SETHUKKARASI C<br>
Register Number:212223230201

```
using System;

class MyClass
{
    private int value;

    public MyClass()
    {
        this.value = 3;
    }

    public MyClass(int value)
    {
        this.value = value;
    }

    public int GetValue()
    {
        return value;
    }

    public static bool operator ==(MyClass obj1, MyClass obj2)
    {

        if (obj1 is null || obj2 is null)
            return false;

        return obj1.value == obj2.value;
    }

    public static bool operator !=(MyClass obj1, MyClass obj2)
    {
        return !(obj1 == obj2);
    }
}

class Overload
{
    static void Main(string[] args)
    {
        MyClass ob1 = new MyClass(28);
        MyClass ob2 = new MyClass(); 
        MyClass ob3 = new MyClass(11);

        Console.WriteLine("Are object1 and object2 equal? " + (ob1 == ob2));
        Console.WriteLine("Are object1 and object3 equal? " + (ob1 == ob3));
    }
}
```

# OUTPUT:
![output](/image.png)

# RESULT:
Thus, the C# program to overload equal operators by checking whether objects are equal using operator overloading is successfully verified and executed.