using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour

{
   
    int count = 4;
    // Start is called before the first frame update
 
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))

            count--;
        

    

        if (count==0)
            Destroy(this.gameObject);
      
    }

    // Update is called once per frame
   
}
