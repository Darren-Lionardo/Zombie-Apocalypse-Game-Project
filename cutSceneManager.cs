using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cutSceneManager : MonoBehaviour
{
    public Image image_1;
    public Text line_1;

    public Image image_2;
    public Text line_2;

    public Image image_3;
    public Text line_3;

    public Image image_4;
    public Text line_4;

    public Image image_5;
    public Text line_5;

    public Image image_6;
    public Text line_6;

    public Image image_7;
    public Text line_7;

    public Image image_8;
    public Text line_8;

    public Image image_9;
    public Text line_9;

    public Image image_10;
    public Text line_10;

    public Text next;
    public int triggerfadenext;


    public int triggerNext = 0;
    void Start(){
        triggerNext += 1;
    }
    void FixedUpdate()
    {
        if(triggerfadenext == 0){
            if(next.color.a <= 1f){
                next.color += new Color32(0, 0, 0, 4);
            }
            else{
                triggerfadenext = 1;
            }
        }
        else{
            if(next.color.a >= 0f){
                next.color -= new Color32(0, 0, 0, 4);
            }
            else{
                triggerfadenext = 0;
            }
        }

        if(triggerNext == 1){
            if(image_1.color.a <= 1f){
                image_1.color += new Color32(0, 0, 0, 2);
            }
            if(line_1.color.a <= 1f){
                line_1.color += new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 2){
            if(image_2.color.a <= 1f){
                image_2.color += new Color32(0, 0, 0, 2);
            }
            if(line_2.color.a <= 1f){
                line_2.color += new Color32(0, 0, 0, 2);
            }

            if(image_1.color.a >= 0f){
                image_1.color -= new Color32(0, 0, 0, 2);
            }
            if(line_1.color.a >= 0f){
                line_1.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 3){
            if(image_3.color.a <= 1f){
                image_3.color += new Color32(0, 0, 0, 2);
            }
            if(line_3.color.a <= 1f){
                line_3.color += new Color32(0, 0, 0, 2);
            }

            if(image_2.color.a >= 0f){
                image_2.color -= new Color32(0, 0, 0, 2);
            }
            if(line_2.color.a >= 0f){
                line_2.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 4){
            if(image_4.color.a <= 1f){
                image_4.color += new Color32(0, 0, 0, 2);
            }
            if(line_4.color.a <= 1f){
                line_4.color += new Color32(0, 0, 0, 2);
            }

            if(image_3.color.a >= 0f){
                image_3.color -= new Color32(0, 0, 0, 2);
            }
            if(line_3.color.a >= 0f){
                line_3.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 5){
            if(image_5.color.a <= 1f){
                image_5.color += new Color32(0, 0, 0, 2);
            }
            if(line_5.color.a <= 1f){
                line_5.color += new Color32(0, 0, 0, 2);
            }

            if(image_4.color.a >= 0f){
                image_4.color -= new Color32(0, 0, 0, 2);
            }
            if(line_4.color.a >= 0f){
                line_4.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 6){
            if(image_6.color.a <= 1f){
                image_6.color += new Color32(0, 0, 0, 2);
            }
            if(line_6.color.a <= 1f){
                line_6.color += new Color32(0, 0, 0, 2);
            }

            if(image_5.color.a >= 0f){
                image_5.color -= new Color32(0, 0, 0, 2);
            }
            if(line_5.color.a >= 0f){
                line_5.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 7){
            if(image_7.color.a <= 1f){
                image_7.color += new Color32(0, 0, 0, 2);
            }
            if(line_7.color.a <= 1f){
                line_7.color += new Color32(0, 0, 0, 2);
            }

            if(image_6.color.a >= 0f){
                image_6.color -= new Color32(0, 0, 0, 2);
            }
            if(line_6.color.a >= 0f){
                line_6.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 8){
            if(image_8.color.a <= 1f){
                image_8.color += new Color32(0, 0, 0, 2);
            }
            if(line_8.color.a <= 1f){
                line_8.color += new Color32(0, 0, 0, 2);
            }

            if(image_7.color.a >= 0f){
                image_7.color -= new Color32(0, 0, 0, 2);
            }
            if(line_7.color.a >= 0f){
                line_7.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 9){
            if(image_9.color.a <= 1f){
                image_9.color += new Color32(0, 0, 0, 2);
            }
            if(line_9.color.a <= 1f){
                line_9.color += new Color32(0, 0, 0, 2);
            }

            if(image_8.color.a >= 0f){
                image_8.color -= new Color32(0, 0, 0, 2);
            }
            if(line_8.color.a >= 0f){
                line_8.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 10){
            if(image_10.color.a <= 1f){
                image_10.color += new Color32(0, 0, 0, 2);
            }
            if(line_10.color.a <= 1f){
                line_10.color += new Color32(0, 0, 0, 2);
            }

            if(image_9.color.a >= 0f){
                image_9.color -= new Color32(0, 0, 0, 2);
            }
            if(line_9.color.a >= 0f){
                line_9.color -= new Color32(0, 0, 0, 2);
            }
        }

        if(triggerNext == 11){
            if(image_10.color.r >= 0f){
                image_10.color -= new Color32(2, 0, 0, 0);
            }
            if(image_10.color.b >= 0f){
                image_10.color -= new Color32(0, 2, 0, 0);
            }
            if(image_10.color.g >= 0f){
                image_10.color -= new Color32(0, 0, 2, 0);
            }
            if(line_10.color.a >= 0f){
                line_10.color -= new Color32(0, 0, 0, 4);
            }
        }

        if(triggerNext == 12){
            SceneManager.LoadScene(2);
        }
    }

    public void onClickNext(){
        triggerNext += 1;
    }
}
