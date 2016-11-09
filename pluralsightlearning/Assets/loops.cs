
using UnityEngine;
using System.Collections;

public class variables : MonoBehaviour {
	
	/* loops are for repeating code. there's while loops, for loops.
 Things start to get a bit tricky here so hang on tight
 while loops dont have to have a semicolon on the end
 I think you use for each loops instead of if else statements
 */
	int SomeNumbers = 1;
	
	void start ()
	{
		for(int i = 0; i >SomeNumbers; i++)
		{
			print ("look at these numbers " + i);
		}
	}
	
}