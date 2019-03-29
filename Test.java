class Test
{
	public Test()
	{
		System.out.println("User created constructor");
	}
	public Test(int a)
	{
		System.out.println("User created constructor");
	}
	
	int x= 100;
	int y = 200;
	void add(int x,int y)
	{
		//will print 300 beacuse of the perameter
		System.out.println(this.x+this.y);
		
		//local variable
		System.out.println(x+y);
		
	}
	
	public static void main(String args[])
	{
		
		Test ts = new Test(2);
		ts.add(4,6);
		
	}
}