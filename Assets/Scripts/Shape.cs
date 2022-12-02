using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    public Color colorStart;
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        // Event m_Event = Event.current;
    }

    // Update is called once per frame
    void Update()
    {

        ChangeColor();

    }
       public virtual void ChangeColor() {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                //RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Cube")
                    {
                        colorStart = Color.blue;
                        rend.material.color = colorStart;
                        Debug.Log(" You change the color of the Shape, the new color is Blue. ");

                    }

                }
            }
        }
    }

    

