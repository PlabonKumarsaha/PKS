class Parent{
	public Parent()
	{
		System.out.println("parent 0 arg const");
	}
	
}
class Child extends Parent
{
public 	Child()
{
	
	//there will be by deafult super() ..thats why  after inheriting the parent const will get called first
	//this()
	//if we use this then the parent const will not get called .
System.out.println("child 0 arg const");	
}

public Child(int a)
{
	System.out.println("child 1 arg const");
}

}

class Constructor 
{
	
	public static void main(String[] args)
	{
		Child ch = new Child();
        //Child ca = new Child(1);		
	}
}