using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class RayCast : MonoBehaviour
{
    bool raycastUsed = false; 
    
    public Text countdownText; 

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && raycastUsed == false) 
        {
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;  
            
            if(Physics.Raycast(ray, out hit)) 
            {
             if(hit.transform.tag == "1") 
                {    
                    SceneManager.LoadScene("Scene 1");
                }
             else if(hit.transform.tag == "2") 
                {
                    SceneManager.LoadScene("Scene 2");
                }
            else if(hit.transform.tag == "3") 
                {
                    SceneManager.LoadScene("Scene 3");
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