# drag and drop 
welcome to this tutorial
Aims
* to understand what drag and drop is 
* to get better at following tutorials
* to use the code in your own time
* you need to understand what unity is and how to code in general.
# what you will need to have knowledge in
* Github
* know basic code
* be able to access unity 
* have a laptop or computer.
# the actual code 
    bool canMove;
    bool dragging;

    Collider2D collider2D;
    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (collider2D != null && collider2D == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                dragging = true;
            }


        }
        if (dragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMove = false;
            dragging = false;

        }
    }
} 
![image](https://github.com/user-attachments/assets/7fd0f4d2-eca7-400e-a3fc-ababc6057665)
what the get the componant does is you tell unity what you would like add 
without this you wouldn't be able to identify the type of core section



# you will need these applications to begin the drag and drop system in unity:
* Unity
* Visual Studio 
Github-only if you would want to wrightup anything about the code you have done or general progress.
its a simple one to do with simple steps please open unity
![9a58ef0b0a39424aaf70dd4c30539b477ae54697-1200x630](https://github.com/user-attachments/assets/f06d5a02-bab6-49e4-8313-e0b10064ea6e)
please create a new project please call this drag and drop 
![image](https://github.com/user-attachments/assets/4374aa45-5891-4280-8f9d-66fd1eae3ee1)
# how to create a script for this tutorial.
![image](https://github.com/user-attachments/assets/3e42edf3-db9b-4a49-8790-b0969ee37a90)
# how to create a game object in unity.
![image](https://github.com/user-attachments/assets/72ad6942-aa25-4342-8343-2ddd8cbd1bde)
the purpose of the two above you need the basics to do anything in unity and this would give a good example of how to do it.
how does it work in game mode you should be able to move the object or drag and drop anything wilst moving.
now that it should work you can add a floor you will need a box clollider just in case
* go to game object
* press create 3d object
* create plane 
![image](https://github.com/user-attachments/assets/0d077d41-5bac-4d61-a284-aea26539e419)
  



Please then follow the video of the basic set-up and copy so we have all we need to start as this is an important step for any programmer to have to learn when doing this.
//I could'nt add a video to the tutorial due to size of the file so here is a screenshot//
the purpose of the tutorial is to do something fun but its a general simple one to do and takes up not a lot of time 
drag and drop is used mainly in balloon tower defense games dragging in different turrets at a time 
here is a finished product of the code.
![image](https://github.com/user-attachments/assets/4ad62059-3331-4af9-b7e0-002dbfab8af9)
the finished product will allow movement so to perfect this you need to add a keycode being the mouse how do you do this so you need to stay on the same code that you have created add a new line and we will go through step by step 
here is a screenshot.
![392043731-4ad62059-3331-4af9-b7e0-002dbfab8af9](https://github.com/user-attachments/assets/1a8bb8f9-fb4a-41b1-b656-2edfde593eed)
Please follow this screenshot what does the getmousebutton do it allows the mouse to control the cube or gameobject in the game scene this allows the function to work going forward and it enables you to check if the code actualy works.
![image](https://github.com/user-attachments/assets/cfb65fc2-c097-426c-8738-efe1802bbb0f)
once you have the code done we will move on to the next section so we will focus on an area that adds more purpose check down below.




once you have the c# file open please start typing this code 
 bool canMove;
 bool dragging;
 this enables you to move the object you chose allowing the functionalilty to work 
 next step
 ![image](https://github.com/user-attachments/assets/23966cf6-20a1-40a2-99cc-3d32a85ac6c6)
 so put this code in the void start section as this would not loop so please put this code in here for the functions.
 # Next step
 the next line of code is a important as it builds up on the main functions as these will enable you to add core parts of the code as this will allow proper functions 
   Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

   if (Input.GetMouseButtonDown(0))
   {
       if (collider2D != null && collider2D == Physics2D.OverlapPoint(mousePos))
       {
           canMove = true;
       }
       else
       {
           canMove = false;
       }
       if (canMove)
       {
           dragging = true;
       }
 
please follow by adding this text in the script attaching a screenshot of what to put in what section to make it easier for you to follow.
![image](https://github.com/user-attachments/assets/80ac5fed-6c22-449d-bf16-d853ba403ec0)
the idea for this code adds the function this would let the gameobject what you would like to do so the code you will type in will not have errors.
going to add the final code this will wrap it up this will make it work so when put in game mode if you click into the screen you would be able to move the item around for a extra challange you can try iy on and other and try to drop it anywhere 
here is the code please add it to the bottom of the code.
![image](https://github.com/user-attachments/assets/408cd4d6-71ac-427d-8f1a-de1da82266ee)
make sure you put it below the {
in the code.
![image](https://github.com/user-attachments/assets/2828f1cc-fd2d-44e2-b299-518511116075)

thank you for following a silly code.
#
summery 
* you have learnt drag and drop
* the basics of creating objects
* adding functions
* how to open/create scripts.
purpose of the tutorial is to learn something fun and simple to do

conclusion 
the drag and drop system benefits the object or anything you would like to use it mostly benefits in games like a tower defense games when having to move a character to hit the enemy 











