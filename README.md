## Problem

The problem is that we have a number of entities (for example, here are the actors: mage and warrior) and a number of handlers for these entities (MageProcessor, WarriorProcessor, etc.). We need to propose a solution for processing a list of entities with their corresponding handlers. The main criterion of the solution is simplicity and maintainability. Here we go.

You can find the source code of the problem [here](CovarianceProblem/CovarianceProblem.Problem). This code compiles, but during execution it throws an exception, can you find out where? 

## Solutions

During the solution process, at least [three](CovarianceProblem/CovarianceProblem.Solves) satisfactory methods were found, each with its own disadvantages and advantages.

0. Visitor Pattern.

One solution could be a visitor pattern, but because of its rampant growth with increasing number of actors and handlers, I immediately dismissed it as a solution.

1. [Pattern Matching](CovarianceProblem/CovarianceProblem.Solves/Matching).

You can run through the incoming list of entities, determine the actor type, and based on that, pick a suitable handler for it. Not bad. However, each addition of a new actor type forces us to edit several files at once: the storage location for all processors (here it's the [factory](/CovarianceProblem/CovarianceProblem.Problem/Factory/ProcessorFactory.cs)) and the entity [executor](CovarianceProblem/CovarianceProblem.Solves/Matching/ExecutorWithMatching.cs) for "extending" the pattern.

The factory, say, can be simplified using `DI`, but "extending" the pattern unfortunately remains a necessity. A good indication of this solution is that only one file needs to be changed to implement it, but the constant editing of that one file is a bit depressing.

2. [Another Processor](CovarianceProblem/CovarianceProblem.Solves/AnotherProcessors).

You can create an [abstract base processor](CovarianceProblem/CovarianceProblem.Solves/AnotherProcessors/Processors/BaseProcessor.cs) that processes any entity and casts it to the required type for specific successors. This is the most extensive solution (to change the code base). It's also pretty good. In particular, it's worth noting that adding new entities (and their handlers) will only affect updating the factory (or any other entity involved in supplying handlers). That's fine.

The main problem with this approach is the direct cast of actor types within the abstract base processor. And a relatively large amount of code to solve: effectively changing all [handlers](CovarianceProblem/CovarianceProblem.Solves/AnotherProcessors/Processors), the issuing [factory](CovarianceProblem/CovarianceProblem.Solves/AnotherProcessors/Factory/AnotherProcessorFactory.cs) and the [executor](CovarianceProblem/CovarianceProblem.Solves/AnotherProcessors/AnotherExecutor.cs). For an example or at the beginning of the design, this is not a problem. But if we already have some code base, such a transition can be painful.

3. [Dynamic](CovarianceProblem/CovarianceProblem.Solves/Dynamic).

A curious solution (and my personal favorite) where we modify just one file using casting to a dynamic type. Thanks to double dispatching in C#, we can discount this problem at runtime. This way, the runtime will determine the actor type and the handler it needs.

In summary, this solution only requires changing the factory (or any other handler provider) when adding new actors and handlers. The disadvantage of the solution is the use of `dynamic`, which other programmers on the team may not be familiar with. It is also certainly disconcerting that we lose the charms of a statically typed language the moment we cast to `dynamic`, but since this is the one and only place of the whole system - it may not be too terrible.

## Contributing

If you have a good solution in mind, please let me know. Create pull request.
