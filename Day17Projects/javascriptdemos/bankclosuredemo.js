
function bankAccount(initialBalance) {
    let balance = initialBalance; // Private variable

    function deposit(amount) {
        if (amount > 0) {
            balance += amount;
            console.log(`Deposited: $${amount}, New Balance: $${balance}`);
        } else {
            console.log("Deposit amount must be greater than 0.");
        }
    }

    function withdraw(amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
            console.log(`Withdrawn: $${amount}, Remaining Balance: $${balance}`);
        } else {
            console.log("Insufficient funds or invalid amount.");
        }
    }

    function checkBalance() {
        console.log(`Current Balance: $${balance}`);
    }

    // Expose functions globally
 
}
   
// Initialize an account
bankAccount(1000);

depositMoney(500);      // Output: Deposited: $500, New Balance: $1500
withdrawMoney(200);     // Output: Withdrawn: $200, Remaining Balance: $1300
checkAccountBalance();  // Output: Current Balance: $1300

console.log(window.balance); // Output: undefined (balance is private)
