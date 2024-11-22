using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRotation : MonoBehaviour
{
        if(Input.GetButtonDown("Fire1") && raycastUsed == false) 
        {
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;  
            
            if(Physics.Raycast(ray, out hit)) 
            {
                if(hit.transform.tag == "1") 
                {    
                    StartCoroutine(Countdown("Scene 1")); 
                    raycastUsed = true; 
                }
                else if(hit.transform.tag == "2") 
                {
                    StartCoroutine(Countdown("Scene 2"));
                    raycastUsed = true; 
                }
                else if(hit.transform.tag == "3") 
                {
                    StartCoroutine(Countdown("Scene 3")); 
                    raycastUsed = true; 
                }

            }
        }
    }

     IEnumerator Countdown(string scene) 
    {
        while(countdownText.text != "GOO!") 
        {
            countdownText.text = "5";
            yield return new WaitForSeconds(1f);
            countdownText.text = "4";
            yield return new WaitForSeconds(1f);
            countdownText.text = "3";
            yield return new WaitForSeconds(1f);
            countdownText.text = "2";
            yield return new WaitForSeconds(1f);
            countdownText.text = "1";
            yield return new WaitForSeconds(1f);
            countdownText.text = "GOO!";
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(scene);
            raycastUsed = false;
        }


    }
}
