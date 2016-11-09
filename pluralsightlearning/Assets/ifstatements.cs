using UnityEngine;
using System.Collections;

public class variables : MonoBehaviour {

	/* if statements check a condition.  It's pretty self explanatory really.  
	 * There's also "if else" statements that preform different results.  
	 * I'm pretty sure that we talked about not using if else.
	 * there are better ways to have the code make a choice between a few actions
	 * it can get pretty messy
	 */
	void SomeNumbers()
	{
		int value= 5 * 4;
		if (value == 20) {
			print ("this is a true statement");
		}
	}
}
