/**************************************************/
/*Course Name:  Algorithm Concepts -- CSCI651-W02 */
/*Spring Semester, 2015							  */
/*Programming 1: Huffman Coding					  */
/*Date: 02.18.15	Due: 03.04.15				  */
/*Name: Li Ji (0865582)							  */
/*Name:  	 ()									  */
/*Name:  	 ()									  */
/*File name: HuffmanTree.java					  */
/**************************************************/
 
abstract class HuffmanTree implements Comparable<HuffmanTree> 
{
    public final int frequency; // the frequency of this tree
    
    public HuffmanTree(int freq) 
    { 
    	frequency = freq; 
    }
 
    // compares on the frequency
    public int compareTo(HuffmanTree tree) 
    {
        return frequency - tree.frequency;
    }
    
    public int getFrequency()
    {
    	return frequency;
    }
    
}
