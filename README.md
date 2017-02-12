# FizzBuzz Tech Test 

To complete the challenge clone the following repo and implement the FizzBuzz Kata either using .NET or Node. We've provided some skeleton code to get you started but feel free to use your own.

# FizzBuzz
The objective of Fizzbuzz is to create a program with the following specification:

The program can be passed a number.

When passed a number that is a multiple of 3, the program returns the message 'Fizz'.  
When passed a number that is a multiple of 5, the program returns the message 'Buzz'.  
When passed a number that is a multiple of both 3 and 5, the program ignores the previous 2 rules and returns the message 'Fizzbuzz'.  
In all other cases, the program simply returns the given number.  


## Submitting your test

Make sure all your work is commited to your local repository.  
Zip the entire folder (including .git) and email back to your recruitment consultant. 

## Notes
Just writing the code was easier than importing [Enterprise FizzBuzz](https://github.com/clementi/EnterpriseFizzBuzz), otherwise I would have done that. :)

## Usage
This implementation is a .Net console app. Input is assumed as a command line list of space seperated values, with the only user input required to exit the application after running.

To run, either add values such as "1 3 5 7 9 10 11 17 30" in the debug command line arguments and run in visual studio or run the statement:

> .\fizzbuzz.exe 1 3 5 7 10 11 17 30