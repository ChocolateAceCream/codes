/**************************************************/
/*Course Name:  Algorithm Concepts -- CSCI651-W02 */
/*Spring Semester, 2015							  */
/*Programming 1: Huffman Coding					  */
/*Date: 02.18.15	Due: 03.04.15				  */
/*Name: Li Ji (0865582)							  */
/*Name:  	 ()									  */
/*Name:  	 ()									  */
/*File name: HuffmanLeaf.java					  */
/**************************************************/

class HuffmanLeaf extends HuffmanTree 
{
    public final char value; // the character this leaf represents
 
    public HuffmanLeaf(int freq, char val) 
    {
        super(freq);
        value = val;
    }
    
    public String getInfo()
    {
    	return "1" + value;
    }
    
}
