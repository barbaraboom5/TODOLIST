using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InfoToDo : MonoBehaviour
{
    public class ToDo
    {
        public ToDo(GameObject toDo, Text textToDo, bool toDoActive)
        {
        }
        public GameObject Todo;
        public Text textToDo;
        public bool toDoActive;


    }
    public ToDo toDo1;
    public GameObject ToDo1;
    public Text textToDo1;
    public bool toDoActive1 = false;

    public ToDo toDo2;
    public GameObject ToDo2;
    public Text textToDo2;
    public bool toDoActive2 = false;

    public ToDo toDo3;
    public GameObject ToDo3;
    public Text textToDo3;
    public bool toDoActive3 = false;

    public ToDo toDo4;
    public GameObject ToDo4;
    public Text textToDo4;
    public bool toDoActive4 = false;

    public ToDo toDo5;
    public GameObject ToDo5;
    public Text textToDo5;
    public bool toDoActive5 = false;
    // Start is called before the first frame update
   

    public void Assign()
    {
        toDo1 = new ToDo(ToDo1, textToDo1, toDoActive1);
        toDo2 = new ToDo(ToDo2, textToDo2, toDoActive2);
        toDo3 = new ToDo(ToDo3, textToDo3, toDoActive3);
        toDo4 = new ToDo(ToDo4, textToDo4, toDoActive4);
        toDo5 = new ToDo(ToDo5, textToDo5, toDoActive5);
        

       
    }
}
