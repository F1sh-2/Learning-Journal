 # Player Movement tutorial 

I expect you are able to do the basics of understanding of unity and how it wors 

Please download Unity 2022 46.1f if not so you can work alongside this document to go step by step. 

Open Unity and go to the game object section, add a 3D object, and select a cube, as this will be the main character in the tutorial  

And after that please do the same step but creates a script how to do this is  

Time to start coding the tutorial. 

(7) How to Create Player Movement in UNITY (Rigidbody & Character Controller) - YouTube 

![Capture](https://github.com/user-attachments/assets/1ba7f3bb-3fe3-419d-b4e4-92813500a88e)


This video will help you if you get stuck at any point in the sections 

What im going to start meddling around with the cube to show it works. 

This is the result of the first step please type this in the script you made earlier called movement 

var step = speed * Time.deltaTime; // calculate distance to move 

        transform.position = Vector2.MoveTowards(transform.position, target.position, step); 

An error should appear when typed in the code   

 

 

 

 

 

 

 

So we will try a different code instead type in slowly  

public float horizontalInput; 

public float verticalInput; 

  

// Start is called before the first frame update 

void Start() 

{ 

      

} 

  

// Update is called once per frame 

void Update() 

{ 

     //read values from keyboard 

     horizontalInput = Input.GetAxis("Horizontal"); 

     verticalInput = Input.GetAxis("Vertical"); 

     // move the object 

     transform.Translate(Vector3.forward * Time.deltaTime * verticalInput); 

     transform. Translate(-Vector3.right * Time.deltaTime * horizontal Input); 

Put it in a script you will call movement  

And for some fun you can add a colour to your cube  

Here will be the finishing touches to complete the tutorial 

 

Here is some videos that you can use to help your understanding when on your own  

How to move a player in Unity 3D 



Thank you. 

        

 