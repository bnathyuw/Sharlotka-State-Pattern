# Sharlotka State Pattern

Exploring the State Pattern through the medium of cake!

There are currently three implementations:

## Classic

This is the classic state pattern, where every state implements every method.

This means there’s lots of redundant code, and Barbara Liskov will not be amused.

## Small Interface

This picks up on a [post by Jan van Ryswyck](http://elegantcode.com/2010/03/19/dont-give-up-on-the-state-pattern-just-yet/) of how to avoid voilating the LSP while using the state pattern.

I have changed the implementation slightly, so at each stage the state is cast to the appropriate interface, and then checked for nullity. Calls are only made on non-null states.

## Fluent

This does away with the state pattern altogether, and uses a different pattern: the fluent interface.

The Sharlotka class implements an interface for each of its possible states. Performing each action then returns the object *as* the interface representing the next state in sequence. All methods are implemented *explicitly*, except for the first, as an attempt to avoid jumping in at the wrong stage in the process. This is not ideal, as you can still cast to the interface you want before making the method call.