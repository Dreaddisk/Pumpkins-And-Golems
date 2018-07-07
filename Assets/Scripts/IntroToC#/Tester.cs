using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {
    /*
    float power = 2.1f;
    double health = 3.5;
    int score = 44;

    string name = "Jose";
    bool isAlive = false;

    void CalculateTwoNumbers() {

    Debug.Log("The sum of a nd b is:" + (3 + 5));

    }

     void CalculateTwoNumbers(int a, int b) {

     Debug.Log("The sum of a nd b is:" + (a + b));
    }

     int CalculateTwoNumbers() {

      return 5 + 6;
    }

     int CalculateTwoNumbers(int a, int b) {

      return a + b;
    }

        CONDITIONALS
           public void IfStatementDoneRight() {

        int number1 = 6;
        int number2 = 7;

        if (number1 == number2)
        {

            Debug.Log("Results are equal");
        }

        else if (number1 < number2)
        {

            Debug.Log("number 1 is less than number2");
        }
    }

                for (int i = 0; i < 10; i++) {

            print("The result is: " + i);
        }

        FOR LOOP WITH ARRAYS:
               
        int[] data = new int[10];

        for (int i = 0; i < data.Length; i++) {

            data[i] = Random.Range(0, 100);
            print("The element at index  " + i + "has a value of: " + data[i]);
        }

        
    void ProcessArray(int[] data) {

        for (int i = 0; i < data.Length; i++) {
            data[i] = Random.Range(0, 100);
            print("The value is: " + data[i]);
        }
    }
*/

    private void Start()
    {
        Player knight = new Player("knight", 1);

        knight.SetHealth(3.4f);

        print(knight.GetHealth());
    }

}	// Main Class
