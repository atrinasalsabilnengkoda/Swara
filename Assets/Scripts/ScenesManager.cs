using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //namespace ini kita gunakan agar dapat memanggil methods untuk berpindah scene yang ada pada class SceneManagement
 
public class PindahScene : MonoBehaviour {
 
    // Update is called once per frame
    void Update () {
 
        if (Input.GetKeyDown(KeyCode.A))            
        {
            //Method untuk memanggil / berpindah scene yang kita inginkan
            SceneManager.LoadScene("ScaneMenu");
        }
 
    }
}