using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

	public TextMeshProUGUI textComponent;
	public Text nameText;
	public Text dialogueText;

	public Animator animator;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		animator.SetTrigger("close");

	}

	public void StartDialogue (Dialogue dialogue)
	{
		nameText.text = dialogue.name;

		sentences.Clear();

        Debug.Log("Start dialogue");

        Debug.Log(dialogue.sentences);


		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
		animator.SetTrigger("pop");
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		textComponent.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			textComponent.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
		animator.SetTrigger("close");
	}

}