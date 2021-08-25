# Representers

A representer is a piece of software that takes a student's solution and returning a normalized representation of it. We then use these representations to streamline automated feedback and classification.

An example helps to explain representers best. Let's presume two students submit two submissions to the `hello-world` exercise in Ruby:

```ruby
# Student 1's submission
def self.hello(name = 'World')
  "Hello, #{name}!"
end
```

```ruby
# Student 2's submission
def self.hello(nom = 'World')
  "Hello, #{nom}!"
end
```

Although the code to these solutions is different (different indentation, variable names, and string syntax), they are essentially the same. So by creating a normalized representation of them, we can _treat_ them as the same for the purposes of providing feedback. This dramatically reduces the amount of duplicate mentoring that needs to happen.

Each track maintains it's own representer, specific to that language. There is no standardized output - we only require a track to be internally consistent.
