# Jump tutorial
create a folder in google drive or onedrive as this is where your files will be contained in files
open up github as you need to have something to remind you if you forget what you are doing.
welcome to the jumping tutorial 
today you will learn how to make a box jump up and down 
so open up unity 
create a c# script 
you will call this jumping
put in this code in the screenShot below 
!
![Jumping](https://github.com/user-attachments/assets/7b668e8c-20ae-4290-b761-6965fa89e02b)
so please add the code in the image so you might see a change in the box you have previously created 
just incase an error appears please put C For the KeyCodeDown part like this so no errors will appear 
so should look like something like this 
![game](https://github.com/user-attachments/assets/28a05214-e1fa-4ca5-b4ea-e8271e70206b)
# nextStep
please make sure you have any ojects you have created are on the screen
so if you could add the next part of the code to add in the script created earlier as it is included as you may have some problems
including errors or more 
![image](https://github.com/user-attachments/assets/3a56a600-9b37-4085-98bf-ffe78d2001cf)
please take a look into the picture above please just put these lines of code under the right parts the first one will be 
this  rb = GetComponent<Rigidbody>();
just this code> isJumping = false; underneath

    rb.velocity = new Vector3(0, 5, 0);
    isJumping=true;

      private void OnCollisionEnter(Collision collision)
  {
      isJumping = false;
  }
so it should end/look like this when finished.
![cube](https://github.com/user-attachments/assets/53a66a23-a196-4d3a-946e-944b2e34f578)


