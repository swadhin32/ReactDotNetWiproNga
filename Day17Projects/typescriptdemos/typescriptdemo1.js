var Person = /** @class */ (function () {
    function Person(FirstName, LastName, DateOfBirth) {
        this.firstName = FirstName;
        this.lastName = LastName;
        this.dateOfBirth = DateOfBirth;
    }
    Person.prototype.Show = function () {
        return ("".concat(this.firstName, " ").concat(this.lastName, " ").concat(this.dateOfBirth, " "));
    };
    return Person;
}());
var person = new Person("Raghavendra", "Ponde", new Date(1982, 7, 7));
person.Show();
