using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoe : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
    public void LoadNextShoe(int nextIndex)
    {
        ButtonsManager.instance.playerShoes[nextIndex].spriteRenderer.enabled = true;
        Debug.Log("Shoe number: " + nextIndex + " is enabeld");
        StartCoroutine(ChangeShoe());
    }

    IEnumerator ChangeShoe()
    {
        anim.SetBool("Animate", true);
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.enabled = false;
        anim.SetBool("Animate", false);
        transform.position = Vector3.zero;
    }
}
