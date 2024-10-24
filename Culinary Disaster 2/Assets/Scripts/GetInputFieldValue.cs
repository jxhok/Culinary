using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class GetInputFieldValue : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public TMP_InputField CostField;
        public TMP_InputField AmountField;

        public float GetCost()
        {
            float cost = -1;
            float.TryParse(CostField.text, out cost);
            return cost;
        }

        public float GetAmount()
        {
            float amount = -1;
            float.TryParse(AmountField.text, out amount);
            return amount;
        }
    }

    [SerializeField]
    private List<Item> items = new List<Item>();

    [SerializeField]
    private TMP_InputField markupValue;
    [SerializeField]
    private TMP_InputField Units;
    [SerializeField]
    private TMP_Text calculatedNumber;

    public void AddItem(TMP_InputField costField, TMP_InputField amountField)
    {
        Item newItem = new Item { CostField = costField, AmountField = amountField };
        items.Add(newItem);
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    public void Calculate()
    {
        float totalCost = 0;

        // Calculate total cost from all items
        foreach (Item item in items)
        {
            float itemCost = item.GetCost();
            float itemAmt = item.GetAmount();
            totalCost += itemCost * itemAmt;
        }

        Debug.Log("Total Cost: " + totalCost);

        // Get markup value
        float markup = -1;
        float.TryParse(markupValue.text, out markup);

        // Calculate markup cost
        float markValue = markup * totalCost;
        Debug.Log("Marked-up Cost: " + markValue);

        // Get units made
        float unitsMade = -1;
        float.TryParse(Units.text, out unitsMade);

        // Calculate price per unit
        float ppu = markValue / unitsMade;
        Debug.Log("Price Per Unit: " + ppu);

        // Display price per unit
        calculatedNumber.text = ppu.ToString();
    }

    public void Reset()
    {
        // Reset all input fields in items
        foreach (Item item in items)
        {
            item.AmountField.text = "0";
            item.CostField.text = "0";
        }

        markupValue.text = "0";
        Units.text = "0";
        calculatedNumber.text = "0";
    }

    public void Quit()
    {
        Application.Quit();
    }
}
