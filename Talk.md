# Fluent interfaces in tests and production!

This talk is not a meant to be a comprehensive course but rather a brief introduction.
The goal of it is to rise awarness of the presented patterns.
Code samples presented in during the talk may and may not be production ready. 
Use them as an inspiration, at your risk and be aware of the trade offs! There's never a silver bullet.

## Fluent interfaces 

### Definition from the Wikipedia

In software engineering, a fluent interface (as first coined by Eric Evans and Martin Fowler) is a method for designing object oriented APIs based extensively on method chaining with the goal of making the readability of the source code close to that of ordinary written prose, essentially creating a domain-specific language within the interface.

tl;dr: Fluent interfaces aim to make code human readable

### Cost

Fluent interfaces often come with extra cost - in some cases neglibigle.
The cost comes mainly (but not always) from increased amount of calls and allocations.

### The cases you're familiar with 

There are some well known libraries that expose Fluent APIs:

- LINQ
- Fluent Assertions
- Fluent Validation
- Polly
- Probably many more...

### Libraries used in the code samples:

- Bddfy - <https://github.com/TestStack/TestStack.BDDfy>
- FluentAssertions - <https://fluentassertions.com/>