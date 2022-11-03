using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoDoctor : MonoBehaviour
{//
	//Script Inspirado no script criado pelo canal do Youtube "Crie Seus Jogos"
	public GameObject spechBaloon, nextBalloon;
	public string[] dialogos1;
	public string[] dialogos2;
	public string[] dialogos3;
	public string[] dialogos4;
	string[] dialogos;
	public float typingSpeed;
	public static int iD;
	public bool activecontrol;
	public Text spechBaloonText;
	public static bool blockFalaUpdate = false;

	public void Start()
	{
		// Falas(dialogos1);
		// activecontrol = true;
		blockFalaUpdate = false;
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
		//if (spechBaloonText.text == dialogos[iD])
		{
			if (iD < dialogos.Length - 1) //essa linha
			{
				iD++;
				spechBaloonText.text = "";
				//spechBaloon.SetActive(false);
				//nextBalloon.SetActive(nextBalloon.GetComponent<DialogoPaciente>().activecontrol);
				//nextBalloon.GetComponent<DialogoPaciente>().activecontrol = false;
				StartCoroutine(TypingDialogues());
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
		if((Player.count==3) && (!blockFalaUpdate)){ // Player.count conta a quantidade de sintomas acertados na linkagem
			//dialogo final do paciente	
			switch(Player.day){
				case 0: {
					dialogos = dialogos1;
					Falas(dialogos1);
					break;
				}
				case 1: {
					dialogos = dialogos2;
					Falas(dialogos2);
					break;
				}
				case 2: {
					dialogos = dialogos3;
					Falas(dialogos3);
					break;
				}
				case 3: {
					dialogos = dialogos4;
					Falas(dialogos4);
					break;
				}
			}
			
			activecontrol = true;
			blockFalaUpdate = true;
		}
		
		if (Input.GetKeyDown(KeyCode.Space)&&(Player.count==3))
		{
			NextSentence();
		}
	}
}