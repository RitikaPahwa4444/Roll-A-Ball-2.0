using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed=0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;
    public TextMeshProUGUI countText;
    public GameObject WinTextObject;
    public GameObject backBtn;
  
    private AudioSource coin;
    private AudioSource vic;
    public AudioClip victory;



    
    // Start is called before the first frame update
    void Start()
    {
    

        rb=GetComponent<Rigidbody>();
        count=0;
        //setCountText();
        backBtn.SetActive(false);
        WinTextObject.SetActive(false);
        coin=GetComponent<AudioSource>();
        vic=GetComponent<AudioSource>();
        
        
    }

    
    void OnMove(InputValue movementValue){
        Vector2 movementVector=movementValue.Get<Vector2>();
        backBtn.SetActive(true);
        movementX=movementVector.x;
        movementY=movementVector.y;

    }
    void setCountText(){
       //countText.text="Count: "+count.ToString(); 
       countText.text="SCORE: "+count.ToString(); 
       if(count>=35)
       {
        vic.PlayOneShot(victory);
        WinTextObject.SetActive(true);

       }
    }
    void FixedUpdate(){
        Vector3 movement=new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PickUp"))
        {
            
           
            
            other.gameObject.SetActive(false);  //disables game object
             count++; 
             setCountText(); 

             
                  //Score added
             coin.Play();             

        }


    }
}
//Dispersive ir and vis ir
//vibrational spectroscopy
/*
smart materials*/