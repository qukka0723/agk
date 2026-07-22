using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance = null;

    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private GameObject gameOverPanel;

    private int coin = 0;

   [HideInInspector]
   public bool isGameOver = false;

   void Awake()
   {
       if (instance == null)
       {
           instance = this;
       }
   }

   public void IncreaseCoin()
   {
       coin += 1;
       text.SetText(coin.ToString());

       if (coin % 15 == 0)
       { // 30, 60, 90, ...
           player player = FindObjectOfType<player>();
           if (player != null)
           {
               player.Upgrade();
           }
       }
   }

   public void SetGameOver()
   {
       isGameOver = true;

       Enemyspawner enemyspawner = FindObjectOfType<Enemyspawner>();
       if (enemyspawner != null)
       {
           enemyspawner.StopEnemyRoutine();
       }

       Invoke("ShowGameOverPanel", 1f);
   }

   void ShowGameOverPanel()
   {
       gameOverPanel.SetActive(true);
   }

   public void PlayAgin()
   {
       SceneManager.LoadScene("SamplsScene");
   }
}
