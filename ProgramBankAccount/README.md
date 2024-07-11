# The Bank Account Program

## Scenario

In a bank, to register a bank account, it is necessary to provide the account number, the account holder's name, and the initial deposit amount that the account holder deposited when opening the account. This initial deposit amount, however, is optional. That is, if the account holder does not have money to deposit at the time of opening their account, the initial deposit will not be made, and the account's initial balance will naturally be zero.

Important: once a bank account has been opened, the account number can never be changed. However, the account holder's name can be changed (as a person might change their name upon marriage, for example).

Lastly, the account balance cannot be freely altered. There must be a mechanism to protect this. The balance only increases through deposits and only decreases through withdrawals. For each withdrawal made, the bank charges a fee of £5.00. Note: the account balance can become negative if there are insufficient funds to make the withdrawal and/or pay the fee.

You should create a program that registers an account, providing the option to include or exclude the initial deposit amount. Then, perform a deposit and subsequently a withdrawal, always displaying the account details after each operation.
