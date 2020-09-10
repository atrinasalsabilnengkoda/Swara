using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
 
public class Scene : MonoBehaviour {
 
   // pindah scene ke menu
   public void ScaneMenu() {
       SceneManager.LoadScene("ScaneMenu");
   }

   public void ScaneLoading() {
       SceneManager.LoadScene("ScaneLoading");
   }

    public void SceneMenuPanel() {
       SceneManager.LoadScene("SceneMenuPanel");
   }
   
   public void ScaneBelajar() {
       SceneManager.LoadScene("ScaneBelajar");
   }

   public void ScenePuzzle() {
       SceneManager.LoadScene("ScenePuzzle");
   }

   public void SceneQuiz() {
       SceneManager.LoadScene("SceneQuiz");
   }

   // keluar dari game
   public void ScaneKeluar() {
       Application.Quit();
   }
}