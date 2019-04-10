using UnityEngine;
using System.Collections;

public class fan : MonoBehaviour {

	//-- set start time 00:00
    public int hand1 = 0;
    public int hand2 = 120;
	public int hand3 = 240;
	
    public GameObject pointerHand1;
    public GameObject pointerHand2;
    public GameObject pointerHand3;

    
    public float speed = 100;  

   
    float msecs=0;

void Start() 
{
	
}

void Update() 
{
    msecs += Time.deltaTime * speed;
    if(msecs >= 1.0f)
    {
        msecs -= 1.0f;
        hand3++;
            if (hand3 >= 60) hand3 = 0;
        hand1++;
            if (hand1 >= 240) hand1 = 120;
        hand2++;
            if (hand2 >= 360) hand2 = 240;
            
    }


        //-- calculate pointer angles
        float rotationHand3 = (360.0f / 60.0f) * hand3;
        float rotationHand1 = (360.0f / 60.0f) * hand1;
        float rotationHand2   = (360.0f / 60.0f) * hand2;

        //-- draw pointers
        pointerHand3.transform.localEulerAngles = new Vector3(0.0f, rotationHand3, 0.0f );
        pointerHand1.transform.localEulerAngles = new Vector3(0.0f, rotationHand1, 0.0f );
        pointerHand2.transform.localEulerAngles   = new Vector3(0.0f, rotationHand2, 0.0f);

}
}
