using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    protected PlantEvo plantEvo;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        plantEvo = new PlantEvo();
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

    protected virtual void EvolvePlant()
    {
        plantEvo.Evolve();
        spriteRenderer.sprite = plantEvo.SetCurrentSprite();

        if (plantEvo.hasGrown)
        {
            this.gameObject.SetActive(false);
        }
    }
}
