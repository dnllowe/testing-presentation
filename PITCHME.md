# Unit Testing and U
---
Debugging Code...
<img src=‘https://images-cdn.9gag.com/photo/aYKWzg2_700b.jpg'>
...Doesn’t have to feel like this!
---
## Overview

* Why we test
* When to test
* What to test
* How to test
---
# Why we test
---
## It makes your life easier
* Confirms that your code actually works as you write it
* Confirms that your code <i>still</i> works if (... when) you change it
* Helps define the problem in sizeable chunks
* Encourages better design and architecture
* Documents code

## Most importantly... It makes MY life easier
---
# When to test
---
<img src=‘/always-be-testing-final.png’>
---
## Always... Be... Testing

* Ideally, write tests before writing code
* Use the Red-to-Green rule
* Use the tests to help you define the problem as manageable chunks
* Write tests to reproduce and resolve new bugs
---
# What to test
---
## TEST ALL THE THINGS... not really, but sort of
* <i>Don't test...</i>
  * Multiple things at once (make separate tests)
  * <i>Other</i> methods while testing a method
  * Private methods (you only need to test public methods)
  * ... And test everything else

* Test a specific, desired output for a specific, intended input
  * Unit testing
  * Like the methods they test, unit tests should be single purpose

* Test every public method...
  * ...But every public method should be performing one, specific task
  * Even if it seems unnecessary now, it might be a godsend later
  * If it seems complicated/difficult to test... consider a refactor
---
# How to test
---
## C# Testing frameworks and libraries
* NUnit (what we use)
* xUnit
* MSTest
  * \+ Built into Visual Studio
  * \+ Simple setup and integration
  * \- Not as performant as the others
---
## References
* https://stackify.com/unit-test-frameworks-csharp/
