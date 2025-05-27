using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeOut;
    void OnTriggerEnter(Collider other){
        StartCoroutine(CollisionEnd(other));
    }

    IEnumerator CollisionEnd(Collider other){
        if(other.CompareTag("Player")){
            collisionFX.time = 0.44f;
            collisionFX.Play();
            thePlayer.GetComponent<PlayerMovement>().enabled = false;
            playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
            mainCam.GetComponent<Animator>().Play("CollisionCam");
            yield return new WaitForSeconds(3);
            fadeOut.SetActive(true);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(0);
        }  
    }

}
