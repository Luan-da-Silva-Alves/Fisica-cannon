
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition : MonoBehaviour
{
    public int pontuacao = 0;
    

    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


        if (pontuacao >= 3)
        {
           SceneManager.LoadScene("Vitória");
            
        }
    }

    

    
}
