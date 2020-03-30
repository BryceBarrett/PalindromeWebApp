## PalindromeWebApp

### Summary
This is a simple MVC web application. It offers users the ability to input a paragraph and/or a letter of their choosing.
Upon submission of this information, the user will be presented with some statistics about their paragraph. They will see
the number of palindrome words within the paragraph as well as the number of palindrome sentences. The user will also be
presented with all words containing the letter they entered and the unique words in the paragraph with a count of their
repetition.

### Palindrome Helper
The palindrome class that drives all of the logic related to the aforementioned functionality can be found at
PalindromeWebApp/PalindromeWebAppDemo/BusinessLogic. An assumption that was made is that palindromes have to be more than 1
letter. Additionally, all punctuation is stripped from everyword that is tested. Sentences are split based upon either a 
period, exclamation point, or question mark. 

### Extra Info
The bootstrap theme that I used in this project can be found [here](https://bootswatch.com/darkly/)!

If you don't want to use this web app, I also made a small console application https://github.com/BryceBarrett/PalindromeDemo.
This captures the exact same functionality but might be easier for someone to look at if you're in a rush.

Please let me know if you have any questions.
