# Project Guidance

This file goal is to help you complete thos project by splitting the task into doable "chunks". Complete these chunks in order.

## Chunk 1 - Parsing Text

### Goal

Using Test Driven Development, create an **Expression** class that will break down a simple 2-term calculator expression.

1. Prove you can extract the terms of the expression.
2. Prove you can extract the operation embedded in the expression.
3. Ensure you have examples of GOOD and BAD input and have your **Expression** class throw an exception when there's an error.

### Hints
- Your expression should work with and without spaces. (i.e. both `2+1` and `2 + 1` should work)
- The use of Regular Expressions is not required.
- GOOD input example: `1+2`
- BAD input example `+2`
- You do not need to handle the cases of usage of parenthesis or expressions with more than 2 terms.


## Chunk 2 - Evaluting Simple Expressions

### Goal

Using Test Driven Development, create another class (the name is up to you, but must be separate from the class int he first Chuch) that can evaluate a simple 2-term calculator expression, returning the appropriate answer.

1. Prove your class can execute the correct operation of a GOOD expression. (If you already have classes for the various math operations, this is easy).
2. Prove your class can handle a BAD expression.

### FAQs/Hints

- Should my **Evaluate** class print something to the **Console**? No


## Chunk 3 - Calculator Commands

### Goal

Using Test Driven Development, create a **Stack** class that can hold the last evaluated expression (for `lastq`) and the last answer returned (for `last`). Also, modify your class from chunk 2 to appropriatly handle the `last` and `lastq` commands.

1. Ensure your **Stack** class can easily set the `lastq` and `last` (you can name your properties whatever you want)
2. Prove your class from Chunk 2 can properly handle the `lastq` and `last` commands.


## Chunk 4 - Constants

### Goal

Using Test Driven Development, expand your **Stack** class to handle the storage and retreival of Constants.

1. Prove that any lowercase letter of the alphabet can be a constant. (e.g. 'a' or 'x'). Constant names are case insensitive.
2. Prove that your constants can only be defined once per session. Throw an exception otherwise.
3. Prove you can defined constants can be used in math expressions.
4. Prove that undefined constants can not be used and doing so throws an exception.


### Hints
- Constants are have names that are 1 character in size, (e.g. `a` or `j` and never `abc`)
- You can create a class **Constants** if **you** want, but it is not required. If you choose to create another class, the class must be unit tested.
- Your **Stack** class should use the **Constants** class. ;)
