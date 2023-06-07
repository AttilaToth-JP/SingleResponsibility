//Code example taken from by Tim Corey's video https://www.youtube.com/watch?v=5RwhyZnVRS8


using ConsoleApp1;

StandardMessages.WelcomeMessage();


//Ask for user information
Person user = PersonDataCapture.Capture();


//Checks to be sure the first and last names are valid
bool isUserValid = PersonValidator.Validate(user);

if (isUserValid == false)
{
    StandardMessages.EndApplication();
    return;
}


//Create a username for the person
AccountGenerator.CreateAccount(user);

StandardMessages.EndApplication();