using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

namespace code
{
    public class mainmenu : MonoBehaviour
    {
        public GameObject MeunBack;
        public GameObject Manual;
        public GameObject Story;

        public void BtnManual()
        {
            MeunBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenManual", 1.5f);
        }

        public void BtnStory()
        {
            MeunBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenStory", 1.5f);
        }




        void OpenManual()
        {
            Manual.SetActive(true);
            Manual.GetComponent<Animator>().SetTrigger("Open");
        }

        void OpenMenuBack()
        {
            MeunBack.GetComponent<Animator>().SetTrigger("Open");
        }

        void OpenStory()
        {
            Story.SetActive(true);
            Story.GetComponent<Animator>().SetTrigger("Open");




            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
