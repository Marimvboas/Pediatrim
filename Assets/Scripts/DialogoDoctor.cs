using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoDoctor : MonoBehaviour
{
	//Script Inspirado no script criado pelo canal do Youtube "Crie Seus Jogos"
	public GameObject spechBaloon, nextBalloon;
	string[] dialogos;
	public float typingSpeed;
	public static int iD;
	public bool activecontrol;
	public Text spechBaloonText;

	public void Start()
	{
		Falas(Dialogo2.dialogues);
		activecontrol = true;
	}

	public void Falas(string[] txt)
	{
		spechBaloon.SetActive(true);
		dialogos = txt;
		StartCoroutine(TypingDialogues());
	}

	IEnumerator TypingDialogues()
	{
		foreach (char character in dialogos[iD].ToCharArray())
		{
			spechBaloonText.text += character;
			yield return new WaitForSeconds(typingSpeed);
		}
	}

	public void NextSentence()
	{
		if (spechBaloonText.text == dialogos[iD])
		{
			if (iD < dialogos.Length - 1)
			{
				iD++;
				spechBaloonText.text = "";
				spechBaloon.SetActive(false);
				nextBalloon.SetActive(nextBalloon.GetComponent<DialogoPaciente>().activecontrol);
				nextBalloon.GetComponent<DialogoPaciente>().activecontrol = false;
			}
			else
			{
				spechBaloonText.text = "";
				iD = 0;
				spechBaloon.SetActive(false);
			}
		}
	}

	public void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			NextSentence();
		}
	}
}