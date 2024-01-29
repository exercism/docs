# Remainder

In mathematics, the **remainder** is the amount "left over" after performing some computation.
For example, the remainder of `5 / 3` is `2`.

Many programming languages use the percentage sign (`%`) as an operator to calculate the remainder.
For example, this is valid code in Javascript and Python:
```javascript
5 % 3 == 2
```

Remainders can often be calculated on both integers and floating point numbers.
For example,
```javascript
5.3 % 3 == 2.3
```

When working with negative numbers, the result always has the same sign as the dividend (the number on the left hand side that is being divided).
For example:
```javascript
-5 % 3 == -2
5 % -3 == 2
-5 % -3 == -2
```

Some languages use the `%` operator for the calculating the modulus, not the remainder.
This treats negative numbers differently.
You can learn more about this [on Wikipedia](https://en.wikipedia.org/wiki/Modulo).


