var arr = [10, 20, 30, 40, 50]
arr.map((element) => console.log(element))

const numbers = [1, 2, 3, 4, 5];
const squares = numbers.map(value => value * value);
console.log(squares);

const people = [
{ id: 1, name: 'Felipe', country: 'DR' },
{ id: 2, name: 'Scott', country: 'USA' },
{ id: 3, name: 'Jennifer', country: 'Canada' },
]
const ids = people.map(person => person.id);
console.log(ids);

// array.filter((element)=>(condition))

var arr2 = [10, 20, 30, 40, 50]
let filtered = arr2.filter((element) => element > 20);
console.log(filtered);

const people2 = [
{ id: 1, name: 'Felipe', country: 'DR' },
{ id: 2, name: 'Scott', country: 'USA' },
{ id: 3, name: 'Jennifer', country: 'Canada' },
  { id: 4, name: 'Marry', country: 'USA' }
]


const peoplesinUSA = people2.filter(person => person.country=='USA');
console.log(peoplesinUSA);