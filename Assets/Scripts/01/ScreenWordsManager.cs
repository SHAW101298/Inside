using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWordsManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] List<ScreenWord> currentWords;
    [SerializeField] GameObject wordsContent;
    [SerializeField] ScreenWord prefab;
    [SerializeField] FlameVisibility flame;
    [Header("Data")]
    [SerializeField] int desiredNumberOfWords;
    [SerializeField] float scaleVariation;
    [SerializeField] float startPositionVariation;
    [Header("Indexes of words")]
    [SerializeField] int indexMin;
    [SerializeField] int indexMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateDesiredNumberOfWords();
        CheckIfNeedToAddMoreWords();
        DeleteExpiredWords();

    }

    void CalculateDesiredNumberOfWords()
    {
        desiredNumberOfWords = (int)(flame.dangerLevel * 4) - 1;
        if(desiredNumberOfWords < 0)
        {
            desiredNumberOfWords = 0;
        }
    }
    void CheckIfNeedToAddMoreWords()
    {
        if(currentWords.Count < desiredNumberOfWords)
        {
            GameObject temp = Instantiate(prefab.gameObject);
            temp.transform.SetParent(wordsContent.transform);
            ScreenWord tempWord = temp.GetComponent<ScreenWord>();
            currentWords.Add(tempWord);

            // Set Random Text
            int randIndex = Random.Range(indexMin, indexMax);
            tempWord.SetText(LanguageManager.Instance.GetText(randIndex));
            // Set Random Scale
            float randScale = Random.Range(-scaleVariation, scaleVariation);
            Vector3 newScale = Vector3.one * randScale;
            temp.transform.localScale = Vector3.one + newScale;
            // Set Random Position
            float randPosition = Random.Range(-startPositionVariation, startPositionVariation);
            Vector3 newPosition = new Vector3();
            newPosition.x = randPosition;
            randPosition = Random.Range(-startPositionVariation, startPositionVariation);
            newPosition.y = randPosition;
            newPosition.z = 0;
            temp.transform.localPosition = newPosition;

        }
    }
    void DeleteExpiredWords()
    {
        if (currentWords.Count <= 0)
            return;

        for(int i = 0; i >= 0; i--)
        {
            if (currentWords[i].CheckIfExpired() == true)
            {
                Destroy(currentWords[i].gameObject);
                currentWords.RemoveAt(i);
            }
        }
    }



}
