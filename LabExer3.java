import java.util.*;

public class LabExer3 {

     class SavingsAccount {
        private double balance;
        public static double interestRate = 0;
        SavingsAccount() {
           this.balance = 0;
        }

        public static void setInterestRate(double newRate) {
            interestRate = newRate;
        }

        public static double getInterestRate() {
            return interestRate;
        }

        public double getBalance() {
            return balance;
        }

        public void deposit(double amount) {
            this.balance += amount;
        }

        public double withdraw(double amount) {
            if (balance >= amount) {
                balance -= amount;
            } else {
                amount = 0;
            }
            return amount;
        }

        public void addInterest() {
            double interest = balance * interestRate;
            balance += interest;
        }

        public static void showBalance(SavingsAccount account) {
            System.out.println("Your balance is " + account.getBalance());
        }
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        LabExer3 lab = new LabExer3();
        SavingsAccount savings = lab.new SavingsAccount();

        System.out.print("Enter interest rate: ");
        double interestRate = sc.nextDouble();
        SavingsAccount.setInterestRate(interestRate);

        System.out.print("Enter deposit amount: ");
        double amount = sc.nextDouble();
        savings.deposit(amount);

        SavingsAccount.showBalance(savings);

        System.out.print("Press D for another deposit or W to withdraw: ");
        sc.nextLine(); 
        String options = sc.nextLine();

        if (options.equalsIgnoreCase("D")) {
            System.out.print("Enter deposit amount: ");
            amount = sc.nextDouble();
            savings.deposit(amount);
        } else if (options.equalsIgnoreCase("W")) {
            System.out.print("Enter amount to withdraw: ");
            amount = sc.nextDouble();
            savings.withdraw(amount);
        }

        if (savings.getBalance() > 1000) {
            savings.addInterest();
        }

        System.out.println("Your new balance is " + savings.getBalance());
    }
}
