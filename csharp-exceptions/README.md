# csharp-exceptions-0`
The 'csharp-exceptions-01 is the first 'lesson' on exceptions in a series of programming lessons.   

This lesson focuses on basic exception handling.

## Project/Lesson Requirements
Create a calculator class that can add numbers together.  

- The calculator must remember the current value and display it every time another number is added to the current value
- Create an ```Add``` method that accepts a string value as a parameter - this is the value to add to the current value
    - Parse the input string value to a decimal and add that decimal value to the curent value
    - Catch any parse exceptions if an invalid integer or decimal 'string' value is parsed and output to the user that an invalid number was entered
    - Catch any other exceptions in case a number/decimal is used that is too big, like: 999999999999999999999999999999, and output the exception message to the user

Use a while loop in the main class to keep on adding numbers until the user enters 'q'.

### Example Output
```
Please enter a number to add to the current value of 0, or 'q' to exit: 4
Please enter a number to add to the current value of 4, or 'q' to exit: 5.6
Please enter a number to add to the current value of 9.6, or 'q' to exit: num
Please pass a valid integer or decimal value.
Please enter a number to add to the current value of 9.6, or 'q' to exit: -6
Please enter a number to add to the current value of 3.6, or 'q' to exit: q
Please enter a number to add to the current value of 0, or 'q' to exit: 78
Please enter a number to add to the current value of 78, or 'q' to exit: 999999999999999999999999999999
An unknown error ocurred, please see exception message: Value was either too large or too small for a Decimal.
Please enter a number to add to the current value of 78, or 'q' to exit: q
```

## Extra 
- Add "Subtract", "Multiply" and "Divide" methods and code the necessary exeption handling to cater for division by zero, or a number that would be too large

### Example output for 'Extra' item
```
The current value is: 0.  Press '+' to add, '-' to subtract, '*' to multiply or '/' to divide: +
Please enter a number to '+' 0 with, or 'q' to exit: 7
The current value is: 7.  Press '+' to add, '-' to subtract, '*' to multiply or '/' to divide: /
Please enter a number to '/' 7 with, or 'q' to exit: 0
Cannot divide by zero, please enter a non-zero number.
The current value is: 7.  Press '+' to add, '-' to subtract, '*' to multiply or '/' to divide: 8
8 is not a valid operator.
The current value is: 7.  Press '+' to add, '-' to subtract, '*' to multiply or '/' to divide: /
Please enter a number to '/' 7 with, or 'q' to exit: 2
The current value is: 3.5.  Press '+' to add, '-' to subtract, '*' to multiply or '/' to divide: *
Please enter a number to '*' 3.5 with, or 'q' to exit: 7
The current value is: 24.5.  Press '+' to add, '-' to subtract, '*' to multiply or '/' to divide:
```

>## NOTE
>- Feel free to create any `other` project that demonstrates your understanding of basic (or advanced) exception handling.  The calculator example is just a guide/pointer 
>- ***As always remember to have FUN!!***

## License
Licensed under the [MIT License](./LICENSE).
