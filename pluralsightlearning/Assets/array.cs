using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//this is for using lists
public class variables : MonoBehaviour {
	
	/* an array is a group of similar items.  Instead of having to type out each Variable, an array allows you
*to group them togeather
*int is the type, dont go array is the name of the variable group and all the things in the brackets are the different
*ints in order.  we dont have to specify how many are in the array.
*/
	int[] DontGoArray = {5,1,3}
	/*if you make an array public you can edit the values in unity without having to mess with the dang script.
	 * it's also a heck of a lot easier to do things in large chunks and work with loops
	 * 
	 * 
	 * Lists... this one I'm having trouble with.  the guy in the tutorial is going
	 * WAY too fast.  what the heck
	 * We'll be using "flowers" on a different page.
	 * I'm so lost
	*/
	void Start ()
	{
		List<flowers> flowers = new List<flowers>();

		flowers.Add (new flowers ("rose", "red"));
		flowers.Add (new flowers ("violets", "blue"));
		flowers.Add (new flowers ("tulip", "yellow"));



	}

}