using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class action : MonoBehaviour
{

    public Button btnClick;
    public InputField inputUser;
    public string textfield;
    public Animator anime;
    public List<string> ar = new List<string>();
    public string[] input;
   

    private void Start()
    {
        anime = GetComponent<Animator>();
     
        //inputUser.onValueChanged.AddListener(delegate { GetInputOnClickHandler(); });

    }

  
    public void btnclick()
    {
       // btnClick.onClick.AddListener(GetInputOnClickHandler);
        GetInputOnClickHandler();
    }

    


    public void GetInputOnClickHandler()
    {
        textfield = inputUser.text.ToString();

        ar.Add("love");
        ar.Add("like");
        ar.Add("yes");
        ar.Add("don'tlike");

        textfield = textfield.ToLower();
        input = textfield.Split(' ');
        


        for (int i = 0; i < input.Length; i++)
        {

          
            
              
                  if (input[i] == "love")
                  {
                      Debug.Log("Log input : " + input[i]);
                      anime.Play(input[i]);
                        

                  }

                  else if (input[i] == "like")
                  {
                      Debug.Log("Log input : " + input[i]);

                      anime.Play(input[i]);

               
            }

                  else if (input[i] == "yes")
                  {
                      Debug.Log("Log input : " + input[i]);
                      anime.Play(input[i]);
                
             
            }

                  else if (input[i] == "don'tlike")
                  {
                      Debug.Log("Log input : " + input[i]);
                      anime.Play(input[i]);
                
               
            }
            
        }


    }
    

   


    /* public void like(string x)
   {
       if (x == "like")
       {
           Debug.Log("Log input : " + x);

           anime.Play(x);
       }
   }

   public void love(string x)
   {
       if (x == "love")
       {
           Debug.Log("Log input : " + x);

           anime.Play(x);
       }
   }
   */
}



