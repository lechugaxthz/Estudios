const EventEmitter = require('events').EventEmitter;

class Dog extends EventEmitter { };
class Food { };
let myDog = new Dog();

const eatenItems = (item) => {
  if (item instanceof Food) {
    console.log('Good dog');
  } else {
    console.log(`Time to buy another ${item}`);
  }
}

myDog.on('chew', eatenItems);
myDog.emit('chew', 'shoe');
const bacon = new Food();
myDog.emit('chew', bacon);


myDog.removeListener('chew', eatenItems);
console.log('post remove');

myDog.emit('chew', bacon); /* this line will not return (log) nothing */

/*  */

class MyEmitter extends EventEmitter { };

const emitter = new MyEmitter();

const message = () => console.log("a message was emitted!");
const message1 = () => console.log("this is not the right message");
const data = () => console.log("a data has been deployed");


emitter
  .on("message", message)
  .on("message", message1)
  .on("data", data)

console.log(emitter.eventNames());
emitter.removeAllListeners("data");
console.log(emitter.eventNames());

/* 
  with that "events" someone can create an entire rest API using http and 
  one function to handle this {type, url} 
*/

