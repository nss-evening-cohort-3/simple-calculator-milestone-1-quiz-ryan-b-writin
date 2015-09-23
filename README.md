# Simple Interactive Calculator 

## Goal

Create a Console based Calculator in C#.

## Rules

- You can work in pairs if you like, but it's not required.
- Everyone forks this repo (then clone your fork).
- Everyone has until the beginning of class on Saturday to complete this task (this includes pushing to github)
- There should be Unit Tests on all classes and methods you create.
- Your solution should have at least 2 total projects. Unit Tests should be in it's own project.
- This is an OOP focused class. Therefore, there will be classes. No implementations should be done within the `Program` class and `Main` method.
- If a user submits an incomplete command or expression, the calculator should **not** attempt to evaluate it and print out a useful message.

## How it should work

Starting your console application should create a prompt that looks like:

```sh
[x]> 
```
where `x` is the number of executed commands/expressions during the user's current session. Call this your "counter".

On startup, your initial prompt should always look like:

```sh
[0]>
```

The user will enter simple mathematical expressions or commands. The user pressing [Enter] will have the calculator print out the correct answer on the following line (prefixed with an `=`). After the answer is printed, the user should return to the original prompt.

For example, below the user entered `2+1`, then pressed [Enter]. The calculator printed out the answer `3` and reprinted the prompt, waiting for input from the user.

```sh
[0]> 2+1
   = 3
[1]>
```

Further use of this session will again increment the counter part of the prompt:

```sh
[1]> 1-10
   = -9
[2]>
```

Finally, typing `exit` or `quit` should exit the program while printing a message:

```sh
[2]> exit
Bye!!
```


## Features

### Math Operations

Your calculator should following operations

1. addition (integer)
2. subtraction (integer)
3. integer division (integer)
4. modulus (integer)
5. multiplication (integer)


### Calculator Commands

In addition to math expressions, your calculator should accept the following commands:

- `quit` and `exit` - exits the program
- `last` - prints the last printed answer
- `lastq` - prints the last entered command or expression


### Constants

For the chosen few, you get the implement the concept of 'constants' in the caluculator. See below for how it should work:

```sh
[0]> x = 3
   = saved 'x' as '3'
[1]> x
   = 3
[2]> 1 + x
   = 4
[3]> x = 4
   = Error!
```

#### Constants Specifications

1. Any lowercase letter of the alphabet can be a constant.
2. Calculator should be case insensitive. `A` is considered the same as `a`.
3. Constants can only be defined once per session.
4. Defined constants can be used in math expressions
5. Undefined constants can not be used and if used should print a helful message.
