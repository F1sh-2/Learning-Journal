# Welcome to the npc tutorial.
today, you will learn how to make NPC dialogue
this can be a hard one to-do as it requires alot of paitence 
i use this video to help me learn the code in the tutorial ////https://www.youtube.com/watch?v=1nFNOyCalzo//
you will need these items:
unity
github
github desktop app
visual studio
# next section 
to import the files and the importance of this is so we know where our files and main sections can be located and protected in the future.
so if you have unity installed please open up a 3d project file how you do this right follow the image down below 
![image](https://github.com/user-attachments/assets/ffe63c4e-3526-437f-a24a-d395af2b016c)
so follow the arrow if need help i will put a video also at the end 
So create a uv file it will be found in the assets 
once you have a uv text document this will apply a conversation or a background for the code to work as this enables the functions to work moving on forward you will need to add text file to find this ill add an example from earlier. 
![image](https://github.com/user-attachments/assets/0efd9c23-07b5-4c13-8a4f-a5045a960168)
before we start the code im going to show the finished product so you know what to expect from the code lesson and the tutorial itself as a simple thing to do.
![image](https://github.com/user-attachments/assets/740099bf-7917-43d5-b25a-9a35352152f0)
i used a youtube video to help with any errors i may of found when doing this myself
//https://www.youtube.com/watch?v=1nFNOyCalzo//
If you want a advance version for extra reading try this tutorial if you like a challange
//https://www.youtube.com/watch?v=vY0Sk93YUhA//
 Lets get into the codeing parts So please create a c# script 
 How do you do this so go into create you do this by right clicking the mouse check the image below as an example.
 ![image](https://github.com/user-attachments/assets/096173a5-7098-4055-8850-873498f12690)
Please doubleclick the script but call it the npc chat to shorten the name to save time 
![image](https://github.com/user-attachments/assets/ace42129-e723-44d5-92ce-f2de33a836dd)
This will then take you into the visual studio

This should pop up when clicking on the script.
so before we do anything just yet make sure you have a text file on the npc dialogue how you do this its a pretty simple
so open the create option go into the ui and get to the legacy option and pick text this is here to remind you and so it works going forward.
![image](https://github.com/user-attachments/assets/0377b739-6280-49ac-b914-94fdb681aecc)
also you will need to create a npc character that can be a simple cube since just a sample as it would have more functionality as you would have multiple codes that would align in the idea so they work together
so create a ui document this would give you a gray block text file name it anything you like 
and then after that add another text file but leave this blank you will need also a canvas which will include a button and the ui needed for these tasks this may feel random it must look like this.
![image](https://github.com/user-attachments/assets/706aae83-b9e8-4bf2-84c4-1beb6e037532)
![image](https://github.com/user-attachments/assets/4a1806e1-c5b6-4f7d-a00a-f7a8362a6d6b)
in the second screenshot follow the gameobject mode and create the ui types each one being different.
![image](https://github.com/user-attachments/assets/06dad15d-4116-446d-a48e-44a79ece7935)

in this screenshot create the eventsystem and the canvas as these are needed for this to work also select the text for the functions and naming of each part of the dialouge.
# back to the coding part after taking a detour
Continuing the coding so you have the visual studio open please go back into this app as you will need this to do the vital part of the npc chat so starting of simple please follow this screenshot of the first part please make sure you label the objects you made these are !IMPORTANT! it could mess up your files and the whole thing if not careful so please copy the names.
# code part 1
public GameObject dialoguePanel;
public Text dialogueText;
public string[] dialogue;
private int index;

public GameObject contButton;
public float wordSpeed;
public bool playerIsClose;
screenshot
![image](https://github.com/user-attachments/assets/62eb80b3-c693-467b-8137-c027b9d2f8c8)
![image](https://github.com/user-attachments/assets/91ec8d33-3a04-4958-8018-b639e9086906)
Then after that please put the next step of code this is an important one as this will help enter text which has a keycode when pressed will show up
so please enter this code
![image](https://github.com/user-attachments/assets/d0594950-4dd4-4fbe-b155-22f7d6c08632)
 if (Input.GetKeyDown(KeyCode.E) && !playerIsClose)
 {
     if (dialoguePanel.activeInHierarchy)
     {
         zeroText();
     }
     else
     {
         dialoguePanel.SetActive(true);
         StartCoroutine(Typing());


     }
 }
 if(dialogueText.text == dialogue[index])
 {
     contButton.SetActive(true);
 }    
it wants to check for any text or functions you have applied to make sure its fine to use.

















