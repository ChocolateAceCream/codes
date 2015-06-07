/**************************************************/
/*Course Name:  Algorithm Concepts -- CSCI651-W02 */
/*Spring Semester, 2015							  */
/*Programming 1: Huffman Coding					  */
/*Date: 02.18.15	Due: 03.04.15				  */
/*Name: Li Ji (0865582)							  */
/*Name:  	 ()									  */
/*Name:  	 ()									  */
/*File name: HuffmanCode.java	(Test file)		  */
/**************************************************/

import java.util.ArrayList;

import java.util.PriorityQueue;
import java.util.Scanner;

public class HuffmanCode 
{
    // input is an array of frequencies, indexed by character code
    public static HuffmanTree buildTree(int[] charFreqs) 
    {
        PriorityQueue<HuffmanTree> tempTree = new PriorityQueue<HuffmanTree>();
        // initially, we have a forest of leaves
        // one for each non-empty character
        for (int i = 0; i < charFreqs.length; i++)
            if (charFreqs[i] > 0)
            	tempTree.offer(new HuffmanLeaf(charFreqs[i], (char)i));
        
        PriorityQueue<HuffmanTree> trees = new PriorityQueue<HuffmanTree>(); 
        int queuelength = tempTree.size();
        //print out the queue elements:
        
        System.out.println("the queue elements are: ");
        for(int i=0; i<queuelength; i++)
        {
        	HuffmanLeaf hl = (HuffmanLeaf) tempTree.poll();
        	trees.offer(hl);
        	System.out.println(hl.getInfo() + "-- F: " + hl.getFrequency());
        }
        System.out.println("=======================\n");
 
        assert trees.size() > 0: "Tree size should be greater than 0";
        // loop until there is only one tree left
        while (trees.size() > 1) 
        {
            // two trees with least frequency
            HuffmanTree a = trees.poll();
            HuffmanTree b = trees.poll();
 
            // put into new node and re-insert into queue
            trees.offer(new HuffmanNode(a, b));
        }
        
        return trees.poll();
    }
 
    public static void printCodes(HuffmanTree tree, StringBuffer prefix) 
    {
        assert tree != null: "the tree is empty!";
        if (tree instanceof HuffmanLeaf) 
        {
            HuffmanLeaf leaf = (HuffmanLeaf)tree;
 
            // print out character, frequency, and code for this leaf (which is just the prefix)
            System.out.println(leaf.value + "\t" + leaf.frequency + "\t" + prefix);
 
        } 
        else if (tree instanceof HuffmanNode) 
        {
            HuffmanNode node = (HuffmanNode)tree;
 
            // traverse left
            prefix.append('0');
            printCodes(node.left, prefix);
            prefix.deleteCharAt(prefix.length()-1);
 
            // traverse right
            prefix.append('1');
            printCodes(node.right, prefix);
            prefix.deleteCharAt(prefix.length()-1);
        }
    }
    
    //create a ArrayList to hold the Header file
    private static ArrayList<String> HeaderFile = new ArrayList<String>();
    
    public static void buildHeader(HuffmanTree tree)
    {
    	if(tree != null)
    	{
    		if(tree instanceof HuffmanNode)
    		{
    			HuffmanNode node = (HuffmanNode)tree;   			
    			buildHeader(node.getLeft());
    			buildHeader(node.getRight());
 
    			HuffmanNode printNode = (HuffmanNode)tree; 
    			HeaderFile.add(printNode.getInfo());
    		}
    		else if(tree instanceof HuffmanLeaf)
    		{
    			HuffmanLeaf printLeaf = (HuffmanLeaf)tree; 
    			HeaderFile.add(printLeaf.getInfo());
    		}
    	}
    }
    
    public static void printHeader(ArrayList<String> headlist, String text)
    {
    	for(int i=0; i<headlist.size(); i++)
    		System.out.print(headlist.get(i));
    	
    	System.out.print("0" + text.length() + "#");
   // 	System.out.println("\n*****************");
    }
    
    private static Scanner inputString;	
    
    public static void main(String[] args) 
    {    	
    	inputString = new Scanner(System.in);
    	String test = new String();
        //String test = "streets are stone stars are not";
    	System.out.println("==This Program produce \"Huffman Code\" !==");
    	System.out.println("please input the Text:");
 
    	test = inputString.nextLine();
    	
        // we will assume that all our characters will have
        // code less than 256, for simplicity
        int[] charFreqs = new int[256];
        // read each character and record the frequencies
        for (char c : test.toCharArray())
        	charFreqs[c]++;
        
        // build tree
        HuffmanTree tree = buildTree(charFreqs);
 
        // print out results
        System.out.println("Huffman Coding: ");
        System.out.println("SYMBOL\tWEIGHT\tHUFFMAN CODE");
        printCodes(tree, new StringBuffer());
        
        //build the header file and print out
        System.out.println("\n=======Header Information: ===========");
        buildHeader(tree);
        printHeader(HeaderFile, test);
        System.out.println("\n==================");
    }

}