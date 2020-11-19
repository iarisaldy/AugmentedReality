using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tambah : MonoBehaviour
{
    public Text txtbox;
    public Text harga;
    public GameObject button;
    public static int jumlah;
    public static int jumlahgen;
    public static int jumlahteh;
    public static int jumlahblak;
    public static int jumlahpiz;
    public static int jumlahlen;
    public static int jumlahkop;
    public static int Genderuo = 15000;
    public static int greenteh = 10000;
    public static int esteh = 5000;
    public static int seblak = 20000;
    public static int pizza = 30000;
    public static int molen = 15000;
    public static int kopi = 12000;

    void Start()
    {
        jumlah = 1;
        jumlahgen = 1;
        jumlahteh = 1;
        jumlahblak = 1;
        jumlahpiz = 1;
        jumlahlen = 1;
        jumlahkop = 1;
    }

    public void Plus()
    {
        jumlah++;
        txtbox.text = "" +jumlah;
        harga.text = "" + jumlah*greenteh;
        if (jumlah >= 1)
        {
            button.SetActive(true);
        }
    }
    public void Minus()
    {
        jumlah--;
        txtbox.text = "" + jumlah;
        harga.text = ""+ jumlah * greenteh;
        if (jumlah <= 1)
        {
            button.SetActive(false);
        }
    }
    public void Plusesteh()
    {
        jumlahteh++;
        txtbox.text = "" + jumlahteh;
        harga.text = "" + jumlahteh * esteh;
        if (jumlahteh >= 1)
        {
            button.SetActive(true);
        }
    }
    public void Minusesteh()
    {
        jumlahteh--;
        txtbox.text = "" + jumlahteh;
        harga.text = "" + jumlahteh * esteh;
        if (jumlahteh <= 1)
        {
            button.SetActive(false);
        }
    }
    public void Plusseblak()
    {
        jumlahblak++;
        txtbox.text = "" + jumlahblak;
        harga.text = "" + jumlahblak * seblak;
        if (jumlahblak >= 1)
        {
            button.SetActive(true);
        }
    }
    public void Minusseblak()
    {
        jumlahblak--;
        txtbox.text = "" + jumlahblak;
        harga.text = "" + jumlahblak * seblak;
        if (jumlahblak <= 1)
        {
            button.SetActive(false);
        }
    }
    public void Pluskopi()
    {
        jumlahkop++;
        txtbox.text = "" + jumlahkop;
        harga.text = "" + jumlahkop * kopi;
        if (jumlahkop >= 1)
        {
            button.SetActive(true);
        }
    }
    public void MinusKopi()
    {
        jumlahkop--;
        txtbox.text = "" + jumlahkop;
        harga.text = "" + jumlahkop * kopi;
        if (jumlahkop <= 1)
        {
            button.SetActive(false);
        }
    }
    public void Plusgenderuo()
    {
        jumlahgen++;
        txtbox.text = "" + jumlahgen;
        harga.text = "" + jumlahgen * Genderuo;
        if (jumlahgen >= 1)
        {
            button.SetActive(true);
        }
    }
    public void Minusgenderuo()
    {
        jumlahgen--;
        txtbox.text = "" + jumlahgen;
        harga.text = "" + jumlahgen * Genderuo;
        if (jumlahgen <= 1)
        {
            button.SetActive(false);
        }
    }
    public void Pluspizza()
    {
        jumlahpiz++;
        txtbox.text = "" + jumlahpiz;
        harga.text = "" + jumlahpiz * pizza;
        if (jumlahpiz >= 1)
        {
            button.SetActive(true);
        }
    }
    public void Minuspizza()
    {
        jumlahpiz--;
        txtbox.text = "" + jumlahpiz;
        harga.text = "" + jumlahpiz * pizza;
        if (jumlahpiz <= 1)
        {
            button.SetActive(false);
        }
    }
    public void Plusmolen()
    {
        jumlahlen++;
        txtbox.text = "" + jumlahlen;
        harga.text = "" + jumlahlen * molen;
        if (jumlahlen >= 1)
        {
            button.SetActive(true);
        }
    }
    public void Minusmolen()
    {
        jumlahlen--;
        txtbox.text = "" + jumlahlen;
        harga.text = "" + jumlahlen * molen;
        if (jumlahlen <= 1)
        {
            button.SetActive(false);
        }
    }
}
