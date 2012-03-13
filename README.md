# Sharlotka State Pattern

Exploring the State Pattern through the medium of cake!

There is currently one implementation:

## Classic

This is the classic state pattern, where every state implements every method.

This means there’s lots of redundant code, and Barbara Liskov will not be amused.

## Small Interface

This picks up on a [post by Jan van Ryswyck](http://elegantcode.com/2010/03/19/dont-give-up-on-the-state-pattern-just-yet/) of how to avoid voilating the LSP while using the state pattern.

I have changed the implementation slightly, so at each stage the state is cast to the appropriate interface, and then checked for nullity. Calls are only made on non-null states.