using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public GameObject hint;
    int triggerhint;
    // Start is called before the first frame update
    void Start()
    {
        triggerhint = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            if(triggerhint == 1){
                if(hint.GetComponent<RectTransform>().offsetMin.x <= -200 || hint.GetComponent<RectTransform>().offsetMin.x >= 200){
                    hint.GetComponent<RectTransform>().offsetMax += new Vector2(15, 0);
                    hint.GetComponent<RectTransform>().offsetMin += new Vector2(15, 0);
                }
                else{
                    hint.GetComponent<RectTransform>().offsetMax += new Vector2(2, 0);
                    hint.GetComponent<RectTransform>().offsetMin += new Vector2(2, 0);
                }
                if(hint.GetComponent<RectTransform>().offsetMin.x >= 1300){
                    triggerhint = 0;
                }
            }
    }
}
