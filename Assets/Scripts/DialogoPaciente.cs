using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoPaciente : MonoBehaviour
{//
	//Script Inspirado no script criado pelo canal do Youtube "Crie Seus Jogos"
	public GameObject spechBaloon, nextBalloon;
	public string[] dialogos1;
	public string[] dialogos2;
	public string[] dialogos3;
	public string[] dialogos4;
	string[] dialogos;
	public float typingSpeed;
	public bool activecontrol;
	public static int iP;
	public Text spechBaloonText;
	public static bool falaPaciente = false;
	public static bool blockFala = false;

    public void Start()
    {
		//Falas(Dialogo1.dialogues);
		if(KidInstante.kid!=null){
			falaPaciente = true;
			// dialogos = dialogos1;
			// Falas(dialogos1);
			// activecontrol = true;
			Debug.Log("Kid != null");
			Debug.Log("kid: "+KidInstante.kid);
		} else {
			falaPaciente = false;
		}
		Debug.Log("FalaPaciente: "+falaPaciente);
		Debug.Log("blockFala: "+blockFala);
		if(falaPaciente && (!blockFala)){
			
			switch(Player.day){
				case 0:{
					dialogos = dialogos1;
					Falas(dialogos1);
					activecontrol = true;
					Debug.Log("dialogos1 antes da consulta");
					falaPaciente = false;
					break;
				}
				case 1:{
					dialogos = dialogos2;
					Falas(dialogos2);
					activecontrol = true;
					Debug.Log("dialogos2 antes da consulta");
					falaPaciente = false;
					break;
				}
				case 2:{
					dialogos = dialogos3;
					Falas(dialogos3);
					activecontrol = true;
					Debug.Log("dialogos3 antes da consulta");
					falaPaciente = false;
					break;
				}
				case 3:{
					dialogos = dialogos4;
					Falas(dialogos4);
					activecontrol = true;
					Debug.Log("dialogos4 antes da consulta");
					falaPaciente = false;
					break;
				}
			}
			activecontrol = true;
		}
		if(Player.count == 3){
			blockFala = false;
		}
		
	}

    public void Falas(string[] txt)
	{
		spechBaloon.SetActive(true);
		dialogos = txt;
		StartCoroutine(TypingDialogues());
	}

	IEnumerator TypingDialogues()
	{
		foreach (char character in dialogos[iP].ToCharArray())
		{
			spechBaloonText.text += character;
			yield return new WaitForSeconds(typingSpeed);
		}
	}

	public void NextSentence()
	{
		//if (spechBaloonText.text == dialogos[iP])
		{
			if ((iP < dialogos.Length - 1)) 
			{
				iP++;
				spechBaloonText.text = "";
				//spechBaloon.SetActive(false);
				StartCoroutine(TypingDialogues());
			}
			else
			{
				spechBaloonText.text = "";
				iP = 0;
				//falaPaciente = false;
				blockFala = true;
				spechBaloon.SetActive(false);
			}

		}
	}

    public void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space)&&((Player.count!=3)))
		{
			if (spechBaloonText.text == dialogos[iP]){ //essa linha
				NextSentence();	
			} else {
				
				//StopCoroutine(TypingDialogues());
				//spechBaloonText.text = "";
				//spechBaloonText.text = dialogos[iP];
			}

		}
	}
}
