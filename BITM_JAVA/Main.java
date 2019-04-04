//this code will show output of differnt types of variables with same name

class Parent
{
	
int a =10;
int b =20;	
	
}

class Child extends Parent{
	
	int a = 100;
	int b = 200;
	void add(int a,int b)
	{
		//perameter variables
		System.out.println(a+b);
		
		//parent class variables
		System.out.println(this.a+this.b);
		
		//craeting an instance of child
		Parent pa = new Parent();
		System.out.println(pa.a+pa.b);
		
		
		//inheited variables
		//System.out.println(super.a+super.b);
	}
	
}

public class Main
{
	public static void main(String[] args)
	{
		Child ch = new Child();
		ch.add(2,3);
		
	}
}