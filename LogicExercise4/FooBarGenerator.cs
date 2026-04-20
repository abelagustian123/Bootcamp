using System;
using System.Text;

namespace LogicExercise4;

public class FooBarGenerator
{
    public Dictionary<int, string> rules = new Dictionary<int, string>();

    public void AddRule(int angka, string kata) => rules[angka] = kata;

    public void RemoveRule(int angka) => rules.Remove(angka);

    public string Generate(int limit)
    {
        StringBuilder finalResults = new StringBuilder();

        for (int i = 1; i <= limit; i++)
        {
            StringBuilder tempResult = new StringBuilder();

            tempResult.Clear();

            foreach (var rule in rules)
            {
                if (i % rule.Key == 0)
                {
                    tempResult.Append(rule.Value);
                }
            }

            if (tempResult.Length == 0)
            {
                finalResults.Append(i.ToString());
            }
            else
            {
                finalResults.Append(tempResult);
            }

            if (i < limit)
            {
                finalResults.Append(",");
            }
        }

        return finalResults.ToString();
    }
}
