class Person
{
	firstName: string;
	lastName: string;
	dateOfBirth: Date;
	constructor(FirstName: string, LastName: string, DateOfBirth: Date) 
	{
		this.firstName = FirstName;
		this.lastName = LastName;
		this.dateOfBirth = DateOfBirth;
	}
	
	Show() :string
	{
		return (`${this.firstName} ${this.lastName} ${this.dateOfBirth} `)
	}
}

let p: Person = new Person("Raghavendra", "Ponde", new Date(1982, 7, 7));

alert(p.Show());