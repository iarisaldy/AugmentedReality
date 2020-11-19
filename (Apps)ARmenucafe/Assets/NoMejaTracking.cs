using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    public class NoMejaTracking : MonoBehaviour
    {
        float currentTime;

        public Transform TextTargetNo;
        public DataNoMeja Script;

        public Text waktu;

        void Start()
        {
            currentTime = 0f;
        }

        void Update()
        {
            currentTime += 1 * Time.deltaTime;
            waktu.text = currentTime.ToString();
            Script.datawaktu = currentTime.ToString();
            if (currentTime <= 0)
            {
                currentTime = 0;
            }
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;

                TextTargetNo.GetComponent<Text>().text = name;

                if (name == "1")
                {
                    TextTargetNo.GetComponent<Text>().text = "001";
                    Script.dataNomeja = "001";
                    SceneManager.LoadScene("Pilih_Kategori");
                }

                if (name == "2")
                {
                    TextTargetNo.GetComponent<Text>().text = "002";
                    Script.dataNomeja = "002";
                    SceneManager.LoadScene("Pilih_Kategori");
                }
                if (name == "3")
                {
                    TextTargetNo.GetComponent<Text>().text = "003";
                    Script.dataNomeja = "003";
                    SceneManager.LoadScene("Pilih_Kategori");
                }
                if (name == "4")
                {
                    TextTargetNo.GetComponent<Text>().text = "004";
                    Script.dataNomeja = "004";
                    SceneManager.LoadScene("Pilih_Kategori");
                }
            }
        }
    }
}
