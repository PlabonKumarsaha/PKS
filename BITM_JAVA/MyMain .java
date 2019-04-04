class Parent{
	void m1()
	{
		System.out.println("parent m1 method");
	}
	
}

class Child extends Parent
{
	
	void m1()
	{
	System.out.println("child m1 method");	
	}
	void m2()
	{
              //this will call the child method m1
		this.m1();
              //this will call the parent method m1
		super.m1();
	}
}

class MyMain 
{
	
	public static void main(String[] args)
	{
		Child ch = new Child();
ch.m2();		
	}
}