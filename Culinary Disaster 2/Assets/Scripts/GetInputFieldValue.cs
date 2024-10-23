using UnityEngine;
using TMPro;
using UnityEngine.Rendering.Universal;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField Amt1;
    [SerializeField]
    TMP_InputField Cost1;
    [SerializeField]
    TMP_InputField Cost2;
    [SerializeField]
    TMP_InputField Amt2;
    [SerializeField]
    TMP_InputField Cost3;
    [SerializeField]
    TMP_InputField Amt3;
    [SerializeField]
    TMP_InputField Cost4;
    [SerializeField] 
    TMP_InputField Amt4;
    [SerializeField]
    TMP_InputField Amt5;
    [SerializeField] 
    TMP_InputField Cost5;
    [SerializeField]
    TMP_InputField Cost6;
    [SerializeField]
    TMP_InputField Amt6;
    [SerializeField]
    TMP_InputField Cost7;
    [SerializeField]
    TMP_InputField Amt7;
    [SerializeField]
    TMP_InputField Cost8;
    [SerializeField]
    TMP_InputField Amt8;
    [SerializeField]
    TMP_InputField markupValue;
    [SerializeField]
    TMP_InputField Units;
    [SerializeField]
    TMP_Text caculatedNumber;
    public void Calculate()
    {
        // finding the raw cost of item 1
            float itemCost1 = -1;
            Debug.Log(Amt1.text);
            Debug.Log(float.TryParse(Cost1.text, out itemCost1));
            float itemAmt1 = -1;
            Debug.Log(float.TryParse(Amt1.text, out itemAmt1));
            Debug.Log(itemAmt1 * itemCost1);
        // cost item 2
        float itemCost2 = -1;
        Debug.Log(Amt2.text);
        Debug.Log(float.TryParse(Cost2.text, out itemCost2));
        float itemAmt2 = -1;
        Debug.Log(float.TryParse(Amt2.text, out itemAmt2));
        Debug.Log(itemAmt2 * itemCost2);
        // item 3
        float itemCost3 = -1;
        Debug.Log(Amt3.text);
        Debug.Log(float.TryParse(Cost3.text, out itemCost3));
        float itemAmt3 = -1;
        Debug.Log(float.TryParse(Amt3.text, out itemAmt3));
        Debug.Log(itemAmt3 * itemCost3);
        // item 4
        float itemCost4 = -1;
        Debug.Log(Amt4.text);
        Debug.Log(float.TryParse(Cost1.text, out itemCost4));
        float itemAmt4 = -1;
        Debug.Log(float.TryParse(Amt4.text, out itemAmt4));
        Debug.Log(itemAmt4 * itemCost4);
        // item 5
        float itemCost5 = -1;
        Debug.Log(Amt5.text);
        Debug.Log(float.TryParse(Cost5.text, out itemCost5));
        float itemAmt5 = -1;
        Debug.Log(float.TryParse(Amt5.text, out itemAmt5));
        Debug.Log(itemAmt5 * itemCost5);
        // item 6
        float itemCost6 = -1;
        Debug.Log(Amt6.text);
        Debug.Log(float.TryParse(Cost6.text, out itemCost6));
        float itemAmt6 = -1;
        Debug.Log(float.TryParse(Amt6.text, out itemAmt6));
        Debug.Log(itemAmt6 * itemCost6);
        // item 7
        float itemCost7 = -1;
        Debug.Log(Amt7.text);
        Debug.Log(float.TryParse(Cost7.text, out itemCost7));
        float itemAmt7 = -1;
        Debug.Log(float.TryParse(Amt7.text, out itemAmt7));
        Debug.Log(itemAmt7 * itemCost7);
        // item 8
        float itemCost8 = -1;
        Debug.Log(Amt8.text);
        Debug.Log(float.TryParse(Cost8.text, out itemCost8));
        float itemAmt8 = -1;
        Debug.Log(float.TryParse(Amt8.text, out itemAmt8));
        Debug.Log(itemAmt8 * itemCost8);
        // find total raw cost
        float totalCost = (itemAmt1 * itemCost1) + (itemAmt2 * itemCost2) + (itemAmt3 * itemCost3) + (itemAmt4 * itemCost4) + (itemAmt5 * itemCost5) + (itemAmt6 * itemCost6) + (itemAmt7 * itemCost7) + (itemAmt8 * itemCost8);
        Debug.Log(totalCost);
        //markup value
        float markup = -1;
        Debug.Log(float.TryParse(markupValue.text, out markup));
        //cost * markup
        float markValue = markup * totalCost;
        Debug.Log(markValue);
        // amount of units
        float unitsMade;
        Debug.Log(float.TryParse(Units.text, out unitsMade));
        // markup devided by number of units
        float ppu = markValue / unitsMade;
        // make price per unit show on screen
        caculatedNumber.text = ppu.ToString();


    }
    public void Quit()
    {
       Application.Quit();
    }
    public void Reset()
    {
        Amt1.text = 0.ToString();
        Amt2.text = 0.ToString();
        Amt3.text = 0.ToString();
        Amt4.text = 0.ToString();
        Amt5.text = 0.ToString();
        Amt6.text = 0.ToString();
        Amt7.text = 0.ToString();
        Amt8.text = 0.ToString();
        Cost1.text = 0.ToString();
        Cost2.text = 0.ToString();
        Cost3.text = 0.ToString();
        Cost4.text = 0.ToString();
        Cost5.text = 0.ToString();
        Cost6.text = 0.ToString();
        Cost7.text = 0.ToString();
        Cost8.text = 0.ToString();
        markupValue.text = 0.ToString();
        Units.text = 0.ToString();
        caculatedNumber.text = 0.ToString();
        

    }
}
