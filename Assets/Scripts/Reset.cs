using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject parent_puzzle, Benar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseUp() {
        for(int i = 0; i < 4; i++){
            parent_puzzle.transform.GetChild (i).GetComponent<Drag> ().on_tempel = false;    
            parent_puzzle.transform.GetChild (i).GetComponent<Drag> ().on_pos = false;
            parent_puzzle.transform.GetChild (i).position = parent_puzzle.transform.GetChild (i).GetComponent<Drag> ().pos_awal;
            parent_puzzle.transform.GetChild (i).localScale = parent_puzzle.transform.GetChild (i).GetComponent<Drag> ().scale_awal;
        }
        Benar.SetActive(false);
        parent_puzzle.GetComponent<FeedbackPuzzle> ().selesai = false;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
