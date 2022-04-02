using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    PlantEvo plantEvo;
    public Monster monster;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        monster.gameObject.SetActive(false);
        spriteRenderer = GetComponent<SpriteRenderer>();

        plantEvo = new PlantEvo();
        plantEvo.plantMon = monster;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Evolve");
            EvolvePlant();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Evolve");
            EvolvePlant();
        }
    }

    void EvolvePlant()
    {
        plantEvo.Evolve();
        spriteRenderer.sprite = plantEvo.SetCurrentSprite();

        if (plantEvo.hasGrown)
        {
            monster.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
