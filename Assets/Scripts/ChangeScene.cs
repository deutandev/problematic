using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

public class ChangeScene : MonoBehaviour
{
    public void Problem01() {  
        SceneManager.LoadScene("Problem01");  
    }
    public void Problem02() {  
        SceneManager.LoadScene("Problem02");  
    }
    public void Problem03() {  
        SceneManager.LoadScene("Problem03");  
    }
    public void Problem04() {  
        SceneManager.LoadScene("Problem04");  
    }
    public void Problem05() {  
        SceneManager.LoadScene("Problem05");  
    }
    public void Problem06() {  
        SceneManager.LoadScene("Problem06");  
    }
    public void Problem07() {  
        SceneManager.LoadScene("Problem07");  
    }
    public void Problem08() {  
        SceneManager.LoadScene("Problem08");  
    }
    public void Problem09menu() {  
        SceneManager.LoadScene("Problem09-menu");  
    }
    public void Problem09() {  
        SceneManager.LoadScene("Problem09");  
    }
    public void Problem10() {  
        SceneManager.LoadScene("Problem09");  
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Problem10");
        }
    }
}
