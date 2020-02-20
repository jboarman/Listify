# Listify
Web API for Listify function
Let's say you need a sequence of numbers that can be used with LINQ for the purpose of some algorithm (e.g., 1, 2, 3,...). You can get an enumerator that can provides the sequence of numbers with something like 'Enumerable.Range(1, 100)'.

That method returns an IEnumerable that generates that sequence on-the-fly without every actually creating a proper data structure to hold all elements of the sequence.

Now, let's say you had a dependency that required this sequence to be randomly accessed via an IList interface. Can you implement an IList that makes random access to a just-in-time return of the value in each "element" of the list? (so … um, ToList() is not a valid answer here)

Here's one test to help gauge your implementation success:

// Given a list of numbers ranging from 100 to 200

var list = new Listify(100, 200);

// When I access index position 50

var val = list[50];

// Then I should get back a value of 150

val.Should().Equal(150);

This WebAPI is set up to simply return a string array of either:
  - Default /listify GET operation will return instructions on submitting to the WebAPI properly.
  - /listify?begin=x&end=x&idx=x will return a string array containing the proper number from the generated sequence starting at begin and ending at a length of end at the index of idx.

In a production instance I would likely make this a JSON response and I would add some default routing to go straight to the /listify GET operation (depending on other funcionality required of the overall WebAPI) as well as making the Listify extension class generic (type T) as opposed to strictly types IList<int> and IEnumerable<int> and I would implement all the methods as necessary in the interface rather than the subset I did for this project.

I started by creating a Listify class that implements the IList<int> and IEnumerable<int>, stubbing out all the methods needed in the interface (throwing a not implemented exception for the methods I did not need for this example), and then setting up a quick and easy Web API in .NET Core 2.1 (for easy transport to a Unix environ).

I also set up the project to continuously deploy from Github to Azure whenever I commit.
