//Addition program in java.
  
import java.io.*;
class Functions
{
    protected int addNumbers(int a, int b)
    {
    int c= 0;
    c= a+b;
    return c;
    }
}
class Addition extends Functions
{
public static void main(String[] args) throws IOException
{
    int a=0,b=0,c=0;
    BufferedReader br=new BufferedReader(new InputStreamReader(System.in));
    System.out.println("ENter the value of a= ");
    a= Integer.parseInt(br.readLine());
    System.out.println("ENter the value of b= ");
    b= Integer.parseInt(br.readLine());
    Functions obj= new Functions();
    c= obj.addNumbers(a, b);
    System.out.println("Sum of the numbers is= "+c);
}
}