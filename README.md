# SimpleEncrytion

This C# Console App was made to complete a simple Encryption Challenge that I found on the internet.

I have also implemented **Unit Test Driven** to help me during the development.


## Challenge

You need to write a program that accepts a string and encrypts it according to a simple algorithm.

The encryption algorithm works as follows:

1. For each word in the input string, you need to take the first letter of the word, place it at the end of the word and then add the two letters 'ay'. 
For example, the word "hello" would be encrypted as "ellohay". You need to repeat this for each word in the input string.

2. Capitals and punctuation need to be preserved. That is, words that initially started with a capital letter need to start with a capital letter in the output string, and punctuation needs to remain in the same place in the output string. For example, the string "Hello, world!" would be encrypted as "Ellohay, orldway!".

|Input|Output|
|-----------------|------------------|
|hello|elloay|
|Hello, world!|Ellohay, orldway!|
|3duard#|duard3ay#|
|PAZ#Arthur|AZA#rthupay|
|¡Have a Great Day!|¡Avehay a Treag Ayday!|

