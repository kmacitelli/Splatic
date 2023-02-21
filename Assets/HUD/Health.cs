using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int originalHealthPoints = 100;
    private int currentHealthPoints;
    private int originalWidth;
    private GameObject healthFillBar;


    // Start is called before the first frame update
    void Start()
    {
       
        healthFillBar = GameObject.Find("HealthFill");
        currentHealthPoints = originalHealthPoints;
        originalWidth = (int)healthFillBar.GetComponent<RectTransform>().rect.width;

        //InvokeRepeating("Damage", 2.0f, 2.0f);

    }

    public void Damage()
    {
        int damPoints = 5;
        currentHealthPoints -= damPoints;
        UpdateHealthFillBar(currentHealthPoints, originalHealthPoints);

        if (currentHealthPoints <= 0)
        {
            //you lose!
        }
    }

    void UpdateHealthFillBar(int curHP, int origHP)
    {   
        healthFillBar.GetComponent<RectTransform>().sizeDelta = new Vector2((float)curHP / (float)origHP * (float)originalWidth, healthFillBar.GetComponent<RectTransform>().rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
