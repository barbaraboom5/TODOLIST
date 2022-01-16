using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditToDo : MonoBehaviour
{
    public ToDoActive Check;
    public GameObject editInput;
    public bool activeeditInput = false;

    public Text inputTextEditToDo;
    public int indexEditToDo;

    // Start is called before the first frame update
    void Start()
    {
        editInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void editToDo(int index)
    {
        editInput.SetActive(true);
        activeeditInput = true;
        indexEditToDo = index;
    }

    public void saveEdit()
    {
        if (inputTextEditToDo.text == ""|| inputTextEditToDo.text.Length < 2)
        {
            Debug.Log("Данные введены не корректно");
        }
        else
        {
            Check.IndexToDo(indexEditToDo, true);
            Check.TextToDo(indexEditToDo, inputTextEditToDo.text);
            editInput.SetActive(false);
            activeeditInput = false;
        }
    }


    public void CancelEditToDo()
    {
        editInput.SetActive(false);
        activeeditInput = false;
    }
}
