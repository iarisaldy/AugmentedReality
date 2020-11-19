using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataLoad : MonoBehaviour
{
    public string[] items;
    public Text txtbox11;
    public Text txtbox12;
    public Text txtbox13;
    public Text txtbox21;
    public Text txtbox22;
    public Text txtbox23;
    public Text txtbox31;
    public Text txtbox32;
    public Text txtbox33;
    public Text txtbox41;
    public Text txtbox42;
    public Text txtbox43;
    public Text txtbox51;
    public Text txtbox52;
    public Text txtbox53;
    public Text txtbox61;
    public Text txtbox62;
    public Text txtbox63;
    public Text txtbox71;
    public Text txtbox72;
    public Text txtbox73;
    public Text txtbox81;
    public Text txtbox82;
    public Text txtbox83;
    public Text txtbox91;
    public Text txtbox92;
    public Text txtbox93;
    public Text txtbox101;
    public Text txtbox102;
    public Text txtbox103;
    public Text txtbox111;
    public Text txtbox112;
    public Text txtbox113;
    public Text txtboxnomeja;

    public IEnumerator Start()
    {
       if (txtboxnomeja.text == "001")
       {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/readpesanan1.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            txtbox11.text = items[0];
            txtbox12.text = items[1];
            txtbox13.text = items[2];
            txtbox21.text = items[3];
            txtbox22.text = items[4];
            txtbox23.text = items[5];
            txtbox31.text = items[6];
            txtbox32.text = items[7];
            txtbox33.text = items[8];
            txtbox41.text = items[9];
            txtbox42.text = items[10];
            txtbox43.text = items[11];
            txtbox51.text = items[12];
            txtbox52.text = items[13];
            txtbox53.text = items[14];
            txtbox61.text = items[15];
            txtbox62.text = items[16];
            txtbox63.text = items[17];
            txtbox71.text = items[18];
            txtbox72.text = items[19];
            txtbox73.text = items[20];
            txtbox81.text = items[21];
            txtbox82.text = items[22];
            txtbox83.text = items[23];
            txtbox91.text = items[24];
            txtbox92.text = items[25];
            txtbox93.text = items[26];
            txtbox101.text = items[27];
            txtbox102.text = items[28];
            txtbox103.text = items[29];
            txtbox111.text = items[30];
            txtbox112.text = items[31];
            txtbox113.text = items[32];
       }
       if (txtboxnomeja.text == "002")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/readpesanan2.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            txtbox11.text = items[0];
            txtbox12.text = items[1];
            txtbox13.text = items[2];
            txtbox21.text = items[3];
            txtbox22.text = items[4];
            txtbox23.text = items[5];
            txtbox31.text = items[6];
            txtbox32.text = items[7];
            txtbox33.text = items[8];
            txtbox41.text = items[9];
            txtbox42.text = items[10];
            txtbox43.text = items[11];
            txtbox51.text = items[12];
            txtbox52.text = items[13];
            txtbox53.text = items[14];
            txtbox61.text = items[15];
            txtbox62.text = items[16];
            txtbox63.text = items[17];
            txtbox71.text = items[18];
            txtbox72.text = items[19];
            txtbox73.text = items[20];
            txtbox81.text = items[21];
            txtbox82.text = items[22];
            txtbox83.text = items[23];
            txtbox91.text = items[24];
            txtbox92.text = items[25];
            txtbox93.text = items[26];
            txtbox101.text = items[27];
            txtbox102.text = items[28];
            txtbox103.text = items[29];
            txtbox111.text = items[30];
            txtbox112.text = items[31];
            txtbox113.text = items[32];
        }
        if (txtboxnomeja.text == "003")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/readpesanan3.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            txtbox11.text = items[0];
            txtbox12.text = items[1];
            txtbox13.text = items[2];
            txtbox21.text = items[3];
            txtbox22.text = items[4];
            txtbox23.text = items[5];
            txtbox31.text = items[6];
            txtbox32.text = items[7];
            txtbox33.text = items[8];
            txtbox41.text = items[9];
            txtbox42.text = items[10];
            txtbox43.text = items[11];
            txtbox51.text = items[12];
            txtbox52.text = items[13];
            txtbox53.text = items[14];
            txtbox61.text = items[15];
            txtbox62.text = items[16];
            txtbox63.text = items[17];
            txtbox71.text = items[18];
            txtbox72.text = items[19];
            txtbox73.text = items[20];
            txtbox81.text = items[21];
            txtbox82.text = items[22];
            txtbox83.text = items[23];
            txtbox91.text = items[24];
            txtbox92.text = items[25];
            txtbox93.text = items[26];
            txtbox101.text = items[27];
            txtbox102.text = items[28];
            txtbox103.text = items[29];
            txtbox111.text = items[30];
            txtbox112.text = items[31];
            txtbox113.text = items[32];
        }
        if (txtboxnomeja.text == "004")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/readpesanan4.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            txtbox11.text = items[0];
            txtbox12.text = items[1];
            txtbox13.text = items[2];
            txtbox21.text = items[3];
            txtbox22.text = items[4];
            txtbox23.text = items[5];
            txtbox31.text = items[6];
            txtbox32.text = items[7];
            txtbox33.text = items[8];
            txtbox41.text = items[9];
            txtbox42.text = items[10];
            txtbox43.text = items[11];
            txtbox51.text = items[12];
            txtbox52.text = items[13];
            txtbox53.text = items[14];
            txtbox61.text = items[15];
            txtbox62.text = items[16];
            txtbox63.text = items[17];
            txtbox71.text = items[18];
            txtbox72.text = items[19];
            txtbox73.text = items[20];
            txtbox81.text = items[21];
            txtbox82.text = items[22];
            txtbox83.text = items[23];
            txtbox91.text = items[24];
            txtbox92.text = items[25];
            txtbox93.text = items[26];
            txtbox101.text = items[27];
            txtbox102.text = items[28];
            txtbox103.text = items[29];
            txtbox111.text = items[30];
            txtbox112.text = items[31];
            txtbox113.text = items[32];
        }
    }
}
