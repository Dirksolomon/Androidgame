using UnityEngine;
using System.Collections;

public class Kosketusviesti : Kosketuslogiikka {

	public static int hypataan = 0;
	public static int vasen = 0;
	public static int oikea = 0;

	void NappiPainettu()
	{
		if (this.name == "Hyppy") 
		{
			hypataan = 1;
		}
		if (this.name == "Left Button") 
		{
			vasen = 1;
		}
		if (this.name == "Right Button") 
		{
			oikea = 1;
		}
		
	}
	void NappiPainamatta()
	{
		hypataan = 0;
		vasen = 0;
		oikea = 0;
		
	}
}
