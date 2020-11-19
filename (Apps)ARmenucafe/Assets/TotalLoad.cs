using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalLoad : MonoBehaviour
{
    public string[] items;
    public Text jumlah;
    public Text txtboxnomeja;

    public IEnumerator Start()
    {
       if (txtboxnomeja.text == "001")
       {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/jumlah1.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            jumlah.text = items[0];
        }
       if (txtboxnomeja.text == "002")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/jumlah2.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            jumlah.text = items[0];
        }
        if (txtboxnomeja.text == "003")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/jumlah3.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            jumlah.text = items[0];
        }
        if (txtboxnomeja.text == "004")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/jumlah4.php");
            yield return itemsData;
            string itemsDataString = itemsData.text;
            items = itemsDataString.Split(';');
            jumlah.text = items[0];
        }
    }
}
