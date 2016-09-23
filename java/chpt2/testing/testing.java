/**
 * @(#)String.java
 *
 *
 * @author
 * @version 1.00 2014/9/6
 */


public class testing
{

    public static void main(String[] args)
    {
    	String gg = "  Gava Dsqwrtqert fan       ";
    	int n = gg.indexOf(" "); // return the index of first occurrence of the substring
    	int k = gg.length();
    	char c= gg.charAt(6); 	//trturns the character at Index in the string.
    	String kk = gg.trim();
    	String qq = gg.toLowerCase();		//return all upperc(NAMase
    	String uu = gg.toUpperCase();
    	String sub = gg.substring(6,10);	//returns a new string begins at stdex start (6), but not including, index End of the string (10)
    	String gaga = gg.replace("G", "P"); //with each occurrence of old char"G" replaced by new char "P"
    	String subb = gg.substring(6);
    	String ll="123qwe123rty";
    	int omg = ll.lastIndexOf("123"); // returns the index of the last occurrence of substring ,return -1 if substring is not found
    	boolean  de=ll.equalsIgnoreCase("123QWE123RtY"); //return true if this string and other string are equal, ignore case. (equals(other_string) for case )
    														// return false if not same
    	System.out.println(de);
    	System.out.println(omg);
    	System.out.println("0123456789");
    	System.out.println(subb);
    	System.out.println(gaga);
    	System.out.println(sub);
    	System.out.println(uu);
    	System.out.println(qq);
    	System.out.println(kk);
    	System.out.println(c);
    	System.out.println(n);
    	System.out.println(k);
    	System.out.println(gg);
    	System.out.println("\"\'\\\nasfdasdf        a\rasdf\tadf");
    	System.out.println("a\\nd");

    }


}