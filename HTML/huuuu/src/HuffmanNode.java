/**************************************************/
/*Course Name:  Algorithm Concepts -- CSCI651-W02 */
/*Spring Semester, 2015							  */
/*Programming 1: Huffman Coding					  */
/*Date: 02.18.15	Due: 03.04.15				  */
/*Name: Li Ji (0865582)							  */
/*Name:  	 ()									  */
/*Name:  	 ()									  */
/*File name: HuffmanNode.java					  */
/**************************************************/

class HuffmanNode extends HuffmanTree 
{
    public final HuffmanTree left, right; // subtrees
 
    public HuffmanNode(HuffmanTree l, HuffmanTree r) 
    {
        super(l.frequency + r.frequency);
        left = l;
        right = r;
    }
    
    public String getInfo()
    {
    	return "0";
    }
    
    public HuffmanTree getLeft()
    {
    	return left;
    }
    
    public HuffmanTree getRight()
    {
    	return right;
    }
}
