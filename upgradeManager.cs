using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeManager : MonoBehaviour
{
    public GameObject[] cloud_value_array;
    public GameObject zombiespeedtxt, zombiespeedinfo;
    public float zombiespeedincrement;
    int zombiespeedlvl = 1;
    public float zombiespeedcost, zombiespeedbasecost, zombiespeedcount = 0f;

    public GameObject cloudregentxt, cloudregeninfo, cloudregenbutton;
    public float cloudregenincrement;
    int cloudregenlvl = 1;
    public float cloudregencost, cloudregeninitialcost, cloudregenbasecost, cloudregencount = 0f, cloudregencd = 3f, cloudregenfirstupgrade = 1f;

    public GameObject clickregentxt, clickregeninfo;
    public float clickregenincrement;
    int clickregenlvl = 1;
    public float clickregencost, clickregenbasecost, clickregencount = 0f;

    public GameObject brainsperhumantxt, brainsperhumaninfo;
    public float brainsperhumanincrement;
    int brainsperhumanlvl = 1;
    public float brainsperhumancost, brainsperhumanbasecost, brainsperhumancount = 0f;

    public GameObject dropletsneededtxt, dropletsneededinfo;
    public float dropletsneededincrement;
    int dropletsneededlvl = 1;
    public float dropletsneededcost, dropletsneededbasecost, dropletsneededcount = 0f;

    void Start(){
        cloudregencd = 3f;
    }

    void FixedUpdate()
    {
        zombiespeedtxt.GetComponent<Text>().text = "Upgrade\n" + "Lvl " + zombiespeedlvl + " >> Lvl " + (zombiespeedlvl + 1);
        zombiespeedinfo.GetComponent<Text>().text = "Cost > " + zombiespeedcost + " Brains\n\nZombie Spawning Cooldown:\n" + zombieSpawning.cd;

        if(cloudregenfirstupgrade == 1){
            cloudregentxt.GetComponent<Text>().text = "Activate!";
            cloudregeninfo.GetComponent<Text>().text = "Cost > " + cloudregeninitialcost + " Brains";
        }
        else{
            if(cloudregenfirstupgrade == 0){
                cloudregentxt.GetComponent<Text>().text = "Upgrade\n" + "lvl " + cloudregenlvl + " >> Lvl " + (cloudregenlvl + 1);
                cloudregeninfo.GetComponent<Text>().text = "Cost > " + cloudregencost + " Brains\n\nCloud Regen Cooldown:\n" + cloudregencd;
            }
        }

        clickregentxt.GetComponent<Text>().text = "Upgrade\n" + "lvl " + clickregenlvl + " >> Lvl " + (clickregenlvl + 1);
        clickregeninfo.GetComponent<Text>().text = "Cost > " + clickregencost + " Brains\n\nIncrement Per Click:\n" + cloudPressing.incrementPerClick;

        brainsperhumantxt.GetComponent<Text>().text = "Upgrade\n" + "lvl " + brainsperhumanlvl + " >> Lvl " + (brainsperhumanlvl + 1);
        brainsperhumaninfo.GetComponent<Text>().text = "Cost > " + brainsperhumancost + " Brains\n\nBrains Per Human:\n" + brainsCompute.increment;

        dropletsneededtxt.GetComponent<Text>().text = "Upgrade\n" + "lvl " + dropletsneededlvl + " >> Lvl " + (dropletsneededlvl + 1);
        dropletsneededinfo.GetComponent<Text>().text = "Cost > " + dropletsneededcost + " Brains\n\nValue Needed:\n" + zombieParachute.needed_value;
    }

    public void onClickUpgradeZombieSpeed(){
        if(brainsCompute.brains >= zombiespeedcost){
            brainsCompute.brains -= zombiespeedcost;
            zombiespeedcount += 1f;
            zombiespeedlvl += 1;
            zombiespeedcost = Mathf.Round(zombiespeedbasecost * Mathf.Pow(1.2f, zombiespeedcount));
            zombieSpawning.cd -= zombiespeedincrement;
        }
    }

    public void onClickUpgradeClickRegen(){
        if(brainsCompute.brains >= clickregencost){
            brainsCompute.brains -= clickregencost;
            clickregencount += 1f;
            clickregenlvl += 1;
            clickregencost = Mathf.Round(clickregenbasecost * Mathf.Pow(1.2f, clickregencount));
            cloudPressing.incrementPerClick += clickregenincrement;
        }
    }

    public void onClickUpgradeBrainsPerHuman(){
        if(brainsCompute.brains >= brainsperhumancost){
            brainsCompute.brains -= brainsperhumancost;
            brainsperhumancount += 1f;
            brainsperhumanlvl += 1;
            brainsperhumancost = Mathf.Round(brainsperhumanbasecost * Mathf.Pow(1.2f, brainsperhumancount));
            brainsCompute.increment += brainsperhumanincrement;
        }
    }

    public void onClickUpgradeDropletsNeeded(){
        if(brainsCompute.brains >= dropletsneededcost){
            brainsCompute.brains -= dropletsneededcost;
            dropletsneededcount += 1f;
            dropletsneededlvl += 1;
            dropletsneededcost = Mathf.Round(dropletsneededbasecost * Mathf.Pow(1.2f, dropletsneededcount));
            zombieParachute.needed_value -= dropletsneededincrement;
        }
    }

    public void onClickUpgradeCloudRegen(){
        if(cloudregenfirstupgrade == 1f && brainsCompute.brains >= cloudregeninitialcost){
            brainsCompute.brains -= cloudregeninitialcost;           
            StartCoroutine(cloudregenspawn());
            cloudregenbutton.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            cloudregenfirstupgrade = 0f;
        }
        if(brainsCompute.brains >= cloudregencost && cloudregenfirstupgrade == 0f){
            brainsCompute.brains -= cloudregencost;
            cloudregencount += 1f;
            cloudregenlvl += 1;
            cloudregencost = Mathf.Round(cloudregenbasecost * Mathf.Pow(1.2f, cloudregencount));
            cloudregencd -= cloudregenincrement;
        }
    }

    IEnumerator cloudregenspawn(){
        while(true){
            int j = Random.Range(0, 4);
            cloud_value_array[j].GetComponent<cloudPressing>().cloud_value += 1;
            yield return new WaitForSeconds(cloudregencd);
        }
    }
}
