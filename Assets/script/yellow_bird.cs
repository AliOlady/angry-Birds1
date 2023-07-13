using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yellow_bird : MonoBehaviour
{

    public Rigidbody2D rb;
    public Rigidbody2D hook;
    public GameObject nextbird;


    public float maxdragdistance = 2f;
    public float releasetime = 0.5f;

    private bool ispressed = false;

    void Addforcee()
    {
        rb.AddForce(new Vector2(150 * 5, transform.position.y));
    }



    void Update()
    {
        if (ispressed)
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Vector3.Distance(mousepos, hook.position) > maxdragdistance)
            {
                rb.position = hook.position + (hook.position - mousepos).normalized * maxdragdistance;
            }
            else
                rb.position = mousepos;


        }

        if (Input.GetMouseButton(0))
        {
            Addforcee();
        }
    }

    void OnMouseDown()
    {
        ispressed = true;
        rb.isKinematic = true;

    }

    void OnMouseUp()
    {
        ispressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }



    IEnumerator Release()
    {
        yield return new WaitForSeconds(releasetime);

        GetComponent<SpringJoint2D>().enabled = false;
        rb.freezeRotation = false;
        yield return new WaitForSeconds(2f);

        if (nextbird != null)
        {
            nextbird.SetActive(true);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}

