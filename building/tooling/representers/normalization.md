# Normalization within Representers

To have solutions with non-essential differences have the same representation, the Representer should apply normalizations. In general, the process of create a normalized representation looks like this:

- Parse the solution's code into an Abstract Syntax Tree (AST)
- Apply normalizations to the AST
- Convert the normalized AST to a string
- Write the normalized AST string to a file named `representation.txt` (see [the interface](/docs/building/tooling/representers/interface))

Note though, that the representation doesn't _have_ to be an AST, it could be regular (normalized) code, whichever works best for your track.

To help you get started, we'll now present some common normalization strategies.

Note 1: the normalization examples don't build on each other, they only show one specific normalization. An actual Representer would want to apply them in succession.

Note 2: the code for these guidelines will be in C#, but the guidelines are language-agnostic.

## Normalize identifiers

To allow for representations to be naming-agnostic, user-defined names (such as variables, functions, etc) can be replaced with placeholders. In this case, a `mapping.json` should be produced (see [the interface](/docs/building/tooling/representers/interface)).

It is important to note that all identical names must be replaced with the same placeholder, irrespective of scope.

### Source code

```csharp
public static class Fake
{
    public static int Test(int input)
    {
        var test = input + 2;
        return test;
    }
}
```

### Representation

```csharp
public static class PLACEHOLDER_1
{
    public static int PLACEHOLDER_2(int PLACEHOLDER_3)
    {
        var PLACEHOLDER_4 = PLACEHOLDER_3 + 2;
        return PLACEHOLDER_4;
    }
}
```

## Normalize white space

Inconsistent white space is so frequent, that normalizing it is a common normalization step.

### Source code

```csharp
using   System;

     public static    class Fake
{
    public     static   DateTime Add    (DateTime    birthDate)
    {
        return birthDate.Add( TimeSpan.FromSeconds   (   10  ) )   ;
    }
}
```

### Representation

```csharp
public static class Fake
{
    public static DateTime Add(DateTime birthDate)
    {
        return birthDate.Add(TimeSpan.FromSeconds(10));
    }
}
```

## Normalize blocks

In many languages, the user has some freedom in how to define a block (or scope). For example, in most C-like languages, scope is declared between curly braces. Usually, it doesn't matter if you put them on the same line or the next, so one could normalize this.

### Source code

```csharp
public static class Fake {
    public static int Test() {
        if (1 > 2) {
            return 0;
        }

        return 1;
    }
}
```

### Representation

```csharp
public static class Fake
{
    public static int Test()
    {
        if (1 > 2)
        {
            return 0;
        }

        return 1;
    }
}
```

## Remove insignificant code

Not all bits of code are significant to the Representer, which could then be removed. As an example, in most languages comments will be insignificant and can safely be removed.

### Source code

```csharp
/*
   These are some very nice
   comments spanning multiple lines
*/
public static class Fake
{
    // Nice method
    public static string Test()
    {
        return "Test"; // This is very nice
    }
}
```

### Representation

```csharp
public static class Fake
{
    public static string Test()
    {
        return "Test";
    }
}
```

## Normalize the order where insignificant

In some cases the order or code does not matter. To prevent the same code in different order to create different representations, it might be useful to sort it. Usually the items to sort are functions or declarations. It might be tricky to find the metric(s) to sort by and also tricky to implement. One metric could be the how many AST node children the node contains, another the name of the type of the first child node.

This example sorts by some kind of function length:

### Source code

```csharp
public static class Fake
{
    public static string Test2()
    {
        int a = "Test2";
        return a;
    }

    public static string Test()
    {
        return "Test";
    }
}
```

### Representation

```csharp
public static class Fake
{
    public static string Test()
    {
        return "Test";
    }

    public static string Test2()
    {
        int a = "Test2";
        return a;
    }
}
```
